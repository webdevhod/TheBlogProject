using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlogProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string Text { get; set; }
        [StringLength(500, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        
        public virtual Post Posts { get; set; }
        public virtual IdentityUser Author { get; set; }
    }
}
