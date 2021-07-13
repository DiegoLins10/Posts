using System;
using System.Collections.Generic;
using System.Text;

namespace Posts.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> ListComments { get; set; } = new List<Comment>(); // associando post com
                                                                               // varios coments com uma list 

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            ListComments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            ListComments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in ListComments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
