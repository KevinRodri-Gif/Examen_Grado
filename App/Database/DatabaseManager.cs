using DegreeExamen.App.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeExamen.App.Database
{
    internal sealed class DatabaseManager
    {
        private static DatabaseManager _Instance;
        private readonly SqlConnection Connection;

        private DatabaseManager()
        {
            Connection = new SqlConnection(DatabaseConfig.ConnectionURL);
            Connection.Open();
        }

        public static DatabaseManager Instance()
        {
            return _Instance ?? (_Instance = new DatabaseManager());
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
