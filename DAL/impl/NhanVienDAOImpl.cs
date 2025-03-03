﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAO.impl
{
    public class NhanVienDAOImpl : INhanVienDAO
    {
        public List<NhanVienDTO> nhanVienDTOs()
        {
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
            string query = "select * from tblNhanVien";

            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            NhanVienDTO nhanVienDTO = new NhanVienDTO();
                            nhanVienDTO.MaNhanVien = int.Parse(dataReader["iMaNV"].ToString());
                            nhanVienDTO.HoTen = dataReader["sHoTen"].ToString();
                            nhanVienDTO.SoDienThoai = dataReader["sSoDienThoai"].ToString();
                            if (bool.Parse(dataReader["bGioiTinh"].ToString()) == true)
                            {
                                nhanVienDTO.GioiTinh = "nam";
                            }
                            else
                            {
                                nhanVienDTO.GioiTinh = "nữ";
                            }
                            nhanVienDTOs.Add(nhanVienDTO);
                        }
                    }
                }//cmd
                sqlConnection.Close();
            }

            return nhanVienDTOs;
        }
    }
}
