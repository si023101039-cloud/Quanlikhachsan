using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DAO
{
    public class BaoCaoDAO
    {
        private MyDbContext db = new MyDbContext();

        public BaoCaoExcelView LayDuLieuBaoCaoChiTiet(int thang, int nam)
        {
            var baoCao = new BaoCaoExcelView
            {
                Thang = thang,
                Nam = nam,
                NgayXuatBaoCao = DateTime.Now
            };

            var query = from hd in db.HoaDon_Entitiess
                        join pdp in db.PhieuDatPhong_Entities on hd.MaPhieuDatPhong equals pdp.MaPhieuDatPhong
                        join kh in db.KhachHang_Entities on pdp.MaKH equals kh.MaKH
                        where hd.NgayThanhToan.Month == thang && hd.NgayThanhToan.Year == nam
                        select new ChiTietDoanhThuThangDTO
                        {
                            MaHoaDon = hd.MaHoaDon,
                            NgayThanhToan = hd.NgayThanhToan,
                            TenKhachHang = kh.TenKH,
                            TienPhong = hd.TongTienPhong,
                            TienDichVu = hd.TongTienDichVu,
                            PhuPhi = hd.PhuPhi,
                            TongThanhToan = hd.TongTienPhong + hd.TongTienDichVu + hd.PhuPhi
                        };

            baoCao.DanhSachHoaDon = query.OrderBy(x => x.NgayThanhToan).ToList();
            return baoCao;
        }
    }
}