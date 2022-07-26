using set2.Entities;

namespace set2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            string[] courses = new string[] { "A", "B", "C" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write($"How many students for course {courses[i]}? ");
                int num = int.Parse(Console.ReadLine());

                for (int j = 0; j < num; j++)
                {
                    int n = int.Parse(Console.ReadLine());
                    students.Add(new Student(n));
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Total students: " + students.Count);
        }
    }
}