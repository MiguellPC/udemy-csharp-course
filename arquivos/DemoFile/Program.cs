namespace DemoFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\DemoFile\files\file1.txt";
            string targetPath = @"C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\DemoFile\files\file2.txt";

            try
            {
                File.Copy(sourcePath, targetPath, true);
                string[] lines = File.ReadAllLines(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
        }
    }
}