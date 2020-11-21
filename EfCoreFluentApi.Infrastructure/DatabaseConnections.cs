using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreFluentApi.Infrastructure
{
    public class DatabaseConnections
    {
        public static IConfiguration Config
        {
            get
            {
                IConfigurationRoot Configuration = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();

                return Configuration;
            }
        }

        public static string PostgresConfig
        {
            get
            {
                return Config.GetConnectionString("Postgres");
            }
        }

        public static string ByName(string name)
        {
            return Config?.GetConnectionString(name != null ? name : "");
        }


    }
}
