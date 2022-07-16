using System.Globalization;

namespace inheritance_exercise2.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualIncome { get; private set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: ${Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
