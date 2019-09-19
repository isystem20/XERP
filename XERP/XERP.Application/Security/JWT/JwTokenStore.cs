using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using XERP.Application.Interfaces;
using XERP.Domain.Entities;
using XERP.Domain.Entities.Security;

namespace XERP.Application.Security.JWT
{
    public class JwTokenStore : IJwTokenStore
    {
        private readonly IXERPDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwTokenModel _jwToken;

        public JwTokenStore(IXERPDbContext context, UserManager<ApplicationUser> userManager, IOptions<JwTokenModel> jwToken)
        {
            _context = context;
            _userManager = userManager;
            _jwToken = jwToken.Value;
        }

        public object ReadRefreshJwToken(string userId)
        {
            var currentDateTime = DateTime.Now;
            var refreshToken = _context.RefreshTokens
                .Where(r => r.UserId == userId && r.ExpiresUtc <= currentDateTime)
                .FirstOrDefault<RefreshToken>();

            return refreshToken;
        }



    }



}
