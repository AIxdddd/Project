using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Projects.Queries.GetProjectsList
{
    public class ProjectListVm
    {
        public IList<ProjectLookUpDto> Projects { get; set; }
    }
}
