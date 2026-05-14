using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DAO
{
    public class baocaohieusuatsudungtungloaiphong_DAO
    {
        private MyDbContext db = new MyDbContext();

        public List<baocaohieusuatsudungtungloaiphong_DTO> LayHieuSuatLoaiPhong(int thang, int nam)
        {
            int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);

            var rawData = (from lp in db.LoaiPhong_Entities
                           select new
                           {
                               lp.TenLoaiPhong,
                               lp.MaLoaiPhong,
                               TongSoPhong = db.Phong_Entities.Count(p => p.MaLoaiPhong == lp.MaLoaiPhong),
                               ChiTietThue = db.ChiTietDatPhong_Entities
                                   .Join(db.Phong_Entities,
                                         ctdp => ctdp.MaPhong,
                                         p => p.MaPhong,
                                         (ctdp, p) => new { ctdp, p })
                                   .Where(x => x.p.MaLoaiPhong == lp.MaLoaiPhong
                                          && x.ctdp.NgayCheckOutThucTe != null
                                          && x.ctdp.NgayCheckInThucTe.Value.Month == thang
                                          && x.ctdp.NgayCheckInThucTe.Value.Year == nam)
                                   .Select(x => x.ctdp)
                                   .ToList() 
                           }).ToList();

            var result = rawData.Select(x => new baocaohieusuatsudungtungloaiphong_DTO
            {
                TenLoaiPhong = x.TenLoaiPhong,
                TongSoPhong = x.TongSoPhong,
                SoNgayThueThucTe = x.ChiTietThue.Count, 
                TongSoNgayKhaDung = x.TongSoPhong * soNgayTrongThang,
                DoanhThuLoaiPhong = x.ChiTietThue.Sum(ct => (decimal?)ct.DonGia) ?? 0
            }).ToList();

            return result;
        }
    }
}