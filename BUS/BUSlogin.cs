using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class TaiKhoan_BUS
    {
        private TaiKhoan_DAO taiKhoan_DAO = new TaiKhoan_DAO();

        public TaiKhoan_DTO? Login(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                return null;
            }

            return taiKhoan_DAO.KiemTraDangNhap(user, pass);
        }
    }
}
