using System.Collections.Generic;

namespace hashset_sortedset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string str in set)
            {
                Console.WriteLine(str);
            }
        }
    }
}