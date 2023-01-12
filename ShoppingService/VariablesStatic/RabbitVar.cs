using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingService.VariablesStatic
{
    public class RabbitVar
    {
        private readonly IConfiguration _configuration;
        public RabbitVar(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string HostName = "";
        public const string Port = "ElastiCacheInit";
        public const string UserName = "ElastiCacheInit";
        public const string PassWord = "ElastiCacheInit";
        public const string VirtualHost = "ElastiCacheInit";
    }
}
