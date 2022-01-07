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
    public partial class frm_NXB : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_NXB()
        {
            InitializeComponent();
        }

        private void frm_NXB_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            NhaXuatBan NXB = new NhaXuatBan();
            NhaXuatBan.TenDangNhap = TenDangNhap;
            NhaXuatBan.MatKhau = PassWord;
            NhaXuatBan.MaSite = MaSite;
            dgvNXB.DataSource = NXB.LayThongTinNXB().Tables[0];

        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvNXB.CurrentRow.Index;
            txtMaNXB.Text = dgvNXB.Rows[CrR].Cells[0].Value.ToString();
            txtTenNXB.Text = dgvNXB.Rows[CrR].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNXB.Rows[CrR].Cells[2].Value.ToString();
            txtSoDT.Text = dgvNXB.Rows[CrR].Cells[3].Value.ToString();
            txtNguoiChuQuan.Text = dgvNXB.Rows[CrR].Cells[4].Value.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDT.Enabled = false;
            txtNguoiChuQuan.Enabled = false;
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

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaNXB.ResetText();
            txtMaNXB.Text = "NXB-";
            txtTenNXB.ResetText();
            txtDiaChi.ResetText();
            txtSoDT.ResetText();
            txtNguoiChuQuan.ResetText();

            //
            txtMaNXB.Enabled = true;
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtNguoiChuQuan.Enabled = true;
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
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtNguoiChuQuan.Enabled = true;
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
            NhaXuatBan NXB = new NhaXuatBan();
            NhaXuatBan.TenDangNhap = TenDangNhap;
            NhaXuatBan.MatKhau = PassWord;
            NhaXuatBan.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaKDSVao = txtMaNXB.Text.Trim();
            bool tl = NXB.XoaNXB(MaKDSVao);
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
                NhaXuatBan KDS = new NhaXuatBan();
                NhaXuatBan.TenDangNhap = TenDangNhap;
                NhaXuatBan.MatKhau = PassWord;
                NhaXuatBan.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string Ma = txtMaNXB.Text.Trim();
                    string Ten = txtTenNXB.Text.Trim();
                    string Dia = txtDiaChi.Text.Trim();
                    string SDT = txtSoDT.Text.Trim();
                    string Nguoi = txtNguoiChuQuan.Text.Trim();
                    //
                    bool tl = KDS.ThemNhaXuatBan(Ma, Ten, Dia,SDT,Nguoi);
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
                    string Ma = txtMaNXB.Text.Trim();
                    string Ten = txtTenNXB.Text.Trim();
                    string Dia = txtDiaChi.Text.Trim();
                    string SDT = txtSoDT.Text.Trim();
                    string Nguoi = txtNguoiChuQuan.Text.Trim();
                    //DL trong CSDL
                    int crR = dgvNXB.CurrentRow.Index;
                    string MaCS = dgvNXB.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenCS = dgvNXB.Rows[crR].Cells[1].Value.ToString().Trim();
                    string DiaCS = dgvNXB.Rows[crR].Cells[2].Value.ToString().Trim();
                    string SDTCS = dgvNXB.Rows[crR].Cells[3].Value.ToString().Trim();
                    string NguoiCS = dgvNXB.Rows[crR].Cells[4].Value.ToString().Trim();
                    if (Ma == MaCS && Ten == TenCS && Dia == DiaCS && SDT == SDTCS && Nguoi == NguoiCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = KDS.CapNhatNXB(Ma, Ten, Dia, SDT, Nguoi);
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
