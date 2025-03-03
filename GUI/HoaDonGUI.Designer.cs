namespace GUI
{
    partial class HoaDonGUI
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
            checkbox_ngaylaphd = new CheckBox();
            btnXuatHoaDon = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            dtpNgayLapHD = new DateTimePicker();
            cboTrangThaiThanhToan = new ComboBox();
            txtHoaDonNam = new TextBox();
            txtHoaDonThang = new TextBox();
            txtTenKhachHang = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dgvHoaDon = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkbox_ngaylaphd);
            panel1.Controls.Add(btnXuatHoaDon);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(dtpNgayLapHD);
            panel1.Controls.Add(cboTrangThaiThanhToan);
            panel1.Controls.Add(txtHoaDonNam);
            panel1.Controls.Add(txtHoaDonThang);
            panel1.Controls.Add(txtTenKhachHang);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 274);
            panel1.TabIndex = 0;
            // 
            // checkbox_ngaylaphd
            // 
            checkbox_ngaylaphd.AutoSize = true;
            checkbox_ngaylaphd.Location = new Point(1069, 104);
            checkbox_ngaylaphd.Name = "checkbox_ngaylaphd";
            checkbox_ngaylaphd.Size = new Size(18, 17);
            checkbox_ngaylaphd.TabIndex = 5;
            checkbox_ngaylaphd.UseVisualStyleBackColor = true;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.AutoSize = true;
            btnXuatHoaDon.Location = new Point(1060, 217);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(161, 38);
            btnXuatHoaDon.TabIndex = 4;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.Location = new Point(888, 217);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 38);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Location = new Point(735, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 38);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.AutoSize = true;
            btnTimKiem.Location = new Point(582, 217);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 38);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtpNgayLapHD
            // 
            dtpNgayLapHD.CustomFormat = "dd/MM/yyyy";
            dtpNgayLapHD.Format = DateTimePickerFormat.Custom;
            dtpNgayLapHD.Location = new Point(1108, 93);
            dtpNgayLapHD.Name = "dtpNgayLapHD";
            dtpNgayLapHD.Size = new Size(185, 35);
            dtpNgayLapHD.TabIndex = 3;
            dtpNgayLapHD.Value = new DateTime(2025, 3, 1, 0, 0, 0, 0);
            // 
            // cboTrangThaiThanhToan
            // 
            cboTrangThaiThanhToan.FormattingEnabled = true;
            cboTrangThaiThanhToan.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán" });
            cboTrangThaiThanhToan.Location = new Point(1108, 31);
            cboTrangThaiThanhToan.Name = "cboTrangThaiThanhToan";
            cboTrangThaiThanhToan.Size = new Size(333, 36);
            cboTrangThaiThanhToan.TabIndex = 2;
            // 
            // txtHoaDonNam
            // 
            txtHoaDonNam.Location = new Point(433, 154);
            txtHoaDonNam.Name = "txtHoaDonNam";
            txtHoaDonNam.Size = new Size(333, 35);
            txtHoaDonNam.TabIndex = 1;
            // 
            // txtHoaDonThang
            // 
            txtHoaDonThang.Location = new Point(433, 93);
            txtHoaDonThang.Name = "txtHoaDonThang";
            txtHoaDonThang.Size = new Size(333, 35);
            txtHoaDonThang.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(433, 24);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(333, 35);
            txtTenKhachHang.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(834, 100);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 0;
            label5.Text = "Ngày lập hóa đơn";
            label5.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(834, 31);
            label4.Name = "label4";
            label4.Size = new Size(237, 28);
            label4.TabIndex = 0;
            label4.Text = "Trạng thái thanh toán";
            label4.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 154);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 0;
            label3.Text = "Hóa đơn năm";
            label3.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 93);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 0;
            label2.Text = "Hóa đơn tháng";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 31);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 621);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1575, 621);
            panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHoaDon);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1575, 621);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 31);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1569, 587);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // HoaDonGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 895);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Roboto", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "HoaDonGUI";
            Text = "HoaDonGUI";
            Load += HoaDonGUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtTenKhachHang;
        private Label label1;
        private DateTimePicker dtpNgayLapHD;
        private ComboBox cboTrangThaiThanhToan;
        private TextBox txtHoaDonNam;
        private TextBox txtHoaDonThang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnXuatHoaDon;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private CheckBox checkbox_ngaylaphd;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgvHoaDon;
    }
}