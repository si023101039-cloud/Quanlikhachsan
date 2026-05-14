using System;
using System.IO;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System.Diagnostics;
using OfficeOpenXml;

namespace QuanLyKhachSan.GUI
{
    public partial class frm_thanhtoan : Form
    {
        private int _maPhieu;
        private ThanhToanBUS bus = new ThanhToanBUS();
        private int _idHoaDonVuaLuu = 0;
        private bool _daThanhToanThanhCong = false;

        public frm_thanhtoan(int maPhieu)
        {
            InitializeComponent();
            this._maPhieu = maPhieu;

            this.Load += Frm_thanhtoan_Load;
            btnThanhToan.Click += BtnThanhToan_Click;
            btnXuatHoaDon.Click += BtnXuatHoaDon_Click;

            btnHuy.Click += (s, e) =>
            {
                this.DialogResult = _daThanhToanThanhCong ? DialogResult.OK : DialogResult.Cancel;
                this.Close();
            };

            textBox4.TextChanged += (s, e) => TinhTong();
        }

        private void Frm_thanhtoan_Load(object sender, EventArgs e)
        {

            btnXuatHoaDon.Visible = false;

            var thongTin = bus.LayThongTin(_maPhieu);

            textBox1.Text = thongTin.TenNhanVien;
            textBox5.Text = thongTin.TongTienPhong.ToString("N0");
            textBox3.Text = thongTin.TongTienDichVu.ToString("N0");
            textBox4.Text = "0";

            TinhTong();
        }

        private void TinhTong()
        {
            decimal.TryParse(textBox5.Text.Replace(".", ""), out decimal phong);
            decimal.TryParse(textBox3.Text.Replace(".", ""), out decimal dv);
            decimal.TryParse(textBox4.Text, out decimal phuPhi);

            textBox2.Text = (phong + dv + phuPhi).ToString("N0");
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            var hd = new ThanhToanDTO
            {
                MaPhieuDatPhong = _maPhieu,
                NgayThanhToan = dateTimePicker1.Value,
                TongTienPhong = decimal.Parse(textBox5.Text.Replace(".", "")),
                TongTienDichVu = decimal.Parse(textBox3.Text.Replace(".", "")),
                PhuPhi = decimal.Parse(textBox4.Text)
            };

            if (bus.ThucHienThanhToan(hd))
            {
                MessageBox.Show("Xác nhận thanh toán vào hệ thống thành công!", "Thông báo");

                _idHoaDonVuaLuu = hd.MaHoaDon;
                btnThanhToan.Enabled = false;


                btnXuatHoaDon.Visible = true;

                _daThanhToanThanhCong = true;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu hóa đơn.");
            }
        }

        private void BtnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string tempFolder = Path.GetTempPath();
                string fileName = $"HoaDon_{_maPhieu}_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                string filePath = Path.Combine(tempFolder, fileName);

                using (ExcelPackage pck = new ExcelPackage())
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("HoaDon");

                    ws.Cells["A1:D1"].Merge = true;
                    ws.Cells["A1"].Value = "HÓA ĐƠN THANH TOÁN KHÁCH SẠN";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.Font.Size = 16;
                    ws.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    ws.Cells["A3"].Value = "Mã hóa đơn:";


                    ws.Cells["B3"].Value = _idHoaDonVuaLuu;
                    ws.Cells["B3"].Style.Font.Bold = true;
                    ws.Cells["B3"].Style.Font.Color.SetColor(System.Drawing.Color.Red);

                    ws.Cells["A4"].Value = "Ngày in:";
                    ws.Cells["B4"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    ws.Cells["A5"].Value = "Nhân viên:";
                    ws.Cells["B5"].Value = textBox1.Text;

                    ws.Cells["A7"].Value = "Tên Dịch Vụ";
                    ws.Cells["B7"].Value = "Số Lượng";
                    ws.Cells["C7"].Value = "Đơn Giá";
                    ws.Cells["D7"].Value = "Thành Tiền";
                    ws.Cells["A7:D7"].Style.Font.Bold = true;

                    var listDichVu = bus.LayDuLieuExcel(_maPhieu);
                    int row = 8;
                    foreach (var item in listDichVu)
                    {
                        ws.Cells[row, 1].Value = item.TenDichVu;
                        ws.Cells[row, 2].Value = item.SoLuong;
                        ws.Cells[row, 3].Value = item.DonGia;
                        ws.Cells[row, 4].Value = item.ThanhTien;

                        ws.Cells[row, 3, row, 4].Style.Numberformat.Format = "#,##0";
                        row++;
                    }

                    int lastRow = row + 1;
                    ws.Cells[lastRow, 3].Value = "Tiền phòng:";
                    ws.Cells[lastRow, 4].Value = decimal.Parse(textBox5.Text.Replace(".", ""));

                    ws.Cells[lastRow + 1, 3].Value = "Phụ phí:";
                    ws.Cells[lastRow + 1, 4].Value = decimal.Parse(textBox4.Text);

                    ws.Cells[lastRow + 2, 3].Value = "TỔNG CỘNG:";
                    ws.Cells[lastRow + 2, 3].Style.Font.Bold = true;
                    ws.Cells[lastRow + 2, 4].Value = decimal.Parse(textBox2.Text.Replace(".", ""));
                    ws.Cells[lastRow + 2, 4].Style.Font.Bold = true;

                    ws.Cells[lastRow, 4, lastRow + 2, 4].Style.Numberformat.Format = "#,##0";

                    ws.Cells.AutoFitColumns();

                    FileInfo fi = new FileInfo(filePath);
                    pck.SaveAs(fi);
                }


                Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất/mở file Excel: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_thanhtoan_Load_1(object sender, EventArgs e)
        {

        }

        private void btnXuatHoaDon_Click_1(object sender, EventArgs e)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
    }
}