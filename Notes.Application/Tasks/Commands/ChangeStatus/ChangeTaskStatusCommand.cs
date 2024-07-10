using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Project.Application.Tasks.Commands.ChangeStatus
{
    public class ChangeTaskStatusCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
    }
}
