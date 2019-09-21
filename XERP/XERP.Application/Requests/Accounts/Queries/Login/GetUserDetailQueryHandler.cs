using MediatR;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using XERP.Application.Exceptions;
using XERP.Application.Interfaces;
using XERP.Domain.Entities;
using XERP.Application.Security.JWT;
using Microsoft.AspNetCore.Identity;

namespace XERP.Application.Requests.Accounts.Queries.Login
{
    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserLoginModel>
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwTokenStore _jwTokenStore;
        private readonly IXERPDbContext _context;

        public GetUserDetailQueryHandler(IXERPDbContext context, IJwTokenStore jwTokenStore, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
            _jwTokenStore = jwTokenStore;
        }


        public async Task<UserLoginModel> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            //var entity = await _context.ApplicationUsers
            //    .FindAsync(request.Id);
            try
            {

                var user = _context.ApplicationUsers.SingleOrDefault(u => u.UserName == request.UserName);

                if (user != null)
                {
                    var result = await _signInManager
                                                 .PasswordSignInAsync(request.UserName, request.Password, false, false);

                    if (result.Succeeded)
                    {
                        var claims = new List<Claim>
                         {
                            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(ClaimTypes.NameIdentifier, user.UserName),
                            new Claim("userId", user.Id)
                         };

                        var roles = await _userManager.GetRolesAsync(user);

                        foreach (var role in roles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }



                    }

                    return UserLoginModel.Create(user);

                }
                else
                {
                    throw new NotFoundException(nameof(ApplicationUser), request.UserName);
                }

                
            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }
}
