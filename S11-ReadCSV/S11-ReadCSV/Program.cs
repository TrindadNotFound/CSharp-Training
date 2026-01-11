

using System.Globalization;

string sourcePath = @"/Users/ricardotrindade/Documents/products.csv";
string newFolferPath = @"/Users/ricardotrindade/Documents/out";
Directory.CreateDirectory(newFolferPath);

string[] lines = File.ReadAllLines(sourcePath);

double totalProductValue = 0;

var formatWithComma = new NumberFormatInfo { NumberDecimalSeparator = "," };

using (StreamReader streamReader = File.OpenText(sourcePath))
{
    foreach (string l in lines)
    {
        string[] productSplit = l.Split(",");
        totalProductValue = Math.Round(double.Parse(productSplit[1],System.Globalization.CultureInfo.InvariantCulture) * int.Parse(productSplit[2]),2);

        string i = Convert.ToString(totalProductValue);
        string result = i.Replace(",", ".");
        using (StreamWriter streamWriter = File.AppendText(newFolferPath + "//summary.csv"))
        {
            streamWriter.WriteLine($"{productSplit[0]},{result}");
        }
    }
}






/*
using (StreamWriter streamWriter = File.AppendText(targetPath))
{
    foreach (string st in lines)
    {
        streamWriter.WriteLine(st.ToUpper());
    }
}*/