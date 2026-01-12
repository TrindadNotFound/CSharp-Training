namespace S12_MonthlyInstalments.entities;

public class Instalment
{
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Instalment(DateTime dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }
}