using System.Globalization;
using System.Collections.Generic;
using inheritance_exercise2.Entities;

namespace inheritance_exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, employees));
                }

            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0.0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}