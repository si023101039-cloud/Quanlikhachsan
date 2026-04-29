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
                Console.WriteLine("Lỗi: " + ex.Message);
                return new List<LoaiPhong_DTO>();
            }
        }
    }
}
