
string sourcePath = @"/Users/ricardotrindade/Documents/file1.txt";
string destinationPath = @"/Users/ricardotrindade/Documents/file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(destinationPath);
    Console.WriteLine("File {0} copied to {1}", sourcePath, destinationPath);
    
    string[] fileLines  = File.ReadAllLines(sourcePath); //Read all line from archive
    
    foreach (string line in fileLines)
    {
        Console.WriteLine(line);
    }
    
    
}
catch (IOException e)
{
    Console.WriteLine($"Error : {e.Message}");
}