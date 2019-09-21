using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XERP.Application.Requests.HumanResource.Employees.Queries.GetEmployeesList
{
    public class EmployeeListViewModel
    {
        public IList<EmployeeLookupModel> Employees { get; set; }
    }
}
