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
        public bool InsertLoaiPhong(LoaiPhong_DTO loaiPhong)
        {
            return loaiPhong_DAO.InsertLoaiPhong(loaiPhong);
        }
        public bool UpdateLoaiPhong(LoaiPhong_DTO loaiPhong)
        {
            return loaiPhong_DAO.UpdateLoaiPhong(loaiPhong);
        }
        public bool DeleteLoaiPhong(int maLoaiPhong)
        {
            return loaiPhong_DAO.DeleteLoaiPhong(maLoaiPhong);
        }
    }
}
