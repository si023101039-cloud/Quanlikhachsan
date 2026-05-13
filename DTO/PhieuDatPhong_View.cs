using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class PhieuDatPhong_View
    {
        public int MaPhieuDatPhong { get; set; }
        public int MaKH { get; set; }
        public string TenKH { get; set; } = "";

        public int MaNV { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public bool TrangThaiPhieu { get; set; }
        public string? GhiChu { get; set; }
    }
}
