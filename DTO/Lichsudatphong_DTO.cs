using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class LichSuDatPhong_DTO
    {
        public int MaPhieuDatPhong { get; set; }
        public string TenNV { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayCheckIn { get; set; }
        public DateTime? NgayCheckOut { get; set; }
    }
}
