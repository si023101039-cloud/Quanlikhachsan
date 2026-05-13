using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhong_BUS
    {
        private PhieuDatPhong_DAO phieuDatPhong_DAO
            = new PhieuDatPhong_DAO();

        public List<PhieuDatPhong_View> GetAllPhieuDatPhong()
        {
            return phieuDatPhong_DAO.GetAllPhieuDatPhong();
        }

        public bool TraPhong(int maPhieuDatPhong)
        {
            return phieuDatPhong_DAO.TraPhong(maPhieuDatPhong);
        }

        public bool CapNhatTrangThaiPhong()
        {
            return phieuDatPhong_DAO.CapNhatTrangThaiPhong();
        }
        public List<LichSuDatPhong_DTO> LayTatCaLichSu()
        {
            return phieuDatPhong_DAO.LayTatCaLichSu();
        }
    }
}
