using DegreeExamen.App.Commands.Auth;
using DegreeExamen.App.Controllers.Exceptions;
using System;
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
            try
            {
                return Command.Handle();
            }
            catch (Exception exception)
            {
                throw new ControllerException(exception.Message);
            }
        }
    }
}
