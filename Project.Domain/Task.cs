using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    internal class Task
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
        public string TaskNm { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
    }
}
