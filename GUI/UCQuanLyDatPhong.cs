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
    public partial class UCQuanLyDatPhong : UserControl
    {
        PhieuDatPhong_BUS bus = new PhieuDatPhong_BUS();
        public UCQuanLyDatPhong()
        {
            InitializeComponent();
        }

        private void UCQuanLyDatPhong_Load(object sender, EventArgs e)
        {
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
            cbtrangthai.Items.Clear();

            cbtrangthai.Items.Add("Đang thuê");
            cbtrangthai.Items.Add("Đã trả");

            cbtrangthai.SelectedIndex = 0;
            LoadDanhSach();
        }

        void LoadDanhSach()
        {
            dgvPhieuDatPhong.DataSource = bus.GetAllPhieuDatPhong();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttraphong_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvPhieuDatPhong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phiếu đặt phòng");
                    return;
                }

                int maPhieu =
                    Convert.ToInt32(
                        dgvPhieuDatPhong.CurrentRow
                        .Cells["MaPhieuDatPhong"]
                        .Value);

                bool result = bus.TraPhong(maPhieu);

                if (result)
                {
                    MessageBox.Show("Trả phòng thành công");

                    LoadDanhSach();
                }
                else
                {
                    MessageBox.Show("Trả phòng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            bool result = bus.CapNhatTrangThaiPhong();

            if (result)
            {
                MessageBox.Show("Cập nhật trạng thái phòng thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái phòng thất bại");
            }
        }

        private void dgvPhieuDatPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvPhieuDatPhong.Rows[e.RowIndex];

                txtKH.Text =
                    row.Cells["MaKH"].Value.ToString();

                datengaydat.Value =
                    Convert.ToDateTime(
                        row.Cells["NgayDat"].Value);

                datengaynhan.Value =
                    Convert.ToDateTime(
                        row.Cells["NgayNhan"].Value);

                datengaytra.Value =
                    Convert.ToDateTime(
                        row.Cells["NgayTra"].Value);

               cbtrangthai.Text =
                    Convert.ToBoolean(
                        row.Cells["TrangThaiPhieu"].Value)
                    ? "Đang thuê"
                    : "Đã trả";

                richghichu.Text =
                    row.Cells["GhiChu"].Value?.ToString();
            }
        }
    }
}

