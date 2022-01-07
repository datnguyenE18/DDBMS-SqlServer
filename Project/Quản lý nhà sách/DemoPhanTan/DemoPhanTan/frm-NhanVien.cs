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
    public partial class frm_NhanVien : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        //
        
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        void LoadDuLieu()
        {
            NhanVien nhanvien = new NhanVien();
            NhanVien.TenDangNhap = TenDangNhap;
            NhanVien.MatKhau = PassWord;
            NhanVien.MaSite = MaSite;
            dgvNhanVien.DataSource = nhanvien.LayThongTinNV().Tables[0];

            //
            for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                dgvNhanVien.Rows[i].Cells[2].Value = nhanvien.LayTenChiNhanh(dgvNhanVien.Rows[i].Cells[2].Value.ToString());
                dgvNhanVien.Rows[i].Cells[3].Value = nhanvien.LayTenChucVu(dgvNhanVien.Rows[i].Cells[3].Value.ToString());
            }
            //
            int CrR = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[CrR].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[CrR].Cells[1].Value.ToString();
            txtChiNhanh.Text = dgvNhanVien.Rows[CrR].Cells[2].Value.ToString();
            cbxChucVu.Text = dgvNhanVien.Rows[CrR].Cells[3].Value.ToString();
            dtpNgayVaoLam.Text = dgvNhanVien.Rows[CrR].Cells[4].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[CrR].Cells[5].Value.ToString();
            txtSoDT.Text = dgvNhanVien.Rows[CrR].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[CrR].Cells[7].Value.ToString();
            txtQueQuan.Text = dgvNhanVien.Rows[CrR].Cells[8].Value.ToString();

            //đổ DL lên cbx chức vụ
            cbxChucVu.DataSource = nhanvien.LayDanhSachChucVu();
            cbxChucVu.DisplayMember = "TenChucVu";
            cbxChucVu.ValueMember = "MaChucVu";
            //đổ DL lên cbx Chi Nhanhs
            cbxChiNhanh.DataSource = nhanvien.LayDanhSachChiNhanh();
            cbxChiNhanh.DisplayMember = "TenChiNhanh";
            cbxChiNhanh.ValueMember = "MaChiNhanh";
            // Tieu chi Tim
            //cbx tiêu chí tìm
            var colours = new Dictionary<string, string>
            {
              {"Tên Nhân Viên","TenNV"},
              {"Địa Chỉ","DiaChi"},
              {"Quê Quán","QueQuan"},
              {"Chức Vụ","ChucVu"},
            }.ToList();

            cbxTieuChiTim.DisplayMember = "Key";
            cbxTieuChiTim.ValueMember = "Value";
            cbxTieuChiTim.DataSource = colours;

            
            //
            btnTimNhanVien.Enabled = true;
            txtTimKiem.Visible = false;
            btnHuy.Enabled = false;
            btnHuy.Enabled = false;
            //
            //cbx tiêu chí tìm
            cbxChucVuDuocTim.DataSource = nhanvien.LayDanhSachChucVu();
            cbxChucVuDuocTim.DisplayMember = "TenChucVu";
            cbxChucVuDuocTim.ValueMember = "MaChucVu";
            cbxChucVuDuocTim.Text = "Chọn Chức Vụ";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CrR = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[CrR].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[CrR].Cells[1].Value.ToString();
            cbxChiNhanh.Text = dgvNhanVien.Rows[CrR].Cells[2].Value.ToString();
            cbxChucVu.Text = dgvNhanVien.Rows[CrR].Cells[3].Value.ToString();
            dtpNgayVaoLam.Text = dgvNhanVien.Rows[CrR].Cells[4].Value.ToString();
            txtLuong.Text = Double.Parse(dgvNhanVien.Rows[CrR].Cells[5].Value.ToString()).ToString();
            txtSoDT.Text = dgvNhanVien.Rows[CrR].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[CrR].Cells[7].Value.ToString();
            txtQueQuan.Text = dgvNhanVien.Rows[CrR].Cells[8].Value.ToString();
        }

        private void btnAnHien_Click(object sender, EventArgs e)
        {
            if (btnAnHien.Text == "↓")//hiện tìm kiếm
            {
                lbTimNhanVien.Visible = true;
                lbTieuChiTim.Visible = true;
                txtTimKiem.Visible = true;
                cbxChucVuDuocTim.Visible = true;
                cbxTieuChiTim.Visible = true;
                btnTimNhanVien.Visible = true;
                btnAnHien.Text = "↑";
            }
            else//ẩn tìm kiếm
            {
                lbTimNhanVien.Visible = false;
                lbTieuChiTim.Visible = false;
                txtTimKiem.Visible = false;
                cbxChucVuDuocTim.Visible = false;
                cbxTieuChiTim.Visible = false;
                btnTimNhanVien.Visible = false;
                btnAnHien.Text = "↓";
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTimNhanVien_Click(sender, e);
            }
        }

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            //lớp NV
            NhanVien NV = new NhanVien();
            NhanVien.MatKhau = PassWord;
            NhanVien.MaSite = MaSite;
            NhanVien.TenDangNhap = TenDangNhap;
            //
            DataSet dsTK;
            DataTable dtTK = null;
            if (cbxTieuChiTim.Text != "Chức Vụ")
            {
                try
                {
                    string TenThuocTinh = "";
                    TenThuocTinh = cbxTieuChiTim.SelectedValue.ToString();                
                    //lấy tên bảng
                    string TenBang = NV.TimTenBang(TenThuocTinh);
                    dsTK = NV.TimKiem(txtTimKiem.Text.Trim(), TenBang.Trim(), TenThuocTinh.Trim());
                    dgvNhanVien.Refresh();
                    dgvNhanVien.DataSource = dsTK.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                txtTimKiem.Visible = false;
                if (cbxChucVuDuocTim.Text != "Chọn thể loại")
                {
                    dtTK = NV.TimTheoChucVu(cbxChucVuDuocTim.SelectedValue.ToString());
                    dgvNhanVien.Refresh();
                    dgvNhanVien.DataSource = dtTK;
                }
            }
            //chuyển đổi DL
            for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                dgvNhanVien.Rows[i].Cells[2].Value = NV.LayTenChiNhanh(dgvNhanVien.Rows[i].Cells[2].Value.ToString());
                dgvNhanVien.Rows[i].Cells[3].Value = NV.LayTenChucVu(dgvNhanVien.Rows[i].Cells[3].Value.ToString());
            }
        }

        private void cbxTieuChiTim_TextChanged(object sender, EventArgs e)
        {
            if (cbxTieuChiTim.Text == "Chức Vụ")
                txtTimKiem.Visible = false;
            else
                txtTimKiem.Visible = true;
        }
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            //lớp NV
            NhanVien NV = new NhanVien();
            NhanVien.MatKhau = PassWord;
            NhanVien.MaSite = MaSite;
            NhanVien.TenDangNhap = TenDangNhap;
            //Bien them
            Them = true;
            // Enable 
            txtMaNV.Enabled =true;
            txtTenNV.Enabled = true;
            txtChiNhanh.Enabled = false;
            cbxChucVu.Enabled = true;
            cbxChiNhanh.Enabled = true;
            dtpNgayVaoLam.Enabled = true;
            txtLuong.Enabled = true;
            txtSoDT.Enabled =true;
            txtDiaChi.Enabled =true;
            txtQueQuan.Enabled =true;
            //reset text
            txtMaNV.ResetText();
            int k = NV.DemSoNhanVien(MaSite) +1;
            txtMaNV.Text = "NV-" + k;
            txtTenNV.ResetText();
            //txtChiNhanh.ResetText();
            txtLuong.ResetText();
            txtSoDT.ResetText();
            txtDiaChi.ResetText();
            txtQueQuan.ResetText();
            //Disable
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnTroVe.Enabled = false;
            btnXoa.Enabled = false;
            btnAnHien.Enabled = false;
            btnLoad.Enabled = false;
            btnChuyen.Enabled = false;
            //Enable
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Disable 
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtChiNhanh.Enabled = false;
            cbxChucVu.Enabled = false;
            dtpNgayVaoLam.Enabled = false;
            txtLuong.Enabled = false;
            txtSoDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            //Enable
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnXoa.Enabled = true;
            btnAnHien.Enabled = true;
            btnLoad.Enabled = true;
            btnChuyen.Enabled = true;
            //Enable
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lớp NV
                NhanVien NV = new NhanVien();
                NhanVien.TenDangNhap = TenDangNhap;
                NhanVien.MatKhau = PassWord;
                NhanVien.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string MaNV = txtMaNV.Text.Trim();
                    string TenNV = txtTenNV.Text.Trim();
                    string MaChiNhanh = NV.TimMaChiNhanh(txtChiNhanh.Text.Trim()).Trim();
                    string ChucVu = cbxChucVu.SelectedValue.ToString().Trim();
                    string NgayVaoLam = dtpNgayVaoLam.Text.Trim();
                    string Luong = txtLuong.Text.Trim();
                    string SDT = txtSoDT.Text.Trim();
                    string DiaChi = txtDiaChi.Text.Trim();
                    string QueQuan = txtQueQuan.Text.Trim();
                    int SoCaTruc = 0;
                    string MatKhau = "123";
                    //
                    bool tl = NV.ThemNV(MaNV, TenNV, MaChiNhanh, ChucVu, NgayVaoLam, Luong, SDT, DiaChi, QueQuan,SoCaTruc, MatKhau);
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
                    string MaNVVao = txtMaNV.Text.Trim();
                    string TenNVVao = txtTenNV.Text.Trim();
                    string MaChiNhanhVao = NV.TimMaChiNhanh(txtChiNhanh.Text.Trim());
                    string ChucVuVao = cbxChucVu.SelectedValue.ToString().Trim();
                    string NgayVaoLamVao = dtpNgayVaoLam.Text.Trim();
                    string LuongVao = txtLuong.Text.Trim();
                    string SDTVao = txtSoDT.Text.Trim();
                    string DiaChiVao = txtDiaChi.Text.Trim();
                    string QueQuanVao = txtQueQuan.Text.Trim();

                    //DL trong CSDL
                    int crR = dgvNhanVien.CurrentRow.Index;
                    string MaNVCS = dgvNhanVien.Rows[crR].Cells[0].Value.ToString().Trim();
                    string TenNVCS = dgvNhanVien.Rows[crR].Cells[1].Value.ToString().Trim();
                    string MaChiNhanhCS =NV.TimMaChiNhanh(dgvNhanVien.Rows[crR].Cells[2].Value.ToString().Trim()).Trim();
                    string ChucVuCS = NV.TimMaChucVu(dgvNhanVien.Rows[crR].Cells[3].Value.ToString().Trim()).Trim();
                    string NgayVaoLamCS = dgvNhanVien.Rows[crR].Cells[4].Value.ToString().Trim();
                    string LuongCS = dgvNhanVien.Rows[crR].Cells[5].Value.ToString().Trim();
                    string SDTCS = dgvNhanVien.Rows[crR].Cells[6].Value.ToString().Trim();
                    string DiaChiCS = dgvNhanVien.Rows[crR].Cells[7].Value.ToString().Trim();
                    string QueQuanCS = dgvNhanVien.Rows[crR].Cells[8].Value.ToString().Trim();

                    if (TenNVVao == TenNVCS && MaChiNhanhVao == MaChiNhanhCS && ChucVuVao == ChucVuCS && NgayVaoLamVao == NgayVaoLamCS
                        && LuongVao == LuongCS && SDTVao == SDTCS && DiaChiVao == DiaChiCS
                        && QueQuanVao == QueQuanCS)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl = NV.CapNhatNV(MaNVVao, TenNVVao, MaChiNhanhVao, ChucVuVao, NgayVaoLamVao,
                                    LuongVao, SDTVao, DiaChiVao, QueQuanVao);
                        if (tl)
                        {
                            MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật !", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
            LoadDuLieu();
            //
            // Enable 
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtChiNhanh.Enabled = false;
            cbxChucVu.Enabled = false;
            cbxChiNhanh.Enabled = false;
            dtpNgayVaoLam.Enabled = false;
            txtLuong.Enabled = false;
            txtSoDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtQueQuan.Enabled = false;
            //Disable
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnTroVe.Enabled = true;
            btnXoa.Enabled = true;
            btnAnHien.Enabled = true;
            btnLoad.Enabled = true;
            btnChuyen.Enabled = true;
            //Enable
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }





        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult tb=MessageBox.Show("Bạn chắc chắn xóa nhân viên này ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                //lớp sach
                NhanVien nv = new NhanVien();
                NhanVien.TenDangNhap = TenDangNhap;
                NhanVien.MatKhau = PassWord;
                NhanVien.MaSite = MaSite;
                //
                //xử lý
                //DL 
                string MaNVVao = txtMaNV.Text.Trim();
                string TenNVVao = txtTenNV.Text.Trim();
                bool tl = nv.XoaNV(MaNVVao, TenNVVao);
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnAnHien.Enabled = false;
            btnChuyen.Enabled = false;
            btnTroVe.Enabled = false;
            btnLoad.Enabled = false;
            //Enable
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtChiNhanh.Enabled = false;
            cbxChucVu.Enabled = true;
            dtpNgayVaoLam.Enabled = true;
            txtLuong.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDT.Enabled = true;
            txtQueQuan.Enabled = true;
            //nút
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //

            //sửa
            Them = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            int crR = dgvNhanVien.CurrentRow.Index;
            FrmChuyenNhanVien frm = new FrmChuyenNhanVien();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.MaNV = dgvNhanVien.Rows[crR].Cells[0].Value.ToString().Trim();
            frm.TenNV = dgvNhanVien.Rows[crR].Cells[1].Value.ToString().Trim();
            frm.SDT = dgvNhanVien.Rows[crR].Cells[6].Value.ToString().Trim();
            frm.DiaChi = dgvNhanVien.Rows[crR].Cells[7].Value.ToString().Trim();
            frm.QueQuan = dgvNhanVien.Rows[crR].Cells[8].Value.ToString().Trim();
            frm.ShowDialog();
        }
    }
}
