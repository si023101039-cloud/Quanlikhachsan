using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.GUI
{
    public partial class frm_dangnhap : Form
    {
        private TaiKhoan_BUS taiKhoan_BUS = new TaiKhoan_BUS();

        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            TaiKhoan_BUS bus = new TaiKhoan_BUS();
            TaiKhoan_DTO? userLogin = bus.Login(user, pass);

            if (userLogin != null)
            {
                Session session = new Session
                {
                    MaNV = userLogin.MaNV ?? 0,
                    TenDangNhap = userLogin.TenDangNhap,
                    VaiTro = userLogin.VaiTro,
                    HoTen = userLogin.NhanVien?.HoTen ?? "Người dùng"
                };

                MessageBox.Show($"Chào mừng {session.HoTen} đã đăng nhập!", "Thành công");

                frm_main frm = new frm_main(session);

                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
