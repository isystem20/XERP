using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Application.Requests.HumanResource.Departments.Commands.CreateDepartment;
using XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentDetail;
using XERP.Application.Requests.HumanResource.Departments.Queries.GetDepartmentsList;

namespace XERP.WebUI.ReactRedux.Controllers.HumanResource
{
    public class DepartmentController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetDepartmentsListQuery()));
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DepartmentDetailModel>> Get(string id)
        {
            return Ok(await Mediator.Send(new GetDepartmentDetailQuery { Id = id }));
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateDepartmentCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
