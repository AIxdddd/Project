using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class Project_
    {
        public Guid AuthorId { get; set; }
        public Guid Id { get; set; }
        [NotMapped]
        public List<Guid> TasksId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public enum StatusCombination { New, Closed }
    }
}
