using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class TaiKhoanDAOImpl : ITaiKhoanDAO
    {
        public List<TaiKhoanDTO> taiKhoanDTOs(string query)
        {
            List<TaiKhoanDTO> taiKhoanDTOs = new List<TaiKhoanDTO>();
            try
            {
                using (SqlConnection sqlConnection = Connection.GetSqlConnection())
                {
                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.CommandType = CommandType.Text;
                        using (SqlDataReader dataReader = command.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                TaiKhoanDTO taiKhoanDTO = new TaiKhoanDTO(
                                      dataReader["sTenTaiKhoan"].ToString(), 
                                      dataReader["sMatKhau"].ToString(),
                                      dataReader["sEmail"].ToString());

                                taiKhoanDTOs.Add(taiKhoanDTO);
                            }
                        }
                    }//command
                    sqlConnection.Close();
                }//sqlConnection
            }//try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return taiKhoanDTOs;
        }

        public List<TaiKhoanDTO> findByTentaikhoanAndMatkhau(string tenTaiKhoan, string matKhau)
        {
            string query = $"select * from tblTaiKhoan where sTenTaiKhoan = N'{tenTaiKhoan}' and sMatKhau = N'{matKhau}'";
            return this.taiKhoanDTOs(query);
        }

        public List<TaiKhoanDTO> findByTentaikhoan(string tenTaiKhoan)
        {
            string query = $"select * from tblTaiKhoan where sTenTaiKhoan = N'{tenTaiKhoan}'";
            return this.taiKhoanDTOs(query);
        }

        public List<TaiKhoanDTO> findByEmail(string email)
        {
            string query = $"select * from tblTaiKhoan where sEmail = N'{email}'";
            return this.taiKhoanDTOs(query);
        }

        public void add(TaiKhoanDTO taiKhoanDTO)
        {
            string query = "spTaiKhoan_Insert";
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@sTenTaiKhoan", SqlDbType.NVarChar, 50)).Value = taiKhoanDTO.TenTaiKhoan;
                    command.Parameters.Add(new SqlParameter("@sMatKhau", SqlDbType.NVarChar, 50)).Value = taiKhoanDTO.MatKhau;
                    command.Parameters.Add(new SqlParameter("@sEmail", SqlDbType.NVarChar, 50)).Value = taiKhoanDTO.Email;

                    int n = command.ExecuteNonQuery();
                    if (n <= 0) throw new Exception("Lỗi, Không thể thêm tài khoản");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void update(TaiKhoanDTO t)
        {
            throw new NotImplementedException();
        }

        public void deleteById(TaiKhoanDTO t)
        {
            throw new NotImplementedException();
        }

        public TaiKhoanDTO findById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
