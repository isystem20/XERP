﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using XERP.Core.API.Models;
using XERP.DataModel.SYSTEM;

namespace XERP.Core.API.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<ApplicationUsers> _userManager;

        private SignInManager<ApplicationUsers> _signInManager;


        public AuthController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet("token")]
        public ActionResult GetToken()
        {

            //Security Key
            string securityKey = "ThisShouldBeLongTextBecauseItWillReturnAnErrorIfTheSecurityKeyIsShort";

            //Symmetric Security Key
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            //Signing Credentials
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            //Create Token
            var token = new JwtSecurityToken(
                    issuer: "theunnamed.com",
                    audience: "clients",
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredentials
                );
                       
            //Return Token
            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }

        [HttpPost]
        [Route("register")]
        //Post: /api/auth/register
        public async Task<Object> RegisterUserAsync(ApplicationUserModel model)
        {
            var applicationUser = new ApplicationUsers()
            {
                UserName = model.UserName,
                Email = model.Email,
                //ClientId = model.ClientId,
                //CompanyId = model.CompanyId,
                //EmployeeId = model.EmployeeId,
                SecurityHash = model.SecurityHash,
            };


            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<Object> LoginUserAsync([FromBody]LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {

                if (await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserId", user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(5),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("H0qvrPrOsGjdJNMHrdwF")), SecurityAlgorithms.HmacSha256Signature),
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    return Ok(new ResultResponse { success = true, result = token });
                }
                else
                {
                    return StatusCode(401, new ResultResponse { success  = false, result = "Invalid Username/Password" } );
                }

            }
            else
                return StatusCode(401, new ResultResponse { success = false, result = "Account Not Found." });
        }
        
    }
}