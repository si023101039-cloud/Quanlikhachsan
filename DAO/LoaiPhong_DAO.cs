using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class LoaiPhong_DAO
    {
        private MyDbContext db = new MyDbContext();
        public List<LoaiPhong_DTO> GetAllLoaiPhong()
        {
            try
            {
                return db.LoaiPhong_Entities.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return new List<LoaiPhong_DTO>();
            }
        }
        public bool InsertLoaiPhong(LoaiPhong_DTO loaiPhong)
        {
            try
            {
                db.LoaiPhong_Entities.Add(loaiPhong);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool UpdateLoaiPhong(LoaiPhong_DTO loaiPhong)
        {
            try
            {
                var phong = db.LoaiPhong_Entities.Find(loaiPhong.MaLoaiPhong);
                if (phong != null)
                {
                    phong.TenLoaiPhong = loaiPhong.TenLoaiPhong;
                    phong.GiaTheoNgay = loaiPhong.GiaTheoNgay;
                    phong.SoNguoiToiDa = loaiPhong.SoNguoiToiDa;
                    phong.MoTa = loaiPhong.MoTa;
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
        public bool DeleteLoaiPhong(int maLoaiPhong)
        {
            try
            {
                var phong = db.LoaiPhong_Entities.Find(maLoaiPhong);
                if (phong != null)
                {
                    db.LoaiPhong_Entities.Remove(phong);
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
    }
}
