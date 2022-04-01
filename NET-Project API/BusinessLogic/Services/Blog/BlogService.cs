using System;
using System.Collections.Generic;
using NET_Project_API.BusinessLogic.Repository.Blog;
using NET_Project_API.Models;
using NET_Project_API.Models.Requests;

namespace NET_Project_API.BusinessLogic.Services.Blog
{
    public class BlogService : IBlogService
    {
        public IBlogRepository BlogRepository { get; set; }

        public BlogService(IBlogRepository blogRepository)
        {
            BlogRepository = blogRepository;
        }

        public void CreatePost(CreatePostRequest request)
        {
            var post = new Post()
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Text = request.Text
            };

            try
            {
                BlogRepository.CreatePost(post);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public IEnumerable<Post> GetNewsFeed()
        {
            try
            {
                return BlogRepository.GetNewsFeed();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void LikePost(Guid postId)
        {
            try
            {
                BlogRepository.LikePost(postId);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void DeletePost(Guid postId)
        {
            try
            {
                BlogRepository.DeletePost(postId);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
