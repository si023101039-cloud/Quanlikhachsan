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
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyDatPhong : UserControl
    {
        int maPhongDuocChon = -1;
        decimal giaPhongDuocChon = 0;
        PhieuDatPhong_BUS bus = new PhieuDatPhong_BUS();
        public UCQuanLyDatPhong()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvPhieuDatPhong.DataSource = bus.LayTatCaPhieu();
        }
        private void LoadPhong()
        {
            PhieuDatPhong_DAO dao = new PhieuDatPhong_DAO();
            var ds = dao.LayDanhSachPhongTrong();

            cbphong.DataSource = ds;
            cbphong.DisplayMember = "TenPhong";
            cbphong.ValueMember = "MaPhong"; 

            cbphong.SelectedIndex = -1;
        }
        private void LoadTrangThai()
        {
            cbtrangthai.Items.Clear();

            cbtrangthai.Items.Add("Chờ xác nhận"); // 0
            cbtrangthai.Items.Add("Đã xác nhận");  // 1

            cbtrangthai.SelectedIndex = 0;
        }
        private void UCQuanLyDatPhong_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadTrangThai();
            LoadData();
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
            try
            {
                if (maPhongDuocChon <= 0)
                {
                    MessageBox.Show("Chưa chọn phòng");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtten.Text))
                {
                    MessageBox.Show("Chưa nhập tên khách hàng");
                    return;
                }

                bool trangThai = cbtrangthai.Text == "Đã xác nhận";

                PhieuDatPhong_DAO dao = new PhieuDatPhong_DAO();

                bool ketQua = dao.DatPhong(
                    txtten.Text,
                    dtpngaydat.Value,
                    dtpngaynhan.Value,
                    dtpngaytra.Value,
                    txtghichu.Text,
                    maPhongDuocChon,
                    trangThai
                );

                if (ketQua)
                {
                    MessageBox.Show("Đặt phòng thành công");
                    LoadData();
                    LoadPhong();
                    btnlammoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Đặt phòng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            PhieuDatPhong_DAO dao = new PhieuDatPhong_DAO();
            lblkiemtra.Text = " Danh sách phòng hệ thống";
            dgvCTPDP.DataSource = dao.LayDanhSachPhong();
        }

        private void dgvPhieuDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhieuDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvPhieuDatPhong.Rows[e.RowIndex];

            if (r.Cells["TenKH"].Value != null)
            {
                txtten.Text = r.Cells["TenKH"].Value.ToString();
            }
            else
            {
                txtten.Text = "";
            }

            if (r.Cells["GhiChu"].Value != null)
            {
                txtghichu.Text = r.Cells["GhiChu"].Value.ToString();
            }
            else
            {
                txtghichu.Text = "";
            }

            if (r.Cells["NgayDat"].Value != null)
            {
                dtpngaydat.Value = Convert.ToDateTime(r.Cells["NgayDat"].Value);
            }

            if (r.Cells["NgayNhan"].Value != null)
            {
                dtpngaynhan.Value = Convert.ToDateTime(r.Cells["NgayNhan"].Value);
            }

            if (r.Cells["NgayTra"].Value != null)
            {
                dtpngaytra.Value = Convert.ToDateTime(r.Cells["NgayTra"].Value);
            }

            if (r.Cells["MaPhieuDatPhong"].Value != null)
            {
                int maPhieu = Convert.ToInt32(r.Cells["MaPhieuDatPhong"].Value);

                dgvCTPDP.DataSource = bus.LayChiTietTheoMa(maPhieu);
            }
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtghichu.Clear();
            lblkiemtra.Text = "Chi tiết phiếu đặt phòng";
            dtpngaydat.Value = DateTime.Now;
            dtpngaynhan.Value = DateTime.Now;
            dtpngaytra.Value = DateTime.Now.AddDays(1);

            txtten.Focus();

            dgvCTPDP.DataSource = null;
            dgvPhieuDatPhong.CurrentCell = null;
        }

        private void dgvCTPDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvCTPDP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbphong.SelectedValue != null && int.TryParse(cbphong.SelectedValue.ToString(), out int maPhong))
            {
                maPhongDuocChon = maPhong;
            }
        }
    }
}

