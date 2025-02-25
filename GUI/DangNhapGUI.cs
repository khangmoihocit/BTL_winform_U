using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class DangNhapGUI : Form
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void lklQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhauGUI quenMatKhauGUI = new QuenMatKhauGUI();
            quenMatKhauGUI.ShowDialog();
        }

        private void lklDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyGUI dangKyGUI = new DangKyGUI();
            dangKyGUI.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "") MessageBox.Show("Vui lòng nhập tên tài khoản");
            else if (txtMatKhau.Text.Trim() == "") MessageBox.Show("Vui lòng nhập mật khẩu");
            else
            {
                List<TaiKhoanDTO> taiKhoanDTOs = taiKhoanBUS.findByTentaikhoanAndMatkhau(txtTaiKhoan.Text, txtMatKhau.Text);
                if(taiKhoanDTOs.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                    {
                        TrangChuGUI trangChuGUI = new TrangChuGUI();
                        trangChuGUI.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
