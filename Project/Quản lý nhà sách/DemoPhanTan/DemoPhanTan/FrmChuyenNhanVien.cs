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
    public partial class FrmChuyenNhanVien : Form
    {
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        //
        public string MaNV;
        public string MaNVF;
        public string TenNV;
        //string ChiNhanh;
        //string ChucVu;
        //string NgayVaoLam;
        //string Luong;
        public string SDT;
        public string DiaChi;
        public string QueQuan;
        public FrmChuyenNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //
        

        private void FrmChuyenNhanVien_Load(object sender, EventArgs e)
        {
            //
            NhanVien nhanvien = new NhanVien();
            NhanVien.TenDangNhap = TenDangNhap;
            NhanVien.MatKhau = PassWord;
            NhanVien.MaSite = MaSite;
            //
            txtTenNhanVien.Text = TenNV;
            txtTenNhanVien.Enabled = false;
            //

            //
            //đổ DL lên cbx Chi Nhanhs
            cbxChiNhanh.DataSource = nhanvien.LayDanhSachChiNhanhDIC();
            cbxChiNhanh.DisplayMember = "TenSite";
            cbxChiNhanh.ValueMember = "MaSite";
            //đổ DL lên cbx chức vụ
            cbxChucVu.DataSource = nhanvien.LayDanhSachChucVuDich(cbxChiNhanh.SelectedValue.ToString().Trim());
            cbxChucVu.DisplayMember = "TenChucVu";
            cbxChucVu.ValueMember = "MaChucVu";
            
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            //
            NhanVien nhanvien = new NhanVien();
            NhanVien.TenDangNhap = TenDangNhap;
            NhanVien.MatKhau = PassWord;
            NhanVien.MaSite = MaSite;
            //
            //string IPDich = nhanvien.LayIP(cbxChiNhanh.SelectedValue.ToString().Trim());
            //string MaSiteDich;
            //string TenDataBaseDich = nhanvien.LaytenDatabase(cbxChiNhanh.SelectedValue.ToString().Trim());
            String maSiteDich = cbxChiNhanh.SelectedValue.ToString().Trim();
            //
            string NgayVaolam = System.DateTime.Now.Date.ToString("MM/dd/yyyy");
            string maChiNhanh = nhanvien.LayMaChiNhanhODic(maSiteDich, cbxChiNhanh.Text.Trim()).Trim();
            double luong = 0;
            int SoCaTruc = 0;
            String matKhau = "123";
            int SoNV = nhanvien.DemSoNhanVien(maSiteDich);
            SoNV = SoNV + 1;
            MaNVF = "NV-" + SoNV;

            bool tl = nhanvien.ChuyenNV(MaNVF, TenNV, maChiNhanh, cbxChucVu.SelectedValue.ToString().Trim(), NgayVaolam, luong, SDT, DiaChi, QueQuan, SoCaTruc, matKhau, maSiteDich);
            if (tl)
            {
                MessageBox.Show("Chuyển thành công !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                nhanvien.XoaNVF(MaNV, MaSite);
                this.Close();

            }
            else
                MessageBox.Show("Đã xảy ra lỗi trong quá trình chuyển !", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void cbxChiNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxChiNhanh_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //
    }
}
