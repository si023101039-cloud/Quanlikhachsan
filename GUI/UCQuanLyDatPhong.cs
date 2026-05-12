using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
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
    public partial class UCQuanLyDatPhong : UserControl
    {
        PhieuDatPhongBUS bus = new PhieuDatPhongBUS();
        public UCQuanLyDatPhong()
        {
            InitializeComponent();

        }
        private void LoadData()
        {
            dgvPhieuDatPhong.DataSource = bus.LayDSPhieu();
        }
        private void UCQuanLyDatPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            cbtrangthai.Items.Clear();
            cbtrangthai.Items.Add("Tất cả");
            cbtrangthai.Items.Add("Đã xác nhận");
            cbtrangthai.Items.Add("Chưa xác nhận");
            cbtrangthai.SelectedIndex = 0;
            dgvPhieuDatPhong.ReadOnly = true;
            dgvPhieuDatPhong.AllowUserToAddRows = false;
            dgvPhieuDatPhong.AllowUserToDeleteRows = false;
            dgvPhieuDatPhong.AllowUserToResizeColumns = false;
            dgvPhieuDatPhong.AllowUserToResizeRows = false;
            dgvPhieuDatPhong.MultiSelect = false;
            dgvPhieuDatPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuDatPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuDatPhong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPhieuDatPhong.RowHeadersVisible = false;
            dgvPhieuDatPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình Header (Màu xanh dương chủ đạo)
            dgvPhieuDatPhong.EnableHeadersVisualStyles = false;
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvPhieuDatPhong.ColumnHeadersHeight = 40;

            // Cấu hình nội dung (Màu trắng)
            dgvPhieuDatPhong.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvPhieuDatPhong.BackgroundColor = Color.White;
            dgvPhieuDatPhong.BorderStyle = BorderStyle.None;
            dgvPhieuDatPhong.DefaultCellStyle.BackColor = Color.White;
            dgvPhieuDatPhong.DefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình dòng xen kẽ (Xanh dương nhạt)
            dgvPhieuDatPhong.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);

            // Cấu hình khi chọn dòng (Màu cam làm điểm nhấn)
            Color selectColor = Color.FromArgb(255, 153, 51);
            dgvPhieuDatPhong.DefaultCellStyle.SelectionBackColor = selectColor;
            dgvPhieuDatPhong.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPhieuDatPhong.RowsDefaultCellStyle.SelectionBackColor = selectColor;
            dgvPhieuDatPhong.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình lưới và các mục khác
            dgvPhieuDatPhong.GridColor = Color.FromArgb(220, 220, 220);
            dgvPhieuDatPhong.CurrentCell = null;
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvPhieuDatPhong.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgvCTPDP.ReadOnly = true;
            dgvCTPDP.AllowUserToAddRows = false;
            dgvCTPDP.AllowUserToDeleteRows = false;
            dgvCTPDP.AllowUserToResizeColumns = false;
            dgvCTPDP.AllowUserToResizeRows = false;
            dgvCTPDP.MultiSelect = false;
            dgvCTPDP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTPDP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPDP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCTPDP.RowHeadersVisible = false;
            dgvCTPDP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTPDP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Cấu hình Header (Màu xanh dương chủ đạo)
            dgvCTPDP.EnableHeadersVisualStyles = false;
            dgvCTPDP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgvCTPDP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCTPDP.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvCTPDP.ColumnHeadersHeight = 40;

            // Cấu hình nội dung (Màu trắng)
            dgvCTPDP.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvCTPDP.BackgroundColor = Color.White;
            dgvCTPDP.BorderStyle = BorderStyle.None;
            dgvCTPDP.DefaultCellStyle.BackColor = Color.White;
            dgvCTPDP.DefaultCellStyle.ForeColor = Color.Black;

            // Cấu hình dòng xen kẽ (Xanh dương nhạt)
            dgvCTPDP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 242, 250);

            // Cấu hình khi chọn dòng (Màu cam làm điểm nhấn)
            Color selectColor1 = Color.FromArgb(255, 153, 51);
            dgvCTPDP.DefaultCellStyle.SelectionBackColor = selectColor1;
            dgvCTPDP.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCTPDP.RowsDefaultCellStyle.SelectionBackColor = selectColor1;
            dgvCTPDP.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình lưới và các mục khác
            dgvCTPDP.GridColor = Color.FromArgb(220, 220, 220);
            dgvCTPDP.CurrentCell = null;
            dgvCTPDP.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dgvCTPDP.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)//dat phong
        {
            if (dgvCTPDP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng nhấn Kiểm tra và chọn 1 phòng ở bảng dưới!");
                return;
            }

            PhieuDatPhongDTO p = new PhieuDatPhongDTO();
            p.MaKH = 1;
            p.MaNV = 1;
            p.NgayDat = dtpngaydat.Value;
            p.NgayNhan = dtpngaynhan.Value;
            p.NgayTra = dtpngaytra.Value;
            p.GhiChu = txtghichu.Text;
            p.TrangThaiPhieu = true;

            int maPhong = (int)dgvCTPDP.CurrentRow.Cells["MaPhong"].Value;
            string tenKhachHang = txtten.Text;
            decimal gia = 500000;

            string ketQua = bus.ThucHienDatPhong(p, maPhong, tenKhachHang, gia);

            MessageBox.Show(ketQua);

            if (ketQua == "Thành công")
            {
                LoadData();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            dgvCTPDP.DataSource = bus.LayDSPhongTrong(dtpngaynhan.Value, dtpngaytra.Value);
        }

        private void dgvPhieuDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhieuDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvPhieuDatPhong.Rows[e.RowIndex];

                txtten.Text = r.Cells["MaKH"].Value?.ToString();
                txtghichu.Text = r.Cells["GhiChu"].Value?.ToString();
                dtpngaydat.Value = Convert.ToDateTime(r.Cells["NgayDat"].Value);
                dtpngaynhan.Value = Convert.ToDateTime(r.Cells["NgayNhan"].Value);
                dtpngaytra.Value = Convert.ToDateTime(r.Cells["NgayTra"].Value);

                int maPhieu = (int)r.Cells["MaPhieuDatPhong"].Value;
                dgvCTPDP.DataSource = bus.LayDSChiTiet(maPhieu);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtghichu.Clear();

            dtpngaydat.Value = DateTime.Now;
            dtpngaynhan.Value = DateTime.Now;
            dtpngaytra.Value = DateTime.Now.AddDays(1);

            txtten.Focus();

            dgvCTPDP.DataSource = null;
            dgvPhieuDatPhong.CurrentCell = null;
        }
    }
}
