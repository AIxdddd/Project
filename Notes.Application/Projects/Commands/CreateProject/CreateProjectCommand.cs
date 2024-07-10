using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
namespace Project.Application.Projects.Commands.CreateProject
{
    public class CreateProjectCommand : IRequest<Guid>
    {

        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public List<Guid> TasksId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public enum StatusCombination { New, Closed }

    }
}
