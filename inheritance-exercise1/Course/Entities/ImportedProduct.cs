using System.Globalization;

namespace Course.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; private set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} - ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: ${CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
