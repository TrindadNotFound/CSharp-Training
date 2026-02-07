using S15_LINQ_Lambda.Entities;
using System.Linq;
namespace S15_LINQ_Lambda;

class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }    
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        Category c1 = new Category(1, "Tools", 2);
        Category c2 = new Category(2, "Computers", 1);
        Category c3 = new Category(3, "Electronics", 1);

        List<Product> products = new List<Product>()
        {
            new Product(1, "Computer", 1100, c2),
            new Product(2, "Hammer", 90, c1),
            new Product(3, "TV", 1700, c3),
            new Product(4, "Notebook", 1300, c2),
            new Product(5, "Saw", 80, c1),
            new Product(6, "Tablet", 700, c2),
            new Product(7, "Camera", 700, c3),
            new Product(8, "Printer",350, c3),
            new Product(9, "McBook", 1800, c2),
            new Product(10, "Sound Bar", 700, c3),
        };
        var result_1 = products
            .Where(p => p.Category.Tier == 1 && p.Price < 900);
        
        Print("TIRE 1 AND PRICE < 900", result_1);
        
    }
}