using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class TaiKhoan_DAO
    {
        private MyDbContext db = new MyDbContext();

        public TaiKhoan_DTO KiemTraDangNhap(string user, string pass)
        {
            try
            {
                var account = db.TaiKhoan_Entities
                                .Include(tk => tk.NhanVien)
                                .FirstOrDefault(tk => tk.TenDangNhap.Trim() == user.Trim()
                                                  && tk.MatKhau.Trim() == pass.Trim()
                                                  && tk.TrangThai == true);
                return account;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối Database: " + ex.Message);
                return null;
            }
        }
    }
}