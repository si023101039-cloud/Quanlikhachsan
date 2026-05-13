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
using System.Xml;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyLoaiPhong : UserControl
    {
        private LoaiPhong_BUS loaiPhong_BUS = new LoaiPhong_BUS();
        public UCQuanLyLoaiPhong()
        {
            InitializeComponent();
        }
        public bool KiemTraControl()
        {
            if (string.IsNullOrWhiteSpace(txtLoaiPhong.Text))
            {
                MessageBox.Show("Tên loại phòng không được để trống !");
                txtLoaiPhong.Focus();
                return false;
            }
            if (numGia.Value <= 0)
            {
                MessageBox.Show("Giá theo ngày phải lớn hơn 0 !");
                numGia.Focus();
                return false;
            }
            if (numSoNguoi.Value <= 0)
            {
                MessageBox.Show("Số người tối đa phải lớn hơn 0 !");
                numSoNguoi.Focus();
                return false;
            }
            return true;
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

            var data = loaiPhong_BUS.GetAllLoaiPhong();
            if (data != null && data.Count > 0)
            {
                dgvLoaiPhong.DataSource = data;
                dgvLoaiPhong.Columns["MaLoaiPhong"].Visible = false;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong bảng LoaiPhong!");
            }

            txtLoaiPhong.Enabled = false;
            numGia.Enabled = false;
            numSoNguoi.Enabled = false;
            rtxtMoTa.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvLoaiPhong_Click(object sender, EventArgs e)
        {
            txtLoaiPhong.Text = dgvLoaiPhong.CurrentRow.Cells["TenLoaiPhong"].Value.ToString();
            numGia.Value = Convert.ToDecimal(dgvLoaiPhong.CurrentRow.Cells["GiaTheoNgay"].Value);
            numSoNguoi.Value = Convert.ToDecimal(dgvLoaiPhong.CurrentRow.Cells["SoNguoiToiDa"].Value);
            rtxtMoTa.Text = dgvLoaiPhong.CurrentRow.Cells["MoTa"].Value.ToString();
            if (btnThem.Text == "Lưu")
            {
                btnThem.Text = "Thêm";
                txtLoaiPhong.Enabled = false;
                numGia.Enabled = false;
                numSoNguoi.Enabled = false;
                rtxtMoTa.Enabled = false;
            }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Lưu";
                txtLoaiPhong.Enabled = true;
                numGia.Enabled = true;
                numSoNguoi.Enabled = true;
                rtxtMoTa.Enabled = true;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                var loaiPhong = new DTO.LoaiPhong_DTO
                {
                    TenLoaiPhong = txtLoaiPhong.Text,
                    GiaTheoNgay = numGia.Value,
                    SoNguoiToiDa = (int)numSoNguoi.Value,
                    MoTa = rtxtMoTa.Text
                };
                if (KiemTraControl())
                {
                    if (loaiPhong_BUS.InsertLoaiPhong(loaiPhong))
                    {
                        MessageBox.Show("Thêm loại phòng thành công!");
                        dgvLoaiPhong.DataSource = loaiPhong_BUS.GetAllLoaiPhong();
                        dgvLoaiPhong.Columns["MaLoaiPhong"].Visible = false;
                        btnThem.Text = "Thêm";
                        txtLoaiPhong.Enabled = false;
                        numGia.Enabled = false;
                        numSoNguoi.Enabled = false;
                        rtxtMoTa.Enabled = false;

                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm loại phòng thất bại!");
                    }
                    btnThem.Text = "Thêm";
                    txtLoaiPhong.Enabled = false;
                    numGia.Enabled = false;
                    numSoNguoi.Enabled = false;
                    rtxtMoTa.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                txtLoaiPhong.Enabled = true;
                numGia.Enabled = true;
                numSoNguoi.Enabled = true;
                rtxtMoTa.Enabled = true;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                try
                {
                    int maLoaiPhong = Convert.ToInt32(dgvLoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value);
                    var loaiPhong = new DTO.LoaiPhong_DTO
                    {
                        MaLoaiPhong = maLoaiPhong,
                        TenLoaiPhong = txtLoaiPhong.Text,
                        GiaTheoNgay = numGia.Value,
                        SoNguoiToiDa = (int)numSoNguoi.Value,
                        MoTa = rtxtMoTa.Text
                    };
                    if (KiemTraControl())
                    {
                        if (loaiPhong_BUS.UpdateLoaiPhong(loaiPhong))
                        {
                            MessageBox.Show("Cập nhật loại phòng thành công!");
                            dgvLoaiPhong.DataSource = loaiPhong_BUS.GetAllLoaiPhong();
                            dgvLoaiPhong.Columns["MaLoaiPhong"].Visible = false;
                            btnSua.Text = "Sửa";
                            txtLoaiPhong.Enabled = false;
                            numGia.Enabled = false;
                            numSoNguoi.Enabled = false;
                            rtxtMoTa.Enabled = false;

                            btnXoa.Enabled = true;
                            btnThem.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật loại phòng thất bại!");
                        }
                        btnSua.Text = "Sửa";
                        txtLoaiPhong.Enabled = false;
                        numGia.Enabled = false;
                        numSoNguoi.Enabled = false;
                        rtxtMoTa.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rlt == DialogResult.Yes)
            {
                int maLoaiPhong = Convert.ToInt32(dgvLoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value);
                if (loaiPhong_BUS.DeleteLoaiPhong(maLoaiPhong))
                {
                    MessageBox.Show("Xóa loại phòng thành công!");
                    dgvLoaiPhong.DataSource = loaiPhong_BUS.GetAllLoaiPhong();
                    dgvLoaiPhong.Columns["MaLoaiPhong"].Visible = false;
                    txtLoaiPhong.Text = "";
                    numGia.Value = 0;
                    numSoNguoi.Value = 0;
                    rtxtMoTa.Text = "";
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng thất bại!");
                }
            }
        }

        private void dgvLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
