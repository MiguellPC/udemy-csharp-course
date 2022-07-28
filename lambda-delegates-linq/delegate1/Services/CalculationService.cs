namespace delegate1.Services
{
    internal class CalculationService
    {
        private static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        private static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return Math.Sqrt(x);
        }

        public static void ShowMax(double x, double y)
        {
            Console.WriteLine("Max: " + Max(x, y));
        }

        public static void ShowSum(double x, double y)
        {
            Console.WriteLine("Sum: " + Sum(x, y));
        }
    }
}
