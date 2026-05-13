using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TaiKhoan_DAO
    {
        private MyDbContext db = new MyDbContext();

        public TaiKhoan_DTO? KiemTraDangNhap(string user, string pass)
        {
            try
            {
                return db.TaiKhoan_Entities
                         .Include(tk => tk.NhanVien)
                         .FirstOrDefault(tk => tk.TenDangNhap == user&& tk.MatKhau == pass&& tk.TrangThai == true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
                return null;
            }
        }
    }
}
