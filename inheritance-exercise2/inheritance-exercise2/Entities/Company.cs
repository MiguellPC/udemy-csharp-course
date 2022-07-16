namespace inheritance_exercise2.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmpolyees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmpolyees) : base(name, anualIncome)
        {
            NumberOfEmpolyees = numberOfEmpolyees;
        }

        public override double Tax()
        {
            if (NumberOfEmpolyees > 10)
            {
                return AnualIncome * .14;
            }
            else
            {
                return AnualIncome * .16;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
