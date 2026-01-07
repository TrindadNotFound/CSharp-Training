namespace S9_ImportedUsedProducts.entities;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    
    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string priceTage()
    {
        return "xpto";
    }
}