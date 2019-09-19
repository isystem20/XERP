using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentDetail
{
    public class GetDepartmentDetailQuery : IRequest<DepartmentDetailModel>
    {
        public string Id { get; set; }
    }
}
