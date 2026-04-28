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
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
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
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 599);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu đặt phòng:";
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
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(155, 240);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(177, 72);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(33, 551);
            button3.Name = "button3";
            button3.Size = new Size(273, 48);
            button3.TabIndex = 8;
            button3.Text = "Cập nhật trạng thái phòng";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 36);
            comboBox1.TabIndex = 16;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(171, 413);
            button2.Name = "button2";
            button2.Size = new Size(152, 48);
            button2.TabIndex = 7;
            button2.Text = "Trả phòng";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker3.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(155, 117);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(177, 34);
            dateTimePicker3.TabIndex = 15;
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
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker2.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(155, 157);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(177, 34);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarMonthBackground = Color.WhiteSmoke;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(155, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 34);
            dateTimePicker1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(155, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(0, 235);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 11;
            label8.Text = "Ghi chú:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(0, 196);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 10;
            label7.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(0, 157);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 9;
            label6.Text = "Ngày trả:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(0, 118);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 8;
            label5.Text = "Ngày nhận:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 79);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 7;
            label4.Text = "Ngày đặt:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 40);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 6;
            label3.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(769, 12);
            label1.Name = "label1";
            label1.Size = new Size(265, 28);
            label1.TabIndex = 4;
            label1.Text = "Danh sách phiếu đặt phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(799, 348);
            label2.Name = "label2";
            label2.Size = new Size(236, 28);
            label2.TabIndex = 5;
            label2.Text = "Chi tiết phiếu đặt phòng";
            // 
            // UCQuanLyDatPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
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
            Size = new Size(1034, 651);
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
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
    }
}
