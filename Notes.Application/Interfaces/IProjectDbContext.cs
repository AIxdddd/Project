using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain;
using Microsoft.EntityFrameworkCore;
namespace Project.Application.Interfaces
{
    public interface IProjectDbContext
    {
        DbSet<Task_> Tasks_ { get; set; }
        DbSet<User_> Users_ { get; set; }
        DbSet<Project_> Projects_ { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
