namespace hashset1.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Product)
            {
                return false;
            }

            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }
    }
}
