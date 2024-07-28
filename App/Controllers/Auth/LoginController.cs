using DegreeExamen.App.Commands.Auth;
using System.Threading.Tasks;

namespace DegreeExamen.App.Controllers.Auth
{
    internal sealed class LoginController: BaseController
    {
        public LoginController(string Email, string Password)
        {
            Command = new LoginCommand(Email, Password);
        }

        public override Task Handle()
        {
            Command.Handle();
            return Task.CompletedTask;
        }
    }
}
