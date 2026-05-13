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
    public class DTOQlyphong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhong { get; set; } 

        public string? TenPhong { get; set; } 

        public int? MaLoaiPhong { get; set; } 

        public int? Tang { get; set; } 

        public bool? TrangThai { get; set; } 

        public string? MoTa { get; set; } 

        public string? GhiChu { get; set; } 

        [ForeignKey("MaLoaiPhong")]
        public virtual LoaiPhong_DTO? LoaiPhong { get; set; }
    }
}
