using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskify.DataAccess.Models
{
    public class ModelBase
    {
        [Key]
        public int Id { get; set; }
    }
}
