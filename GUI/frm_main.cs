using QuanLyKhachSan.GUI;

namespace QuanLyKhachSan
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        public void btnQuanLyDichVu_Click(object sender, EventArgs e)
        {
            UCQuanLyDichVu frm = new UCQuanLyDichVu();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            lblpage.Text = "Trang chủ > " + "Quản Lý Dịch Vụ";
            btnQuanLyPhong.BackColor = Color.Orange;
            btnQuanLyLoaiPhong.BackColor = Color.Orange;
            btnQuanLyDatPhong.BackColor = Color.Orange;
            btnQuanLyDichVu.BackColor = Color.Chocolate;
            btnQuanLyBaoCao.BackColor = Color.Orange;
        }
        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            UCQuanLyPhong uc = new UCQuanLyPhong();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            btnQuanLyPhong.BackColor = Color.Chocolate;
            btnQuanLyLoaiPhong.BackColor = Color.Orange;
            btnQuanLyDatPhong.BackColor = Color.Orange;
            btnQuanLyDichVu.BackColor = Color.Orange;
            btnQuanLyBaoCao.BackColor = Color.Orange;

            lblpage.Text = "Trang chủ > " + "Quản Lý Phòng";
        }
        private void btnQuanLyDatPhong_Click(object sender, EventArgs e)
        {
            UCQuanLyDatPhong uc = new UCQuanLyDatPhong();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);

            lblpage.Text = "Trang chủ > " + "Quản Lý Đặt Phòng";
            btnQuanLyPhong.BackColor = Color.Orange;
            btnQuanLyLoaiPhong.BackColor = Color.Orange;
            btnQuanLyDatPhong.BackColor = Color.Chocolate;
            btnQuanLyDichVu.BackColor = Color.Orange;
            btnQuanLyBaoCao.BackColor = Color.Orange;
        }

        private void btnQuanLyLoaiPhong_Click(object sender, EventArgs e)
        {
            lblpage.Text = "Trang chủ > " + "Quản Lý Loại Phòng";
            btnQuanLyPhong.BackColor = Color.Orange;
            btnQuanLyLoaiPhong.BackColor = Color.Chocolate;
            btnQuanLyDatPhong.BackColor = Color.Orange;
            btnQuanLyDichVu.BackColor = Color.Orange;
            btnQuanLyBaoCao.BackColor = Color.Orange;

            UCQuanLyLoaiPhong uc = new UCQuanLyLoaiPhong();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void btnQuanLyBaoCao_Click(object sender, EventArgs e)
        {
            lblpage.Text = "Trang chủ > " + "Quản Lý Báo Cáo";
            btnQuanLyPhong.BackColor = Color.Orange;
            btnQuanLyLoaiPhong.BackColor = Color.Orange;
            btnQuanLyDatPhong.BackColor = Color.Orange;
            btnQuanLyDichVu.BackColor = Color.Orange;
            btnQuanLyBaoCao.BackColor = Color.Chocolate;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            UCQuanLyPhong uc = new UCQuanLyPhong();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
            lblpage.Text = "Trang chủ ";
        }
    }
}
