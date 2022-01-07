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
using System.Data.SqlClient;

namespace DemoPhanTan
{
    public partial class frm_ChucVu : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_ChucVu()
        {
            InitializeComponent();
        }

        private void frm_ChucVu_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            ChucVu NXB = new ChucVu();
            ChucVu.TenDangNhap = TenDangNhap;
            ChucVu.MatKhau = PassWord;
            ChucVu.MaSite = MaSite;
            dgvCV.DataSource = NXB.LayThongTinChucVu().Tables[0];

        }

        private void dgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvCV.CurrentRow.Index;
            txtmaCV.Text = dgvCV.Rows[CrR].Cells[0].Value.ToString();
            txttenCV.Text = dgvCV.Rows[CrR].Cells[1].Value.ToString();
            txtLuong.Text = double.Parse(dgvCV.Rows[CrR].Cells[2].Value.ToString()).ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmaCV.Enabled = false;
            txttenCV.Enabled = false;
            txtLuong.Enabled = false;
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
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtmaCV.ResetText();
            txtmaCV.Text = "CV-";
            txttenCV.ResetText();
            txtLuong.ResetText();

            //
            txtmaCV.Enabled = true;
            txttenCV.Enabled = true;
            txtLuong.Enabled = true;
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
            txtmaCV.Enabled = false;
            txttenCV.Enabled = true;
            txtLuong.Enabled = true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lớp Khu
            ChucVu NXB = new ChucVu();
            ChucVu.TenDangNhap = TenDangNhap;
            ChucVu.MatKhau = PassWord;
            ChucVu.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaKDSVao = txtmaCV.Text.Trim();
            bool tl = NXB.XoaChucVu(MaKDSVao);
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

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lớp NV
                ChucVu KDS = new ChucVu();
                ChucVu.TenDangNhap = TenDangNhap;
                ChucVu.MatKhau = PassWord;
                ChucVu.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string Ma = txtmaCV.Text.Trim();
                    string Ten = txttenCV.Text.Trim();
                    double MucLuong = double.Parse(txtLuong.Text.Trim());
                    //
                    bool tl = KDS.ThemChucVu(Ma, Ten, MucLuong);
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
                    //
                    string Ma = txtmaCV.Text.Trim();
                    string Ten = txttenCV.Text.Trim();
                    double MucLuong = double.Parse(txtLuong.Text.Trim());
                    //DL trong CSDL
                    int crR = dgvCV.CurrentRow.Index;
                    string MaCS = dgvCV.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenCS = dgvCV.Rows[crR].Cells[1].Value.ToString().Trim();
                    double MucLuongCS = double.Parse(dgvCV.Rows[crR].Cells[2].Value.ToString().Trim());
                    if (Ma == MaCS && Ten == TenCS && MucLuong == MucLuongCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = KDS.CapNhatChucVu(Ma, Ten, MucLuong);
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
