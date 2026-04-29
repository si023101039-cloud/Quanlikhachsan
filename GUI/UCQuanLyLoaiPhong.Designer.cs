namespace QuanLyKhachSan.GUI
{
    partial class UCQuanLyLoaiPhong
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
            label2 = new Label();
            rtxtMoTa = new RichTextBox();
            cbxLoaiPhong = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            numSoNguoi = new NumericUpDown();
            numGia = new NumericUpDown();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            dgvLoaiPhong = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoNguoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(774, 5);
            label2.Name = "label2";
            label2.Size = new Size(249, 28);
            label2.TabIndex = 11;
            label2.Text = "Danh sách các loại phòng:";
            // 
            // rtxtMoTa
            // 
            rtxtMoTa.BorderStyle = BorderStyle.None;
            rtxtMoTa.Location = new Point(124, 197);
            rtxtMoTa.Name = "rtxtMoTa";
            rtxtMoTa.Size = new Size(195, 64);
            rtxtMoTa.TabIndex = 14;
            rtxtMoTa.Text = "";
            // 
            // cbxLoaiPhong
            // 
            cbxLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxLoaiPhong.FormattingEnabled = true;
            cbxLoaiPhong.Location = new Point(125, 42);
            cbxLoaiPhong.Name = "cbxLoaiPhong";
            cbxLoaiPhong.Size = new Size(196, 36);
            cbxLoaiPhong.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 141);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 11;
            label7.Text = "Số người:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 200);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 10;
            label6.Text = "Mô tả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 94);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 9;
            label5.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 46);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 8;
            label4.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numSoNguoi);
            groupBox2.Controls.Add(numGia);
            groupBox2.Controls.Add(rtxtMoTa);
            groupBox2.Controls.Add(cbxLoaiPhong);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 612);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin loại phòng";
            // 
            // numSoNguoi
            // 
            numSoNguoi.Location = new Point(124, 142);
            numSoNguoi.Name = "numSoNguoi";
            numSoNguoi.Size = new Size(196, 34);
            numSoNguoi.TabIndex = 16;
            // 
            // numGia
            // 
            numGia.Location = new Point(125, 92);
            numGia.Name = "numGia";
            numGia.Size = new Size(196, 34);
            numGia.TabIndex = 15;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(102, 537);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 49);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
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
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.CornflowerBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSua.Location = new Point(179, 470);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 49);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(343, 36);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.Size = new Size(680, 581);
            dgvLoaiPhong.TabIndex = 8;
            // 
            // UCQuanLyLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(dgvLoaiPhong);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyLoaiPhong";
            Size = new Size(1034, 651);
            Load += UCQuanLyLoaiPhong_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoNguoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RichTextBox rtxtMoTa;
        private ComboBox cbxLoaiPhong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvLoaiPhong;
        private NumericUpDown numSoNguoi;
        private NumericUpDown numGia;
    }
}
