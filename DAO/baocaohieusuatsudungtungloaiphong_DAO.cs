using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class baocaohieusuatsudungtungloaiphong_DAO
    {
        private MyDbContext db = new MyDbContext();
        public List<baocaohieusuatsudungtungloaiphong_DTO> LayHieuSuatLoaiPhong(int thang, int nam)
        {
            int soNgayTrongThang = DateTime.DaysInMonth(nam, thang);

            var danhSachLoaiPhong = db.LoaiPhong_Entities.ToList();

            var query = from lp in db.LoaiPhong_Entities
                        let phongThuocLoai = db.Phong_Entities.Where(p => p.MaLoaiPhong == lp.MaLoaiPhong)
                        let chiTietThue = (from ctdp in db.ChiTietDatPhong_Entities
                                           join p in db.Phong_Entities on ctdp.MaPhong equals p.MaPhong
                                           where p.MaLoaiPhong == lp.MaLoaiPhong
                                              && ctdp.NgayCheckOutThucTe != null
                                              && ctdp.NgayCheckInThucTe.Value.Month == thang
                                              && ctdp.NgayCheckInThucTe.Value.Year == nam
                                           select ctdp)
                        select new baocaohieusuatsudungtungloaiphong_DTO
                        {
                            TenLoaiPhong = lp.TenLoaiPhong,
                            TongSoPhong = phongThuocLoai.Count(),
                            SoNgayThueThucTe = chiTietThue.Count(),
                            TongSoNgayKhaDung = phongThuocLoai.Count() * soNgayTrongThang,
                            DoanhThuLoaiPhong = chiTietThue.Sum(x => (decimal?)x.DonGia) ?? 0
                        };

            return query.ToList();
        }
    }
}
