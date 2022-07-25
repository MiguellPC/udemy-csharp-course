using System.Globalization;
using interface_exercise.Entities;
using interface_exercise.Services;

namespace interface_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, contractValue);

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService()); 
            contractService.ProcessContract(contract, installments);

            Console.WriteLine("\nInstallments:");
            foreach (Installment item in contract.Installments)
            {
                Console.WriteLine(item);
            }
        }
    }
}