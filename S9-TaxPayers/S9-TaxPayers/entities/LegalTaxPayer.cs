namespace S9_TaxPayers;

public class LegalTaxPayer : TaxPayer
{
    public int TotalEmployees { get; set; }

    public LegalTaxPayer(string name, double anualIncome, int totalEmployees) : base(name, anualIncome)
    {
        TotalEmployees = totalEmployees;
    }

    public override double TaxCalculation()
    {
        double result = 0;

        switch (TotalEmployees)
        {
            case > 10:
                result = 0.14 * AnualIncome;;
                break;
            default:
                result = 0.16 * AnualIncome;
                break;
        }

        return result;
    }
    
    public override string ToString()
    {
        return $"{Name} - {TaxCalculation():F2}";
    }
}