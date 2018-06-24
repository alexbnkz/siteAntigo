using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.alexbnkz.Base
{
    public class ConnectionString
    {
        public string MsSqlServer()
        {
            return "Data Source=.\\MSSQLSERVER2014;Integrated Security=False;User ID=user; Password=Bnkz*1234;Connect Timeout=15;Encrypt=False;Packet Size=4096";
        }
    }
}
