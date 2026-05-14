using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyDichVu : UserControl
    {
        private DichVu_BUS dvBUS = new DichVu_BUS();
        private ChiTietDichVu_BUS ctdvBUS = new ChiTietDichVu_BUS();
        private BUSQlyphong phongBUS = new BUSQlyphong();

        private int currentMaCTDV = 0;

        public UCQuanLyDichVu()
        {
            InitializeComponent();


            this.Load += UCQuanLyDichVu_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThanhToan.Click += BtnThanhToan_Click;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            dgvLoaiPhong.CellClick += DgvLoaiPhong_CellClick;
        }

        private void UCQuanLyDichVu_Load(object? sender, EventArgs e)
        {
            LoadComboBoxDichVu();
            LoadComboBoxPhong();
        }

        private void LoadComboBoxDichVu()
        {
            comboBox1.DataSource = dvBUS.GetAllDichVu();
            comboBox1.DisplayMember = "TenDichVu";
            comboBox1.ValueMember = "MaDichVu";
        }

        private void LoadComboBoxPhong()
        {
            var danhSachPhongDangThue = phongBUS.LayTatCaPhong().Where(p => p.TrangThai == true).ToList();

            comboBox2.SelectedIndexChanged -= ComboBox2_SelectedIndexChanged;
            comboBox2.DataSource = danhSachPhongDangThue;
            comboBox2.DisplayMember = "TenPhong";
            comboBox2.ValueMember = "MaPhong";
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;

            if (comboBox2.Items.Count > 0)
            {
                LoadDataGrid(Convert.ToInt32(comboBox2.SelectedValue));
            }
            else
            {
                dgvLoaiPhong.DataSource = null;
            }
        }

        private void LoadDataGrid(int maPhong)
        {
            dgvLoaiPhong.DataSource = ctdvBUS.GetDichVuByPhong(maPhong);

            if (dgvLoaiPhong.Columns.Count > 0)
            {
                dgvLoaiPhong.Columns["MaCTDV"].HeaderText = "ID";
                dgvLoaiPhong.Columns["TenPhong"].HeaderText = "Phòng";
                dgvLoaiPhong.Columns["TenDichVu"].HeaderText = "Tên Dịch Vụ";
                dgvLoaiPhong.Columns["SoLuong"].HeaderText = "SL";


                dgvLoaiPhong.Columns["DonGia"].HeaderText = "Đơn Giá";
                dgvLoaiPhong.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvLoaiPhong.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvLoaiPhong.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                dgvLoaiPhong.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgvLoaiPhong.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvLoaiPhong.Columns["ThoiDiemSuDung"].HeaderText = "Thời Điểm Gọi";

                dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DichVu_DTO dv)
            {
                numericUpDown1.Value = dv.DonGia;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null && int.TryParse(comboBox2.SelectedValue.ToString(), out int maPhong))
            {
                LoadDataGrid(maPhong);
            }
        }

        private void DgvLoaiPhong_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                currentMaCTDV = Convert.ToInt32(row.Cells["MaCTDV"].Value);

                comboBox1.Text = row.Cells["TenDichVu"].Value?.ToString();
                numericUpDown2.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                numericUpDown1.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
                dateTimePicker2.Value = Convert.ToDateTime(row.Cells["ThoiDiemSuDung"].Value);
            }
        }


        private void BtnThanhToan_Click(object? sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần thanh toán!", "Thông báo");
                return;
            }

            int maPhong = Convert.ToInt32(comboBox2.SelectedValue);
            int maPhieu = LayMaPhieuDatPhongTuMaPhong(maPhong);

            if (maPhieu != 0)
            {
                frm_thanhtoan frm = new frm_thanhtoan(maPhieu);
                frm.ShowDialog();



                comboBox1.SelectedIndex = -1;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;


                phongBUS = new BUSQlyphong();
                LoadComboBoxPhong();

                if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Text = "";
                    dgvLoaiPhong.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin dịch vụ hợp lệ!", "Lỗi");
            }
        }


        private void BtnThem_Click(object? sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng và dịch vụ cần thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (numericUpDown2.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng dịch vụ lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPhong = Convert.ToInt32(comboBox2.SelectedValue);


            int? maDatPhongCT = ctdvBUS.LayMaDatPhongCT_HienTai(maPhong);


            if (maDatPhongCT == null || maDatPhongCT == 0)
            {
                MessageBox.Show("Phòng này hiện chưa có Phiếu Đặt Phòng (chưa Check-in hợp lệ)!\nVui lòng sang tab Quản lý đặt phòng để nhận phòng trước.", "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ChiTietDichVu_DTO moi = new ChiTietDichVu_DTO()
            {
                MaDichVu = Convert.ToInt32(comboBox1.SelectedValue),
                MaDatPhongCT = maDatPhongCT.Value,
                SoLuong = (int)numericUpDown2.Value,
                DonGiaThoiDiemBan = numericUpDown1.Value,
                ThoiDiemSuDung = dateTimePicker2.Value
            };


            if (ctdvBUS.Insert(moi))
            {
                LoadDataGrid(maPhong);


                numericUpDown2.Value = 0;

                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại! Vui lòng kiểm tra lại dữ liệu.", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSua_Click(object? sender, EventArgs e)
        {
            if (currentMaCTDV == 0) return;

            ChiTietDichVu_DTO sua = new ChiTietDichVu_DTO()
            {
                MaCTDV = currentMaCTDV,
                MaDichVu = Convert.ToInt32(comboBox1.SelectedValue),
                SoLuong = (int)numericUpDown2.Value,
                DonGiaThoiDiemBan = numericUpDown1.Value,
                ThoiDiemSuDung = dateTimePicker2.Value
            };

            if (ctdvBUS.Update(sua))
            {
                int maPhong = Convert.ToInt32(comboBox2.SelectedValue);
                LoadDataGrid(maPhong);
                numericUpDown2.Value = 0;
                currentMaCTDV = 0;
            }
        }

        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (currentMaCTDV == 0) return;

            if (MessageBox.Show("Xóa dịch vụ này khỏi phòng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ctdvBUS.Delete(currentMaCTDV))
                {
                    int maPhong = Convert.ToInt32(comboBox2.SelectedValue);
                    LoadDataGrid(maPhong);
                    numericUpDown2.Value = 0;
                    currentMaCTDV = 0;
                }
            }
        }


        private int LayMaPhieuDatPhongTuMaPhong(int maPhong)
        {
            using (var db = new MyDbContext())
            {
                var chiTiet = db.ChiTietDatPhong_Entities
                                .FirstOrDefault(ct => ct.MaPhong == maPhong && ct.NgayCheckOutThucTe == null);

                return (chiTiet != null && chiTiet.MaPhieuDatPhong.HasValue)
                        ? chiTiet.MaPhieuDatPhong.Value
                        : 0;
            }
        }
    }
}