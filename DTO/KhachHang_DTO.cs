using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("KhachHang")]
    public class KhachHang_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public bool GioiTinh { get; set; }
        public string CCCD { get; set; }
        public string email { get; set; }
    }
}
