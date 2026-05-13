namespace QuanLyKhachSan.GUI
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            btnDangNhap = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            txtMatKhau = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtTaiKhoan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Orange;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Location = new Point(5, 322);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(293, 41);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 299);
            panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 234);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(57, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 2);
            panel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 203);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 21;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.WhiteSmoke;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Location = new Point(57, 234);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(208, 27);
            txtMatKhau.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Location = new Point(54, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 2);
            panel3.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 122);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 16;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.WhiteSmoke;
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Location = new Point(54, 153);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(208, 27);
            txtTaiKhoan.TabIndex = 15;
            // 
            // frm_dangnhap
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(305, 426);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangNhap);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frm_dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_dangnhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDangNhap;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Label label2;
        private TextBox txtMatKhau;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtTaiKhoan;
    }
}