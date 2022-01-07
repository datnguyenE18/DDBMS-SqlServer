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
using System.Data;

namespace DemoPhanTan
{
    public partial class Frm_ThongKeDonHang : Form
    {
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        public String MaNV = "";
        public Frm_ThongKeDonHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            ThongKe.MaSite = MaSite;
            ThongKe.MatKhau = PassWord;
            ThongKe.TenDangNhap = TenDangNhap;

            DataTable dt = tk.LamThongKeDH(dtpNgayTu.Text.ToString(), dtpNgayDen.Text.ToString());

            dgvThongKe.DataSource = dt;

            int tongTien = 0;
            //
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int dg = int.Parse(dt.Rows[i][3].ToString());
                int sl = int.Parse(dt.Rows[i][4].ToString());
                tongTien += dg * sl;
            }
            txtTongTien.Text = tongTien.ToString();
        }
    }
}
