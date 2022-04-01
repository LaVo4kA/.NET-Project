using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NET_Project_API.BusinessLogic.Services.Blog;
using NET_Project_API.Models.Requests;

namespace NET_Project_API.Controllers
{
    [ApiController]
    [Route("blog")]
    public class BlogController : ControllerBase
    {
        private IBlogService BlogService { get; }

        public BlogController(IBlogService blogService)
        {
            BlogService = blogService;
        }

        /// <summary>
        /// Создание поста.
        /// </summary>
        /// <remarks>
        /// First sample request:
        ///
        ///     {
        ///         "title": "Как высыпаться каждый день?",
        ///         "text": "Если вы за ночь не выспались, то попробуйте сегодня уснуть на 10 минут раньше"
        ///     }
        ///
        /// Second sample request:
        ///
        ///     {
        ///         "title": "Обзор Elden Ring",
        ///         "text": "Сейчас у меня наиграно 35 часов, а я убил только первого 'главного' босса. Игра топ :)"
        ///     }
        ///
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Route("create")]
        public IActionResult CreatePost([Required][FromBody] CreatePostRequest request)
        {
            BlogService.CreatePost(request);
            return new ObjectResult("Пост успешно создан") { StatusCode = 201 };
        }

        /// <summary>
        /// Получение новостной ленты.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("news")]
        public IActionResult GetNewsFeed()
        {
            var news = BlogService.GetNewsFeed();
            return new ObjectResult(news) { StatusCode = 200 };
        }

        /// <summary>
        /// Лайкнуть пост по его id.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("like")]
        public IActionResult LikePost([FromQuery] Guid postId)
        {
            BlogService.LikePost(postId);
            return new ObjectResult("Пост лайкнут") { StatusCode = 200 };
        }

        /// <summary>
        /// Удалить пост.
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeletePost([FromQuery] Guid postId)
        {
            BlogService.DeletePost(postId);
            return new ObjectResult("Пост успешно удалён") { StatusCode = 200 };
        }
    }
}
