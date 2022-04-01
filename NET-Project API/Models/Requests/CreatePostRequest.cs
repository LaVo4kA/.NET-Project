using System.ComponentModel.DataAnnotations;

namespace NET_Project_API.Models.Requests
{
    public class CreatePostRequest
    {
        /// <summary>
        /// Заголовок поста
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Основное содержание
        /// </summary>
        [Required]
        public string Text { get; set; }
    }
}
