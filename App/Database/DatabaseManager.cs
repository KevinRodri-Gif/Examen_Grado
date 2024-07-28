using DegreeExamen.App.Config;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DegreeExamen.App.Database
{
    internal sealed class DatabaseManager
    {
        private static DatabaseManager _Instance;
        private readonly SqlConnection Connection;
        private IList<string> Commands = new List<string>();

        private string JoinedCommands
        {
            get => string.Join(" ", Commands.ToArray());
        }

        private DatabaseManager()
        {
            Connection = new SqlConnection(DatabaseConfig.ConnectionURL);
            Connection.Open();
        }

        public static DatabaseManager Instance()
        {
            return _Instance ?? (_Instance = new DatabaseManager());
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }

        public DatabaseManager Statement(string statement)
        {
            Commands.Add(statement);
            return this;
        }

        public SqlDataReader Execute()
        {
            SqlCommand command = new SqlCommand(JoinedCommands, Connection);
            Commands.Clear();
            return command.ExecuteReader();
        }
    }
}
