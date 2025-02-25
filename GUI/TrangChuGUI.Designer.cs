namespace GUI
{
    partial class TrangChuGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnThongkeVaBaocao = new Button();
            btnHoaDon = new Button();
            btnQuanLySuDungNuoc = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            btnTongQuan = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblHeader = new Label();
            panel_Body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(btnThongkeVaBaocao);
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnQuanLySuDungNuoc);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(btnTongQuan);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 1033);
            panel1.TabIndex = 2;
            // 
            // btnThongkeVaBaocao
            // 
            btnThongkeVaBaocao.Dock = DockStyle.Top;
            btnThongkeVaBaocao.Location = new Point(0, 439);
            btnThongkeVaBaocao.Name = "btnThongkeVaBaocao";
            btnThongkeVaBaocao.Size = new Size(309, 75);
            btnThongkeVaBaocao.TabIndex = 12;
            btnThongkeVaBaocao.Text = "Thống kế và báo cáo";
            btnThongkeVaBaocao.UseVisualStyleBackColor = true;
            btnThongkeVaBaocao.Click += btnThongkeVaBaocao_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.Location = new Point(0, 374);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(309, 65);
            btnHoaDon.TabIndex = 11;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnQuanLySuDungNuoc
            // 
            btnQuanLySuDungNuoc.Dock = DockStyle.Top;
            btnQuanLySuDungNuoc.Location = new Point(0, 304);
            btnQuanLySuDungNuoc.Name = "btnQuanLySuDungNuoc";
            btnQuanLySuDungNuoc.Size = new Size(309, 70);
            btnQuanLySuDungNuoc.TabIndex = 10;
            btnQuanLySuDungNuoc.Text = "Quản lý sử dụng nước";
            btnQuanLySuDungNuoc.UseVisualStyleBackColor = true;
            btnQuanLySuDungNuoc.Click += btnQuanLySuDungNuoc_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.Location = new Point(0, 235);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(309, 69);
            btnKhachHang.TabIndex = 9;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.Location = new Point(0, 165);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(309, 70);
            btnNhanVien.TabIndex = 8;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.Location = new Point(0, 91);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Size = new Size(309, 74);
            btnTongQuan.TabIndex = 7;
            btnTongQuan.Text = "Tổng quan";
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.Location = new Point(0, 956);
            button6.Name = "button6";
            button6.Size = new Size(309, 77);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblHeader);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(309, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1593, 91);
            panel2.TabIndex = 3;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Roboto", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Blue;
            lblHeader.Location = new Point(685, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(142, 34);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Trang chủ";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_Body
            // 
            panel_Body.BackColor = Color.SteelBlue;
            panel_Body.Dock = DockStyle.Fill;
            panel_Body.Location = new Point(309, 91);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(1593, 942);
            panel_Body.TabIndex = 4;
            // 
            // TrangChuGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel_Body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "TrangChuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản ly thu phí cấp nước sạch";
            WindowState = FormWindowState.Maximized;
            Load += TrangChuGUI_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel_Body;
        private Button button6;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button btnTongQuan;
        private Button btnThongkeVaBaocao;
        private Button btnHoaDon;
        private Button btnQuanLySuDungNuoc;
        private Label lblHeader;
    }
}