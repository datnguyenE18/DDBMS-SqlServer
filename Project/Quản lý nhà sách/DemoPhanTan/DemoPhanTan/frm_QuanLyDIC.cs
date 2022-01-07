using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;

namespace DemoPhanTan
{
    public partial class frm_QuanLyDIC : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_QuanLyDIC()
        {
            InitializeComponent();
        }

        private void frm_QuanLyDIC_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            DDictionary DD = new DDictionary();
            DDictionary.TenDangNhap = TenDangNhap;
            DDictionary.MatKhau = PassWord;
            DDictionary.MaSite = MaSite;

            
            DataTable dtTK = DD.LayTaiKhoan().Tables[0];
            DataTable dtChiNhanh = DD.LayChiNhanh().Tables[0];
            
            ChiNhanh.DataSource = DD.LayChiNhanh().Tables[0];
            ChiNhanh.DisplayMember = "TenSite";
            ChiNhanh.ValueMember = "MaSite";
            dgvTaiKhoan.DataSource = DD.LayTaiKhoan().Tables[0];
            for (int i = 0; i < dgvTaiKhoan.Rows.Count-1; i++)
            {
                dgvTaiKhoan.Rows[i].Cells[2].Value = DD.LayTenQuyen(dgvTaiKhoan.Rows[i].Cells[2].Value.ToString());
            }
            cbbQuyen.DataSource = DD.LayDSQuyen().Tables[0];
            cbbQuyen.DisplayMember = "TenQuyen";
            cbbQuyen.ValueMember = "MaQuyen";
            cbbSite.DataSource = DD.LayDSSite().Tables[0];
            cbbSite.DisplayMember = "TenSite";
            cbbSite.ValueMember = "MaSite";
        }

        private void dgvTaiKhoan_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void dgvTaiKhoan_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DDictionary DD = new DDictionary();
            DDictionary.TenDangNhap = TenDangNhap;
            DDictionary.MatKhau = PassWord;
            DDictionary.MaSite = MaSite;

            int ind = dgvTaiKhoan.CurrentRow.Index;
            if (e.ColumnIndex == 3)
            {
                dgvTaiKhoan.Rows[ind].Cells[2].Value = DD.LayQuyen(dgvTaiKhoan.Rows[ind].Cells[3].Value.ToString().Trim(), dgvTaiKhoan.Rows[ind].Cells[0].Value.ToString().Trim());
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            DDictionary DD = new DDictionary();
            DDictionary.TenDangNhap = TenDangNhap;
            DDictionary.MatKhau = PassWord;
            DDictionary.MaSite = MaSite;
            //
            int ind = dgvTaiKhoan.CurrentRow.Index;
            txtTenDN.Text = dgvTaiKhoan.Rows[ind].Cells[0].Value.ToString().Trim();
            txtMatKhau.Text = dgvTaiKhoan.Rows[ind].Cells[1].Value.ToString().Trim();
            cbbQuyen.Text = dgvTaiKhoan.Rows[ind].Cells[2].Value.ToString().Trim();
            cbbSite.Text = DD.LayTenSite(dgvTaiKhoan.Rows[ind].Cells[3].Value.ToString().Trim());

        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtTenDN.Enabled = true;
            txtMatKhau.Enabled = true;
            cbbSite.Enabled = true;
            cbbQuyen.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnTaiLai.Enabled = false;
            //

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenDN.Enabled = false;
            txtMatKhau.Enabled = true;
            cbbSite.Enabled = true;
            cbbQuyen.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnTaiLai.Enabled = false;
            //

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenDN.Enabled = false;
            txtMatKhau.Enabled = false;
            cbbSite.Enabled = false;
            cbbQuyen.Enabled = false;
            //
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnTaiLai.Enabled = true;
            //

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lớp NV
                DDictionary DD = new DDictionary();
                DDictionary.TenDangNhap = TenDangNhap;
                DDictionary.MatKhau = PassWord;
                DDictionary.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string Ma = txtTenDN.Text.Trim();
                    string Ten = txtMatKhau.Text.Trim();
                    string MaSites = cbbSite.SelectedValue.ToString().Trim();
                    string Quyens = cbbQuyen.SelectedValue.ToString().Trim();
                    //
                    bool tl = DD.ThemTK(Ma, Ten, MaSites, Quyens);
                    if (tl)
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else//sửa
                {
                    //xử lý
                    //DL nhập vào
                    //
                    string Ma = txtTenDN.Text.Trim();
                    string Ten = txtMatKhau.Text.Trim();
                    string MaSites = cbbSite.SelectedValue.ToString().Trim();
                    string Quyens = cbbQuyen.SelectedValue.ToString().Trim();
                    //DL trong CSDL
                    bool tl = DD.CapNhatTK(Ma, Ten, MaSites, Quyens);
                    if (tl)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lớp Khu
            DDictionary DD = new DDictionary();
            DDictionary.TenDangNhap = TenDangNhap;
            DDictionary.MatKhau = PassWord;
            DDictionary.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaKDSVao = txtTenDN.Text.Trim();
            string MaSiteVao = cbbSite.SelectedValue.ToString().Trim();
            bool tl = DD.XoaTK(MaKDSVao, MaSiteVao);
            if (tl)
            {
                MessageBox.Show("Xóa thành công !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadDuLieu();
        }
    }
}
