namespace S15_LINQ_Lambda.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; }

    public Product(int id, string name, decimal price, Category category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }


    public override string ToString()
    {
        return $"Id : {Id} " +
               $"Name : {Name} " +
               $"Price : {Price.ToString("F2")} " +
               $"Category Name : {Category.Name}" +
               $"Category Tier : {Category.Tier}";
    }
}