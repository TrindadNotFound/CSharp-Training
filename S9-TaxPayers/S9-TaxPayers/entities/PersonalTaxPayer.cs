namespace S9_TaxPayers;

public class PersonalTaxPayer : TaxPayer
{
    public double HealthcareExpenses { get; set; }

    public PersonalTaxPayer(string name, double anualIncome, double  healthcareExpenses) : base(name, anualIncome)
    {
        HealthcareExpenses = healthcareExpenses;        
    }

    public override double TaxCalculation()
    {
        double result = 0;
        
        switch (AnualIncome)
        {
            case < 20000.00:
                result = AnualIncome-((AnualIncome - (0.15 * AnualIncome))) - (HealthcareExpenses - (0.5 * HealthcareExpenses));
                break;
            case >= 20000.00:
                result = AnualIncome-((AnualIncome - (0.25 * AnualIncome))) - (HealthcareExpenses - (0.5 * HealthcareExpenses));
                break;
            default:
                break;
        }

        return result;
    }

    public override string ToString()
    {
        return $"{Name} - {TaxCalculation():F2}";
    }
}