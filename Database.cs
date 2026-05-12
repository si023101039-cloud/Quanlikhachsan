using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public class MyDbContext : DbContext
    {
        public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }
        public virtual DbSet<PhongDTO> Phongs { get; set; }
        public virtual DbSet<PhieuDatPhongDTO> PhieuDatPhongs { get; set; }
        public virtual DbSet<ChiTietDatPhongDTO> ChiTietDatPhongs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HI\MSSQLSERVER01;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}