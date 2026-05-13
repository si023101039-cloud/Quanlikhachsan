namespace QuanLyKhachSan.GUI
{
    partial class UCQuanLyDichVu
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
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label1 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            btnXoa = new Button();
            btnThem = new Button();
            btnSua = new Button();
            dgvLoaiPhong = new DataGridView();
            btnThanhToan = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
           
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(806, 5);
            label2.Name = "label2";
            label2.Size = new Size(225, 28);
            label2.TabIndex = 14;
            label2.Text = "Chi tiết dịch vụ đã thuê";
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 36);
            comboBox1.TabIndex = 12;
            
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 165);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 11;
            label7.Text = "Số lượng:";
            
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 222);
            label6.Name = "label6";
            label6.Size = new Size(157, 28);
            label6.TabIndex = 10;
            label6.Text = "Thời điểm thuê:";
            
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 122);
            label5.Name = "label5";
            label5.Size = new Size(46, 28);
            label5.TabIndex = 9;
            label5.Text = "Giá:";
           
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 32);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 8;
            label4.Text = "Tên dịch vụ:";
            
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Location = new Point(6, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 612);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin loại phòng";
            
            dateTimePicker2.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker2.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(163, 218);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(162, 34);
            dateTimePicker2.TabIndex = 19;
           
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(162, 70);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 36);
            comboBox2.TabIndex = 18;
            
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 74);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 17;
            label1.Text = "Tên phòng:";
            
            numericUpDown2.Location = new Point(162, 166);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(163, 34);
            numericUpDown2.TabIndex = 16;
            
            numericUpDown1.Location = new Point(163, 116);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(163, 34);
            numericUpDown1.TabIndex = 15;
           
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnXoa.Location = new Point(93, 478);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 49);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            
            btnThem.BackColor = Color.CornflowerBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThem.Location = new Point(6, 409);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 49);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            
            btnSua.BackColor = Color.CornflowerBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSua.Location = new Point(168, 409);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 49);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
           
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Location = new Point(346, 36);
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.Size = new Size(680, 362);
            dgvLoaiPhong.TabIndex = 12;
            
            btnThanhToan.BackColor = Color.Lime;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.Black;
            btnThanhToan.Location = new Point(884, 422);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(142, 49);
            btnThanhToan.TabIndex = 17;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnThanhToan);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(dgvLoaiPhong);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyDichVu";
            Size = new Size(1034, 651);
            Load += UCQuanLyDichVu_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button btnXoa;
        private Button btnThem;
        private Button btnSua;
        private DataGridView dgvLoaiPhong;
        private Button btnThanhToan;
        private ComboBox comboBox2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
    }
}