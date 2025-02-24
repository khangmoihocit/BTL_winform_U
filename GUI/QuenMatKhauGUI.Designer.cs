namespace GUI
{
    partial class QuenMatKhauGUI
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtEmailDK = new TextBox();
            label2 = new Label();
            btnLayLaiMK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(116, 251);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 1;
            label1.Text = "Email đăng kí:";
            // 
            // txtEmailDK
            // 
            txtEmailDK.Location = new Point(257, 243);
            txtEmailDK.Name = "txtEmailDK";
            txtEmailDK.Size = new Size(306, 32);
            txtEmailDK.TabIndex = 0;
            txtEmailDK.TextChanged += txtEmailDK_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(116, 315);
            label2.Name = "label2";
            label2.Size = new Size(89, 24);
            label2.TabIndex = 1;
            label2.Text = "Kết quả: ";
            // 
            // btnLayLaiMK
            // 
            btnLayLaiMK.AutoSize = true;
            btnLayLaiMK.BackColor = SystemColors.Highlight;
            btnLayLaiMK.Font = new Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLayLaiMK.ForeColor = Color.White;
            btnLayLaiMK.Location = new Point(257, 434);
            btnLayLaiMK.Name = "btnLayLaiMK";
            btnLayLaiMK.Size = new Size(178, 37);
            btnLayLaiMK.TabIndex = 1;
            btnLayLaiMK.Text = "Lấy lại mật khẩu";
            btnLayLaiMK.UseVisualStyleBackColor = false;
            btnLayLaiMK.Click += btnLayLaiMK_Click;
            // 
            // QuenMatKhauGUI
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 618);
            Controls.Add(btnLayLaiMK);
            Controls.Add(label2);
            Controls.Add(txtEmailDK);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "QuenMatKhauGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtEmailDK;
        private Label label2;
        private Button btnLayLaiMK;
    }
}