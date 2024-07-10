using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.Application.Common.Mappings;
using Project.Domain;

namespace Project.Application.Projects.Queries.GetProjectDetails
{
    public class ProjectDetailsVm : IMapWith<Project_>
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap<Project_, ProjectDetailsVm>()
                .ForMember(projectVm => projectVm.Name,
                    opt => opt.MapFrom(project => project.Name))
                .ForMember(projectVm => projectVm.Details,
                    opt => opt.MapFrom(project => project.Details))
                .ForMember(projectVm => projectVm.Id,
                    opt => opt.MapFrom(project => project.Id));
            //.ForMember(projectVm => projectVm.TasksId,
            //opt => opt.MapFrom(project => project.TasksId));
        }
    }
}
