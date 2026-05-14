using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class baocaohieusuatsudungtungloaiphong_BUS
    {
        private DAO.baocaohieusuatsudungtungloaiphong_DAO dao = new DAO.baocaohieusuatsudungtungloaiphong_DAO();
        public List<baocaohieusuatsudungtungloaiphong_DTO> ThongKeHieuSuat(int thang, int nam)
        {
            return dao.LayHieuSuatLoaiPhong(thang, nam);
        }
    }
}
