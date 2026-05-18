namespace QuanLyKhachSan.GUI
{
    partial class UCQuanLyDatPhong
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
            dgvPhieuDatPhong = new DataGridView();
            dgvCTPDP = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            cbphong = new ComboBox();
            btnlammoi = new Button();
            panel1 = new Panel();
            btnkiemtra = new Button();
            txtghichu = new RichTextBox();
            btncapnhattrangthai = new Button();
            cbtrangthai = new ComboBox();
            btntraphong = new Button();
            dtpngaynhan = new DateTimePicker();
            btndatphong = new Button();
            dtpngaytra = new DateTimePicker();
            dtpngaydat = new DateTimePicker();
            txtten = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lblkiemtra = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDatPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTPDP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuDatPhong
            // 
            dgvPhieuDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuDatPhong.Location = new Point(348, 43);
            dgvPhieuDatPhong.Name = "dgvPhieuDatPhong";
            dgvPhieuDatPhong.RowHeadersWidth = 51;
            dgvPhieuDatPhong.Size = new Size(680, 287);
            dgvPhieuDatPhong.TabIndex = 0;
            dgvPhieuDatPhong.CellClick += dgvPhieuDatPhong_CellClick;
            dgvPhieuDatPhong.CellContentClick += dgvPhieuDatPhong_CellContentClick_1;
            // 
            // dgvCTPDP
            // 
            dgvCTPDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPDP.Location = new Point(349, 379);
            dgvCTPDP.Name = "dgvCTPDP";
            dgvCTPDP.RowHeadersWidth = 51;
            dgvCTPDP.Size = new Size(680, 178);
            dgvCTPDP.TabIndex = 1;
            dgvCTPDP.CellClick += dgvCTPDP_CellClick;
            dgvCTPDP.CellContentClick += dgvCTPDP_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbphong);
            groupBox1.Controls.Add(btnlammoi);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnkiemtra);
            groupBox1.Controls.Add(txtghichu);
            groupBox1.Controls.Add(btncapnhattrangthai);
            groupBox1.Controls.Add(cbtrangthai);
            groupBox1.Controls.Add(btntraphong);
            groupBox1.Controls.Add(dtpngaynhan);
            groupBox1.Controls.Add(btndatphong);
            groupBox1.Controls.Add(dtpngaytra);
            groupBox1.Controls.Add(dtpngaydat);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 609);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu đặt phòng:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(6, 240);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 21;
            label9.Text = "Phòng:";
            // 
            // cbphong
            // 
            cbphong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbphong.FormattingEnabled = true;
            cbphong.Location = new Point(155, 240);
            cbphong.Name = "cbphong";
            cbphong.Size = new Size(177, 29);
            cbphong.TabIndex = 20;
            cbphong.SelectedIndexChanged += cbphong_SelectedIndexChanged;
            // 
            // btnlammoi
            // 
            btnlammoi.BackColor = Color.CornflowerBlue;
            btnlammoi.Cursor = Cursors.Hand;
            btnlammoi.FlatAppearance.BorderSize = 0;
            btnlammoi.FlatStyle = FlatStyle.Flat;
            btnlammoi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlammoi.Location = new Point(171, 359);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(159, 48);
            btnlammoi.TabIndex = 19;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = false;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(156, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 2);
            panel1.TabIndex = 18;
            // 
            // btnkiemtra
            // 
            btnkiemtra.BackColor = Color.CornflowerBlue;
            btnkiemtra.Cursor = Cursors.Hand;
            btnkiemtra.FlatAppearance.BorderSize = 0;
            btnkiemtra.FlatStyle = FlatStyle.Flat;
            btnkiemtra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkiemtra.Location = new Point(13, 467);
            btnkiemtra.Name = "btnkiemtra";
            btnkiemtra.Size = new Size(317, 48);
            btnkiemtra.TabIndex = 9;
            btnkiemtra.Text = "Kiểm tra tình trạng phòng";
            btnkiemtra.UseVisualStyleBackColor = false;
            btnkiemtra.Click += btnkiemtra_Click;
            // 
            // txtghichu
            // 
            txtghichu.BorderStyle = BorderStyle.None;
            txtghichu.Location = new Point(155, 282);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(177, 37);
            txtghichu.TabIndex = 17;
            txtghichu.Text = "";
            // 
            // btncapnhattrangthai
            // 
            btncapnhattrangthai.BackColor = Color.CornflowerBlue;
            btncapnhattrangthai.Cursor = Cursors.Hand;
            btncapnhattrangthai.FlatAppearance.BorderSize = 0;
            btncapnhattrangthai.FlatStyle = FlatStyle.Flat;
            btncapnhattrangthai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncapnhattrangthai.Location = new Point(13, 359);
            btncapnhattrangthai.Name = "btncapnhattrangthai";
            btncapnhattrangthai.Size = new Size(152, 48);
            btncapnhattrangthai.TabIndex = 8;
            btncapnhattrangthai.Text = "Cập nhật  phòng";
            btncapnhattrangthai.UseVisualStyleBackColor = false;
            btncapnhattrangthai.Click += button3_Click;
            // 
            // cbtrangthai
            // 
            cbtrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtrangthai.FormattingEnabled = true;
            cbtrangthai.Location = new Point(155, 198);
            cbtrangthai.Name = "cbtrangthai";
            cbtrangthai.Size = new Size(177, 29);
            cbtrangthai.TabIndex = 16;
            // 
            // btntraphong
            // 
            btntraphong.BackColor = Color.Red;
            btntraphong.Cursor = Cursors.Hand;
            btntraphong.FlatAppearance.BorderSize = 0;
            btntraphong.FlatStyle = FlatStyle.Flat;
            btntraphong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntraphong.Location = new Point(171, 413);
            btntraphong.Name = "btntraphong";
            btntraphong.Size = new Size(159, 48);
            btntraphong.TabIndex = 7;
            btntraphong.Text = "Trả phòng";
            btntraphong.UseVisualStyleBackColor = false;
            btntraphong.Click += button2_Click;
            // 
            // dtpngaynhan
            // 
            dtpngaynhan.CalendarForeColor = Color.WhiteSmoke;
            dtpngaynhan.CalendarMonthBackground = Color.WhiteSmoke;
            dtpngaynhan.Format = DateTimePickerFormat.Short;
            dtpngaynhan.Location = new Point(155, 117);
            dtpngaynhan.Name = "dtpngaynhan";
            dtpngaynhan.Size = new Size(177, 29);
            dtpngaynhan.TabIndex = 15;
            // 
            // btndatphong
            // 
            btndatphong.BackColor = Color.CornflowerBlue;
            btndatphong.Cursor = Cursors.Hand;
            btndatphong.FlatAppearance.BorderSize = 0;
            btndatphong.FlatStyle = FlatStyle.Flat;
            btndatphong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndatphong.Location = new Point(13, 413);
            btndatphong.Name = "btndatphong";
            btndatphong.Size = new Size(152, 48);
            btndatphong.TabIndex = 6;
            btndatphong.Text = "Đặt phòng";
            btndatphong.UseVisualStyleBackColor = false;
            btndatphong.Click += button1_Click;
            // 
            // dtpngaytra
            // 
            dtpngaytra.CalendarForeColor = Color.WhiteSmoke;
            dtpngaytra.CalendarMonthBackground = Color.WhiteSmoke;
            dtpngaytra.Format = DateTimePickerFormat.Short;
            dtpngaytra.Location = new Point(155, 157);
            dtpngaytra.Name = "dtpngaytra";
            dtpngaytra.Size = new Size(177, 29);
            dtpngaytra.TabIndex = 14;
            // 
            // dtpngaydat
            // 
            dtpngaydat.CalendarForeColor = Color.WhiteSmoke;
            dtpngaydat.CalendarMonthBackground = Color.WhiteSmoke;
            dtpngaydat.Format = DateTimePickerFormat.Short;
            dtpngaydat.Location = new Point(155, 78);
            dtpngaydat.Name = "dtpngaydat";
            dtpngaydat.Size = new Size(177, 29);
            dtpngaydat.TabIndex = 13;
            // 
            // txtten
            // 
            txtten.BackColor = Color.WhiteSmoke;
            txtten.BorderStyle = BorderStyle.FixedSingle;
            txtten.Location = new Point(155, 38);
            txtten.Name = "txtten";
            txtten.Size = new Size(177, 29);
            txtten.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(6, 291);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 11;
            label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(0, 196);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 10;
            label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(0, 157);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 9;
            label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(0, 118);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 8;
            label5.Text = "Ngày nhận:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 79);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 7;
            label4.Text = "Ngày đặt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 40);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 6;
            label3.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(665, 12);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 4;
            label1.Text = "Danh sách phiếu đặt phòng";
            // 
            // lblkiemtra
            // 
            lblkiemtra.AutoSize = true;
            lblkiemtra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblkiemtra.Location = new Point(680, 348);
            lblkiemtra.Name = "lblkiemtra";
            lblkiemtra.Size = new Size(187, 21);
            lblkiemtra.TabIndex = 5;
            lblkiemtra.Text = "Chi tiết phiếu đặt phòng";
            // 
            // UCQuanLyDatPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblkiemtra);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvCTPDP);
            Controls.Add(dgvPhieuDatPhong);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyDatPhong";
            Size = new Size(1034, 634);
            Load += UCQuanLyDatPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuDatPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCTPDP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhieuDatPhong;
        private DataGridView dgvCTPDP;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblkiemtra;
        private TextBox txtten;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox txtghichu;
        private ComboBox cbtrangthai;
        private DateTimePicker dtpngaynhan;
        private DateTimePicker dtpngaytra;
        private DateTimePicker dtpngaydat;
        private Button btndatphong;
        private Button btnkiemtra;
        private Button btncapnhattrangthai;
        private Button btntraphong;
        private Panel panel1;
        private Button btnlammoi;
        private Label label9;
        private ComboBox cbphong;
    }
}
