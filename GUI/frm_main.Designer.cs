namespace QuanLyKhachSan
{
    partial class frm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnQuanLyBaoCao = new Button();
            btnQuanLyLoaiPhong = new Button();
            btnQuanLyDatPhong = new Button();
            btnQuanLyDichVu = new Button();
            btnQuanLyPhong = new Button();
            panel3 = new Panel();
            lblpage = new Label();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 102);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1145, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(944, 19);
            button1.Name = "button1";
            button1.Size = new Size(183, 61);
            button1.TabIndex = 1;
            button1.Text = "    Trần Văn A";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnQuanLyLoaiPhong);
            panel2.Controls.Add(btnQuanLyBaoCao);
            panel2.Controls.Add(btnQuanLyDatPhong);
            panel2.Controls.Add(btnQuanLyDichVu);
            panel2.Controls.Add(btnQuanLyPhong);
            panel2.Location = new Point(-1, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 651);
            panel2.TabIndex = 1;
            // 
            // btnQuanLyBaoCao
            // 
            btnQuanLyBaoCao.BackColor = Color.Orange;
            btnQuanLyBaoCao.Cursor = Cursors.Hand;
            btnQuanLyBaoCao.FlatAppearance.BorderSize = 0;
            btnQuanLyBaoCao.FlatStyle = FlatStyle.Flat;
            btnQuanLyBaoCao.Image = (Image)resources.GetObject("btnQuanLyBaoCao.Image");
            btnQuanLyBaoCao.Location = new Point(3, 381);
            btnQuanLyBaoCao.Name = "btnQuanLyBaoCao";
            btnQuanLyBaoCao.Size = new Size(182, 72);
            btnQuanLyBaoCao.TabIndex = 7;
            btnQuanLyBaoCao.Text = "Quản lý báo cáo";
            btnQuanLyBaoCao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLyBaoCao.UseVisualStyleBackColor = false;
            btnQuanLyBaoCao.Click += btnQuanLyBaoCao_Click;
            // 
            // btnQuanLyLoaiPhong
            // 
            btnQuanLyLoaiPhong.BackColor = Color.Orange;
            btnQuanLyLoaiPhong.Cursor = Cursors.Hand;
            btnQuanLyLoaiPhong.FlatAppearance.BorderSize = 0;
            btnQuanLyLoaiPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyLoaiPhong.Image = (Image)resources.GetObject("btnQuanLyLoaiPhong.Image");
            btnQuanLyLoaiPhong.Location = new Point(3, 105);
            btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
            btnQuanLyLoaiPhong.Size = new Size(182, 72);
            btnQuanLyLoaiPhong.TabIndex = 6;
            btnQuanLyLoaiPhong.Text = "Quản lý loại phòng";
            btnQuanLyLoaiPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLyLoaiPhong.UseVisualStyleBackColor = false;
            btnQuanLyLoaiPhong.Click += btnQuanLyLoaiPhong_Click;
            // 
            // btnQuanLyDatPhong
            // 
            btnQuanLyDatPhong.BackColor = Color.Orange;
            btnQuanLyDatPhong.Cursor = Cursors.Hand;
            btnQuanLyDatPhong.FlatAppearance.BorderSize = 0;
            btnQuanLyDatPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyDatPhong.Image = (Image)resources.GetObject("btnQuanLyDatPhong.Image");
            btnQuanLyDatPhong.Location = new Point(3, 197);
            btnQuanLyDatPhong.Name = "btnQuanLyDatPhong";
            btnQuanLyDatPhong.Size = new Size(182, 72);
            btnQuanLyDatPhong.TabIndex = 5;
            btnQuanLyDatPhong.Text = "Quản lý đặt phòng";
            btnQuanLyDatPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLyDatPhong.UseVisualStyleBackColor = false;
            btnQuanLyDatPhong.Click += btnQuanLyDatPhong_Click;
            // 
            // btnQuanLyDichVu
            // 
            btnQuanLyDichVu.BackColor = Color.Orange;
            btnQuanLyDichVu.Cursor = Cursors.Hand;
            btnQuanLyDichVu.FlatAppearance.BorderSize = 0;
            btnQuanLyDichVu.FlatStyle = FlatStyle.Flat;
            btnQuanLyDichVu.Image = (Image)resources.GetObject("btnQuanLyDichVu.Image");
            btnQuanLyDichVu.Location = new Point(3, 289);
            btnQuanLyDichVu.Name = "btnQuanLyDichVu";
            btnQuanLyDichVu.Size = new Size(182, 72);
            btnQuanLyDichVu.TabIndex = 4;
            btnQuanLyDichVu.Text = "Quản dịch vụ";
            btnQuanLyDichVu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLyDichVu.UseVisualStyleBackColor = false;
            btnQuanLyDichVu.Click += btnQuanLyDichVu_Click;
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.BackColor = Color.Orange;
            btnQuanLyPhong.Cursor = Cursors.Hand;
            btnQuanLyPhong.FlatAppearance.BorderSize = 0;
            btnQuanLyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhong.Image = (Image)resources.GetObject("btnQuanLyPhong.Image");
            btnQuanLyPhong.Location = new Point(3, 13);
            btnQuanLyPhong.Name = "btnQuanLyPhong";
            btnQuanLyPhong.Size = new Size(182, 72);
            btnQuanLyPhong.TabIndex = 3;
            btnQuanLyPhong.Text = "Quản lý phòng";
            btnQuanLyPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLyPhong.UseVisualStyleBackColor = false;
            btnQuanLyPhong.Click += btnQuanLyPhong_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblpage);
            panel3.Location = new Point(-1, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(1225, 40);
            panel3.TabIndex = 2;
            // 
            // lblpage
            // 
            lblpage.AutoSize = true;
            lblpage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpage.Location = new Point(4, 4);
            lblpage.Name = "lblpage";
            lblpage.Size = new Size(105, 28);
            lblpage.TabIndex = 0;
            lblpage.Text = "Trang chủ";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.WhiteSmoke;
            pnlMain.Location = new Point(186, 140);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1034, 651);
            pnlMain.TabIndex = 3;
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1224, 784);
            Controls.Add(pnlMain);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frm_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý khách sạn";
            Load += frm_main_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel pnlMain;
        private Button btnQuanLyBaoCao;
        private Button btnQuanLyLoaiPhong;
        private Button btnQuanLyDatPhong;
        private Button btnQuanLyDichVu;
        private Button btnQuanLyPhong;
        private Label lblpage;
    }
}
