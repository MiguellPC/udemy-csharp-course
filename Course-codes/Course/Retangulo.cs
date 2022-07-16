namespace Course
{
    internal class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}

//Retangulo r = new();

//Console.WriteLine("Entre com a largura e com a altura do retângulo:");
//r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine($"\nAREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
//Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
//Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");