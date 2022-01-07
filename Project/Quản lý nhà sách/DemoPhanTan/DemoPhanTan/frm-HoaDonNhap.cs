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
    public partial class frm_HoaDonNhap : Form
    {
        public frm_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        //
        public String TenDangNhap = "";
        public String PassWord = "";
        public String MaSite = "";
        void LoadDuLieu()
        {
            try
            {
                Chung HDB = new Chung();
                Chung.TenDangNhap = TenDangNhap;
                Chung.MatKhau = PassWord;
                Chung.MaSite = MaSite;
                //
                DataTable dtSach = HDB.LayHDNhap().Tables[0];
                //
                dgvHDN.DataSource = dtSach;
                for (int i = 0; i < dgvHDN.Rows.Count - 1; i++)
                {
                    dgvHDN.Rows[i].Cells[3].Value = HDB.LayTenNV(dgvHDN.Rows[i].Cells[3].Value.ToString().Trim()).Trim();
                    dgvHDN.Rows[i].Cells[2].Value = HDB.LayTenNCC(dgvHDN.Rows[i].Cells[2].Value.ToString().Trim()).Trim();
                }
            }
            catch (Exception)
            { }
        }
    }
}
