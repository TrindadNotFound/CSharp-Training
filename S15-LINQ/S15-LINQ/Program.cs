namespace S15_LINQ;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Specify data source
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        //Define the query expression
        var result = numbers
            .Where(n => n % 2 == 0)
            .Select(x => x * 10);
        
        //Execute query
        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}