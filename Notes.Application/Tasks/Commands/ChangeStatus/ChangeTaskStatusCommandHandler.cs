﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Project.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Project.Application.Tasks.Commands.ChangeStatus
{
    public class ChangeTaskStatusCommandHandler : IRequestHandler<ChangeTaskStatusCommand, Unit>
    {
        private readonly IProjectDbContext _projectDbContext;
        public ChangeTaskStatusCommandHandler(IProjectDbContext dbContext) =>
            _projectDbContext = dbContext;
        public async Task<Unit> Handle(ChangeTaskStatusCommand request, CancellationToken cancellationToken)
        {
            var entity =
            await _projectDbContext.Tasks_.FirstOrDefaultAsync(Task =>
            Task.Id == request.Id, cancellationToken);
            entity.Status = request.Status;
            await _projectDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
