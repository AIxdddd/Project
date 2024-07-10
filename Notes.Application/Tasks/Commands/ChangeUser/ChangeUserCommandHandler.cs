using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Project.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Project.Application.Tasks.Commands.ChangeUser
{
    public class ChangeUserCommandHandler : IRequestHandler<ChangeUserCommand, Unit>
    {
        private readonly IProjectDbContext _projectDbContext;
        public ChangeUserCommandHandler(IProjectDbContext dbContext) =>
            _projectDbContext = dbContext;
        public async Task<Unit> Handle(ChangeUserCommand request, CancellationToken cancellationToken)
        {
            var entity =
            await _projectDbContext.Tasks_.FirstOrDefaultAsync(Task =>
            Task.Id == request.Id, cancellationToken);
            entity.UserId = request.UserId;
            await _projectDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
