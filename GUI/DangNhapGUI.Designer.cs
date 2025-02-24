namespace GUI
{
    partial class DangNhapGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapGUI));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtTaiKhoan = new TextBox();
            pictureBox3 = new PictureBox();
            txtMatKhau = new TextBox();
            lklQuenMatKhau = new LinkLabel();
            lklDangKy = new LinkLabel();
            btnDangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.hello_2488_256;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // txtTaiKhoan
            // 
            resources.ApplyResources(txtTaiKhoan, "txtTaiKhoan");
            txtTaiKhoan.Name = "txtTaiKhoan";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngegg__1_;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // txtMatKhau
            // 
            resources.ApplyResources(txtMatKhau, "txtMatKhau");
            txtMatKhau.Name = "txtMatKhau";
            // 
            // lklQuenMatKhau
            // 
            resources.ApplyResources(lklQuenMatKhau, "lklQuenMatKhau");
            lklQuenMatKhau.BackColor = Color.White;
            lklQuenMatKhau.Name = "lklQuenMatKhau";
            lklQuenMatKhau.TabStop = true;
            lklQuenMatKhau.LinkClicked += lklQuenMatKhau_LinkClicked;
            // 
            // lklDangKy
            // 
            resources.ApplyResources(lklDangKy, "lklDangKy");
            lklDangKy.BackColor = Color.White;
            lklDangKy.Name = "lklDangKy";
            lklDangKy.TabStop = true;
            lklDangKy.LinkClicked += lklDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            resources.ApplyResources(btnDangNhap, "btnDangNhap");
            btnDangNhap.BackColor = Color.FromArgb(226, 255, 255);
            btnDangNhap.ForeColor = Color.FromArgb(64, 0, 0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // DangNhapGUI
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 255, 255);
            Controls.Add(btnDangNhap);
            Controls.Add(lklDangKy);
            Controls.Add(lklQuenMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(pictureBox3);
            Controls.Add(txtTaiKhoan);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DangNhapGUI";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtTaiKhoan;
        private PictureBox pictureBox3;
        private TextBox txtMatKhau;
        private LinkLabel lklQuenMatKhau;
        private LinkLabel lklDangKy;
        private Button btnDangNhap;
    }
}