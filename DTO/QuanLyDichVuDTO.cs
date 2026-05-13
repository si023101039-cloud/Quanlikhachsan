using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyKhachSan.DTO
{
    
    [Table("DichVu")]
    public class DichVu_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDichVu { get; set; }
        public string TenDichVu { get; set; } = "";
        public decimal DonGia { get; set; }
        public string DonViTinh { get; set; } = "";
        public bool TrangThai { get; set; }
    }

    
    [Table("ChiTietDichVu")]
    public class ChiTietDichVu_DTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCTDV { get; set; }
        public int MaDichVu { get; set; }
        public int MaDatPhongCT { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGiaThoiDiemBan { get; set; }
        public DateTime ThoiDiemSuDung { get; set; }
    }

    
    public class ChiTietDichVu_View
    {
        public int MaCTDV { get; set; }
        public string TenPhong { get; set; } = "";
        public string TenDichVu { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia; 
        public DateTime ThoiDiemSuDung { get; set; }
    }
}