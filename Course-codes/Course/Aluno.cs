using System.Globalization;

namespace Course
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }

        public double NotaFinal()
        {
            return (PrimeiraNota + SegundaNota + TerceiraNota);
        }

        public string Situacao()
        {
            if (NotaFinal() >= 60.00)
            {
                return $"APROVADO!!!";
            }
            else
            {
                return $"REPROVADO \nFALTARAM {(60.00 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}

//Aluno aluno = new Aluno();

//Console.Write("Nome do aluno: ");
//aluno.Nome = Console.ReadLine();
//Console.WriteLine("Digite as três notas do aluno: ");
//aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine($"\nNOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

//Console.WriteLine($"\n{aluno.Situacao()}");