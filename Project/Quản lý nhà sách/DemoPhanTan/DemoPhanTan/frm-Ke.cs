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
    public partial class frm_Ke : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        //
        public frm_Ke()
        {
            InitializeComponent();
        }

        private void frm_Ke_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            KeSach KS = new KeSach();
            KeSach.TenDangNhap = TenDangNhap;
            KeSach.MatKhau = PassWord;
            KeSach.MaSite = MaSite;
            dgvKe.DataSource = KS.LayThongTinKeSach().Tables[0];


            for (int i = 0; i < dgvKe.Rows.Count; i++)
            {
                dgvKe.Rows[i].Cells[2].Value = KS.LayTenKhu(dgvKe.Rows[i].Cells[2].Value.ToString());
            }
            
            //int CrR = dgvNhanVien.CurrentRow.Index;
            //txtMaNV.Text = dgvNhanVien.Rows[CrR].Cells[0].Value.ToString();
            //txtTenNV.Text = dgvNhanVien.Rows[CrR].Cells[1].Value.ToString();
            //txtChiNhanh.Text = dgvNhanVien.Rows[CrR].Cells[2].Value.ToString();
            //cbxChucVu.Text = dgvNhanVien.Rows[CrR].Cells[3].Value.ToString();
            //dtpNgayVaoLam.Text = dgvNhanVien.Rows[CrR].Cells[4].Value.ToString();
            //txtLuong.Text = dgvNhanVien.Rows[CrR].Cells[5].Value.ToString();
            //txtSoDT.Text = dgvNhanVien.Rows[CrR].Cells[6].Value.ToString();
            //txtDiaChi.Text = dgvNhanVien.Rows[CrR].Cells[7].Value.ToString();
            //txtQueQuan.Text = dgvNhanVien.Rows[CrR].Cells[8].Value.ToString();

            //đổ DL lên cbx Khu
            cbxKhu.DataSource = KS.LayDanhSachKhu();
            cbxKhu.DisplayMember = "TenKhu";
            cbxKhu.ValueMember = "MaKhu";
            // Tieu chi Tim
            //cbx tiêu chí tìm
            //var colours = new Dictionary<string, string>
            //{
            //  {"Tên Nhân Viên","TenNV"},
            //  {"Địa Chỉ","DiaChi"},
            //  {"Quê Quán","QueQuan"},
            //  {"Chức Vụ","ChucVu"},
            //}.ToList();

            //cbxTieuChiTim.DisplayMember = "Key";
            //cbxTieuChiTim.ValueMember = "Value";
            //cbxTieuChiTim.DataSource = colours;


            ////
            //btnTimNhanVien.Enabled = true;
            //txtTimKiem.Visible = false;
            //btnHuy.Enabled = false;
            //btnHuy.Enabled = false;
            ////
            ////cbx tiêu chí tìm
            //cbxChucVuDuocTim.DataSource = nhanvien.LayDanhSachChucVu();
            //cbxChucVuDuocTim.DisplayMember = "TenChucVu";
            //cbxChucVuDuocTim.ValueMember = "MaChucVu";
            //cbxChucVuDuocTim.Text = "Chọn Chức Vụ";
        }

        private void dgvKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvKe.CurrentRow.Index;
            txtmaKe.Text = dgvKe.Rows[CrR].Cells[0].Value.ToString();
            txttenKe.Text = dgvKe.Rows[CrR].Cells[1].Value.ToString();
            cbxKhu.Text = dgvKe.Rows[CrR].Cells[2].Value.ToString();
        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtmaKe.ResetText();
            txtmaKe.Text = "K-";
            txttenKe.ResetText();
            //
            txtmaKe.Enabled = true;
            txttenKe.Enabled = true;
            cbxKhu.Enabled = true;
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
            txtmaKe.Enabled = true;
            txttenKe.Enabled = true;
            cbxKhu.Enabled = true;
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
            txtmaKe.Enabled = false;
            txttenKe.Enabled = false;
            cbxKhu.Enabled = false;
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
            //lớp sach
            KeSach KS = new KeSach();
            KeSach.TenDangNhap = TenDangNhap;
            KeSach.MatKhau = PassWord;
            KeSach.MaSite = MaSite;
            //
            //xử lý
            //DL 
            string MaKSVao = txtmaKe.Text.Trim();
            bool tl = KS.XoaKeSach(MaKSVao);
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
                KeSach KS = new KeSach();
                KeSach.TenDangNhap = TenDangNhap;
                KeSach.MatKhau = PassWord;
                KeSach.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string MaKe = txtmaKe.Text.Trim();
                    string TenKe= txttenKe.Text.Trim();
                    string Khu = KS.TimMaKhu(cbxKhu.Text.Trim());
                    //
                    bool tl = KS.ThemKeSach(MaKe, TenKe, Khu);
                    if (tl)
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm !", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//sửa
                {
                    //xử lý
                    //DL nhập vào
                    string MaKe = txtmaKe.Text.Trim();
                    string TenKe = txttenKe.Text.Trim();
                    string Khu = KS.TimMaKhu(cbxKhu.Text.Trim());
                    //DL trong CSDL
                    int crR = dgvKe.CurrentRow.Index;
                    string MaKeCS = dgvKe.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenKeCS = dgvKe.Rows[crR].Cells[1].Value.ToString().Trim();
                    string MaKhuCS = KS.TimMaKhu(dgvKe.Rows[crR].Cells[2].Value.ToString().Trim()).Trim();
                    if (MaKe == MaKeCS && TenKe == TenKeCS && Khu == MaKhuCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = KS.CapNhatKe(MaKe, TenKe, Khu);
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
            catch
            {

            }
        }
        //
    }
}
