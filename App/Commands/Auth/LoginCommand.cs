using DegreeExamen.App.Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DegreeExamen.App.Commands.Auth
{
    internal sealed class LoginCommand: BaseCommand
    {
        private readonly string Email;
        private readonly string Password;

        public LoginCommand(string Email, string Password) {
            this.Email = Email;
            this.Password = Password;
        }

        public override Task Handle()
        {
            try
            {
                SqlDataReader reader = Database
                    .Statement("SELECT * FROM users")
                    .Statement($"WHERE email = {Email} AND password = {Password}")
                    .Statement("LIMIT 1")
                    .Execute();

                if (reader.HasRows)
                {
                    throw new Exception("Wrong credentials");
                }

                return Task.FromResult(reader.Read());
            } catch (Exception exception)
            {
                return Task.FromException(exception);
            }
        }
    }
}
