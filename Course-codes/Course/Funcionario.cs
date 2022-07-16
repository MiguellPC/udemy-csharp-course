namespace Course
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            this.SalarioBruto += (this.SalarioBruto * porcentagem / 100.0);
        }
    }
}

//Funcionario f = new();

//Console.Write("Nome: ");
//f.Nome = Console.ReadLine();
//Console.Write("Salário Bruto: ");
//f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.Write("Imposto: ");
//f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine($"\nFuncionário: {f.Nome}, ${f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

//Console.Write("\nDigite a porcentagem para aumentar o salário: ");
//f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

//Console.WriteLine($"\nDados atualizados: {f.Nome}, ${f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
