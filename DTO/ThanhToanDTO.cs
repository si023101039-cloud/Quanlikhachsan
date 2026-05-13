using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    [Table("HoaDon")]
    public class ThanhToanDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDon { get; set; }
        public int MaPhieuDatPhong { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTienPhong { get; set; }
        public decimal TongTienDichVu { get; set; }
        public decimal PhuPhi { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal TongTienThanhToan { get; private set; }
    }

    
    public class ThanhToanView
    {
        public string TenNhanVien { get; set; } = "";
        public decimal TongTienPhong { get; set; }
        public decimal TongTienDichVu { get; set; }
    }

    
    public class ChiTietExcelView
    {
        public string TenDichVu { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}