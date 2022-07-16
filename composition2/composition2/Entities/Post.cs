using System.Text;


namespace composition2.Entities
{
    internal class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.AppendLine($"{Likes} Likes - {Moment}");
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment item in Comments)
            {
                sb.AppendLine(item.Text);
            }

            return sb.ToString();
        }
    }
}
