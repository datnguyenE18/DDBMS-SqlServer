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
    public partial class frm_QLSach : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_QLSach()
        {
            InitializeComponent();
        }

        private void frm_QLSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            txtTimKiem.Visible = false;
            //nút
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //lớp sách
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = PassWord;
                Sach.MaSite = MaSite;
                //
                int crR = dgvSach.CurrentRow.Index;
                txtMaSach.Text = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();
                txtTenSach.Text = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();
                txtSoLuong.Text = dgvSach.Rows[crR].Cells[2].Value.ToString().Trim();
                cbxNXB.Text = dgvSach.Rows[crR].Cells[3].Value.ToString();
                cbxNhaCC.Text = dgvSach.Rows[crR].Cells[4].Value.ToString();
                cbxTheLoai.Text = dgvSach.Rows[crR].Cells[5].Value.ToString();
                cbxTacGia.Text = dgvSach.Rows[crR].Cells[6].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[crR].Cells[7].Value.ToString().Trim();
                txtSoTrang.Text = dgvSach.Rows[crR].Cells[8].Value.ToString().Trim();
                txtNgonNgu.Text = dgvSach.Rows[crR].Cells[9].Value.ToString().Trim();
                txtISBN.Text = dgvSach.Rows[crR].Cells[10].Value.ToString().Trim();
                txtGiaNhap.Text = dgvSach.Rows[crR].Cells[11].Value.ToString().Trim();
                //
                cbxKhu.Text = sach.LayKhuChuaSach(txtMaSach.Text);
                cbxKe.Text = sach.LayKeChuaSach(txtMaSach.Text);
            }
            catch (Exception)
            { }

        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            //lớp sách
            Sach sach = new Sach();
            Sach.MatKhau = PassWord;
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
            //chuyển đổi DL
            ChuyenDoiDL();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            //nút
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            //nút
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //deEnable
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoTrang.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtISBN.Enabled = false;
            txtGiaNhap.Enabled = false;
        }
        //
        bool Them = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            //reset text
            txtMaSach.ResetText();
            txtTenSach.ResetText();
            txtSoLuong.ResetText();
            txtGiaBan.ResetText();
            txtSoTrang.ResetText();
            txtNgonNgu.ResetText();
            txtISBN.ResetText();
            txtGiaNhap.ResetText();
            //Enable
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaBan.Enabled = true;
            txtSoTrang.Enabled = true;
            txtNgonNgu.Enabled = true;
            txtISBN.Enabled = true;
            txtGiaNhap.Enabled = true;
            //cbx
            cbxNXB.Enabled = true;
            cbxNhaCC.Enabled = true;
            cbxTheLoai.Enabled = true;
            cbxTacGia.Enabled = true;
            cbxKhu.Enabled = true;
            cbxKe.Enabled = true;
            //đang thêm không thể sửa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //nút
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lớp sách
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = PassWord;
                Sach.MaSite = MaSite;
                //
                if (Them)
                {
                    //
                    string MaSach = txtMaSach.Text.Trim();
                    string TenSach = txtTenSach.Text.Trim();
                    string SoLuong = txtSoLuong.Text.Trim();
                    string NXB = cbxNXB.SelectedValue.ToString();
                    string NCC = cbxNhaCC.SelectedValue.ToString();
                    string TheLoai = cbxTheLoai.SelectedValue.ToString();
                    string TacGia = cbxTacGia.SelectedValue.ToString();
                    string GiaBan = txtGiaBan.Text.Trim();
                    string SoTrang = txtSoTrang.Text.ToString().Trim();
                    string NgonNgu = txtNgonNgu.Text.ToString().Trim();
                    string ISBN = txtISBN.Text.ToString().Trim();
                    string GiaNhap = txtGiaNhap.Text.ToString().Trim();
                    //
                    bool tl = sach.ThemSach(MaSach,TenSach,SoLuong,NXB,NCC,TheLoai,TacGia,GiaBan,SoTrang,NgonNgu,ISBN,GiaNhap);
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
                    string MaSachVao = txtMaSach.Text.Trim();
                    string TenSachVao = txtTenSach.Text.Trim();
                    string SoLuongVao = txtSoLuong.Text.Trim();
                    string NXBVao = cbxNXB.SelectedValue.ToString();
                    string NCCVao = cbxNhaCC.SelectedValue.ToString();
                    string TheLoaiVao = cbxTheLoai.SelectedValue.ToString();
                    string TacGiaVao = cbxTacGia.SelectedValue.ToString();
                    string GiaBanVao = txtGiaBan.Text.Trim();
                    string SoTrangVao = txtSoTrang.Text.ToString().Trim();
                    string NgonNguVao = txtNgonNgu.Text.ToString().Trim();
                    string ISBNVao = txtISBN.Text.ToString().Trim();
                    string GiaNhapVao = txtGiaNhap.Text.ToString().Trim();

                    //DL trong CSDL
                    int crR = dgvSach.CurrentRow.Index;
                    string TenSachCSDL = dgvSach.Rows[crR].Cells[1].Value.ToString();
                    string SoLuongCSDL = dgvSach.Rows[crR].Cells[2].Value.ToString();
                    string NXBCSDL = dgvSach.Rows[crR].Cells[3].Value.ToString();
                    string NhaCCCSDL = dgvSach.Rows[crR].Cells[4].Value.ToString();
                    string TheLoaiCSDL = dgvSach.Rows[crR].Cells[5].Value.ToString();
                    string TacGiaCSDL = dgvSach.Rows[crR].Cells[6].Value.ToString();
                    string GiaBanCSDL = dgvSach.Rows[crR].Cells[7].Value.ToString();
                    string SoTrangCSDL = dgvSach.Rows[crR].Cells[8].Value.ToString();
                    string NgonNguCSDL = dgvSach.Rows[crR].Cells[9].Value.ToString();
                    string ISBNCSDL = dgvSach.Rows[crR].Cells[10].Value.ToString();
                    string GiaNhapCSDL = dgvSach.Rows[crR].Cells[11].Value.ToString();

                    if (TenSachVao == TenSachCSDL && SoLuongVao == SoLuongCSDL && NXBVao == NXBCSDL && TheLoaiVao == TheLoaiCSDL
                        && TacGiaVao == TacGiaCSDL && GiaBanVao == GiaBanCSDL && SoTrangVao == SoTrangCSDL
                        && NgonNguVao == NgonNguCSDL && ISBNVao == ISBNCSDL && GiaNhapVao == GiaNhapCSDL)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDuLieu();
                    }
                    else
                    {
                        bool tl= sach.CapNhatSach(MaSachVao, TenSachVao, SoLuongVao, NXBVao, NCCVao, 
                                    TheLoaiVao, TacGiaVao, GiaBanVao, SoTrangVao, NgonNguVao, ISBNVao, GiaNhapVao);
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
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm !!!", "Thông báo",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDuLieu();
            //
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            //deEnable
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoTrang.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtISBN.Enabled = false;
            txtGiaNhap.Enabled = false;
            //cbx
            cbxNXB.Enabled = false;
            cbxNhaCC.Enabled = false;
            cbxTheLoai.Enabled = false;
            cbxTacGia.Enabled = false;
            cbxKhu.Enabled = false;
            cbxKe.Enabled = false;
            //nút
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        //nhấn enter
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTKSach_Click(sender, e);
            }
        }

        //
        private void cbxTieuChiTim_TextChanged(object sender, EventArgs e)
        {
            if (cbxTieuChiTim.Text == "Thể Loại")
                txtTimKiem.Visible = false;
            else
                txtTimKiem.Visible = true;
        }

        //chuyển các mã NCC,NXB,mã thể loại vv.. thành tên
        void ChuyenDoiDL()
        {
            //lớp sách
            Sach sach = new Sach();
            Sach.MatKhau = PassWord;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //nút
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            //deEnable
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoTrang.Enabled = false;
            txtNgonNgu.Enabled = false;
            txtISBN.Enabled = false;
            txtGiaNhap.Enabled = false;
            //cbx
            cbxNXB.Enabled = false;
            cbxNhaCC.Enabled = false;
            cbxTheLoai.Enabled = false;
            cbxTacGia.Enabled = false;
            cbxKhu.Enabled = false;
            cbxKe.Enabled = false;
            //
            btnReLoad_Click(sender, e);

        }
        
        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //Enable
            txtTenSach.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaBan.Enabled = true;
            txtSoTrang.Enabled = true;
            txtNgonNgu.Enabled = true;
            txtISBN.Enabled = true;
            txtGiaNhap.Enabled = true;
            //nút
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //cbx
            cbxNXB.Enabled = true;
            cbxNhaCC.Enabled = true;
            cbxTheLoai.Enabled = true;
            cbxTacGia.Enabled = true;
            cbxKhu.Enabled = true;
            cbxKe.Enabled = true;
            //sửa
            Them = false;
        }

        //chỉ cho phép nhập số
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
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

        //load dữ liệu ban đầu
        void LoadDuLieu()
        {
            try
            {
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = PassWord;
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
                cbxNXB.Text = sach.LayTenNXB(dgvSach.Rows[crR].Cells[3].Value.ToString());
                cbxNhaCC.Text = dgvSach.Rows[crR].Cells[4].Value.ToString();
                cbxTheLoai.Text = sach.LayTenTheloai(dgvSach.Rows[crR].Cells[5].Value.ToString());
                cbxTacGia.Text = dgvSach.Rows[crR].Cells[6].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[crR].Cells[7].Value.ToString().Trim();
                txtSoTrang.Text = dgvSach.Rows[crR].Cells[8].Value.ToString().Trim();
                txtNgonNgu.Text = dgvSach.Rows[crR].Cells[9].Value.ToString().Trim();
                txtISBN.Text = dgvSach.Rows[crR].Cells[10].Value.ToString().Trim();
                txtGiaNhap.Text = dgvSach.Rows[crR].Cells[11].Value.ToString().Trim();
                //
                cbxKhu.Text = sach.LayKhuChuaSach(txtMaSach.Text);
                cbxKe.Text = sach.LayKeChuaSach(txtMaSach.Text);

                //đổ DL vào cbx thể loại
                cbxTheLoai.DataSource = sach.LayDanhSachTheLoai();
                cbxTheLoai.DisplayMember = "TenTheLoai";
                cbxTheLoai.ValueMember = "MaTheLoai";

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

                //cbx nhà cung cấp
                cbxNhaCC.DataSource = sach.LayDanhSachNCC();
                cbxNhaCC.DisplayMember = "TenNCC";
                cbxNhaCC.ValueMember = "MaNCC";

                //cbx nhà xuất bản
                cbxNXB.DataSource = sach.LayDanhSachNXB();
                cbxNXB.DisplayMember = "TenNXB";
                cbxNXB.ValueMember = "MaNXB";

                //cbx tác giả
                cbxTacGia.DataSource = sach.LayDanhSachTacGia();
                cbxTacGia.DisplayMember = "TenTacGia";
                cbxTacGia.ValueMember = "MaTacGia";

                //cbx khu chứa sách
                cbxKhu.DataSource = sach.LayDanhSachKhu();
                cbxKhu.DisplayMember = "TenKhu";
                cbxKhu.ValueMember = "MaKhu";

                //cbx kệ chứa sách
                cbxKe.DataSource = sach.LayDanhSachKe();
                cbxKe.DisplayMember = "TenKe";
                cbxKe.ValueMember = "MaKe";

                //chuyển đổi dữ liệu
                ChuyenDoiDL();
                //cập nhật
                cbxTacGia.Text = dgvSach.Rows[crR].Cells[6].Value.ToString();
            }
            catch (Exception)
            { }
        }

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

        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb=MessageBox.Show("Bạn chắc chắn xóa cuốn sách này ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                //lớp sách
                Sach sach = new Sach();
                Sach.TenDangNhap = TenDangNhap;
                Sach.MatKhau = PassWord;
                Sach.MaSite = MaSite;
                //
                //xử lý
                //DL 
                string MaSachVao = txtMaSach.Text.Trim();
                string TenSachVao = txtTenSach.Text.Trim();
                bool tl = sach.XoaSach(MaSachVao, TenSachVao);
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

        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lấy kí tự trên luồng nhập
            string decimalString = txtMaSach.Text;
            //
            if (decimalString.Length >= 10)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
            int test = e.KeyChar;
        }
    }
}
