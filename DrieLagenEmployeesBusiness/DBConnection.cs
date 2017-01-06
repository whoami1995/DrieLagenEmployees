﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrieLagenEmployeesBusiness
{
    public static class DBConnection
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(localdb)\\v11.0";
            builder.InitialCatalog = "Employee_DOTNET";
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
