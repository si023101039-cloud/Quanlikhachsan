using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public class MyDbContext : DbContext
    {
        public DbSet<KhachHang_DTO> KhachHangs { get; set; }
        public DbSet<Phong_DTO> Phongs { get; set; }
        public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }
        public DbSet<PhieuDatPhong_DTO> PhieuDatPhongs { get; set; }
        public DbSet<ChiTietDatPhong_DTO> ChiTietDatPhongs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HI\MSSQLSERVER01;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}