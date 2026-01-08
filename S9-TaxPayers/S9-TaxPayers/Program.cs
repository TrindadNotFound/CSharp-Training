// See https://aka.ms/new-console-template for more information

using S9_TaxPayers;

Console.Write("Enter the number of tax payers : ");
int totaltaxPayers = int.Parse(Console.ReadLine());

List<TaxPayer> payersList = new List<TaxPayer>();

Console.WriteLine("");

for (int i = 1; i <= totaltaxPayers; i++)
{
    Console.WriteLine($"Tax payer #{i} data : ");
    Console.Write("individual or Company (i/c) : ");
    char individualOrCompany = char.Parse(Console.ReadLine());

    Console.Write("Name : ");
    string name = Console.ReadLine();
    
    Console.Write("Annual income : ");
    double annualIncome = double.Parse(Console.ReadLine());

    if (individualOrCompany == 'c' || individualOrCompany == 'C')
    {
        Console.Write("Number of employees : ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        
        LegalTaxPayer legalPayer = new LegalTaxPayer(name, annualIncome, numberOfEmployees);
        payersList.Add(legalPayer);
        
    } else if (individualOrCompany == 'i' || individualOrCompany == 'I')
    {
        Console.Write("Healthcare expenses : ");
        double healthcareExpenses = double.Parse(Console.ReadLine());
        
        PersonalTaxPayer personalPayer = new PersonalTaxPayer(name, annualIncome, healthcareExpenses);
        payersList.Add(personalPayer);
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("TAX PAID : ");

double totalTaxes = 0;
foreach (TaxPayer taxP in payersList)
{
    Console.WriteLine(taxP);
    totalTaxes += taxP.TaxCalculation();
}

Console.WriteLine("");
Console.WriteLine($"Total taxes : {totalTaxes:F2}");

