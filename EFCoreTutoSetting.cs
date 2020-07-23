using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTuto
{
    public class EFCoreTutoSetting
    {
       
        public string ConnectionString { get; set; }
        public string PwdSqlAzure { get; set; }
        public string UserSqlAzure { get; set; }

        public string AccountName { get; set; }

        public string ApiKey { get; set; }
    }
}
