using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Taskify.DataAccess.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }


    }
}
