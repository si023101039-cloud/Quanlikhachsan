using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QuanLyKhachSan.BUS
{
    public class PhieuDatPhongBUS
    {
        private PhieuDatPhongDAO dao = new PhieuDatPhongDAO();

        public List<PhieuDatPhongDTO> LayDSPhieu()
        {
            return dao.LayTatCaPhieu();
        }

        public List<ChiTietDatPhongDTO> LayDSChiTiet(int maPhieuDatPhong)
        {
            return dao.LayChiTietTheoMa(maPhieuDatPhong);
        }

        public List<PhongDTO> LayDSPhongTrong(DateTime ngayNhan, DateTime ngayTra)
        {
            return dao.TimPhongTrong(ngayNhan, ngayTra);
        }

        public string ThucHienDatPhong(PhieuDatPhongDTO p, int maPhong, string tenKhach, decimal gia)
        {
            if (string.IsNullOrWhiteSpace(tenKhach))
                return "Tên khách hàng không được để trống!";

            if (Regex.IsMatch(tenKhach, @"\d"))
                return "Lỗi: Tên khách hàng không được chứa chữ số!";

            if (p.NgayNhan < DateTime.Now.Date)
                return "Lỗi: Ngày nhận không được nhỏ hơn ngày hiện tại!";

            if (p.NgayNhan >= p.NgayTra)
                return "Lỗi: Ngày nhận phải nhỏ hơn ngày trả!";

            bool kq = dao.LuuDatPhong(p, maPhong, gia);

            if (kq)
                return "Thành công";

            return "Lỗi: Không thể lưu vào cơ sở dữ liệu!";
        }
    }
}