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
    public partial class frm_CTHoaDonNhap : Form
    {
        public frm_CTHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frm_CTHoaDonNhap_Load(object sender, EventArgs e)
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
                DataTable dtSach = HDB.LayCTHDNhap();
                //
                dgvCTHDN.DataSource = dtSach;

            }
            catch (Exception)
            { }
        }
    }
}
