using System;
using System.Linq;
using QuanLyKhachSan.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhong_DAO
    {
        MyDbContext db = new MyDbContext();

        public object LayTatCaPhieu()
        {
            try
            {
                return (from p in db.PhieuDatPhong_Entities
                        join k in db.KhachHang_Entities on p.MaKH equals k.MaKH
                        select new
                        {
                            p.MaPhieuDatPhong,
                            k.TenKH,
                            p.NgayDat,
                            p.NgayNhan,
                            p.NgayTra,
                            p.TrangThaiPhieu,
                            p.GhiChu
                        }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return new List<object>();
            }
        }

        public object LayDanhSachPhong()
        {
            return (from p in db.Phong_Entities
                    join lp in db.LoaiPhong_Entities
                    on p.MaLoaiPhong equals lp.MaLoaiPhong
                    select new
                    {
                        p.MaPhong,
                        p.TenPhong,
                        lp.TenLoaiPhong,
                        GiaTheoNgay = string.Format("{0:N0} VNĐ", lp.GiaTheoNgay),
                        p.TrangThai
                    }).ToList();
        }

        public object LayDanhSachPhongTrong()
        {
            return (from p in db.Phong_Entities
                    join lp in db.LoaiPhong_Entities
                    on p.MaLoaiPhong equals lp.MaLoaiPhong
                    where p.TrangThai == false
                    select new
                    {
                        p.MaPhong,
                        p.TenPhong
                    }).ToList();
        }

        public object LayChiTietTheoMa(int maPhieu)
        {
            return (from ct in db.ChiTietDatPhong_Entities
                    join p in db.Phong_Entities
                    on ct.MaPhong equals p.MaPhong
                    where ct.MaPhieuDatPhong == maPhieu
                    select new
                    {
                        ct.MaDatPhongCT,
                        ct.MaPhieuDatPhong,
                        p.TenPhong,
                        DonGia = string.Format("{0:N0} VNĐ", ct.DonGia),
                        ct.NgayCheckInThucTe,
                        ct.NgayCheckOutThucTe
                    }).ToList();
        }

        public bool DatPhong(string tenKH, DateTime ngayDat, DateTime ngayNhan,
                     DateTime ngayTra, string ghiChu, int maPhong, bool trangThai)
        {
            try
            {
                var phong = db.Phong_Entities.FirstOrDefault(x => x.MaPhong == maPhong);

                if (phong == null || phong.TrangThai == true || string.IsNullOrWhiteSpace(tenKH) || ngayNhan >= ngayTra)
                    return false;

                KhachHang_DTO khach = new KhachHang_DTO();
                khach.TenKH = tenKH.Trim();
                khach.SDT = "";
                khach.Email = "";
                khach.GioiTinh = null;
                khach.CCCD = "KH" + DateTime.Now.Ticks.ToString();

                db.KhachHang_Entities.Add(khach);
                db.SaveChanges(); 

                decimal gia = 0;
                var loaiPhong = db.LoaiPhong_Entities.FirstOrDefault(x => x.MaLoaiPhong == phong.MaLoaiPhong);
                if (loaiPhong != null) gia = loaiPhong.GiaTheoNgay;

                PhieuDatPhong_DTO phieu = new PhieuDatPhong_DTO();
                phieu.MaKH = khach.MaKH;
                phieu.MaNV = 3;
                phieu.NgayDat = ngayDat;
                phieu.NgayNhan = ngayNhan;
                phieu.NgayTra = ngayTra;
                phieu.TrangThaiPhieu = trangThai;
                phieu.GhiChu = ghiChu;

                db.PhieuDatPhong_Entities.Add(phieu);
                db.SaveChanges(); 

                ChiTietDatPhong_DTO ct = new ChiTietDatPhong_DTO();
                ct.MaPhieuDatPhong = phieu.MaPhieuDatPhong;
                ct.MaPhong = maPhong;
                ct.DonGia = gia;
                ct.NgayCheckInThucTe = ngayNhan;
                ct.NgayCheckOutThucTe = null;

                db.ChiTietDatPhong_Entities.Add(ct);

                phong.TrangThai = true; 

                db.SaveChanges(); 
                return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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