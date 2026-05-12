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
            panel1 = new Panel();
            button4 = new Button();
            richghichu = new RichTextBox();
            btcapnhat = new Button();
            cbtrangthai = new ComboBox();
            bttraphong = new Button();
            datengaynhan = new DateTimePicker();
            button1 = new Button();
            datengaytra = new DateTimePicker();
            datengaydat = new DateTimePicker();
            txtKH = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
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
            dgvPhieuDatPhong.CellContentClick += dgvPhieuDatPhong_CellContentClick;
            // 
            // dgvCTPDP
            // 
            dgvCTPDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPDP.Location = new Point(349, 379);
            dgvCTPDP.Name = "dgvCTPDP";
            dgvCTPDP.RowHeadersWidth = 51;
            dgvCTPDP.Size = new Size(680, 178);
            dgvCTPDP.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(richghichu);
            groupBox1.Controls.Add(btcapnhat);
            groupBox1.Controls.Add(cbtrangthai);
            groupBox1.Controls.Add(bttraphong);
            groupBox1.Controls.Add(datengaynhan);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(datengaytra);
            groupBox1.Controls.Add(datengaydat);
            groupBox1.Controls.Add(txtKH);
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
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(156, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 2);
            panel1.TabIndex = 18;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 482);
            button4.Name = "button4";
            button4.Size = new Size(273, 48);
            button4.TabIndex = 9;
            button4.Text = "Kiểm tra tình trạng phòng";
            button4.UseVisualStyleBackColor = false;
            // 
            // richghichu
            // 
            richghichu.BorderStyle = BorderStyle.None;
            richghichu.Location = new Point(155, 240);
            richghichu.Name = "richghichu";
            richghichu.Size = new Size(177, 72);
            richghichu.TabIndex = 17;
            richghichu.Text = "";
            // 
            // btcapnhat
            // 
            btcapnhat.BackColor = Color.CornflowerBlue;
            btcapnhat.Cursor = Cursors.Hand;
            btcapnhat.FlatAppearance.BorderSize = 0;
            btcapnhat.FlatStyle = FlatStyle.Flat;
            btcapnhat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btcapnhat.Location = new Point(33, 331);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(273, 48);
            btcapnhat.TabIndex = 8;
            btcapnhat.Text = "Cập nhật trạng thái phòng";
            btcapnhat.UseVisualStyleBackColor = false;
            btcapnhat.Click += btcapnhat_Click;
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
            // bttraphong
            // 
            bttraphong.BackColor = Color.Red;
            bttraphong.Cursor = Cursors.Hand;
            bttraphong.FlatAppearance.BorderSize = 0;
            bttraphong.FlatStyle = FlatStyle.Flat;
            bttraphong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttraphong.Location = new Point(171, 413);
            bttraphong.Name = "bttraphong";
            bttraphong.Size = new Size(152, 48);
            bttraphong.TabIndex = 7;
            bttraphong.Text = "Trả phòng";
            bttraphong.UseVisualStyleBackColor = false;
            bttraphong.Click += bttraphong_Click;
            // 
            // datengaynhan
            // 
            datengaynhan.CalendarForeColor = Color.WhiteSmoke;
            datengaynhan.CalendarMonthBackground = Color.WhiteSmoke;
            datengaynhan.Format = DateTimePickerFormat.Short;
            datengaynhan.Location = new Point(155, 117);
            datengaynhan.Name = "datengaynhan";
            datengaynhan.Size = new Size(177, 29);
            datengaynhan.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 413);
            button1.Name = "button1";
            button1.Size = new Size(152, 48);
            button1.TabIndex = 6;
            button1.Text = "Đặt phòng";
            button1.UseVisualStyleBackColor = false;
            // 
            // datengaytra
            // 
            datengaytra.CalendarForeColor = Color.WhiteSmoke;
            datengaytra.CalendarMonthBackground = Color.WhiteSmoke;
            datengaytra.Format = DateTimePickerFormat.Short;
            datengaytra.Location = new Point(155, 157);
            datengaytra.Name = "datengaytra";
            datengaytra.Size = new Size(177, 29);
            datengaytra.TabIndex = 14;
            // 
            // datengaydat
            // 
            datengaydat.CalendarForeColor = Color.WhiteSmoke;
            datengaydat.CalendarMonthBackground = Color.WhiteSmoke;
            datengaydat.Format = DateTimePickerFormat.Short;
            datengaydat.Location = new Point(155, 78);
            datengaydat.Name = "datengaydat";
            datengaydat.Size = new Size(177, 29);
            datengaydat.TabIndex = 13;
            // 
            // txtKH
            // 
            txtKH.BackColor = Color.WhiteSmoke;
            txtKH.BorderStyle = BorderStyle.None;
            txtKH.Location = new Point(155, 38);
            txtKH.Name = "txtKH";
            txtKH.Size = new Size(177, 22);
            txtKH.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(0, 235);
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
            label1.Location = new Point(769, 12);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 4;
            label1.Text = "Danh sách phiếu đặt phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(799, 348);
            label2.Name = "label2";
            label2.Size = new Size(187, 21);
            label2.TabIndex = 5;
            label2.Text = "Chi tiết phiếu đặt phòng";
            // 
            // UCQuanLyDatPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label2);
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
        private Label label2;
        private TextBox txtKH;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox richghichu;
        private ComboBox cbtrangthai;
        private DateTimePicker datengaynhan;
        private DateTimePicker datengaytra;
        private DateTimePicker datengaydat;
        private Button button1;
        private Button button4;
        private Button btcapnhat;
        private Button bttraphong;
        private Panel panel1;
    }
}
