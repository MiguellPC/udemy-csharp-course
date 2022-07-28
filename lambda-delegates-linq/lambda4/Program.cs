using lambda4.Entities;

namespace lambda4
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

            // a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.
            
            // #1
            //List<string> result = list.Select(NameUpper).ToList();
            
            // #2
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            // #3
            //Func<Product, string> func = p => p.Name.ToUpper(); 
            //List<string> result = list.Select(func).ToList();
            
            // #4
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}