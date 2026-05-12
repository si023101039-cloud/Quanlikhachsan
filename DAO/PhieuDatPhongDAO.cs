using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhongDAO
    {
        MyDbContext db = new MyDbContext();

        public List<PhieuDatPhongDTO> LayTatCaPhieu()
        {
            return db.PhieuDatPhongs.ToList();
        }

        public List<ChiTietDatPhongDTO> LayChiTietTheoMa(int maPhieu)
        {
            return db.ChiTietDatPhongs.Where(ct => ct.MaPhieuDatPhong == maPhieu).ToList();
        }

        public List<PhongDTO> TimPhongTrong(DateTime nhan, DateTime tra)
        {
            var phongBan = from p in db.PhieuDatPhongs
                           join ct in db.ChiTietDatPhongs on p.MaPhieuDatPhong equals ct.MaPhieuDatPhong
                           where p.TrangThaiPhieu == true
                           where !(p.NgayTra <= nhan || p.NgayNhan >= tra)
                           select ct.MaPhong;

            return db.Phongs.Where(ph => !phongBan.Contains(ph.MaPhong)).ToList();
        }

        public bool LuuDatPhong(PhieuDatPhongDTO phieu, int maPhong, decimal gia)
        {
            try
            {
                db.PhieuDatPhongs.Add(phieu);
                db.SaveChanges();

                ChiTietDatPhongDTO ct = new ChiTietDatPhongDTO
                {
                    MaPhieuDatPhong = phieu.MaPhieuDatPhong,
                    MaPhong = maPhong,
                    DonGia = gia
                };

                db.ChiTietDatPhongs.Add(ct);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}