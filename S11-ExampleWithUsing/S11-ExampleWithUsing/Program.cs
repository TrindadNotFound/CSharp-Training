
string sourcePath = @"/Users/ricardotrindade/Documents/file1.txt";
string targetPath = @"/Users/ricardotrindade/Documents/file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath); 
    using (StreamReader streamReader = File.OpenText(sourcePath))
    {
        while (!streamReader.EndOfStream)
        {
            Console.WriteLine(streamReader.ReadLine());
        }
        
        
    }

    using (StreamWriter streamWriter = File.AppendText(targetPath))
    {
        foreach (string st in lines)
        {
            streamWriter.WriteLine(st.ToUpper());
        }
    }
    
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}