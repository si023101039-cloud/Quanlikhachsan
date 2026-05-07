using QuanLyKhachSan.BUS;
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
    public partial class UCQuanLyLoaiPhong : UserControl
    {
        private LoaiPhong_BUS loaiPhong_BUS = new LoaiPhong_BUS();
        public UCQuanLyLoaiPhong()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                var data = loaiPhong_BUS.GetAllLoaiPhong();
                if (data != null && data.Count > 0)
                {
                    dgvLoaiPhong.DataSource = data;
                    dgvLoaiPhong.Columns["MaLoaiPhong"].Visible = false;
                    cbxLoaiPhong.DataSource = data;
                    cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
                    cbxLoaiPhong.ValueMember = "MaLoaiPhong";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong bảng LoaiPhong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void UCQuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.AllowUserToResizeColumns = false;
            dgvLoaiPhong.AllowUserToResizeRows = false;
            dgvLoaiPhong.MultiSelect = false;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiPhong.RowHeadersVisible = false;
            dgvLoaiPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình Header (Màu xanh dương chủ đạo)
            dgvLoaiPhong.EnableHeadersVisualStyles = false;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvLoaiPhong.ColumnHeadersHeight = 40;

            // Cấu hình nội dung (Màu trắng)
            dgvLoaiPhong.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvLoaiPhong.BackgroundColor = Color.White;
            dgvLoaiPhong.BorderStyle = BorderStyle.None;
            dgvLoaiPhong.DefaultCellStyle.BackColor = Color.White;
            dgvLoaiPhong.DefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình dòng xen kẽ (Xanh dương nhạt)
            dgvLoaiPhong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);

            // Cấu hình khi chọn dòng (Màu cam làm điểm nhấn)
            Color selectColor = Color.FromArgb(255, 153, 51);
            dgvLoaiPhong.DefaultCellStyle.SelectionBackColor = selectColor;
            dgvLoaiPhong.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvLoaiPhong.RowsDefaultCellStyle.SelectionBackColor = selectColor;
            dgvLoaiPhong.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình lưới và các mục khác
            dgvLoaiPhong.GridColor = Color.FromArgb(220, 220, 220);
            dgvLoaiPhong.CurrentCell = null;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Load dữ liệu từ BUS
            LoadData();

            dgvLoaiPhong.DataSource = loaiPhong_BUS.GetAllLoaiPhong();
        }

        private void dgvLoaiPhong_Click(object sender, EventArgs e)
        {
            cbxLoaiPhong.SelectedValue = dgvLoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value;
            numGia.Value = Convert.ToDecimal(dgvLoaiPhong.CurrentRow.Cells["GiaTheoNgay"].Value);
            numSoNguoi.Value = Convert.ToDecimal(dgvLoaiPhong.CurrentRow.Cells["SoNguoiToiDa"].Value);
            rtxtMoTa.Text = dgvLoaiPhong.CurrentRow.Cells["MoTa"].Value.ToString();
        }
    }
}
