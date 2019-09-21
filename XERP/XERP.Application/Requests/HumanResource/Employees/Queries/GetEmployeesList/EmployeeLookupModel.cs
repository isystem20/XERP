using AutoMapper;
using XERP.Application.Interfaces.Mapping;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Requests.HumanResource.Employees.Queries.GetEmployeesList
{
    public class EmployeeLookupModel : IHaveCustomMapping
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Employee, EmployeeLookupModel>()
                .ForMember(cDTO => cDTO.Id, opt => opt.MapFrom(c => c.Id));
        }

    }
}
