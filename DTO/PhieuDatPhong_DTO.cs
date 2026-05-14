using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("PhieuDatPhong")]
    public class PhieuDatPhong_DTO
    {
        [Key]
        public int MaPhieuDatPhong { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayNhan { get; set; }
        public DateTime NgayTra { get; set; }
        public bool TrangThaiPhieu { get; set; }
        public string GhiChu { get; set; }
    }
}