using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using XERP.DataModel.SYSTEM;

namespace XERP.Core.API.Controllers.Authentication
{
    [Route("api/cas")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUsers> _userManager;

        private SignInManager<ApplicationUsers> _signInManager;


        public ApplicationUserController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //[HttpPost]
        //[Route("register")]



    }
}