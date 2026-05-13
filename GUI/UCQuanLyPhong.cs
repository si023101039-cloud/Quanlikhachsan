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
    public partial class UCQuanLyPhong : UserControl
    {
        private BUSQlyphong phong_BUS = new BUSQlyphong();
        private LoaiPhong_BUS loaiPhong_BUS = new LoaiPhong_BUS();
        public UCQuanLyPhong()
        {
            InitializeComponent();
        }
        private void LoadLoaiPhong()
        {
            cboLoaiPhong.DataSource = loaiPhong_BUS.GetAllLoaiPhong();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void LoadData()
        {
            dgvPhong.DataSource = phong_BUS.LayTatCaPhong();
            if (dgvPhong.Columns["LoaiPhong"] != null) dgvPhong.Columns["LoaiPhong"].Visible = false;
            for (int i = 0; i < dgvPhong.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvPhong.Rows[i].Cells["Tang"].Value) == 0)
                {
                    dgvPhong.Rows[i].Cells["Tang"].Value = "1";
                }

            }
            dgvPhong.Columns["MaPhong"].Visible = false;
        }
        private void ResetInput()
        {
            txtTenPhong.Clear();
            rtxtMoTa.Clear();
            rtxtGhiChu.Clear();
            txtfind.Clear();
            cboLoaiPhong.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
        }
        public void loadtrangthai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đang sử dụng");
            cboTrangThai.SelectedIndex = 0;
        }
        private void UCQuanLyPhong_Load(object sender, EventArgs e)
        {
            txtTenPhong.Enabled = false;
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
            LoadLoaiPhong();
            LoadData();
            loadtrangthai();
            phong_BUS.CapNhatTenPhong();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tang = (int)numtang.Value;

            int soLonNhat = 0;

        
            for (int i = 0; i < dgvPhong.Rows.Count; i++)
            {
                string tenPhong = dgvPhong.Rows[i].Cells["TenPhong"].Value.ToString();

                
                if (tenPhong.StartsWith("P" + tang))
                {
                  
                    int so = Convert.ToInt32(tenPhong.Substring(2));

                    
                    if (so > soLonNhat)
                    {
                        soLonNhat = so;
                    }
                }
            }

            
            string tenPhongMoi = "P" + tang + (soLonNhat + 1).ToString("00");

            txtTenPhong.Text = tenPhongMoi;

            DTOQlyphong phong = new DTOQlyphong
            {
                TenPhong = tenPhongMoi,
                MaLoaiPhong = (int)cboLoaiPhong.SelectedValue,
                Tang = tang,
                TrangThai = cboTrangThai.SelectedIndex == 1,
                MoTa = rtxtMoTa.Text,
                GhiChu = rtxtGhiChu.Text
            };

            if (phong_BUS.ThemPhong(phong))
            {
                MessageBox.Show("Thêm phòng mới thành công!", "Thông báo");
                LoadData();
                ResetInput();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count > 0)
            {
                int maPhong = Convert.ToInt32(dgvPhong.CurrentRow.Cells["MaPhong"].Value);

                DTOQlyphong phong = new DTOQlyphong
                {
                    MaPhong = maPhong,
                    TenPhong = txtTenPhong.Text,
                    MaLoaiPhong = (int)cboLoaiPhong.SelectedValue,
                    Tang = (int)numtang.Value,
                    TrangThai = cboTrangThai.SelectedIndex == 1,
                    MoTa = rtxtMoTa.Text,
                    GhiChu = rtxtGhiChu.Text
                };

                if (phong_BUS.SuaPhong(phong))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa trên lưới!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count > 0)
            {
                int maPhong = Convert.ToInt32(dgvPhong.CurrentRow.Cells["MaPhong"].Value);
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (phong_BUS.XoaPhong(maPhong))
                    {
                        LoadData();
                        ResetInput();
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtfind.Text;
            dgvPhong.DataSource = phong_BUS.TimKiemPhong(keyword);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadData();
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow != null)
            {
                DataGridViewRow row = dgvPhong.CurrentRow;
                txtTenPhong.Text = row.Cells["TenPhong"].Value?.ToString();
                rtxtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                rtxtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
                cboLoaiPhong.SelectedValue = row.Cells["MaLoaiPhong"].Value;
                numtang.Value = Convert.ToDecimal(row.Cells["Tang"].Value);
                bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                cboTrangThai.SelectedIndex = trangThai ? 1 : 0;
            }
        }
    }
}
