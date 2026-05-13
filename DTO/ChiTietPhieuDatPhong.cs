using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    [Table("ChiTietDatPhong")]
    public class ChiTietDatPhong_DTO
    {
        [Key]
        public int MaDatPhongCT { get; set; }

        public int MaPhieuDatPhong { get; set; }

        public int MaPhong { get; set; }

        public DateTime? NgayCheckInThucTe { get; set; }

        public DateTime? NgayCheckOutThucTe { get; set; }
    }
}
