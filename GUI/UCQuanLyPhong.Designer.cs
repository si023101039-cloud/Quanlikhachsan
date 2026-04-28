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
            textBox1 = new TextBox();
            label1 = new Label();
            btnHuy = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Location = new Point(343, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 105);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(138, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 2);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(137, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 8;
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(textBox2);
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
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(124, 274);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(195, 64);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(125, 204);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 64);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(126, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 36);
            comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(125, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 36);
            comboBox1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Location = new Point(126, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 2);
            panel2.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(125, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 3;
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
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
    }
}
