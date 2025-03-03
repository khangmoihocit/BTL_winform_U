using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private int _id;
        private string _tenKhachHang;
        private int _hdThang;
        private int _hdNam;
        private bool _trangThaiThanhToan;
        private DateTime _ngayLapHD;
        private double _tongThanhTien;
        private double _soNuocTieuThu;

        public HoaDonDTO() { }
        
        public HoaDonDTO(int id, string tenKhachHang, int hdThang, int hdNam, bool trangThaiThanhToan, DateTime ngayLapHD, double tongThanhTien, double soNuocTieuThu)
        {
            Id = id;
            TenKhachHang = tenKhachHang;
            HdThang = hdThang;
            HdNam = hdNam;
            TrangThaiThanhToan = trangThaiThanhToan;
            NgayLapHD = ngayLapHD;
            TongThanhTien = tongThanhTien;
            SoNuocTieuThu = soNuocTieuThu;
        }

        public int Id { get => _id; set => _id = value; }
        public string TenKhachHang { get => _tenKhachHang; set => _tenKhachHang = value; }
        public int HdThang { get => _hdThang; set => _hdThang = value; }
        public int HdNam { get => _hdNam; set => _hdNam = value; }
        public bool TrangThaiThanhToan { get => _trangThaiThanhToan; set => _trangThaiThanhToan = value; }
        public DateTime NgayLapHD { get => _ngayLapHD; set => _ngayLapHD = value; }
        public double TongThanhTien { get => _tongThanhTien; set => _tongThanhTien = value; }
        public double SoNuocTieuThu { get => _soNuocTieuThu; set => _soNuocTieuThu = value; }
    }
}
