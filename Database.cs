using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using QuanLyKhachSan.DTO;

public class MyDbContext : DbContext
{
    public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }
    public DbSet<PhieuDatPhong_DTO> PhieuDatPhong_Entities { get; set; }
    public DbSet<Phong_DTO> Phong_Entities { get; set; }

    public DbSet<ChiTietDatPhong_DTO> ChiTietDatPhong_Entities { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-3R4OQCCK;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;");
    }

}