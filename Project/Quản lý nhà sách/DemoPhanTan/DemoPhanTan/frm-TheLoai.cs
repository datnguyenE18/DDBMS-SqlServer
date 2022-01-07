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
    public partial class frm_TheLoai : Form
    {
        //
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public frm_TheLoai()
        {
            InitializeComponent();
        }

        private void frm_TheLoai_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        void LoadDuLieu()
        {
            TheLoai TL = new TheLoai();
            TheLoai.TenDangNhap = TenDangNhap;
            TheLoai.MatKhau = PassWord;
            TheLoai.MaSite = MaSite;
            dgvTL.DataSource = TL.LayThongTinTheLoai().Tables[0];
            for (int i = 0; i < dgvTL.Rows.Count - 1; i++)
            {
                dgvTL.Rows[i].Cells[2].Value = TL.LayTenKeSach(dgvTL.Rows[i].Cells[2].Value.ToString().Trim());
            }
            //đổ DL lên cbx Khu
            cbxKe.DataSource = TL.LayDanhSachKe();
            cbxKe.DisplayMember = "TenKe";
            cbxKe.ValueMember = "MaKe";

        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            TheLoai TL = new TheLoai();
            TheLoai.TenDangNhap = TenDangNhap;
            TheLoai.MatKhau = PassWord;
            TheLoai.MaSite = MaSite;
            //
            int CrR = dgvTL.CurrentRow.Index;
            txtMaTL.Text = dgvTL.Rows[CrR].Cells[0].Value.ToString();
            txtTenTL.Text = dgvTL.Rows[CrR].Cells[1].Value.ToString();
            cbxKe.Text = dgvTL.Rows[CrR].Cells[2].Value.ToString();
            string a = TL.LayMaKhu(cbxKe.Text.Trim()).Trim();
            txtKhu.Text = TL.LayTenKhu(a);
        }
    }
}
