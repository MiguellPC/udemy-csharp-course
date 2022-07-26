using set1.Entities;

namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            // C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\generics-set-dictionary\set1\files\in.txt
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}