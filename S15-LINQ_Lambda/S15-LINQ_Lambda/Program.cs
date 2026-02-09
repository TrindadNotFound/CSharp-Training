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
        
        
        var result_2 = products
            .Where(p => p.Category.Name == "Tools");
        Print("NAME OF PRODUCTS FROM TOOLS", result_2);

        
        var result_3 = products
            .Where(p=>p.Name.StartsWith('C') || p.Name.StartsWith('c'))
            .Select(p => new {PRODUCT_NAME = p.Name, PRODUCT_PRICE = p.Price, CATEGORY_NAME = p.Category.Name});
        Print("NAME OF PRODUCTS STARTED BY 'C'", result_3);

        
        var result_4 = products
            .Where(p => p.Category.Tier == 1)
            .Select(p => new {PRODUCT_NAME = p.Name, PRODUCT_PRICE = p.Price, CATEGORY_NAME = p.Category.Name})
            .OrderBy(p => p.PRODUCT_PRICE)
            .ThenBy(p => p.CATEGORY_NAME);
        Print("ALL PRODUCTS WHERE TIRE IS 1", result_4);

        
        var result_5 = result_4
            .Skip(2)
            .Take(4)
            .OrderBy(p => p.PRODUCT_PRICE); 
        Print("SKIP FIRST 2 PRODUCTS AND SHOW NEXT 4 PRODUCTS", result_5);

        try
        {
            var result_6 = products.Where(p => p.Price > 4000).FirstOrDefault();

            Console.WriteLine($"PRICE > 4000 : {result_6}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"FIRST PRICE > 4000 ERROR : {e.Message}");
        }

        Console.WriteLine();
        
        var result_7 = products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine($"SINGLE RESULT : {result_7}");
        
        Console.WriteLine();
        
        var result_8 = products.MaxBy(p => p.Price);
        Console.WriteLine($"MAX PRICE PRODUCT : {result_8.Name} -  {result_8.Price}");
        
        Console.WriteLine();
        
        var result_9 = products.MinBy(p => p.Price);
        Console.WriteLine($"MIN PRICE PRODUCT : {result_9.Name} -   {result_9.Price}");
    }
}