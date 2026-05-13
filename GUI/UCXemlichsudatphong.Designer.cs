namespace QuanLyKhachSan.GUI
{
    partial class UCXemlichsudatphong
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
            label1 = new Label();
            dgvLSDP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLSDP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "Lịch sử đặt phòng:";
            // 
            // dgvLSDP
            // 
            dgvLSDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLSDP.Location = new Point(22, 59);
            dgvLSDP.Name = "dgvLSDP";
            dgvLSDP.RowHeadersWidth = 51;
            dgvLSDP.Size = new Size(985, 561);
            dgvLSDP.TabIndex = 1;
            // 
            // UCXemlichsudatphong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvLSDP);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "UCXemlichsudatphong";
            Size = new Size(1034, 651);
            Load += UCXemlichsudatphong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLSDP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLSDP;
    }
}
