﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
    internal class connection
    {
        static string dbPath = @"C:\LOCALDB\EMS.mdb";
        public static string conString = $"Provider=Microsoft.ACE.OLEDB.12.0;DATA SOURCE={dbPath};";

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);
        }
        public static OleDbConnection con = mysqldb();
    }
}
