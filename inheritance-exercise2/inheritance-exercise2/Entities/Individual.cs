namespace inheritance_exercise2.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * .15 - HealthExpenditures * .5;
            }
            else
            {
                return AnualIncome * .25 - HealthExpenditures * .5;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
