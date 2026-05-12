using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("Phong")]
    public class PhongDTO
    {
        [Key]
        public int MaPhong { get; set; }
        public string? TenPhong { get; set; }
        public int? MaLoaiPhong { get; set; }
        public bool? TrangThai { get; set; }
    }
}