using MediatR;

namespace XERP.Application.Requests.Accounts.Queries.Login
{
    public class GetUserDetailQuery : IRequest<UserLoginModel>
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
