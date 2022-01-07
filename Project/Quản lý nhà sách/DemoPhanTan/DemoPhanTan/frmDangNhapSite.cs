using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;

namespace DemoPhanTan
{
    public partial class frmDangNhapSite : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        //
        public frmDangNhapSite()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //
            Site st = new Site();
            DataSet dssite= st.LayTenSite();
            DataTable dtsite = new DataTable();
            dtsite = dssite.Tables[0];
            cbxSite.DataSource = dtsite;
            cbxSite.DisplayMember = "TenSite";
            cbxSite.ValueMember = "MaSite";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User us = new User();
            String PassCSDL = us.LayPass(txtUser.Text).Trim();
            String SiteCSDL = us.LayMaSite(txtUser.Text).Trim();
            if (txtPass.Text.Trim() == PassCSDL.Trim() && 
                cbxSite.SelectedValue.ToString().Trim() == SiteCSDL.Trim())
            {
                //lấy pass + tên user
                TenDangNhap = txtUser.Text.Trim();
                PassWord = txtPass.Text.Trim();
                MaSite = cbxSite.SelectedValue.ToString().Trim();
                //
                MessageBox.Show("Đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtUser.Text == "admin")
                {
                    frm_QuanLyDIC frm = new frm_QuanLyDIC();
                    frm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult traloi=MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }
    }
}
