using S9_ImportedUsedProducts.entities;

Console.Write("Enter the number of products : ");
int numberOfProducts = int.Parse(Console.ReadLine());

List<Product> productList = new List<Product>();

Console.WriteLine("");

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, Used or Imported (c/u/i) ? ");
    char productType = char.Parse(Console.ReadLine());

    if (productType == 'u' || productType == 'U')
    {
        Console.Write("Product name : ");
        string productName = Console.ReadLine();
    
        Console.Write("Product price : ");
        double productPrice = double.Parse(Console.ReadLine());

        Console.Write("Manufacture date (DD/MM/YYYY) : ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        
        UsedProduct usedProduct = new UsedProduct(productName, productPrice, manufactureDate);
        
        productList.Add(usedProduct);
        
    } else if (productType == 'i' || productType == 'I')
    {
        Console.Write("Product name : ");
        string productName = Console.ReadLine();
    
        Console.Write("Product price : ");
        double productPrice = double.Parse(Console.ReadLine());

        Console.Write("Customs fee : ");
        double customsFee = double.Parse(Console.ReadLine());
        
        ImportedProduct importedProduct = new ImportedProduct(productName, productPrice, customsFee);
        
        productList.Add(importedProduct);
    }
    else
    {
        Console.Write("Product name : ");
        string productName = Console.ReadLine();
    
        Console.Write("Product price : ");
        double productPrice = double.Parse(Console.ReadLine());
        
        Product product = new Product(productName, productPrice);
        
        productList.Add(product);
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("PRICE TAGS");
foreach (Product prod in productList)
{
    Console.WriteLine(prod.PriceTag());
}