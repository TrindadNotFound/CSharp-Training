using S15_Func.Entities;
using System.Linq;
namespace S15_Func;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        
        list.Add(new Product("TV", 900));
        list.Add(new Product("XBox", 600));
        list.Add(new Product("Samsung Galaxy", 600));
        list.Add(new Product("iPhone X", 600));
        list.Add(new Product("iPhone X Pro", 600));


        Func<Product, string> func = p => p.Name.ToUpper();
        
        List<string> result = list.Select(func).ToList();

        foreach (String s in result)
        {
            Console.WriteLine(s);
        }
    }
}