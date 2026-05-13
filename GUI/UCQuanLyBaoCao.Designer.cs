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
            button1 = new Button();
            button2 = new Button();
            btnbaocaohieusuat = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(75, 241);
            button1.Name = "button1";
            button1.Size = new Size(188, 172);
            button1.TabIndex = 0;
            button1.Text = "Báo cáo tỷ lệ sử dụng phòng";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(420, 241);
            button2.Name = "button2";
            button2.Size = new Size(188, 172);
            button2.TabIndex = 1;
            button2.Text = "Báo cáo doanh thu theo tháng";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnbaocaohieusuat
            // 
            btnbaocaohieusuat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnbaocaohieusuat.Location = new Point(765, 241);
            btnbaocaohieusuat.Name = "btnbaocaohieusuat";
            btnbaocaohieusuat.Size = new Size(188, 172);
            btnbaocaohieusuat.TabIndex = 2;
            btnbaocaohieusuat.Text = "Báo cáo hiệu suất sử dụng từng loại phòng";
            btnbaocaohieusuat.UseVisualStyleBackColor = true;
            btnbaocaohieusuat.Click += btnbaocaohieusuat_Click;
            // 
            // UCQuanLyBaoCao
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnbaocaohieusuat);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyBaoCao";
            Size = new Size(1034, 651);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnbaocaohieusuat;
    }
}
