using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Project.Application.Projects.Queries.GetProjectDetails
{
    public class GetProjectDetailsQueryHandler
       : IRequestHandler<GetProjectDetailsQuery, ProjectDetailsVm>
    {

        private readonly IProjectDbContext _projectDbContext;
        private readonly IMapper _mapper;
        public GetProjectDetailsQueryHandler(IProjectDbContext dbContext, IMapper mapper)
            => (_projectDbContext, _mapper) = (dbContext, mapper);
        public async Task<ProjectDetailsVm> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _projectDbContext.Projects_
                .FirstOrDefaultAsync(project =>
                project.Id == request.Id, cancellationToken);
            return _mapper.Map<ProjectDetailsVm>(entity);
        }
    }
}
