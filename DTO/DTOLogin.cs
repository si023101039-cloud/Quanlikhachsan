using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    [Table("TaiKhoan")]
    public class TaiKhoan_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTK { get; set; }

        public int? MaNV { get; set; }
        public string TenDangNhap { get; set; }
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
    }
}
