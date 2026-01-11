namespace S12_RentalCarInterface.entities;

public class Invoice (double basicPayment, double tax)
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public double TotalPayment
    {
        get {return BasicPayment + Tax;}
    }

    public override string ToString()
    {
        return $"Basic payment: {BasicPayment.ToString("F2")} \n Tax: {Tax.ToString("F2")} \n Total payment: {TotalPayment.ToString("F2")}";
    }
}