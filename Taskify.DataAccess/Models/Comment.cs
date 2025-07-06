using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taskify.DataAccess.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(TaskItem))]
        public string TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
