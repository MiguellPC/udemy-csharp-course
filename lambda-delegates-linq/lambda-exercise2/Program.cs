using System.Globalization;
using System.Linq;
using lambda_exercise2.Entities;

namespace lambda_exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: "); ;
            // C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\lambda-delegates-linq\lambda-exercise2\Files\in.txt
            string path = Console.ReadLine();

            Console.Write("\nEnter salary: ");
            double searchSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine("\nEmail of people whose salary is more than " + searchSalary.ToString("F2", CultureInfo.InvariantCulture));
                var emails = employees.Where(e => e.Salary > searchSalary).OrderBy(e => e.Email).Select(e => e.Email);
                foreach (string email in emails)
                {
                    Console.WriteLine("- " + email);
                }

                var startWithM = employees.Where(e => e.Name.StartsWith('M')).Select(e => e.Salary).Sum();
                Console.WriteLine("\nSum of salary of people whose name starts with 'M': " + startWithM.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}