using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Application.Interfaces;
using Project.Domain;
using Project.persistance.EntityTypeConfiguration;

namespace Project.persistance
{
    public class ProjectsDbContext : DbContext, IProjectDbContext
    {
        public DbSet<Project_> Projects_ { get; set; }
        public DbSet<Task_> Tasks_ { get; set; }
        public DbSet<User_> Users_ { get; set; }
        public ProjectsDbContext(DbContextOptions<ProjectsDbContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<User_>().HasData(new User_
            {
                Id = Guid.NewGuid(),
                Login = "admin1",
                Password = "admin1",
                UserName = "Admin1",
                UserRole = "Admin"
            });
            var converter = new ValueConverter<string[], string>(
                    x => string.Join(",", x),
                     x => x.Split(',', StringSplitOptions.RemoveEmptyEntries));
            Builder.Entity<Project_>()
                .Property(e => e.StatusCombination)
                .HasConversion(converter);

            Builder.Entity<Project_>()
                .HasMany(tasks => tasks.TasksId);

            Builder.Entity<Task_>()
               .HasOne(user => user.Worker);
            Builder.ApplyConfiguration(new ProjectConfiguration());

            base.OnModelCreating(Builder);

        }

    }
}
