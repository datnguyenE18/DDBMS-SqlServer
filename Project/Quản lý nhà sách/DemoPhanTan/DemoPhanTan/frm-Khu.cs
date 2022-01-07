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
    public partial class frm_Khu : Form
    {
        //
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        //
        public frm_Khu()
        {
            InitializeComponent();
        }

        private void frm_Khu_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            KhuDeSach KDS = new KhuDeSach();
            KhuDeSach.TenDangNhap = TenDangNhap;
            KhuDeSach.MatKhau = PassWord;
            KhuDeSach.MaSite = MaSite;
            dgvKhu.DataSource = KDS.LayThongTinKhuDeSach().Tables[0];
            for (int i = 0; i < dgvKhu.Rows.Count-1; i++)
            {
                dgvKhu.Rows[i].Cells[2].Value = KDS.LayTenNhanVien(dgvKhu.Rows[i].Cells[2].Value.ToString().Trim());
            }
            //đổ DL lên cbx Khu
            cbxTenNhanVien.DataSource = KDS.LayDanhSachNhanVien();
            cbxTenNhanVien.DisplayMember = "TenNV";
            cbxTenNhanVien.ValueMember = "MaNV";
            
        }

        private void dgvKhu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvKhu.CurrentRow.Index;
            txtmaKhu.Text = dgvKhu.Rows[CrR].Cells[0].Value.ToString();
            txttenKhu.Text = dgvKhu.Rows[CrR].Cells[1].Value.ToString();
            cbxTenNhanVien.Text = dgvKhu.Rows[CrR].Cells[2].Value.ToString();
        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtmaKhu.ResetText();
            txtmaKhu.Text = "K-";
            txttenKhu.ResetText();
            //
            txtmaKhu.Enabled = true;
            txttenKhu.Enabled = true;
            cbxTenNhanVien.Enabled = true;
            //
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTroVe.Enabled = false;
            btnXoa.Enabled = false;
            btntaiLai.Enabled = false;
            //
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            //
            txtmaKhu.Enabled = false;
            txttenKhu.Enabled = true;
            cbxTenNhanVien.Enabled = true;
            //
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTroVe.Enabled = false;
            btnXoa.Enabled = false;
            btntaiLai.Enabled = false;
            //
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmaKhu.Enabled = false;
            txttenKhu.Enabled = false;
            cbxTenNhanVien.Enabled = false;
            //
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnXoa.Enabled = true;
            btntaiLai.Enabled = true;
            //
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntaiLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //lớp Khu
            KhuDeSach KDS = new KhuDeSach();
            KhuDeSach.TenDangNhap = TenDangNhap;
            KhuDeSach.MatKhau = PassWord;
            KhuDeSach.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaKDSVao = txtmaKhu.Text.Trim();
            bool tl = KDS.XoaKhuDeSach(MaKDSVao);
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
                KhuDeSach KDS = new KhuDeSach();
                KhuDeSach.TenDangNhap = TenDangNhap;
                KhuDeSach.MatKhau = PassWord;
                KhuDeSach.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string MaKhu = txtmaKhu.Text.Trim();
                    string TenKhu = txttenKhu.Text.Trim();
                    string NhanVien = KDS.TimMaNV(cbxTenNhanVien.Text.Trim()).Trim();
                    //
                    bool tl = KDS.ThemKhuDeSach(MaKhu, TenKhu, NhanVien);
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
                    string MaKhu = txtmaKhu.Text.Trim();
                    string TenKhu = txttenKhu.Text.Trim();
                    string NhanVien = KDS.TimMaNV(cbxTenNhanVien.Text.Trim());
                    //DL trong CSDL
                    int crR = dgvKhu.CurrentRow.Index;
                    string MaKhuCS= dgvKhu.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenKhuCS = dgvKhu.Rows[crR].Cells[1].Value.ToString().Trim();
                    string MaNVCS = KDS.TimMaNV(dgvKhu.Rows[crR].Cells[2].Value.ToString().Trim()).Trim();
                    if (MaKhu == MaKhuCS && TenKhu == TenKhuCS && NhanVien == MaNVCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = KDS.CapNhatKhuDeSach(MaKhu, TenKhu, NhanVien);
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
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
