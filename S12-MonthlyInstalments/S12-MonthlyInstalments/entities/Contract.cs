namespace S12_MonthlyInstalments.entities;

public class Contract
{
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public double TotalValue { get; set; }
    
    public List<Instalment> Instalments { get; set; }

    public Contract(int number, DateTime date, double totalValue, List<Instalment> Instalments)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
        Instalments = Instalments;
    }
}