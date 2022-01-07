using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPhanTan
{
    public partial class frm_Main : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public String MaNV = "";

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frm = new frm_DangNhap();
            frm.ShowDialog();
            TenDangNhap = frm.TenDangNhap;
            PassWord = frm.PassWord;
            MaSite = frm.MaSite;
            MaNV = frm.MaNV;
            
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLSach frm = new frm_QLSach();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm = new frm_NhanVien();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BanHang frm=new frm_BanHang();
            frm.TenDangNhap = TenDangNhap;
            frm.MatKhau = PassWord;
            frm.MaSite = MaSite;
            frm.MaNV = MaNV;
            frm.ShowDialog();
            this.Show();
        }

        private void kệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Ke frm = new frm_Ke();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();

        }

        private void khuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Khu frm = new frm_Khu();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TacGia frm = new frm_TacGia();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TheLoai frm = new frm_TheLoai();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NXB frm = new frm_NXB();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ChucVu frm = new frm_ChucVu();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frm = new frm_DangNhap();
            frm.ShowDialog();
            TenDangNhap = frm.TenDangNhap;
            PassWord = frm.PassWord;
            MaSite = frm.MaSite;
            MaNV = frm.MaNV;
            this.Show();
        }

        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhapSach frm = new Frm_NhapSach();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuanLyDIC frm = new frm_QuanLyDIC();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            //frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDonBan frm = new frm_HoaDonBan();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            //frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void chiTietDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_CTHoaDonBan frm = new frm_CTHoaDonBan();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            //frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_HoaDonNhap frm = new frm_HoaDonNhap();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            //frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void chiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_CTHoaDonNhap frm = new frm_CTHoaDonNhap();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            
            
            frm.ShowDialog();
            this.Show();
        }

        private void TKdonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThongKeDonHang frm = new Frm_ThongKeDonHang();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }

        private void TKhoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ThongKeHoaDon frm = new Frm_ThongKeHoaDon();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            frm.MaNV = MaNV;
            //
            frm.ShowDialog();
            this.Show();
        }
    }
}
