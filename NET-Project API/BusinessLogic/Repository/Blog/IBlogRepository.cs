using System;
using System.Collections.Generic;
using NET_Project_API.Models;

namespace NET_Project_API.BusinessLogic.Repository.Blog
{
    public interface IBlogRepository
    {
        /// <summary>
        /// Создание поста.
        /// </summary>
        /// <param name="post"></param>
        public void CreatePost(Post post);

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
