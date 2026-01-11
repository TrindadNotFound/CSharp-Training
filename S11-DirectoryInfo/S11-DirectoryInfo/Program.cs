
string sourcePath = @"/Users/ricardotrindade/Documents";

try
{
   var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.TopDirectoryOnly);
   Console.WriteLine("Folders :");
   foreach (string i in folders)
   {
       Console.WriteLine(i);    
   }
   
   Console.WriteLine();
   
   
   var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);
   Console.WriteLine("Files :");
   foreach (string i in files)
   {
       Console.WriteLine(i);
   }

   Directory.CreateDirectory(@"/Users/ricardotrindade/Documents/newFolder");
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}