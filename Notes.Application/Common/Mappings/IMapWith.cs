using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AutoMapper;
using Project.Application.Common.Mappings;
namespace Project.Application.Common.Mappings
{
    public interface IMapWith<T>
    {
        void Mapping(Profile profile)
        {
            profile.AllowNullCollections = true;
            profile.CreateMap(typeof(T), GetType());
        }
    }
}
