using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DAO
{
    public class ThanhToanDAO
    {
        private MyDbContext db = new MyDbContext();

        public ThanhToanView LayDuLieuThanhToan(int maPhieu)
        {
            var view = new ThanhToanView();

            var phieu = db.PhieuDatPhong_Entities.FirstOrDefault(p => p.MaPhieuDatPhong == maPhieu);
            if (phieu != null)
            {
                var nv = db.NhanVien_Entities.Find(phieu.MaNV);
                view.TenNhanVien = nv?.HoTen ?? "N/A";
            }

            view.TongTienPhong = db.ChiTietDatPhong_Entities
                                   .Where(ct => ct.MaPhieuDatPhong == maPhieu)
                                   .Sum(ct => (decimal?)ct.DonGia) ?? 0;

            
            view.TongTienDichVu = (from ctdv in db.ChiTietDichVu_Entities
                                   from ctdp in db.ChiTietDatPhong_Entities
                                   where ctdv.MaDatPhongCT == ctdp.MaDatPhongCT 
                                      && ctdp.MaPhieuDatPhong == maPhieu      
                                   select (decimal?)(ctdv.SoLuong * ctdv.DonGiaThoiDiemBan)).Sum() ?? 0;

            return view;
        }

        public bool LuuHoaDon(ThanhToanDTO hd)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.HoaDon_Entities.Add(hd);

                    var danhSachChiTiet = db.ChiTietDatPhong_Entities
                                            .Where(ct => ct.MaPhieuDatPhong == hd.MaPhieuDatPhong && ct.NgayCheckOutThucTe == null)
                                            .ToList();

                    foreach (var item in danhSachChiTiet)
                    {
                        item.NgayCheckOutThucTe = hd.NgayThanhToan;

                        var phong = db.Phong_Entities.Find(item.MaPhong);
                        if (phong != null)
                        {
                            phong.TrangThai = false;
                        }
                    }

                    db.SaveChanges();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Lỗi thanh toán: " + ex.Message);
                    return false;
                }
            }
        }

        public List<ChiTietExcelView> LayChiTietHoaDonChoExcel(int maPhieu)
        {
            
            var result = (from ctdv in db.ChiTietDichVu_Entities
                          from dv in db.DichVu_Entities
                          from ctdp in db.ChiTietDatPhong_Entities
                          where ctdv.MaDichVu == dv.MaDichVu               
                             && ctdv.MaDatPhongCT == ctdp.MaDatPhongCT     
                             && ctdp.MaPhieuDatPhong == maPhieu            
                          select new ChiTietExcelView
                          {
                              TenDichVu = dv.TenDichVu,
                              SoLuong = ctdv.SoLuong,
                              DonGia = ctdv.DonGiaThoiDiemBan,
                              ThanhTien = ctdv.SoLuong * ctdv.DonGiaThoiDiemBan
                          }).ToList();

            return result;
        }
    }
}