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
using System.Threading;

namespace DemoPhanTan
{
    public partial class frm_BanHang : Form
    {
        public String TenDangNhap = "";
        public String MatKhau = "";
        public String MaSite = "";
        public String MaNV = "";
        //
        bool ThanhToan = false;
        //
        public frm_BanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                this.Close();
                TraHangChuaThanhToan();
            }
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            LoadDL();
            //
            txtTimKiem.Visible = false;
            //
            //lấy tên nhân viên
            NhanVien nv = new NhanVien();
            NhanVien.MaSite = MaSite;
            NhanVien.MatKhau = MatKhau;
            NhanVien.TenDangNhap = TenDangNhap;
            txtTenNV.Text = nv.LayTenNV(MaNV);
        }

        void LoadDL()
        {
            try
            {
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = MatKhau;
                Sach.MaSite = MaSite;
                //
                DataTable dtSach = sach.LayDLBangSach();
                //
                dgvSach.DataSource = dtSach;
                //
                int crR = 0;
                txtMaSach.Text = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();
                txtTenSach.Text = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();
                txtSoLuong.Text = dgvSach.Rows[crR].Cells[2].Value.ToString().Trim();
                txtTheLoai.Text = sach.LayTenTheloai(dgvSach.Rows[crR].Cells[5].Value.ToString());
                txtTacGia.Text = dgvSach.Rows[crR].Cells[6].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[crR].Cells[7].Value.ToString().Trim();
                txtSoTrang.Text = dgvSach.Rows[crR].Cells[8].Value.ToString().Trim();
                txtNgonNgu.Text = dgvSach.Rows[crR].Cells[9].Value.ToString().Trim();
                //
                txtKhu.Text = sach.LayKhuChuaSach(txtMaSach.Text);
                txtKe.Text = sach.LayKeChuaSach(txtMaSach.Text);

                
                //cbx tiêu chí tìm
                if (cbxTieuChiTim.Items.Count < dgvSach.Columns.Count - 1)
                {
                    for (int i = 1; i < dgvSach.Columns.Count; i++)
                    {
                        cbxTieuChiTim.Items.Add(dgvSach.Columns[i].HeaderText);
                    }
                    cbxTieuChiTim.Text = cbxTieuChiTim.Items[0].ToString();
                }

                //cbx tiêu chí tìm
                cbxTheLoaiDuocTim.DataSource = sach.LayDanhSachTheLoai();
                cbxTheLoaiDuocTim.DisplayMember = "TenTheLoai";
                cbxTheLoaiDuocTim.ValueMember = "MaTheLoai";
                cbxTheLoaiDuocTim.Text = "Chọn thể loại";

                //chuyển đổi dữ liệu
                ChuyenDoiDL();
                txtTimKiem.ResetText();
            }
            catch (Exception)
            { }
        }

        //chuyển các mã NCC,NXB,mã thể loại vv.. thành tên
        void ChuyenDoiDL()
        {
            //lớp sách
            Sach sach = new Sach();
            Sach.MatKhau = MatKhau;
            Sach.MaSite = MaSite;
            Sach.TenDangNhap = TenDangNhap;
            //
            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
            {
                //NXB
                dgvSach.Rows[i].Cells[3].Value = sach.LayTenNXB(dgvSach.Rows[i].Cells[3].Value.ToString());
                //NCC
                dgvSach.Rows[i].Cells[4].Value = sach.LayTenNCC(dgvSach.Rows[i].Cells[4].Value.ToString());
                //thể loại
                dgvSach.Rows[i].Cells[5].Value = sach.LayTenTheloai(dgvSach.Rows[i].Cells[5].Value.ToString());
                //tác giả
                dgvSach.Rows[i].Cells[6].Value = sach.LayTenTacGia(dgvSach.Rows[i].Cells[6].Value.ToString());
            }

        }

        //ẩn hiện
        private void btnAnHien_Click(object sender, EventArgs e)
        {
            if (btnAnHien.Text == "↓")//hiện tìm kiếm
            {
                lbTimSach.Visible = true;
                lbTieuChiTim.Visible = true;
                txtTimKiem.Visible = true;
                cbxTheLoaiDuocTim.Visible = true;
                cbxTieuChiTim.Visible = true;
                btnTKSach.Visible = true;
                btnAnHien.Text = "↑";
            }
            else//ẩn tìm kiếm
            {
                lbTimSach.Visible = false;
                lbTieuChiTim.Visible = false;
                txtTimKiem.Visible = false;
                cbxTheLoaiDuocTim.Visible = false;
                cbxTieuChiTim.Visible = false;
                btnTKSach.Visible = false;
                btnAnHien.Text = "↓";
            }
        }

        //tìm kiếm
        private void btnTKSach_Click(object sender, EventArgs e)
        {
            //lớp sách
            Sach sach = new Sach();
            Sach.MatKhau = MatKhau;
            Sach.MaSite = MaSite;
            Sach.TenDangNhap = TenDangNhap;
            //
            DataSet dsTK;
            DataTable dtTK = null;
            if (cbxTieuChiTim.Text != "Thể Loại")
            {
                try
                {
                    string TenThuocTinh = "";
                    //lấy tên thuộc tính
                    for (int i = 0; i < dgvSach.Columns.Count; i++)
                    {
                        if (dgvSach.Columns[i].HeaderText == cbxTieuChiTim.Text)
                            TenThuocTinh = dgvSach.Columns[i].Name;
                    }
                    //lấy tên bảng
                    string TenBang = sach.TimTenBang(TenThuocTinh);
                    //

                    //
                    dsTK = sach.TimKiem(txtTimKiem.Text.Trim(), TenBang.Trim(), TenThuocTinh.Trim());

                    dgvSach.Refresh();
                    dgvSach.DataSource = dsTK.Tables[0];
                    //chuyển đổi DL
                    ChuyenDoiDL();
                }
                catch (Exception)
                {
                    dgvSach.DataSource = null;
                }
            }
            else
            {
                if (cbxTheLoaiDuocTim.Text != "Chọn thể loại")
                {
                    dtTK = sach.TimTheoTheLoai(cbxTheLoaiDuocTim.SelectedValue.ToString());
                    dgvSach.Refresh();
                    dgvSach.DataSource = dtTK;
                    //chuyển đổi DL
                    ChuyenDoiDL();
                }
            }
            
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lớp sách
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = MatKhau;
                Sach.MaSite = MaSite;
                //
                int crR = dgvSach.CurrentRow.Index;
                txtMaSach.Text = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();
                txtTenSach.Text = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();
                txtSoLuong.Text = dgvSach.Rows[crR].Cells[2].Value.ToString().Trim();
                txtTheLoai.Text = dgvSach.Rows[crR].Cells[5].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[crR].Cells[6].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[crR].Cells[7].Value.ToString().Trim();
                txtSoTrang.Text = dgvSach.Rows[crR].Cells[8].Value.ToString().Trim();
                txtNgonNgu.Text = dgvSach.Rows[crR].Cells[9].Value.ToString().Trim();
                //
                txtKhu.Text = sach.LayKhuChuaSach(txtMaSach.Text);
                txtKe.Text = sach.LayKeChuaSach(txtMaSach.Text);
            }
            catch (Exception)
            {
            }
        }

        private void cbxTieuChiTim_TextChanged(object sender, EventArgs e)
        {
            if (cbxTieuChiTim.Text == "Thể Loại")
                txtTimKiem.Visible = false;
            else
                txtTimKiem.Visible = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            //lớp sách 
            Sach sach = new Sach();
            Sach.MatKhau = MatKhau;
            Sach.MaSite = MaSite;
            Sach.TenDangNhap = TenDangNhap;
            if (btnMua.Text == "Mua")
            {

                //
                if (txtSoLuongMua.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng để mua !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuongMua.Focus();
                }
                else
                {
                    try
                    {
                        int crR = dgvSach.CurrentRow.Index;
                        int SoLuong = int.Parse(txtSoLuongMua.Text.ToString().Trim());
                        int SoLuongCSDL = int.Parse(txtSoLuong.Text.ToString().Trim());
                        if (SoLuong > 0 && SoLuongCSDL > 0 && SoLuong <= SoLuongCSDL)
                        {
                            string MaSach = txtMaSach.Text.ToString().Trim();
                            bool tl = sach.CapNhatSoLuongSach(MaSach, (SoLuongCSDL - SoLuong).ToString());
                            bool DaCoSach = false;
                            int DongSach = 0;
                            //
                            for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                            {
                                if (dgvGioHang.Rows[i].Cells[0].Value.ToString() == MaSach && dgvGioHang.Rows[i].Cells[6].Value.ToString() == "Mua")
                                {
                                    DongSach = i;
                                    DaCoSach = true;
                                    i = dgvGioHang.Rows.Count;
                                }
                            }
                            if (DaCoSach)
                            {
                                int SLMoi = int.Parse(dgvGioHang.Rows[DongSach].Cells[2].Value.ToString()) + SoLuong;
                                dgvGioHang.Rows[DongSach].Cells[2].Value = SLMoi.ToString();
                            }
                            else
                            {
                                //thêm vào giỏ
                                DataGridViewRow dgR = (DataGridViewRow)dgvGioHang.Rows[0].Clone();
                                dgR.Cells[0].Value = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();//mã sách 
                                dgR.Cells[1].Value = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();//tên sách
                                dgR.Cells[2].Value = txtSoLuongMua.Text.ToString().Trim();//số lượng
                                dgR.Cells[3].Value = txtTheLoai.Text.ToString().Trim();//thể loại
                                dgR.Cells[4].Value = txtTacGia.Text.ToString().Trim();//tác giả
                                dgR.Cells[5].Value = txtGiaBan.Text.ToString().Trim();//giá bán
                                dgR.Cells[6].Value = "Mua";//trạng thái
                                dgvGioHang.Rows.Add(dgR);
                            }
                            //
                            if (tl)
                                MessageBox.Show("Mua thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Mua thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadDL();
                        }
                        else
                        {
                            MessageBox.Show("Không đủ sách để mua !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoLuongMua.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Số lượng nhập không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuongMua.Focus();
                    }
                }
            }
            else//thanh toán
            {
                if (ThanhToan)
                    MessageBox.Show("Bạn đã thanh toán rồi !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    HoaDon hd = new HoaDon();
                    HoaDon.MaSite = MaSite;
                    HoaDon.TenDangNhap = TenDangNhap;
                    HoaDon.MatKhau = MatKhau;
                    //
                    DataTable dt = new DataTable();
                    dt = hd.LayDanhSachHoaDon();
                    int dong = dt.Rows.Count + 1;
                    string MaHD = "HD-0" + dong;
                    bool tlHD = hd.TaoHoaDon(MaHD, txtTongTien.Text, MaNV);
                    if (!tlHD)
                        MessageBox.Show("Không tạo được hóa đơn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        int i = 0;
                        ChiTietHoaDon cthd = new ChiTietHoaDon();
                        ChiTietHoaDon.MaSite = MaSite;
                        ChiTietHoaDon.TenDangNhap = TenDangNhap;
                        ChiTietHoaDon.MatKhau = MatKhau;

                        //danh sach mảnh chứa cthd
                        DataTable dtct = new DataTable();

                        for (i = 0; i < dgvGioHang.Rows.Count - 1; i++)
                        {
                            //các chi tiết đã có trong CSDL
                            dtct = cthd.LayDanhSachChiTietHoaDon();
                            //lấy mã thể loại dựa trên tên thể loại 
                            string MaTheLoai = sach.LayMaTheloai(dgvGioHang.Rows[i].Cells[3].Value.ToString().Trim()).Trim();
                            //

                            //
                            int dongct = dtct.Rows.Count + 1;
                            string MaCTHD = "CTHD-0" + dongct;
                            string NgayBan = System.DateTime.Now.Date.ToString("yyyy/MM/dd");
                            string GiaTien = dgvGioHang.Rows[i].Cells[5].Value.ToString().Trim();
                            string SoLuong = dgvGioHang.Rows[i].Cells[2].Value.ToString().Trim();
                            string MaSach = dgvGioHang.Rows[i].Cells[0].Value.ToString().Trim();
                            //
                            bool tlCT = cthd.TaoChiTietHoaDon(MaTheLoai, MaCTHD, MaHD, NgayBan, GiaTien, SoLuong, MaSach);
                        }
                        ThanhToan = true;
                        MessageBox.Show("Thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lấy kí tự trên luồng nhập
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            //chuyeern sang kí tự
            char decimalChar = Convert.ToChar(decimalString);
            //só sánh
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))//ko phải kí tự và phím điều khiển
            {
                e.Handled = true;
            }
        }
        //xem giỏ hàng
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
            {
                string tinhTrang=dgvGioHang.Rows[i].Cells[6].Value.ToString();
                if (tinhTrang.Trim() == "Mua")
                {
                    int giaTien = int.Parse(dgvGioHang.Rows[i].Cells[5].Value.ToString());
                    int soLuong = int.Parse(dgvGioHang.Rows[i].Cells[2].Value.ToString());
                    tongTien += giaTien * soLuong;
                }
            }
            txtTongTien.Text = tongTien.ToString();
            //
            if(btnGioHang.Text=="Giỏ hàng")
            {
                txtSoLuongMua.Visible= false;
                lbSoLuongBan.Visible = false;
                dgvGioHang.Visible = true;
                btnGioHang.Text = "Sách";
                btnMua.Text = "Thanh Toán";
                btnHuy.Visible = true;
                btnTaiLai.Visible = false;
                btnBoKhoiGio.Visible = true;
                //btnDoi.Visible = false;
            }
            else
            {
                txtSoLuongMua.Visible = true;
                lbSoLuongBan.Visible = true;
                dgvGioHang.Visible = false;
                btnGioHang.Text = "Giỏ hàng";
                btnMua.Text = "Mua";
                btnHuy.Visible = false;
                btnTaiLai.Visible = true;
                btnBoKhoiGio.Visible = false;
                //btnDoi.Visible = true;
            }
        }
        //bỏ sản phẩm
        private void btnBoKhoiGio_Click(object sender, EventArgs e)
        {
            try
            {
                int CrR = dgvGioHang.CurrentRow.Index;
                DataGridViewRow dgvR = dgvGioHang.Rows[CrR];
                int SLTra = int.Parse(dgvGioHang.Rows[CrR].Cells[2].Value.ToString());
                string MaSach = dgvGioHang.Rows[CrR].Cells[0].Value.ToString();
                TraSachKhongMua(SLTra, MaSach);
                dgvGioHang.Rows.Remove(dgvR);

            }
            catch (Exception)
            {
                MessageBox.Show("Không có gì để bỏ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //trả lại số sách ko mua
        void TraSachKhongMua(int SLTra, string MaSach)
        {
            //lớp sách 
            Sach sach = new Sach();
            Sach.MatKhau = MatKhau;
            Sach.MaSite = MaSite;
            Sach.TenDangNhap = TenDangNhap;
            //
            int SoLuongCSDL = 0;
            for (int i = 0; i < dgvSach.Rows.Count - 1; i++)
            {
                if (dgvSach.Rows[i].Cells[0].Value.ToString().Trim() == MaSach)
                {
                    SoLuongCSDL = int.Parse(dgvSach.Rows[i].Cells[2].Value.ToString());
                    i = dgvSach.Rows.Count;
                }
                bool tl = sach.CapNhatSoLuongSach(MaSach, (SoLuongCSDL + SLTra).ToString());
            }
        }

        //trả lại tất cả hàng khi chưa thanh toán
        void TraHangChuaThanhToan()
        {
            for (int i = 0; i < dgvGioHang.Rows.Count - 1; i++)
            {
                int SoLong = int.Parse(dgvGioHang.Rows[i].Cells[2].Value.ToString());
                string MaSach = dgvGioHang.Rows[i].Cells[0].Value.ToString();
                TraSachKhongMua(SoLong, MaSach);
            }
        }

        //không mua nữa
        private void btnHuy_Click(object sender, EventArgs e)
        {
            TraHangChuaThanhToan();
            dgvGioHang.Rows.Clear();
            dgvGioHang.Refresh();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            int crR = dgvSach.CurrentRow.Index;
            //thêm vào giỏ
            if (crR >= 0)
            {
                DataGridViewRow dgR = (DataGridViewRow)dgvGioHang.Rows[0].Clone();
                dgR.Cells[0].Value = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();//mã sách 
                dgR.Cells[1].Value = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();//tên sách
                dgR.Cells[2].Value = txtSoLuongMua.Text.ToString().Trim();//số lượng
                dgR.Cells[3].Value = txtTheLoai.Text.ToString().Trim();//thể loại
                dgR.Cells[4].Value = txtTacGia.Text.ToString().Trim();//tác giả
                dgR.Cells[5].Value = txtGiaBan.Text.ToString().Trim();//giá bán
                dgR.Cells[6].Value = "Đổi";//trạng thái
                dgvGioHang.Rows.Add(dgR);
            }
        }
    }
}
