using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DAO
{
    public class DichVu_DAO
    {
        private MyDbContext db = new MyDbContext();

        public List<DichVu_DTO> GetAllDichVu()
        {
           
            return db.DichVu_Entities.Where(dv => dv.TrangThai == true).ToList();
        }
    }

    public class ChiTietDichVu_DAO
    {
        private MyDbContext db = new MyDbContext();

       
        public int? LayMaDatPhongCT_HienTai(int maPhong)
        {
            var chiTiet = db.ChiTietDatPhong_Entities
                            .FirstOrDefault(c => c.MaPhong == maPhong && c.NgayCheckOutThucTe == null);

            if (chiTiet != null)
            {
                return chiTiet.MaDatPhongCT;
            }
            return null; 
        }

        public List<ChiTietDichVu_View> GetDichVuByPhong(int maPhong)
        {
            try
            {
                var data = (from ctdv in db.ChiTietDichVu_Entities
                            join dv in db.DichVu_Entities on ctdv.MaDichVu equals dv.MaDichVu
                            join ctdp in db.ChiTietDatPhong_Entities on ctdv.MaDatPhongCT equals ctdp.MaDatPhongCT
                            join p in db.Phong_Entities on ctdp.MaPhong equals p.MaPhong
                            where ctdp.MaPhong == maPhong && ctdp.NgayCheckOutThucTe == null
                            select new ChiTietDichVu_View
                            {
                                MaCTDV = ctdv.MaCTDV,
                                TenPhong = p.TenPhong,
                                TenDichVu = dv.TenDichVu,
                                SoLuong = ctdv.SoLuong,
                                DonGia = ctdv.DonGiaThoiDiemBan,
                                ThoiDiemSuDung = ctdv.ThoiDiemSuDung
                            }).ToList();
                return data;
            }
            catch (Exception)
            {
                return new List<ChiTietDichVu_View>();
            }
        }

        public bool Insert(ChiTietDichVu_DTO ctdv)
        {
            try
            {
                db.ChiTietDichVu_Entities.Add(ctdv);
                return db.SaveChange() > 0;
            }
            catch { return false; }
        }

        public bool Update(ChiTietDichVu_DTO ctdv)
        {
            try
            {
                var target = db.ChiTietDichVu_Entities.Find(ctdv.MaCTDV);
                if (target != null)
                {
                    target.MaDichVu = ctdv.MaDichVu;
                    target.SoLuong = ctdv.SoLuong;
                    target.DonGiaThoiDiemBan = ctdv.DonGiaThoiDiemBan;
                    target.ThoiDiemSuDung = ctdv.ThoiDiemSuDung;
                    return db.SaveChanges() > 0;
                }
                return false;
            }
            catch { return false; }
        }

        public bool Delete(int maCTDV)
        {
            try
            {
                var target = db.ChiTietDichVu_Entities.Find(maCTDV);
                if (target != null)
                {
                    db.ChiTietDichVu_Entities.Remove(target);
                    return db.SaveChanges() > 0;
                }
                return false;
            }
            catch { return false; }
        }
    }
}