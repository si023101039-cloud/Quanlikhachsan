using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System.Collections.Generic;

namespace QuanLyKhachSan.BUS
{
    public class DichVu_BUS
    {
        private DichVu_DAO dichVu_DAO = new DichVu_DAO();

        public List<DichVu_DTO> GetAllDichVu()
        {
            return dichVu_DAO.GetAllDichVu();
        }
    }

    public class ChiTietDichVu_BUS
    {
        private ChiTietDichVu_DAO chiTietDichVu_DAO = new ChiTietDichVu_DAO();

        public List<ChiTietDichVu_View> GetDichVuByPhong(int maPhong)
        {
            return chiTietDichVu_DAO.GetDichVuByPhong(maPhong);
        }

        public bool Insert(ChiTietDichVu_DTO ctdv)
        {
            return chiTietDichVu_DAO.Insert(ctdv);
        }

        public bool Update(ChiTietDichVu_DTO ctdv)
        {
            if (ctdv.SoLuong <= 0) return false;
            return chiTietDichVu_DAO.Update(ctdv);
        }

        public bool Delete(int maCTDV)
        {
            return chiTietDichVu_DAO.Delete(maCTDV);
        }

        // THÊM MỚI: Cầu nối gọi xuống DAO để sửa lỗi CS1061
        public int? LayMaDatPhongCT_HienTai(int maPhong)
        {
            return chiTietDichVu_DAO.LayMaDatPhongCT_HienTai(maPhong);
        }
    }
}