using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    internal class Project
    {
        public Guid AuthorId { get; set; }
        public Guid Id { get; set; }
        public Guid[] TasksId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public enum StatusCombination { New, InWork, InAcceptance, InTest, Closed }
    }
}
