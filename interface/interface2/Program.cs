using interface2.Entities;

namespace interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\interface\interface2\files\in.txt");
                        
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}