using System;
using System.IO;

namespace DemoFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\arquivos\files\file1.txt";
            string targetPath = @"C:\workspace\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercises\arquivos\arquivos\files\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath, true);
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