using System;

namespace DegreeExamen.App.Config
{
    internal sealed class DatabaseConfig
    {
        public static string DatabaseName
        {
            get => Environment.GetEnvironmentVariable("DATABASE_NAME");
        }

        public static string DatabaseServer
        {
            get => Environment.GetEnvironmentVariable("DATABASE_SERVER");
        }

        public static string DatabaseSecurity
        {
            get => Environment.GetEnvironmentVariable("DATABASE_SECURITY") ?? "true";
        }

        public static string ConnectionURL
        {
            // We need to replace the pattern template in the URL to connect to database server.
            // 
            // Default URL template: server={SERVER}; database={DATABASE}; integrated security=true
            // Using the `Replace` method, we can change the template values for the real values.
            get => ConnectionURLTemplate
                .Replace("{DATABASE_SERVER}", DatabaseServer)
                .Replace("{DATABASE_NAME}", DatabaseName)
                .Replace("{DATABASE_SECURITY}", DatabaseSecurity);
        }

        // Connection URL template for SQL Server express
        private static readonly string ConnectionURLTemplate = "server={DATABASE_SERVER}; database={DATABASE_NAME}; integrated security={DATABASE_SECURITY}";
    }
}
