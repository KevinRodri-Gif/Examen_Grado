using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeExamen.App.Config
{
    internal sealed class DatabaseConfig
    {
        public static string ConnectionURL
        {
            get => Environment.GetEnvironmentVariable("DATABASE_URL");
        }
    }
}
