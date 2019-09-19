using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentsList
{
    public class DepartmentsListViewModel
    {
        public IList<DepartmentLookupModel> Departments { get; set; }
    }
}
