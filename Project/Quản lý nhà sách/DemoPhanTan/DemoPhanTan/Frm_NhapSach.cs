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
    public partial class Frm_NhapSach : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public String MaNV = "";
        public Frm_NhapSach()
        {
            InitializeComponent();
        }

        private void Frm_NhapSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();

            txtTimKiem.Visible = false;
            //
            //cbx tiêu chí tìm
            if (cbxTieuChiTim.Items.Count < dgvSach.Columns.Count - 1)
            {
                for (int i = 1; i < dgvSach.Columns.Count; i++)
                {
                    cbxTieuChiTim.Items.Add(dgvSach.Columns[i].HeaderText);
                }
                cbxTieuChiTim.Text = cbxTieuChiTim.Items[0].ToString();
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
                txtTenSach.Text = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();
                //
                //cbx tiêu chí tìm
                if (cbxTieuChiTim.Items.Count < dgvSach.Columns.Count - 1)
                {
                    for (int i = 1; i < dgvSach.Columns.Count; i++)
                    {
                        cbxTieuChiTim.Items.Add(dgvSach.Columns[i].HeaderText);
                    }
                    cbxTieuChiTim.Text = cbxTieuChiTim.Items[0].ToString();
                }
                //đổ DL vào cbx thể loại
                cbxTheLoaiDuocTim.DataSource = sach.LayDanhSachTheLoai();
                cbxTheLoaiDuocTim.DisplayMember = "TenTheLoai";
                cbxTheLoaiDuocTim.ValueMember = "MaTheLoai";

                //đổ DL vào cbx Mã sách
                cbxMaSach.DataSource = sach.LayDLBangSach();
                cbxMaSach.DisplayMember = "MaSach";
                cbxMaSach.ValueMember = "MaSach";
                //chuyển đổi dữ liệu
                ChuyenDoiDL();

                txtTimKiem.Visible = false;
            }
            catch (Exception)
            { }
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
                cbxMaSach.Text = dgvSach.Rows[crR].Cells[0].Value.ToString().Trim();
                txtTenSach.Text = dgvSach.Rows[crR].Cells[1].Value.ToString().Trim();

            }
            catch (Exception)
            { }
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
            for (int i = 0; i < dgvSach.Rows.Count; i++)
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

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QLSach frm = new frm_QLSach();
            frm.TenDangNhap = TenDangNhap;
            frm.PassWord = PassWord;
            frm.MaSite = MaSite;
            //
            frm.ShowDialog();
            this.Show();
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
                }
            }
            //chuyển đổi DL
            ChuyenDoiDL();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void cbxTieuChiTim_TextChanged(object sender, EventArgs e)
        {
            if (cbxTieuChiTim.Text == "Thể Loại")
                txtTimKiem.Visible = false;
            else
                txtTimKiem.Visible = true;
        }

        private void cbxMaSach_TextChanged(object sender, EventArgs e)
        {
            if (cbxMaSach.Text != "")
            {
                //lớp sách
                Sach sach = new Sach();
                Sach.MatKhau = PassWord;
                Sach.MaSite = MaSite;
                Sach.TenDangNhap = TenDangNhap;
                //
                txtTenSach.Text = sach.LayTenSach(cbxMaSach.Text);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int SoLuongNhap=int.Parse(txtSoLuongNhap.Text.ToString());
            if (txtSoLuongNhap.Text != "" && SoLuongNhap > 0)
            {
                int SLTrongCSDL = 0;
                string MaSach = cbxMaSach.Text.ToString().Trim();
                int Dong = dgvSach.Rows.Count;
                for (int i = 0; i < Dong; i++)
                {
                    if (MaSach == dgvSach.Rows[i].Cells[0].Value.ToString().Trim())
                    {
                        SLTrongCSDL = int.Parse(dgvSach.Rows[i].Cells[2].Value.ToString());
                        i = Dong;
                    }
                }
                int SoLuongMoi = SLTrongCSDL + SoLuongNhap;
                //lớp sách
                Sach sach = new Sach();
                Sach.MatKhau = PassWord;
                Sach.MaSite = MaSite;
                Sach.TenDangNhap = TenDangNhap;
                //
                bool tl = sach.CapNhatSoLuongSach(MaSach, SoLuongMoi.ToString());
                if (tl)
                {
                    MessageBox.Show("Nhập sách thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    MessageBox.Show("Nhập sách không thành công !", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hãy xem lại số lượng nhập !", "Thông báo",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
