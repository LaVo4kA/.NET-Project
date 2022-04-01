using System;

namespace NET_Project_API.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int Likes { get; set; }
    }
}
