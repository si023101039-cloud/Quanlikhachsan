using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAO
{
    public class PhieuDatPhong_DAO
    {
        private MyDbContext db = new MyDbContext();

        // LẤY DANH SÁCH PHIẾU ĐẶT PHÒNG
        public List<PhieuDatPhong_DTO> GetAllPhieuDatPhong()
        {
            try
            {
                return db.PhieuDatPhong_Entities.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return new List<PhieuDatPhong_DTO>();
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}