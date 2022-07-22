namespace Streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\StreamWriter\files\file1.txt");
            string targetPath = Path.Combine(Directory.GetCurrentDirectory(), @"\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\StreamWriter\files\file2.txt");

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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