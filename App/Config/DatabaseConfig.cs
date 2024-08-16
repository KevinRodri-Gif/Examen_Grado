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
            get => $"server={DatabaseServer}; database={DatabaseName}; integrated security={DatabaseSecurity}";
        }
    }
}
