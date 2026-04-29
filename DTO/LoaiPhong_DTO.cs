using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    [Table("LoaiPhong")]
    public class LoaiPhong_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public decimal GiaTheoNgay { get; set; }
        public int SoNguoiToiDa { get; set; }
        public string MoTa { get; set; }
    }
}
