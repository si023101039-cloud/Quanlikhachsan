using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class ChiTietDoanhThuThangDTO
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TenKhachHang { get; set; }
        public decimal TienPhong { get; set; }
        public decimal TienDichVu { get; set; }
        public decimal PhuPhi { get; set; }
        public decimal TongThanhToan { get; set; }
    }

    public class BaoCaoExcelView
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public DateTime NgayXuatBaoCao { get; set; }
        public string NguoiLapBaoCao { get; set; }
        public List<ChiTietDoanhThuThangDTO> DanhSachHoaDon { get; set; } = new List<ChiTietDoanhThuThangDTO>();

        public decimal TongDoanhThuThang => DanhSachHoaDon.Sum(x => x.TongThanhToan);
        public int TongSoHoaDon => DanhSachHoaDon.Count;
    }
}
