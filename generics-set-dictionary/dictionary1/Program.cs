namespace dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("Deleting email");
            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key!");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("\nALL COOKIES:");
            foreach (KeyValuePair<string, string> str in cookies)
            {
                Console.WriteLine(str.Key + ": " + str.Value);
            }
        }
    }
}