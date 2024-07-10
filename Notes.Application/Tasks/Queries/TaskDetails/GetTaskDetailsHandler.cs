using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Project.Application.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project.Application.Tasks.Queries.TaskDetails
{
    public class GetTaskDetailsHandler
        : IRequestHandler<GetTaskDetails, TaskDetailsVm>
    {
        private readonly IProjectDbContext _projectDbContext;
        private readonly IMapper _mapper;
        public GetTaskDetailsHandler(IProjectDbContext dbContext, IMapper mapper)
            => (_projectDbContext, _mapper) = (dbContext, mapper);
        public async Task<TaskDetailsVm> Handle(GetTaskDetails request, CancellationToken cancellationToken)
        {
            var entity = await _projectDbContext.Tasks_
                .FirstOrDefaultAsync(task =>
                task.Id == request.Id, cancellationToken);
            return _mapper.Map<TaskDetailsVm>(entity);
        }
    }
}
