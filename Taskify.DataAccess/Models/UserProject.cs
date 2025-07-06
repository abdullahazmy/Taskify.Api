namespace Taskify.DataAccess.Models
{
    public class UserProject
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public string ProjectId { get; set; }
        public Project Project { get; set; }

        public string Role { get; set; } // Admin, Member, etc.
    }
}
