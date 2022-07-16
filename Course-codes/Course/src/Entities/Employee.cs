using System.Globalization;

namespace Course.src.Entities
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int iD, string name, double salary)
        {
            ID = iD;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage / 100.00);
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, ${Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

/*
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee ID that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.ID == idIncrease);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }


            Console.WriteLine("\nUpdated list of employees: ");
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
*/