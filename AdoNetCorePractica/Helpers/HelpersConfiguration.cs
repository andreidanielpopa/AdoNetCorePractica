using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdoNetCorePractica.Helpers
{
    public class HelpersConfiguration
    {
        public static string GetConnectionString()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("settings.json", false, true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("SqlTajamar");

            return connectionString;
        }
    }
}
