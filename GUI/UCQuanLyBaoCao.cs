using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace QuanLyKhachSan.GUI
{
    public partial class UCQuanLyBaoCao : UserControl
    {
        public UCQuanLyBaoCao()
        {
            InitializeComponent();
        }

        private void UCQuanLyBaoCao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MyDbContext())
            {
                int trong = dbContext.Phong_Entities.Count(p => p.TrangThai == false);
                int daDat = dbContext.Phong_Entities.Count(p => p.TrangThai == true);

                chartBaoCao.Series.Clear();
                var chuoiTron = chartBaoCao.Series.Add("TyLe");
                chuoiTron.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                chuoiTron.Points.AddXY("Phòng Trống", trong);
                chuoiTron.Points.AddXY("Phòng Có Khách", daDat);

                // Hiện phần trăm trực tiếp trên miếng bánh
                chuoiTron.IsValueShownAsLabel = true;
                chuoiTron.Label = "#VALX: #PERCENT";
            }
        }

        private void btnbaocaodoanhthu_Click(object sender, EventArgs e)
        {
            PhieuDatPhong_DAO daoBaoCao = new PhieuDatPhong_DAO();
            List<dynamic> danhSachDoanhThu = daoBaoCao.LayDuLieuDoanhThu();

            chartBaoCao.Series.Clear();
            var chuoiDuLieu = chartBaoCao.Series.Add("Doanh thu (VND)");
            chuoiDuLieu.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (var dong in danhSachDoanhThu)
            {
                chuoiDuLieu.Points.AddXY(dong.Thang, dong.TongTien);
            }

            chuoiDuLieu.IsValueShownAsLabel = true;
            chartBaoCao.ChartAreas[0].AxisX.Title = "Tháng";
            chartBaoCao.ChartAreas[0].AxisY.Title = "Số tiền (VND)";
            chartBaoCao.DataBind();
        }

        private void btnbaocaohieusuat_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MyDbContext())
            {
                var danhSach = dbContext.ChiTietDatPhong_Entities
                                        .GroupBy(ct => ct.MaPhong)
                                        .Select(nhom => new { MaSoPhong = nhom.Key, LuotThue = nhom.Count() })
                                        .ToList();

                chartBaoCao.Series.Clear();
                var chuoiNgang = chartBaoCao.Series.Add("Số lượt đặt");
                chuoiNgang.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

                foreach (var item in danhSach)
                {
                    chuoiNgang.Points.AddXY("Phòng " + item.MaSoPhong, item.LuotThue);
                }

                chuoiNgang.IsValueShownAsLabel = true;
                chartBaoCao.ChartAreas[0].AxisX.Title = "Tên Phòng";
                chartBaoCao.ChartAreas[0].AxisY.Title = "Số lượt thuê";
            }
        }
    }
}
