using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using exception;
using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class HoaDonDAOImpl : IHoaDonDAO
    {
        public DataTable HoaDons()
        {
            //List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            DataTable dataTable = new DataTable();
            string query = "select * from vHoaDon";
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void deleteById(int id)
        {
            string query = "spHoaDon_Delete";
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.Add(new SqlParameter("@iMaHD", SqlDbType.Int)).Value = id;
                        int n = sqlCommand.ExecuteNonQuery();
                        if (n < 0) throw new DatabaseException("Lỗi! Chưa xóa được");
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {

            }
        }


    }
}
