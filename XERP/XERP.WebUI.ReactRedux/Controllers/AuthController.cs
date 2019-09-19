using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XERP.Application.Requests.Accounts.Queries.Login;

namespace XERP.WebUI.ReactRedux.Controllers
{
    public class AuthController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Login([FromBody]UserLoginModel model)
        {

            var user = await Mediator.Send(new GetUserDetailQuery { UserName = model.UserName, Password = model.Password });

            return Ok();
        }
    }
}
