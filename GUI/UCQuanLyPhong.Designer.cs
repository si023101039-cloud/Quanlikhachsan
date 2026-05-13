namespace QuanLyKhachSan.GUI
{
    partial class UCQuanLyPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPhong = new DataGridView();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            txtfind = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            numtang = new NumericUpDown();
            label8 = new Label();
            rtxtGhiChu = new RichTextBox();
            rtxtMoTa = new RichTextBox();
            cboTrangThai = new ComboBox();
            cboLoaiPhong = new ComboBox();
            panel2 = new Panel();
            txtTenPhong = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numtang).BeginInit();
            SuspendLayout();
            // 
            // dgvPhong
            // 
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Location = new Point(343, 150);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.Size = new Size(680, 467);
            dgvPhong.TabIndex = 0;
            dgvPhong.CellClick += dgvPhong_CellClick;
            dgvPhong.CellContentClick += dgvPhong_CellContentClick;
            dgvPhong.Click += dgvPhong_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(txtfind);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Location = new Point(343, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 105);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(138, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 2);
            panel1.TabIndex = 9;
            // 
            // txtfind
            // 
            txtfind.BackColor = Color.WhiteSmoke;
            txtfind.BorderStyle = BorderStyle.None;
            txtfind.Location = new Point(137, 45);
            txtfind.Name = "txtfind";
            txtfind.Size = new Size(194, 27);
            txtfind.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 10;
            label1.Text = "Tên phòng:";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnHuy.Location = new Point(503, 30);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(132, 49);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.CornflowerBlue;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTimKiem.Location = new Point(346, 31);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(132, 49);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThem.Location = new Point(17, 470);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 49);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm phòng";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.CornflowerBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSua.Location = new Point(177, 470);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 49);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa phòng";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(99, 538);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 49);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa phòng";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numtang);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(rtxtGhiChu);
            groupBox2.Controls.Add(rtxtMoTa);
            groupBox2.Controls.Add(cboTrangThai);
            groupBox2.Controls.Add(cboLoaiPhong);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(txtTenPhong);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 612);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin phòng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // numtang
            // 
            numtang.Location = new Point(120, 365);
            numtang.Name = "numtang";
            numtang.Size = new Size(195, 34);
            numtang.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 370);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 16;
            label8.Text = "Tầng: ";
            // 
            // rtxtGhiChu
            // 
            rtxtGhiChu.BorderStyle = BorderStyle.None;
            rtxtGhiChu.Location = new Point(124, 274);
            rtxtGhiChu.Name = "rtxtGhiChu";
            rtxtGhiChu.Size = new Size(195, 64);
            rtxtGhiChu.TabIndex = 15;
            rtxtGhiChu.Text = "";
            // 
            // rtxtMoTa
            // 
            rtxtMoTa.BorderStyle = BorderStyle.None;
            rtxtMoTa.Location = new Point(125, 204);
            rtxtMoTa.Name = "rtxtMoTa";
            rtxtMoTa.Size = new Size(195, 64);
            rtxtMoTa.TabIndex = 14;
            rtxtMoTa.Text = "";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(126, 141);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(196, 36);
            cboTrangThai.TabIndex = 13;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(125, 92);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(196, 36);
            cboLoaiPhong.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(126, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 2);
            panel2.TabIndex = 4;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BackColor = Color.WhiteSmoke;
            txtTenPhong.BorderStyle = BorderStyle.None;
            txtTenPhong.Location = new Point(125, 47);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(194, 27);
            txtTenPhong.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 273);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 11;
            label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 207);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 10;
            label6.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 144);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 96);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 8;
            label4.Text = "Loại phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 48);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 7;
            label3.Text = "Tên phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(853, 113);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 7;
            label2.Text = "Danh sách phòng:";
            // 
            // UCQuanLyPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvPhong);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyPhong";
            Size = new Size(1034, 651);
            Load += UCQuanLyPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numtang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhong;
        private GroupBox groupBox1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private GroupBox groupBox2;
        private Button btnHuy;
        private Button btnTimKiem;
        private Label label2;
        private Panel panel2;
        private TextBox txtTenPhong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox rtxtMoTa;
        private ComboBox cboTrangThai;
        private ComboBox cboLoaiPhong;
        private RichTextBox rtxtGhiChu;
        private Panel panel1;
        private TextBox txtfind;
        private Label label1;
        private NumericUpDown numtang;
        private Label label8;
    }
}
