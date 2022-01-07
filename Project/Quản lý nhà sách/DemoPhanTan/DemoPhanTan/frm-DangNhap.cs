using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;

namespace DemoPhanTan
{
    public partial class frm_DangNhap : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public String MaNV = "";
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhapSite frm = new frmDangNhapSite();
            frm.ShowDialog();
            TenDangNhap = frm.TenDangNhap;
            PassWord = frm.PassWord;
            MaSite = frm.MaSite;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User us = new User();
            User.TenDangNhap = TenDangNhap;
            User.MatKhau = PassWord;

            string PassCSDL= us.LayPassData(MaSite, txtUser.Text.Trim()).Trim();
            if (txtPass.Text.Trim() == PassCSDL.Trim())
            {
                //
                MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MaNV = txtUser.Text.ToString().Trim();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.Focus();
        }
    }
}
