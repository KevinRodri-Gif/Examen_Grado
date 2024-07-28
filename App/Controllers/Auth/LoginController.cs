using DegreeExamen.App.Commands;
using DegreeExamen.App.Commands.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeExamen.App.Controllers.Auth
{
    internal sealed class LoginController: BaseController
    {
        private readonly BaseCommand Command;

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
