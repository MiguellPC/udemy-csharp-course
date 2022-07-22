namespace FileStream_StreamReader_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\FileStream-StreamReader-1\files\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}