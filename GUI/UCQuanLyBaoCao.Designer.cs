namespace QuanLyKhachSan.GUI
{
    partial class UCQuanLyBaoCao
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
            bsdt = new Button();
            bcdttheothang = new Button();
            button3 = new Button();
            cbxThang = new ComboBox();
            txtNam = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bsdt
            // 
            bsdt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            bsdt.Location = new Point(75, 241);
            bsdt.Name = "bsdt";
            bsdt.Size = new Size(188, 172);
            bsdt.TabIndex = 0;
            bsdt.Text = "Báo cáo tỷ lệ sử dụng phòng";
            bsdt.UseVisualStyleBackColor = true;
            // 
            // bcdttheothang
            // 
            bcdttheothang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bcdttheothang.Location = new Point(420, 241);
            bcdttheothang.Name = "bcdttheothang";
            bcdttheothang.Size = new Size(188, 172);
            bcdttheothang.TabIndex = 1;
            bcdttheothang.Text = "Báo cáo doanh thu theo tháng";
            bcdttheothang.UseVisualStyleBackColor = true;
            bcdttheothang.Click += bcdttheothang_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.Location = new Point(765, 241);
            button3.Name = "button3";
            button3.Size = new Size(188, 172);
            button3.TabIndex = 2;
            button3.Text = "Báo cáo hiệu suất sử dụng từng loại phòng";
            button3.UseVisualStyleBackColor = true;
            // 
            // cbxThang
            // 
            cbxThang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxThang.FormattingEnabled = true;
            cbxThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxThang.Location = new Point(437, 446);
            cbxThang.Name = "cbxThang";
            cbxThang.Size = new Size(151, 36);
            cbxThang.TabIndex = 3;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(437, 515);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(151, 34);
            txtNam.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 417);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 5;
            label1.Text = "Tháng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 484);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 6;
            label2.Text = "Năm:";
            // 
            // UCQuanLyBaoCao
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNam);
            Controls.Add(cbxThang);
            Controls.Add(button3);
            Controls.Add(bcdttheothang);
            Controls.Add(bsdt);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyBaoCao";
            Size = new Size(1034, 651);
            Load += UCQuanLyBaoCao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bsdt;
        private Button bcdttheothang;
        private Button button3;
        private ComboBox cbxThang;
        private TextBox txtNam;
        private Label label1;
        private Label label2;
    }
}
