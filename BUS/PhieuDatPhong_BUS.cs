using QuanLyKhachSan.DAO;
using System;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhong_BUS
    {
        PhieuDatPhong_DAO dao = new PhieuDatPhong_DAO();

        public object LayTatCaPhieu()
        {
            return dao.LayTatCaPhieu();
        }

        public object LayChiTietTheoMa(int ma)
        {
            return dao.LayChiTietTheoMa(ma);
        }

       
    }
}