using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XERP.Domain.Entities;

namespace XERP.Application.Requests.Accounts.Queries.Login
{
    public class UserLoginModel
    {

        public string UserName { get; set; }

        public string Password { get; set; }


        public static Expression<Func<ApplicationUser, UserLoginModel>> Projection
        {
            get
            {
                return user => new UserLoginModel
                {
                    UserName = user.UserName,
                    Password = user.PasswordHash
                };
            }
        }

        public static UserLoginModel Create(ApplicationUser user)
        {
            return Projection.Compile().Invoke(user);
        }

    }
}
