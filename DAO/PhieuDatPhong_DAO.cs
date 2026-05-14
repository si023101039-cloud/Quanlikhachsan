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

        public List<object> LayTatCaPhieu()
        {
            return (from p in db.PhieuDatPhong_Entities
                    join k in db.KhachHang_Entities
                    on p.MaKH equals k.MaKH
                    select new
                    {
                        p.MaPhieuDatPhong,
                        k.TenKH,
                        NgayDat = p.NgayDat ?? DateTime.Now,
                        NgayNhan = p.NgayNhan ?? DateTime.Now,
                        NgayTra = p.NgayTra ?? DateTime.Now,
                        TrangThaiPhieu = p.TrangThaiPhieu ?? false,
                        p.GhiChu
                    }).ToList<object>();
        }

        public List<object> LayDanhSachPhong()
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
                        TrangThai = p.TrangThai ?? false
                    }).ToList<object>();
        }

        public List<object> LayDanhSachPhongTrong()
        {
            return (from p in db.Phong_Entities
                    join lp in db.LoaiPhong_Entities
                    on p.MaLoaiPhong equals lp.MaLoaiPhong
                    where p.TrangThai == false
                    select new
                    {
                        p.MaPhong,
                        p.TenPhong
                    }).ToList<object>();
        }

        public List<object> LayChiTietTheoMa(int maPhieu)
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
                    }).ToList<object>();
        }

        public bool DatPhong(string tenKH, DateTime ngayDat, DateTime ngayNhan,
                      DateTime ngayTra, string ghiChu, int maPhong, bool trangThai)
        {
            try
            {
                var phong = db.Phong_Entities.FirstOrDefault(x => x.MaPhong == maPhong);

                if (phong == null) return false;
                if (phong.TrangThai == true) return false;
                if (string.IsNullOrWhiteSpace(tenKH)) return false;
                if (ngayNhan >= ngayTra) return false;

                var khach = new KhachHang_DTO
                {
                    TenKH = tenKH.Trim(),
                    SDT = "",
                    Email = "",
                    GioiTinh = null,
                    CCCD = "KH" + DateTime.Now.Ticks
                };

                db.KhachHang_Entities.Add(khach);
                db.SaveChanges();

                var loaiPhong = db.LoaiPhong_Entities.FirstOrDefault(x => x.MaLoaiPhong == phong.MaLoaiPhong);

                decimal gia = loaiPhong?.GiaTheoNgay ?? 0;

                var phieu = new PhieuDatPhong_DTO
                {
                    MaKH = khach.MaKH,
                    MaNV = 1,
                    NgayDat = ngayDat,
                    NgayNhan = ngayNhan,
                    NgayTra = ngayTra,

                    TrangThaiPhieu = trangThai,

                    GhiChu = ghiChu
                };

                db.PhieuDatPhong_Entities.Add(phieu);
                db.SaveChanges();

                var ct = new ChiTietDatPhong_DTO
                {
                    MaPhieuDatPhong = phieu.MaPhieuDatPhong,
                    MaPhong = maPhong,
                    DonGia = gia,
                    NgayCheckInThucTe = ngayNhan,
                    NgayCheckOutThucTe = null
                };

                db.ChiTietDatPhong_Entities.Add(ct);

                phong.TrangThai = true;

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<PhieuDatPhong_View> GetAllPhieuDatPhong()
        {
            return (from pdp in db.PhieuDatPhong_Entities
                    join kh in db.KhachHang_Entities
                    on pdp.MaKH equals kh.MaKH
                    select new PhieuDatPhong_View
                    {
                        MaPhieuDatPhong = pdp.MaPhieuDatPhong,
                        MaKH = kh.MaKH,
                        TenKH = kh.TenKH,
                        MaNV = pdp.MaNV ?? 0,
                        NgayDat = pdp.NgayDat ?? DateTime.Now,
                        NgayNhan = pdp.NgayNhan ?? DateTime.Now,
                        NgayTra = pdp.NgayTra ?? DateTime.Now,
                        TrangThaiPhieu = pdp.TrangThaiPhieu ?? false,
                        GhiChu = pdp.GhiChu ?? ""
                    }).ToList();
        }

        public bool TraPhong(int maPhieuDatPhong)
        {
            var phieu = db.PhieuDatPhong_Entities.Find(maPhieuDatPhong);
            if (phieu == null) return false;

            phieu.TrangThaiPhieu = false;

            var ct = db.ChiTietDatPhong_Entities
                .FirstOrDefault(x => x.MaPhieuDatPhong == maPhieuDatPhong);

            if (ct != null)
            {
                var phong = db.Phong_Entities.FirstOrDefault(p => p.MaPhong == ct.MaPhong);
                if (phong != null) phong.TrangThai = false;

                ct.NgayCheckOutThucTe = DateTime.Now;
            }

            db.SaveChanges();
            return true;
        }

        public bool CapNhatTrangThaiPhong()
        {
            try
            {
                var danhSachPhong = db.Phong_Entities.ToList();

                foreach (var phong in danhSachPhong)
                {
                    bool dangSuDung =
                        (from ct in db.ChiTietDatPhong_Entities
                         join pdp in db.PhieuDatPhong_Entities
                         on ct.MaPhieuDatPhong equals pdp.MaPhieuDatPhong
                         where ct.MaPhong == phong.MaPhong
                         && pdp.TrangThaiPhieu == true
                         && pdp.NgayNhan <= DateTime.Now
                         && pdp.NgayTra >= DateTime.Now
                         select ct).Any();

                    phong.TrangThai = dangSuDung;
                }

                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LichSuDatPhong_DTO> LayTatCaLichSu()
        {
            return (from nv in db.NhanVien_Entities
                    from pdp in db.PhieuDatPhong_Entities
                    from kh in db.KhachHang_Entities
                    where nv.MaNV == pdp.MaNV && pdp.MaKH == kh.MaKH
                    select new LichSuDatPhong_DTO
                    {
                        MaPhieuDatPhong = pdp.MaPhieuDatPhong,
                        TenNV = nv.HoTen,
                        TenKhachHang = kh.TenKH,
                        NgayDat = pdp.NgayDat ?? DateTime.Now,
                        NgayCheckIn = pdp.NgayNhan ?? DateTime.Now,
                        NgayCheckOut = pdp.NgayTra ?? DateTime.Now
                    }).ToList();
        }
        public List<dynamic> LayDuLieuDoanhThu()
        {
            using (var db = new MyDbContext())
            {
                return (from ct in db.ChiTietDatPhong_Entities
                        join p in db.PhieuDatPhong_Entities on ct.MaPhieuDatPhong equals p.MaPhieuDatPhong
                        where p.NgayDat != null
                        group ct by p.NgayDat.Value.Month into g
                        select new
                        {
                            Thang = "T" + g.Key,
                            TongTien = (double)g.Sum(x => x.DonGia)
                        }).ToList<dynamic>();
            }
        }
    }
}