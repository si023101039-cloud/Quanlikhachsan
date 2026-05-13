using OfficeOpenXml;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyBaoCao : UserControl
    {
        private baocaohieusuatsudungtungloaiphong_BUS _baoCaoBus = new baocaohieusuatsudungtungloaiphong_BUS();
        public UCQuanLyBaoCao()
        {
            InitializeComponent();
        }
        public void XuatExcelHieuSuat(List<baocaohieusuatsudungtungloaiphong_DTO> data, int thang, int nam)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var pck = new ExcelPackage())
            {
                var ws = pck.Workbook.Worksheets.Add("HieuSuatPhong");

                // Header
                ws.Cells["A1:E1"].Merge = true;
                ws.Cells["A1"].Value = $"BÁO CÁO HIỆU SUẤT SỬ DỤNG PHÒNG THÁNG {thang}/{nam}";
                ws.Cells["A1"].Style.Font.Bold = true;
                ws.Cells["A1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                // Bảng dữ liệu
                ws.Cells["A3"].Value = "Loại Phòng";
                ws.Cells["B3"].Value = "Tổng Số Phòng";
                ws.Cells["C3"].Value = "Số Ngày Thuê";
                ws.Cells["D3"].Value = "Doanh Thu";
                ws.Cells["E3"].Value = "Hiệu Suất (%)";
                ws.Cells["A3:E3"].Style.Font.Bold = true;

                int row = 4;
                foreach (var item in data)
                {
                    ws.Cells[row, 1].Value = item.TenLoaiPhong;
                    ws.Cells[row, 2].Value = item.TongSoPhong;
                    ws.Cells[row, 3].Value = item.SoNgayThueThucTe;
                    ws.Cells[row, 4].Value = item.DoanhThuLoaiPhong;
                    ws.Cells[row, 5].Value = item.HieuSuat / 100; // Để định dạng Percent

                    // Định dạng màu sắc dựa trên hiệu suất
                    if (item.HieuSuat < 30) // Hiệu suất thấp
                        ws.Cells[row, 5].Style.Font.Color.SetColor(Color.Red);
                    else if (item.HieuSuat > 70) // Hiệu suất cao
                        ws.Cells[row, 5].Style.Font.Color.SetColor(Color.Green);

                    row++;
                }

                // Định dạng cột
                ws.Cells[4, 4, row, 4].Style.Numberformat.Format = "#,##0";
                ws.Cells[4, 5, row, 5].Style.Numberformat.Format = "0.00%";
                ws.Cells.AutoFitColumns();

                // Lưu file
                string filePath = Path.Combine(Path.GetTempPath(), $"HieuSuat_{thang}_{nam}.xlsx");
                pck.SaveAs(new FileInfo(filePath));
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
        }

        private void btnbaocaohieusuat_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy giá trị tháng và năm từ giao diện
                int thang = int.Parse(cbxThang.Text);
                int nam = (int)txtNam.Value;

                // 2. Gọi hàm ThongKeHieuSuat từ BUS (đúng chức năng hiệu suất)
                var dataHieuSuat = _baoCaoBus.ThongKeHieuSuat(thang, nam);

                // 3. Kiểm tra dữ liệu và xuất Excel
                if (dataHieuSuat != null && dataHieuSuat.Count > 0)
                {
                    XuatExcelHieuSuat(dataHieuSuat, thang, nam);
                }
                else
                {
                    MessageBox.Show($"Không có dữ liệu hiệu suất phòng trong tháng {thang}/{nam}", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
