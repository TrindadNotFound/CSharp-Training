Console.WriteLine("Enter two integer numbers to set a matrix size : ");
Console.Write("Number of rows : ");
int numRows = int.Parse(Console.ReadLine());

Console.Write("Number of lines : ");
int numColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[numRows, numColumns];

Console.WriteLine();
Console.WriteLine("Values to fill the matrix :");

for (int i = 0; i < numRows; i++)
{
    int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    
    for (int j = 0; j < numColumns; j++)
    {
        matrix[i, j] = values[j];
    }
}

Console.WriteLine("-------------------");
for (int i = 0; i < numRows; i++)
{
    for (int j = 0; j < numColumns; j++)
    {
        Console.Write($"{matrix[i, j]} " );
    }
    Console.WriteLine();
}
Console.WriteLine("-------------------");


Console.Write("Position to search (rows,columns) : ");
int[] coordinates = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

int searchedRow = coordinates[0];
int searchedCol = coordinates[1];

if (searchedRow<numRows && searchedCol<numColumns)
{ 
    if ((searchedRow == 0) && (searchedCol == 0))
    {   
        Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
        Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
        
    } else if ((searchedRow == numRows-1) && (searchedCol == 0))
    {
        Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
        Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}");
        
    } else if ((searchedRow == 0) && (searchedCol == numColumns-1))
    {
        Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
        Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
        
    } else if ((searchedRow == numRows-1) && (searchedCol == numColumns-1))
    {
        Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
        Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}");
        
    } else if ((searchedRow == numRows-1) && ((searchedCol>0) && (searchedCol<numColumns-1)))
    {
        Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
        Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
        Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}");
        
    } else if ((searchedRow == 0)&& ((searchedCol>0) && (searchedCol<numColumns-1)))
    {
        Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
        Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
        Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
        
    } else if (((searchedRow > 0) && (searchedRow < numRows-1)) && (searchedCol == 0))
    {
        Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
        Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}"); 
        Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
        
    } else if (((searchedRow > 0) && (searchedRow < numRows-1)) && (searchedCol == numColumns-1))
    {
        Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
        Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}"); 
        Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
    }
else
{
    Console.WriteLine($"Left : {matrix[searchedRow, searchedCol-1]}");
    Console.WriteLine($"Right : {matrix[searchedRow, searchedCol+1]}");
    Console.WriteLine($"Top : {matrix[searchedRow-1, searchedCol]}"); 
    Console.WriteLine($"Bottom : {matrix[searchedRow+1, searchedCol]}");
}   
}
else
{
    Console.WriteLine("Invalid coordinates");
}