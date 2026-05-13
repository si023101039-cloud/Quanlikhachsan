using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    [Table("KhachHang")]
    public class KhachHang_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MaKH { get; set; }

        public string TenKH { get; set; } = "";

        public string? SDT { get; set; }

        public bool? GioiTinh { get; set; }

        public string? CCCD { get; set; }

        public string? Email { get; set; }
    }
}
