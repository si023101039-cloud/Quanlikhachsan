using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    [Table("Phong")]
    public class Phong_DTO
    {
        [Key]
        public int MaPhong { get; set; }
        public string? TenPhong { get; set; }
        public int? MaLoaiPhong { get; set; }
        public bool? TrangThai { get; set; }
    }
}
