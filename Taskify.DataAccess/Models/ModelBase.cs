using System.ComponentModel.DataAnnotations;

namespace Taskify.DataAccess.Models
{
    public class ModelBase
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
