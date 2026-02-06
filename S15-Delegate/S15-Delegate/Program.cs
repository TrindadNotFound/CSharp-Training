using S15_Delegate.Service;

namespace S15_Delegate;

//delegate double BinaryNumericOperation(double n1, double n2);
delegate void BinaryNumericOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 20;

        //BinaryNumericOperation bno = CalculationService.Sum;
        //double result = bno(a, b);
        
        
        BinaryNumericOperation bno = CalculationService.ShowSum;
        bno += CalculationService.ShowMax;
        
        bno(a,b);
    }
}