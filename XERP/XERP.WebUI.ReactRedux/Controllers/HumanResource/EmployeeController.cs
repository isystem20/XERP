using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Application.Requests.HumanResource.Employees.Queries.GetEmployeesList;

namespace XERP.WebUI.ReactRedux.Controllers.HumanResource
{
    public class EmployeeController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetEmployeesListQuery()));
        }
    }
}
