using System;
using System.Linq;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhong_DAO
    {
        MyDbContext db = new MyDbContext();

        public object LayTatCaPhieu()
        {
            return (from p in db.PhieuDatPhongs
                    join k in db.KhachHangs on p.MaKH equals k.MaKH
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

        public object LayDanhSachPhong()
        {
            return (from p in db.Phongs
                    join lp in db.LoaiPhong_Entities
                    on p.MaLoaiPhong equals lp.MaLoaiPhong
                    select new
                    {
                        p.MaPhong,
                        p.TenPhong,
                        lp.TenLoaiPhong,
                        lp.GiaTheoNgay,
                        p.TrangThai
                    }).ToList();
        }

        public object LayDanhSachPhongTrong()
        {
            return (from p in db.Phongs
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
            return (from ct in db.ChiTietDatPhongs
                    join p in db.Phongs
                    on ct.MaPhong equals p.MaPhong
                    where ct.MaPhieuDatPhong == maPhieu
                    select new
                    {
                        ct.MaDatPhongCT,
                        ct.MaPhieuDatPhong,
                        p.TenPhong,
                        ct.DonGia,
                        ct.NgayCheckInThucTe,
                        ct.NgayCheckOutThucTe
                    }).ToList();
        }

        public bool DatPhong(string tenKH, DateTime ngayDat, DateTime ngayNhan,
                     DateTime ngayTra, string ghiChu, int maPhong, bool trangThai)
        {
            try
            {
                var phong = db.Phongs.FirstOrDefault(x => x.MaPhong == maPhong);

                if (phong == null)
                    return false;

                if (phong.TrangThai == true)
                    return false;

                if (string.IsNullOrWhiteSpace(tenKH))
                    return false;

                if (ngayNhan >= ngayTra)
                    return false;

                KhachHang_DTO khach = new KhachHang_DTO();
                khach.TenKH = tenKH.Trim();
                khach.SDT = "";
                khach.Email = "";
                khach.GioiTinh = null;
                khach.CCCD = "KH" + DateTime.Now.Ticks.ToString();

                db.KhachHangs.Add(khach);
                db.SaveChanges();

                decimal gia = 0;

                var loaiPhong = db.LoaiPhong_Entities
                    .FirstOrDefault(x => x.MaLoaiPhong == phong.MaLoaiPhong);

                if (loaiPhong != null)
                {
                    gia = loaiPhong.GiaTheoNgay;
                }

                PhieuDatPhong_DTO phieu = new PhieuDatPhong_DTO();
                phieu.MaKH = khach.MaKH;
                phieu.MaNV = 1;
                phieu.NgayDat = ngayDat;
                phieu.NgayNhan = ngayNhan;
                phieu.NgayTra = ngayTra;
                phieu.TrangThaiPhieu = trangThai;
                phieu.GhiChu = ghiChu;

                db.PhieuDatPhongs.Add(phieu);
                db.SaveChanges();

                ChiTietDatPhong_DTO ct = new ChiTietDatPhong_DTO();
                ct.MaPhieuDatPhong = phieu.MaPhieuDatPhong;
                ct.MaPhong = maPhong;
                ct.DonGia = gia;
                ct.NgayCheckInThucTe = ngayNhan;
                ct.NgayCheckOutThucTe = null;

                db.ChiTietDatPhongs.Add(ct);

                phong.TrangThai = true;

                db.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}