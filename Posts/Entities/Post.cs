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
    }
}
