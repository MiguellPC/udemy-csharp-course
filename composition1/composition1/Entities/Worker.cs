using composition1.Entities.Enums;

namespace composition1.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        public Department Department { get; private set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract item in Contracts)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    sum += item.TotalValue();
                }
            }
            return sum;
        }
    }
}
