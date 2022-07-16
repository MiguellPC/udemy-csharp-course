using composition2.Entities;

namespace composition2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you!");

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine($"\n{p1}");
            Console.WriteLine($"\n{p2}");

            p1.RemoveComment(c1);
            p2.RemoveComment(c4);

            Console.WriteLine($"\n{p1}");
            Console.WriteLine($"\n{p2}");
        }
    }
}