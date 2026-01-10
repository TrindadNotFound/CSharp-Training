
string filePath = @"/Users/ricardotrindade/Documents/file1.txt";

FileStream fileStream = null;
StreamReader streamReader = null;

try
{
    fileStream = new FileStream(filePath, FileMode.Open);
    streamReader = new StreamReader(fileStream);
    
    string line = streamReader.ReadLine();

    Console.WriteLine(line);
    

}
catch (IOException e)
{
    Console.WriteLine(e.Message);
} 
finally
{
    fileStream.Close();
    fileStream.Dispose();
    
    streamReader.Close();
    streamReader.Dispose();
}