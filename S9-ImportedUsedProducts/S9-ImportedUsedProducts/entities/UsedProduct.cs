namespace S9_ImportedUsedProducts.entities;

public class UsedProduct : Product
{
    public DateTime ManufacturedDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
    {
        ManufacturedDate = manufacturedDate;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) - {Price}€ (Manufacture date: {ManufacturedDate})";
    }
}