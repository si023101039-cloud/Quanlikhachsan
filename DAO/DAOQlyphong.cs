using QuanLyKhachSan.DTO;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class DAOQlyphong
    {
        private MyDbContext db = new MyDbContext();

        public List<DTOQlyphong> GetAll()
        {
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message
            //}
            return db.Phong_Entities.Include(p => p.LoaiPhong).ToList();
        }

        public bool Insert(DTOQlyphong p)
        {
            try
            {
                db.Phong_Entities.Add(p);
                return db.SaveChanges() > 0;
            }
            catch { return false; }
        }

        public bool Update(DTOQlyphong p)
        {
            var target = db.Phong_Entities.Find(p.MaPhong);
            if (target != null)
            {
                target.TenPhong = p.TenPhong;
                target.MaLoaiPhong = p.MaLoaiPhong;
                target.Tang = p.Tang;
                target.TrangThai = p.TrangThai;
                target.MoTa = p.MoTa;
                target.GhiChu = p.GhiChu;
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var target = db.Phong_Entities.Find(id);
            if (target != null)
            {
                db.Phong_Entities.Remove(target);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<DTOQlyphong> Search(string keyword)
        {
            return db.Phong_Entities
                     .Include(p => p.LoaiPhong)
                     .Where(p => p.TenPhong.Contains(keyword))
                     .ToList();
        }
        public void CapNhatTenPhong()
        {
            var phong = db.Phong_Entities
                          .FirstOrDefault(p => p.TenPhong == "P305");

            if (phong != null)
            {
                phong.TenPhong = "P301";
                db.SaveChanges();
            }
        }
    }
}
