using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities.HumanResource;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentDetail
{
    public class DepartmentDetailModel
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string CompanyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public DateTime CreatedAt { get; set; }
        public string LastModifiedById { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public int VersionNo { get; set; }
        public string Status { get; set; }


        public static Expression<Func<Department, DepartmentDetailModel>> Projection
        {
            get
            {
                return department => new DepartmentDetailModel
                {
                    Id = department.Id,
                    Code = department.Code,
                    CompanyId = department.CompanyId,
                    Name = department.Name,
                    Description = department.Description,
                    CreatedById = department.CreatedById,
                    CreatedAt = department.CreatedAt,
                    LastModifiedById = department.LastModifiedById,
                    LastModifiedAt = department.LastModifiedAt,
                    VersionNo = department.VersionNo,
                    Status = department.Status
                };
            }
        }

        public static DepartmentDetailModel Create(Department department)
        {
            return Projection.Compile().Invoke(department);
        }

    }
}
