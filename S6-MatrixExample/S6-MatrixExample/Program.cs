Console.WriteLine("Enter two integer numbers to set a matrix size : ");
Console.Write("Number 1 (columns) : ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Number 2 (lines) : ");
int num2 = int.Parse(Console.ReadLine());

int[,] matrix = new int[num1, num2];

Console.WriteLine();
Console.WriteLine("Values to fill the matrix :");

for (int i = 0; i < num1; i++)
{
    int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    
    for (int j = 0; j < num2; j++)
    {
        matrix[i, j] = values[j];
    }
}

Console.WriteLine("-------------------");
for (int i = 0; i < num1; i++)
{
    for (int j = 0; j < num2; j++)
    {
        Console.Write($"{matrix[i, j]} " );
    }
    Console.WriteLine();
}
Console.WriteLine("-------------------");

Console.Write("Position to search : ");
int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

