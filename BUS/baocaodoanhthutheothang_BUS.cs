using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BaoCaoBUS
    {
        private BaoCaoDAO dao = new BaoCaoDAO();

        public BaoCaoExcelView GetFullBaoCao(int thang, int nam, string tenNhanVienDangNhap)
        {
            var data = dao.LayDuLieuBaoCaoChiTiet(thang, nam);
            data.NguoiLapBaoCao = tenNhanVienDangNhap;
            return data;
        }
    }
}
