using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Application.Interfaces.Mapping;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentsList
{
    public class DepartmentLookupModel : IHaveCustomMapping
    {
        public string Id { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Department, DepartmentLookupModel>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id));
        }
    }
}
