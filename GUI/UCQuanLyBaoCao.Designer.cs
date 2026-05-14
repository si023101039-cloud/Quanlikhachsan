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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnbaocaotyle = new Button();
            btnbaocaodoanhthu = new Button();
            btnbaocaohieusuat = new Button();
            chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartBaoCao).BeginInit();
            SuspendLayout();
            // 
            // btnbaocaotyle
            // 
            btnbaocaotyle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnbaocaotyle.Location = new Point(39, 3);
            btnbaocaotyle.Name = "btnbaocaotyle";
            btnbaocaotyle.Size = new Size(188, 172);
            btnbaocaotyle.TabIndex = 0;
            btnbaocaotyle.Text = "Báo cáo tỷ lệ sử dụng phòng";
            btnbaocaotyle.UseVisualStyleBackColor = true;
            btnbaocaotyle.Click += button1_Click;
            // 
            // btnbaocaodoanhthu
            // 
            btnbaocaodoanhthu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbaocaodoanhthu.Location = new Point(384, 3);
            btnbaocaodoanhthu.Name = "btnbaocaodoanhthu";
            btnbaocaodoanhthu.Size = new Size(188, 172);
            btnbaocaodoanhthu.TabIndex = 1;
            btnbaocaodoanhthu.Text = "Báo cáo doanh thu theo tháng";
            btnbaocaodoanhthu.UseVisualStyleBackColor = true;
            btnbaocaodoanhthu.Click += btnbaocaodoanhthu_Click;
            // 
            // btnbaocaohieusuat
            // 
            btnbaocaohieusuat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnbaocaohieusuat.Location = new Point(729, 3);
            btnbaocaohieusuat.Name = "btnbaocaohieusuat";
            btnbaocaohieusuat.Size = new Size(188, 172);
            btnbaocaohieusuat.TabIndex = 2;
            btnbaocaohieusuat.Text = "Báo cáo hiệu suất sử dụng từng loại phòng";
            btnbaocaohieusuat.UseVisualStyleBackColor = true;
            btnbaocaohieusuat.Click += btnbaocaohieusuat_Click;
            // 
            // chartBaoCao
            // 
            chartArea1.Name = "ChartArea1";
            chartBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBaoCao.Legends.Add(legend1);
            chartBaoCao.Location = new Point(0, 287);
            chartBaoCao.Name = "chartBaoCao";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBaoCao.Series.Add(series1);
            chartBaoCao.Size = new Size(1034, 364);
            chartBaoCao.TabIndex = 3;
            chartBaoCao.Text = "chart1";
            // 
            // UCQuanLyBaoCao
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnbaocaohieusuat);
            Controls.Add(btnbaocaodoanhthu);
            Controls.Add(btnbaocaotyle);
            Controls.Add(chartBaoCao);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "UCQuanLyBaoCao";
            Size = new Size(1034, 651);
            Load += UCQuanLyBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)chartBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbaocaotyle;
        private Button btnbaocaodoanhthu;
        private Button btnbaocaohieusuat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
    }
}