using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace zhongyiCore.Models
{
    public class ConfigConnection
    {
        public static string GetSqlConnStr(string connsectionName)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();//创建ConfigurationBuilder对象
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();
            return configuration[connsectionName];
        }
    }
}
