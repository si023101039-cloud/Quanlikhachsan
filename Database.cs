using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using QuanLyKhachSan.DTO;

public class MyDbContext : DbContext
{
    public  DbSet<DTOQlyphong> Phong_Entities { get; set; }
    public DbSet<TaiKhoan_DTO> TaiKhoan_Entities { get; set; }
    public DbSet<NhanVien_DTO> NhanVien_Entities { get; set; }
    public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-HGT6EFA7\SQLEXPRESS;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}