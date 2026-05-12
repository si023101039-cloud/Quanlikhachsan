using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("ChiTietDatPhong")]
    public class ChiTietDatPhongDTO
    {
        [Key]
        public int MaDatPhongCT { get; set; }
        public int? MaPhieuDatPhong { get; set; }
        public int? MaPhong { get; set; }
        public decimal? DonGia { get; set; }
        public DateTime? NgayCheckInThucTe { get; set; }
        public DateTime? NgayCheckOutThucTe { get; set; }
    }
}