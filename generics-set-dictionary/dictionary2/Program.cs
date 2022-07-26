namespace dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file full path: ");
                // C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\generics-set-dictionary\dictionary2\files\file.txt
                string path = Console.ReadLine();

                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> candidate = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (!candidate.ContainsKey(name))
                        {
                            candidate.Add(name, votes);
                            //candidate[name] = votes;
                        }
                        else
                        {
                            candidate[name] += votes;
                        }
                    }

                    foreach (var item in candidate)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}