using BlogApi.Exceptions;
using BlogApi.Token;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Threading;
using System.Threading.Tasks;


namespace BlogApi.DTO.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest,LoginUserCommandResponse>
    {
        readonly UserManager<EntityLayer.Concrete.AppUser> _userManager;
        readonly SignInManager<EntityLayer.Concrete.AppUser> _signinManager;
        readonly ITokenHandler _tokenHandler;

        public LoginUserCommandHandler(UserManager<EntityLayer.Concrete.AppUser> userManager, SignInManager<EntityLayer.Concrete.AppUser> signinManager, ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signinManager = signinManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            EntityLayer.Concrete.AppUser user = await _userManager.FindByNameAsync(request.username);
            if (user == null)
                user = await _userManager.FindByNameAsync(request.username);
            if (user == null)
                throw new NotFoundUserException();

            SignInResult result = await _signinManager.CheckPasswordSignInAsync(user, request.password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(5);
                return new LoginUserSuccessCommandResponse()
                {
                    Token = token

                };
            }
            return new LoginUserErrorCommandResponse()
            {
                Message = "Kullanıcı adı veya şifre hatalı"
            };
        }
    }
}
