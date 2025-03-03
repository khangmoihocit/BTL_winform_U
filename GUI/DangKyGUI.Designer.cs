namespace GUI
{
    partial class DangKyGUI
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtTenTaiKhoan = new TextBox();
            label2 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtXacNhanMK = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnDangKy = new Button();
            errorProvider1 = new ErrorProvider(components);
            cboNhanVien = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._CITYPNG_COM_FREE_Round_Flat_Male_Portrait_Avatar_User_Icon_PNG___1500x1500;
            pictureBox1.Location = new Point(231, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.Location = new Point(40, 232);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Roboto", 12F);
            txtTenTaiKhoan.Location = new Point(231, 232);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(415, 32);
            txtTenTaiKhoan.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F);
            label2.Location = new Point(40, 287);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Roboto", 12F);
            txtMatKhau.Location = new Point(231, 287);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(415, 32);
            txtMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.Location = new Point(40, 348);
            label3.Name = "label3";
            label3.Size = new Size(182, 24);
            label3.TabIndex = 1;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Font = new Font("Roboto", 12F);
            txtXacNhanMK.Location = new Point(231, 348);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(415, 32);
            txtXacNhanMK.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F);
            label4.Location = new Point(40, 405);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Roboto", 12F);
            txtEmail.Location = new Point(231, 405);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(415, 32);
            txtEmail.TabIndex = 3;
            // 
            // btnDangKy
            // 
            btnDangKy.AutoSize = true;
            btnDangKy.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(300, 518);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 34);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(233, 466);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(413, 28);
            cboNhanVien.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 12F);
            label5.Location = new Point(40, 466);
            label5.Name = "label5";
            label5.Size = new Size(65, 24);
            label5.TabIndex = 1;
            label5.Text = "Bạn là";
            // 
            // DangKyGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 618);
            Controls.Add(cboNhanVien);
            Controls.Add(btnDangKy);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtXacNhanMK);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "DangKyGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            Load += DangKyGUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtTenTaiKhoan;
        private Label label2;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtXacNhanMK;
        private Label label4;
        private TextBox txtEmail;
        private Button btnDangKy;
        private ErrorProvider errorProvider1;
        private ComboBox cboNhanVien;
        private Label label5;
    }
}