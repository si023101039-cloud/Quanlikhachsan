using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUSQlyphong
    {
        private DAOQlyphong dao = new DAOQlyphong();

        public List<DTOQlyphong> LayTatCaPhong()
        {
            return dao.GetAll();
        }

        public bool ThemPhong(DTOQlyphong p)
        {
            // Có thể thêm logic kiểm tra tên phòng không được trùng ở đây
            return dao.Insert(p);
        }

        public bool SuaPhong(DTOQlyphong p)
        {
            return dao.Update(p);
        }

        public bool XoaPhong(int id)
        {
            return dao.Delete(id);
        }

        public List<DTOQlyphong> TimKiemPhong(string keyword)
        {
            if (string.IsNullOrEmpty(keyword)) return dao.GetAll();
            return dao.Search(keyword);
        }
    }
}
