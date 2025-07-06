using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taskify.DataAccess.Models
{
    public class TaskItem
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public TaskStatus Status { get; set; }
        public Priority Priority { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; }

        [ForeignKey("AssignedToUser")]
        public string AssignedToUserId { get; set; }
        public ApplicationUser AssignedToUser { get; set; }

        [ForeignKey(nameof(Project))]
        public string ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }

    public enum Priority { Low, Medium, High }
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Done
    }

}
