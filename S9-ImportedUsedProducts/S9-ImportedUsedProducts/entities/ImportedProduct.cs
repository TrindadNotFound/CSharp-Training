namespace S9_ImportedUsedProducts.entities;

public class ImportedProduct : Product
{
    public double CustomerFee { get; set; }

    public ImportedProduct(string name, double price, double customerFee) : base(name, price)
    {
        CustomerFee = customerFee;
    }

    public double TotalPrice()
    {
        return Price * CustomerFee;
    }
    
    public override string PriceTag()
    {
        return $"{Name} - {TotalPrice():F2}€ (Customs fee : {CustomerFee}€)";
    }
}