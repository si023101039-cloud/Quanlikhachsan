using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;

namespace QuanLyKhachSan.GUI
{
    public partial class UCXemlichsudatphong : UserControl
    {
        private PhieuDatPhong_BUS phieuDatPhongBUS = new PhieuDatPhong_BUS();

        public UCXemlichsudatphong()
        {
            InitializeComponent();
        }

        private void UCXemlichsudatphong_Load(object sender, EventArgs e)
        {
            dgvLSDP.DataSource = phieuDatPhongBUS.LayTatCaLichSu();
            if (dgvLSDP.Rows.Count > 0)
            {
                dgvLSDP.Columns["MaPhieuDatPhong"].Visible = false;
            }
        }
    }
}
