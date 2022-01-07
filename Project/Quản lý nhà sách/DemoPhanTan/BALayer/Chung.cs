using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBLayer;

namespace BALayer
{
    public class Chung
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public Chung()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayHDBan()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("HoaDonBanSach", MaSite).Tables[0];
            String SeZone = "";
            String SelectZone = "";
            //lấy các thuộc tính của sách
            foreach (DataRow sa in dtThuocTinh.Rows)
            {
                SeZone += sa[0].ToString().Trim() + ",";
            }
            //bỏ dấu phẩy
            int length = SeZone.Length;
            for (int i = 0; i < length - 1; i++)
            {
                SelectZone += SeZone[i];
            }
            //
            DAL.stringConnection = conn;
            string QueRy = "select " + SelectZone + " from HoaDonBanSach";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        public DataSet LayHDNhap()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("HoaDonNhapSach", MaSite).Tables[0];
            String SeZone = "";
            String SelectZone = "";
            //lấy các thuộc tính của sách
            foreach (DataRow sa in dtThuocTinh.Rows)
            {
                SeZone += sa[0].ToString().Trim() + ",";
            }
            //bỏ dấu phẩy
            int length = SeZone.Length;
            for (int i = 0; i < length - 1; i++)
            {
                SelectZone += SeZone[i];
            }
            //
            DAL.stringConnection = conn;
            string QueRy = "select " + SelectZone + " from HoaDonNhapSach";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        public DataTable LayCTHDBan()
        {
            DAL da = new DAL();
            DataTable dtKQ = new DataTable();

            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("CTHDBanSach", MaSite);

            //thuộc tính của bảng Sách
            string ThuocTinh = da.LayThuocTinhString("CTHDBanSach");
            //câu try vấn
            string Query = "";

            for (int i = 0; i < DSManhQH.Rows.Count; i++)
            {
                if (i != DSManhQH.Rows.Count - 1)
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                else
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + "";
            }

            //chuỗi kết nối
            String conn = da.getConnectStrSite(MaSite);
            DAL.stringConnection = conn;
            //thực thi
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //table
            dtKQ = dsSach.Tables[0];

            return dtKQ;
        }
        //
        public DataTable LayCTHDNhap()
        {
            DAL da = new DAL();
            DataTable dtKQ = new DataTable();

            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("CTHDNhapSach", MaSite);

            //thuộc tính của bảng Sách
            string ThuocTinh = da.LayThuocTinhString("CTHDNhapSach");
            //câu try vấn
            string Query = "";

            for (int i = 0; i < DSManhQH.Rows.Count; i++)
            {
                if (i != DSManhQH.Rows.Count - 1)
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                else
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + "";
            }

            //chuỗi kết nối
            String conn = da.getConnectStrSite(MaSite);
            DAL.stringConnection = conn;
            //thực thi
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //table
            dtKQ = dsSach.Tables[0];

            return dtKQ;
        }
        //
        public String LayTenNV(string MaNV)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenNV from NhanVien where MaNV = '" + MaNV + "'";
                DAL.stringConnection = conn;
                DataTable dtSach = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtSach.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        public String LayTenNCC(string MaNCC)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenNCC from NhaCungCapSach where MaNCC = '" + MaNCC + "'";
                DAL.stringConnection = conn;
                DataTable dtSach = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtSach.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
    }
}
