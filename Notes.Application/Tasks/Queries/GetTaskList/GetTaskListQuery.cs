using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Project.Application.Tasks.Queries.GetTaskList
{
    public class GetTaskListQuery : IRequest<TaskListVm>
    {

        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
    }
}
