using System;
using System.Collections.Generic;
using NET_Project_API.Models;
using NET_Project_API.Models.Requests;

namespace NET_Project_API.BusinessLogic.Services.Blog
{
    public interface IBlogService
    {
        /// <summary>
        /// Создаёт пост в новостной ленте пользователя.
        /// </summary>
        /// <returns></returns>
        public void CreatePost(CreatePostRequest request);
        
        /// <summary>
        /// Получение ленты новостей.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Post> GetNewsFeed();

        /// <summary>
        /// Лайкнуть пост.
        /// </summary>
        /// <param name="postId"></param>
        public void LikePost(Guid postId);

        /// <summary>
        /// Удалить пост.
        /// </summary>
        /// <param name="postId"></param>
        public void DeletePost(Guid postId);
    }
}
