using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;

namespace QuanLyKhachSan.GUI
{
    public partial class UCXemlichsudatphong : UserControl
    {
        private PhieuDatPhong_BUS phieuDatPhongBUS = new PhieuDatPhong_BUS();

        public UCXemlichsudatphong()
        {
            InitializeComponent();
        }

        private void UCXemlichsudatphong_Load(object sender, EventArgs e)
        {
            dgvLSDP.ReadOnly = true;
            dgvLSDP.AllowUserToAddRows = false;
            dgvLSDP.AllowUserToDeleteRows = false;
            dgvLSDP.AllowUserToResizeColumns = false;
            dgvLSDP.AllowUserToResizeRows = false;
            dgvLSDP.MultiSelect = false;
            dgvLSDP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLSDP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLSDP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLSDP.RowHeadersVisible = false;
            dgvLSDP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLSDP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình Header (Màu xanh dương chủ đạo)
            dgvLSDP.EnableHeadersVisualStyles = false;
            dgvLSDP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvLSDP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLSDP.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvLSDP.ColumnHeadersHeight = 40;

            // Cấu hình nội dung (Màu trắng)
            dgvLSDP.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvLSDP.BackgroundColor = Color.White;
            dgvLSDP.BorderStyle = BorderStyle.None;
            dgvLSDP.DefaultCellStyle.BackColor = Color.White;
            dgvLSDP.DefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình dòng xen kẽ (Xanh dương nhạt)
            dgvLSDP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);

            // Cấu hình khi chọn dòng (Màu cam làm điểm nhấn)
            Color selectColor = Color.FromArgb(255, 153, 51);
            dgvLSDP.DefaultCellStyle.SelectionBackColor = selectColor;
            dgvLSDP.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvLSDP.RowsDefaultCellStyle.SelectionBackColor = selectColor;
            dgvLSDP.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình lưới và các mục khác
            dgvLSDP.GridColor = Color.FromArgb(220, 220, 220);
            dgvLSDP.CurrentCell = null;
            dgvLSDP.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvLSDP.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvLSDP.DataSource = phieuDatPhongBUS.LayTatCaLichSu();
            if (dgvLSDP.Rows.Count > 0)
            {
                dgvLSDP.Columns["MaPhieuDatPhong"].Visible = false;
            }
        }
    }
}
