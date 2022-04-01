using System;
using System.Collections.Generic;
using NET_Project_API.Models;

namespace NET_Project_API.BusinessLogic.Repository.Blog
{
    public class BlogRepository : IBlogRepository
    {
        private IDictionary<Guid,Post> NewsFeed { get; set; }

        public BlogRepository()
        {
            NewsFeed = new Dictionary<Guid, Post>();
        }

        public void CreatePost(Post post)
        {
            NewsFeed.Add(post.Id, post);
        }

        public IEnumerable<Post> GetNewsFeed()
        {
            return NewsFeed.Values;
        }

        public void LikePost(Guid postId)
        {
            if (NewsFeed.TryGetValue(postId, out var post))
            {
                post.Likes++;
                NewsFeed[postId] = post;
            }
            else
            {
                throw new ArgumentException("Пост не найден");
            }
        }

        public void DeletePost(Guid postId)
        {
            NewsFeed.Remove(postId);
        }
    }
}
