namespace extension_method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTimeExceptions
            DateTime dt = new DateTime(2022, 07, 25, 14, 50, 32);
            Console.WriteLine(dt.TimeElapsed());

            // StringExceptions
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}