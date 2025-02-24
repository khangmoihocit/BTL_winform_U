using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class Connection
    {
        //private static string connectionString = ConfigurationManager.ConnectionStrings["admin"].ConnectionString;
        private static string connectionString = "Data Source=KHANG\\SQLEXPRESS02;Initial Catalog=QuanLyThuPhiCapNuocSach;Integrated Security = True; Trust Server Certificate=True";

        public static SqlConnection GetSqlConnection() => new SqlConnection(connectionString);
    }
}
