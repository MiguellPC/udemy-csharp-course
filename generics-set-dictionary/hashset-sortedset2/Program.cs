namespace hashset_sortedset2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollenction(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollenction(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollenction(e);
        }

        static void PrintCollenction<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}