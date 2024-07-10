using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Project.Application.Projects.Queries.GetProjectsList
{
    public class GetProjectListQuery : IRequest<ProjectListVm>
    {
        public Guid AuthorId { get; set; }
    }
}
