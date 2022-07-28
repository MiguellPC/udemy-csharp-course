using lambda3.Entities;

namespace lambda3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // aumente o preço dos produtos em 10 %

            //Action<Product> act = UpdatePrice;
            //list.ForEach(UpdatePrice);

            //Action<Product> act = p => { p.Price += p.Price * 0.10; };
            //list.ForEach(act);

            list.ForEach(p => { p.Price += p.Price * 0.10; });

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += (p.Price * 0.10);
        }
    }
}