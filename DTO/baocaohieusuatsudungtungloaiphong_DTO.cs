using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class baocaohieusuatsudungtungloaiphong_DTO
    {
        public string TenLoaiPhong { get; set; }
        public int TongSoPhong { get; set; } 
        public int SoNgayThueThucTe { get; set; }
        public int TongSoNgayKhaDung { get; set; }

        public double HieuSuat => TongSoNgayKhaDung > 0
            ? Math.Round(((double)SoNgayThueThucTe / TongSoNgayKhaDung) * 100, 2)
            : 0;

        public decimal DoanhThuLoaiPhong { get; set; }
    }
}
