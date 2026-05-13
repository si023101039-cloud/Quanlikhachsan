using System.Collections.Generic;
using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.BUS
{
    public class ThanhToanBUS
    {
        private ThanhToanDAO dao = new ThanhToanDAO();

        public ThanhToanView LayThongTin(int maPhieu)
        {
            return dao.LayDuLieuThanhToan(maPhieu);
        }

        public bool ThucHienThanhToan(ThanhToanDTO hd)
        {
            // Kiểm tra phụ phí không được âm
            if (hd.PhuPhi < 0) return false;
            return dao.LuuHoaDon(hd);
        }

       
        public List<ChiTietExcelView> LayDuLieuExcel(int maPhieu)
        {
            return dao.LayChiTietHoaDonChoExcel(maPhieu);
        }
    }
}