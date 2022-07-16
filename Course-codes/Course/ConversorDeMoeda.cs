namespace Course
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double valor(double cotacao, double quantidade)
        {
            double total = cotacao * quantidade;
            return total + total * Iof / 100;
        }
    }
}
/*
Console.Write("Qual a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"Valor a ser pago em reais = R${ConversorDeMoeda.valor(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture)}");
*/