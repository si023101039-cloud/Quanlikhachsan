using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public class MyDbContext : DbContext
    {
        public DbSet<DTOQlyphong> Phong_Entities { get; set; }
        public DbSet<TaiKhoan_DTO> TaiKhoan_Entities { get; set; }
        public DbSet<NhanVien_DTO> NhanVien_Entities { get; set; }
        public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }
        public DbSet<PhieuDatPhong_DTO> PhieuDatPhong_Entities { get; set; }

        public DbSet<KhachHang_DTO> KhachHang_Entities { get; set; }
        public DbSet<ChiTietDatPhong_DTO> ChiTietDatPhong_Entities { get; set; }
        public DbSet<DichVu_DTO> DichVu_Entities { get; set; }
        public DbSet<ChiTietDichVu_DTO> ChiTietDichVu_Entities { get; set; }
        public DbSet<ThanhToanDTO> HoaDon_Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LAPTOP-3R4OQCCK;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}