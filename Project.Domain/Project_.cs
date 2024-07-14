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
        public Project_()
        {
            TasksId = new List<Task_>();
        }
        public Guid AuthorId { get; set; }
        public Guid Id { get; set; }

        public List<Task_> TasksId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string[] StatusCombination { get; set; }
    }
}
