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
using exception;

namespace GUI
{
    public partial class HoaDonGUI : Form
    {
        private HoaDonBUS hoaDonBUS;
        public HoaDonGUI()
        {
            InitializeComponent();
            hoaDonBUS = new HoaDonBUS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void HoaDonGUI_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDonBUS.HoaDons();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvHoaDon.SelectedRows[0];

                    if (selectedRow.Cells[0].Value != null)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                        DialogResult re = MessageBox.Show("Bạn có muốn xóa hóa đơn có mã là: " + id,
                                                          "Thông báo",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                        if (re == DialogResult.Yes)
                        {
                            hoaDonBUS.deleteById(id);
                            HoaDonGUI_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn không hợp lệ hoặc dữ liệu trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi: Không thể chuyển đổi ID, dữ liệu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(DatabaseException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
