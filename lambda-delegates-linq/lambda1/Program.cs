using lambda1.Entities;

namespace lambda1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> compName = CompareProductsByName;
            Comparison<Product> compPrice = CompareProductsByPrice;

            // lambda
            Comparison<Product> compNameLambda = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            Comparison<Product> compPriceLambda = (p1, p2) => p1.Price.CompareTo(p2.Price);

            list.Sort(compPriceLambda);

            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProductsByName(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }

        static int CompareProductsByPrice(Product p1, Product p2)
        {
            return p1.Price.CompareTo(p2.Price);
        }
    }
}