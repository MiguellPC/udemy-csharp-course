using delegate1.Services;

namespace delegate1
{
    delegate void BynareNumericOperation(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            double c = 20;

            BynareNumericOperation op1 = CalculationService.ShowSum;
            op1 += CalculationService.ShowMax;
            op1(a, b);
            op1(a, c);

            BynareNumericOperation op2 = CalculationService.ShowMax;
            op2(a, b);
        }
    }
}