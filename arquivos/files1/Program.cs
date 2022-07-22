using System.Globalization;

namespace files1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\files1\files\Products.csv");

            try
            {
                string[] products = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string product in products)
                    {
                        string[] items = product.Split(',');
                        string name = items[0];
                        double price = double.Parse(items[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(items[2]);

                        double total = price * quantity;

                        sw.WriteLine(name + "," + total.ToString("F2", CultureInfo.InvariantCulture));
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