using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string Body { get; set; }
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string? ModeratedBody { get; set; }
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string? DeletedBody { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual BlogUser Author { get; set; }
        public virtual BlogUser Moderator { get; set; }
        public virtual Post Post { get; set; }

    }
}
