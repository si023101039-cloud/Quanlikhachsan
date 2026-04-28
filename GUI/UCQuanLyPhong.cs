using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyPhong : UserControl
    {
        public UCQuanLyPhong()
        {
            InitializeComponent();
        }

        private void UCQuanLyPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.ReadOnly = true;
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.AllowUserToResizeColumns = false;
            dgvPhong.AllowUserToResizeRows = false;
            dgvPhong.MultiSelect = false;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPhong.RowHeadersVisible = false;
            dgvPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình Header (Màu xanh dương chủ đạo)
            dgvPhong.EnableHeadersVisualStyles = false;
            dgvPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204); // Xanh dương đậm
            dgvPhong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhong.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvPhong.ColumnHeadersHeight = 40;

            // Cấu hình nội dung (Màu trắng)
            dgvPhong.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvPhong.BackgroundColor = Color.White;
            dgvPhong.BorderStyle = BorderStyle.None;
            dgvPhong.DefaultCellStyle.BackColor = Color.White;
            dgvPhong.DefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình dòng xen kẽ (Xanh dương nhạt)
            dgvPhong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);

            // Cấu hình khi chọn dòng (Màu cam làm điểm nhấn)
            Color selectColor = Color.FromArgb(255, 153, 51); // Màu cam
            dgvPhong.DefaultCellStyle.SelectionBackColor = selectColor;
            dgvPhong.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPhong.RowsDefaultCellStyle.SelectionBackColor = selectColor;
            dgvPhong.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình lưới và các mục khác
            dgvPhong.GridColor = Color.FromArgb(220, 220, 220);
            dgvPhong.CurrentCell = null;
            dgvPhong.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvPhong.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
