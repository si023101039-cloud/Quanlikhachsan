using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.BUS
{
    public class LoaiPhong_BUS
    {
        private LoaiPhong_DAO loaiPhong_DAO = new LoaiPhong_DAO();
        public List<LoaiPhong_DTO> GetAllLoaiPhong()
        {
            return loaiPhong_DAO.GetAllLoaiPhong();
        }
    }
}
