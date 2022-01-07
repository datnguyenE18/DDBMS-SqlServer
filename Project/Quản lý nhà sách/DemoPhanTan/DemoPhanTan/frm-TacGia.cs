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
    public partial class frm_TacGia : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_TacGia()
        {
            InitializeComponent();
        }

        private void frm_TacGia_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            TacGia TG = new TacGia();
            TacGia.TenDangNhap = TenDangNhap;
            TacGia.MatKhau = PassWord;
            TacGia.MaSite = MaSite;
            dgvTG.DataSource = TG.LayThongTinTacGia().Tables[0];
        }

        private void dgvTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvTG.CurrentRow.Index;
            txtTenTG.Text = dgvTG.Rows[CrR].Cells[0].Value.ToString();
            txtMaTG.Text = dgvTG.Rows[CrR].Cells[1].Value.ToString();
        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaTG.ResetText();
            txtMaTG.Text = "TG-";
            txtTenTG.ResetText();
            //
            txtMaTG.Enabled = true;
            txtTenTG.Enabled = true;
            //
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTroVe.Enabled = false;
            btnXoa.Enabled = false;
            btnTaiLai.Enabled = false;
            //
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            //
            txtMaTG.Enabled = false;
            txtTenTG.Enabled = true;
            //
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTroVe.Enabled = false;
            btnXoa.Enabled = false;
            btnTaiLai.Enabled = false;
            //
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTG.Enabled = false;
            txtTenTG.Enabled = false;
            //
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnXoa.Enabled = true;
            btnTaiLai.Enabled = true;
            //
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lớp TG
            TacGia TG = new TacGia();
            TacGia.TenDangNhap = TenDangNhap;
            TacGia.MatKhau = PassWord;
            TacGia.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaTGVao = txtMaTG.Text.Trim();
            bool tl = TG.XoaTacGia(MaTGVao);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lớp NV
                TacGia TG = new TacGia();
                TacGia.TenDangNhap = TenDangNhap;
                TacGia.MatKhau = PassWord;
                TacGia.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string MaTacGia = txtMaTG.Text.Trim();
                    string TenTG = txtTenTG.Text.Trim();
                    //
                    bool tl = TG.ThemTacGia(MaTacGia, TenTG);
                    if (tl)
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDuLieu();
                }
                else//sửa
                {
                    //xử lý
                    //DL nhập vào
                    string MaTacGia = txtMaTG.Text.Trim();
                    string TenTG = txtTenTG.Text.Trim();
                    //DL trong CSDL
                    int crR = dgvTG.CurrentRow.Index;
                    string MaTacGiaCS = dgvTG.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenTGCS = dgvTG.Rows[crR].Cells[1].Value.ToString().Trim();
                    if (MaTacGia == MaTacGiaCS && TenTG == TenTGCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = TG.CapNhatTacGia(MaTacGia, TenTG);
                        if (tl)
                        {
                            MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDuLieu();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadDuLieu();
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
