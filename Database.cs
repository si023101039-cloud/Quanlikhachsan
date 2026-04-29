using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using QuanLyKhachSan.DTO;

public class MyDbContext : DbContext
{
    public DbSet<LoaiPhong_DTO> LoaiPhong_Entities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Thay chuỗi kết nối của bạn vào đây
        optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS01;Database=Quanlikhachsan;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}