using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Title Max length can be up to 280 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(5, ErrorMessage = "Content must be 5 characters")]
        [MaxLength(280, ErrorMessage = "Content Max length can be up to 280 characters")]
        public string Content { get; set; }= string.Empty;
    }
}