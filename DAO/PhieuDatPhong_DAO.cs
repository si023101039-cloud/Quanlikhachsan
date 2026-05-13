using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhong_DAO
    {
        private MyDbContext db = new MyDbContext();

        public List<PhieuDatPhong_View> GetAllPhieuDatPhong()
        {
            try
            {
                var data = (from pdp in db.PhieuDatPhong_Entities
                            join kh in db.KhachHang_Entities
                            on pdp.MaKH equals kh.MaKH
                            select new PhieuDatPhong_View
                            {
                                MaPhieuDatPhong = pdp.MaPhieuDatPhong,
                                MaKH = pdp.MaKH,
                                TenKH = kh.TenKH,
                                MaNV = pdp.MaNV,
                                NgayDat = pdp.NgayDat,
                                NgayNhan = pdp.NgayNhan,
                                NgayTra = pdp.NgayTra,
                                TrangThaiPhieu = pdp.TrangThaiPhieu,
                                GhiChu = pdp.GhiChu
                            }).ToList();

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return new List<PhieuDatPhong_View>();
            }
        }

        // TRẢ PHÒNG
        public bool TraPhong(int maPhieuDatPhong)
        {
            try
            {
                var phieu = db.PhieuDatPhong_Entities
                              .Find(maPhieuDatPhong);

                if (phieu != null)
                {
                    phieu.TrangThaiPhieu = false;

                    db.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        // CẬP NHẬT TRẠNG THÁI PHÒNG
        public bool CapNhatTrangThaiPhong()
        {
            try
            {
                var danhSachPhong = db.Phong_Entities.ToList();

                foreach (var phong in danhSachPhong)
                {
                    bool dangSuDung =
                        db.ChiTietDatPhong_Entities.Any(ct =>
                            ct.MaPhong == phong.MaPhong &&
                            ct.NgayCheckOutThucTe == null);

                    phong.TrangThai = dangSuDung;
                }

                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        // xem lịch sử đặt phòng
        public List<LichSuDatPhong_DTO> LayTatCaLichSu()
        {
            var result = from nv in db.NhanVien_Entities
                         from pdp in db.PhieuDatPhong_Entities
                         from kh in db.KhachHang_Entities
                         where nv.MaNV == pdp.MaNV && pdp.MaKH == kh.MaKH
                         select new LichSuDatPhong_DTO
                         {
                             MaPhieuDatPhong = pdp.MaPhieuDatPhong,
                             TenNV = nv.HoTen,
                             TenKhachHang = kh.TenKH,
                             NgayDat = pdp.NgayDat,
                             NgayCheckIn = pdp.NgayNhan,
                             NgayCheckOut = pdp.NgayTra,
                         };

            return result.ToList();
        }
    }
}