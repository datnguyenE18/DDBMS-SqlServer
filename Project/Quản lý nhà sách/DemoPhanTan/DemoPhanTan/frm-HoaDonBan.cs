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
    public partial class frm_HoaDonBan : Form
    {
        //
        
        public frm_HoaDonBan()
        {
            InitializeComponent();
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
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
                DataTable dtSach = HDB.LayHDBan().Tables[0];
                //
                dataGridView1.DataSource = dtSach;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[2].Value = HDB.LayTenNV(dataGridView1.Rows[i].Cells[2].Value.ToString().Trim()).Trim();
                }
            }
            catch (Exception)
            { }
        }
    }
}
