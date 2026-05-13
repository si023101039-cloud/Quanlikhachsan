using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("TaiKhoan")]
    public class TaiKhoan_DTO
    {
        [Key]
        public int MaTK { get; set; }

        public int? MaNV { get; set; }

        [Column("TenDangNhap", TypeName = "varchar")]
        public string TenDangNhap { get; set; }

        [Column("MatKhau", TypeName = "varchar")]
        public string MatKhau { get; set; }

        public string VaiTro { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? TrangThai { get; set; }

        [ForeignKey("MaNV")]
        public virtual NhanVien_DTO NhanVien { get; set; }
    }

    [Table("NhanVien")]
    public class NhanVien_DTO
    {
        [Key]
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        // Thêm các cột khác từ script nếu cần dùng
        public string Sdt { get; set; }
        public bool? TrangThai { get; set; }
    }
}