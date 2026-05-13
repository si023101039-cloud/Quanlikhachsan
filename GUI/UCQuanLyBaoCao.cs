using OfficeOpenXml;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Style;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyBaoCao : UserControl
    {
        public UCQuanLyBaoCao()
        {
            InitializeComponent();
        }


        public void XuatBaoCaoDoanhThuExcel(BaoCaoExcelView data)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                string fileName = $"BaoCaoDoanhThu_Thang{data.Thang}_{data.Nam}_{DateTime.Now:yyyyMMdd}.xlsx";
                string filePath = Path.Combine(Path.GetTempPath(), fileName);

                using (ExcelPackage pck = new ExcelPackage())
                {
                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("DoanhThu");

                    ws.Cells["A1:G1"].Merge = true;
                    ws.Cells["A1"].Value = $"BÁO CÁO DOANH THU THÁNG {data.Thang}/{data.Nam}";
                    ws.Cells["A1"].Style.Font.Bold = true;
                    ws.Cells["A1"].Style.Font.Size = 18;
                    ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    ws.Cells["A3"].Value = "Người lập báo cáo:";
                    ws.Cells["B3"].Value = data.NguoiLapBaoCao;
                    ws.Cells["A4"].Value = "Ngày xuất bản:";
                    ws.Cells["B4"].Value = data.NgayXuatBaoCao.ToString("dd/MM/yyyy HH:mm");

                    string[] headers = { "STT", "Mã HĐ", "Ngày TT", "Khách Hàng", "Tiền Phòng", "Tiền DV", "Tổng Cộng" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        var cell = ws.Cells[6, i + 1];
                        cell.Value = headers[i];
                        cell.Style.Font.Bold = true;
                        cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cell.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                        cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }

                    int currentRow = 7;
                    int stt = 1;
                    foreach (var item in data.DanhSachHoaDon)
                    {
                        ws.Cells[currentRow, 1].Value = stt++;
                        ws.Cells[currentRow, 2].Value = item.MaHoaDon;
                        ws.Cells[currentRow, 3].Value = item.NgayThanhToan.ToString("dd/MM/yyyy");
                        ws.Cells[currentRow, 4].Value = item.TenKhachHang;
                        ws.Cells[currentRow, 5].Value = item.TienPhong;
                        ws.Cells[currentRow, 6].Value = item.TienDichVu;
                        ws.Cells[currentRow, 7].Value = item.TongThanhToan;

                        ws.Cells[currentRow, 5, currentRow, 7].Style.Numberformat.Format = "#,##0";
                        currentRow++;
                    }

                    int summaryRow = currentRow + 1;
                    ws.Cells[summaryRow, 4].Value = "TỔNG DOANH THU THÁNG:";
                    ws.Cells[summaryRow, 4].Style.Font.Bold = true;

                    ws.Cells[summaryRow, 7].Value = data.TongDoanhThuThang;
                    ws.Cells[summaryRow, 7].Style.Font.Bold = true;
                    ws.Cells[summaryRow, 7].Style.Font.Color.SetColor(Color.Red);
                    ws.Cells[summaryRow, 7].Style.Numberformat.Format = "#,##0";

                    ws.Cells.AutoFitColumns();

                    FileInfo fi = new FileInfo(filePath);
                    pck.SaveAs(fi);

                    Process.Start(new ProcessStartInfo { FileName = filePath, UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message);
            }
        }

        private void UCQuanLyBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void bcdttheothang_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbxThang.Text);
            int nam = int.Parse(txtNam.Text);   

            string nhanVienHienTai = "Tran Minh Si";

            BaoCaoBUS baoCaoBus = new BaoCaoBUS();

            var duLieu = baoCaoBus.GetFullBaoCao(thang, nam, nhanVienHienTai);

            if (duLieu.DanhSachHoaDon.Count > 0)
            {
                XuatBaoCaoDoanhThuExcel(duLieu);
            }
            else
            {
                MessageBox.Show($"Tháng {thang}/{nam} không có dữ liệu doanh thu!");
            }
        }
    }
}
