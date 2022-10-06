using MediatR;

namespace BlogApi.DTO.AppUser.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
