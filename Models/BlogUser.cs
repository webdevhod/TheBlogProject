using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    // https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.identityuser?view=aspnetcore-6.0
    public class BlogUser : IdentityUser
    {
        [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [StringLength(75, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string? Google { get; set; }

        [StringLength(75, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string? Facebook { get; set; }
        
        [StringLength(75, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 2)]
        public string? Twitter { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageType { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
