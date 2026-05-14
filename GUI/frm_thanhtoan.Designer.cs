namespace QuanLyKhachSan.GUI
{
    partial class frm_thanhtoan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnThanhToan = new Button();
            btnXuatHoaDon = new Button();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.LawnGreen;
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnThanhToan.Location = new Point(12, 340);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(203, 49);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Xác nhận thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.BackColor = Color.DodgerBlue;
            btnXuatHoaDon.Cursor = Cursors.Hand;
            btnXuatHoaDon.FlatAppearance.BorderSize = 0;
            btnXuatHoaDon.FlatStyle = FlatStyle.Flat;
            btnXuatHoaDon.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnXuatHoaDon.ForeColor = Color.White;
            btnXuatHoaDon.Location = new Point(232, 340);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(190, 49);
            btnXuatHoaDon.TabIndex = 2;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(440, 340);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(190, 49);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 14;
            label1.Text = "Nhân viên thanh toán:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 13;
            label2.Text = "Ngày thanh toán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 12;
            label3.Text = "Tổng tiền đặt phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 11;
            label4.Text = "Tổng tiền dịch vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 202);
            label5.Name = "label5";
            label5.Size = new Size(182, 28);
            label5.TabIndex = 10;
            label5.Text = "Tổng tiền phụ phí:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            label6.Location = new Point(12, 261);
            label6.Name = "label6";
            label6.Size = new Size(222, 50);
            label6.TabIndex = 9;
            label6.Text = "Thanh toán:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 34);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(240, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 57);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 34);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(373, 34);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(244, 111);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(373, 34);
            textBox5.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(373, 34);
            dateTimePicker1.TabIndex = 3;
            // 
            // frm_thanhtoan
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(656, 415);
            Controls.Add(btnXuatHoaDon);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThanhToan);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frm_thanhtoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh toán hóa đơn";
            Load += frm_thanhtoan_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThanhToan;
        private Button btnXuatHoaDon; 
        private Button btnHuy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
    }
}