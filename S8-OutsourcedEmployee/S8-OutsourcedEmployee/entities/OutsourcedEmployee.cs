namespace S8_OutsourcedEmployee.entities;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        return (ValuePerHour * Hours) + ((ValuePerHour * Hours) * (AdditionalCharge/100));
    }
}