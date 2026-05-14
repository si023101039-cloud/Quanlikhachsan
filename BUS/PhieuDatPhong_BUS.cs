using QuanLyKhachSan.DAO;
using System;
using QuanLyKhachSan.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhong_BUS
    {
        PhieuDatPhong_DAO phieuDatPhong_DAO = new PhieuDatPhong_DAO();

        public object LayTatCaPhieu()
        {
            return phieuDatPhong_DAO.LayTatCaPhieu();
        }

        public object LayChiTietTheoMa(int ma)
        {
            return phieuDatPhong_DAO.LayChiTietTheoMa(ma);
        }

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

        public bool TrangThaiDangThue(bool check)
        {
            return check;
        }

        public bool TrangThaiDaTra(bool check)
        {
            return !check;
        }
    }
}