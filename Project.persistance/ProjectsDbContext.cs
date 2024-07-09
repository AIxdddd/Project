using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
            Builder.Entity<Project_>()
                .HasNoKey();
            Builder.ApplyConfiguration(new ProjectConfiguration());

            base.OnModelCreating(Builder);

        }
    }
}
