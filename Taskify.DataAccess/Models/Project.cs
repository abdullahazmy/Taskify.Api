namespace Taskify.DataAccess.Models
{
    public class Project : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
        public ICollection<UserProject> UserProjects { get; set; }

    }
}
