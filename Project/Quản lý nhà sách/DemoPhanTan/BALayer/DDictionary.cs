using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class DDictionary
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public DDictionary()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayTaiKhoan()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            //String conn = da.getConnectStrSite(MaSite);
            //            
            DAL.stringConnection = DAL.connStringDic;
            string QueRy = "select distinct TaiKhoan.TaiKhoan, TaiKhoan.MatKhau, DSTaiKhoanSiteDuLieu.Quyen, DSTaiKhoanSiteDuLieu.MaSite from TaiKhoan, DSTaiKhoanSiteDuLieu where TaiKhoan.TaiKhoan = DSTaiKhoanSiteDuLieu.TaiKhoan";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        public String LayTenSite(string MaSite)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenSite from SiteDuLieu where MaSite = '" + MaSite + "'";
                DAL.stringConnection = DAL.connStringDic;
                DataTable dt = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dt.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        public String LayTenQuyen(string MaQuyen)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();            
                string Query = "select TenQuyen from Quyen where MaQuyen = '" + MaQuyen + "'";
                DAL.stringConnection = DAL.connStringDic;
                DataTable dt = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dt.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        public DataSet LayDSSite()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            //String conn = da.getConnectStrSite(MaSite);
            //            
            DAL.stringConnection = DAL.connStringDic;
            string QueRy = "select * from SiteDuLieu";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        public DataSet LayChiNhanh()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            //String conn = da.getConnectStrSite(MaSite);
            //            
            DAL.stringConnection = DAL.connStringDic;
            string QueRy = "select MaSite, TenSite from SiteDuLieu";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        public String LayQuyen(string MaSite, string TaiKhoan)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                string Query = "Select TenQuyen from Quyen where MaQuyen = (select Quyen from DSTaiKhoanSiteDuLieu where TaiKhoan = '"+TaiKhoan+"' and MaSite = '"+MaSite+"')";
                DAL.stringConnection = DAL.connStringDic;
                DataTable dt = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dt.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return "Deny";
            }
        }
        //
        public DataSet LayDSQuyen()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            //String conn = da.getConnectStrSite(MaSite);
            //            
            DAL.stringConnection = DAL.connStringDic;
            string QueRy = "select * from Quyen";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        public bool ThemTK(string TaiKhoan, string MatKhau, string MaSites, string MaQuyen)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                bool m, n;
                string abc = da.LayTenDB(MaSites).ToString().Trim();
                string Query = "INSERT INTO TaiKhoan (TaiKhoan, MatKhau) VALUES ('" + TaiKhoan + "', '" + MatKhau + "')";
                string Query2 = "INSERT INTO DSTaiKhoanSiteDuLieu (TaiKhoan, MaSite, Quyen) VALUES ('" + TaiKhoan + "', '" + MaSites + "', '" + MaQuyen + "')";
                string Query3 = "CREATE LOGIN " + TaiKhoan + " WITH PASSWORD = '" + MatKhau + "', DEFAULT_DATABASE = " + abc + " , DEFAULT_LANGUAGE = us_english, CHECK_POLICY= OFF; ";
                DAL.stringConnection = DAL.connStringDic;
                m = da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
                n = da.MyExecuteNonQuery(Query2, CommandType.Text, ref err);
                if (m == true && n == true)
                    return da.MyExecuteNonQuery(Query3, CommandType.Text, ref err);
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        public bool CapNhatTK(string TaiKhoan, string MatKhau, string MaSites, string MaQuyen)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //String conn = da.getConnectStrSite(MaSite);
                bool m, n;
                string Query = "update TaiKhoan " +
                        " set MatKhau =" + MatKhau + " where TaiKhoan = '" + TaiKhoan + "'";
                string Query1 = "update DSTaiKhoanSiteDuLieu " +
                        " set MaSite =" + MaSites + " where TaiKhoan = '" + TaiKhoan + "'";
                DAL.stringConnection = DAL.connStringDic;
                m =  da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
                n = da.MyExecuteNonQuery(Query1, CommandType.Text, ref err);
                if (m == true && n == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        public bool XoaTK(string TaiKhoan, string MaSite)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //
                bool m, n;
                string Query = "Delete From DSTaiKhoanSiteDuLieu where TaiKhoan='" + TaiKhoan + "' and MaSite ='"+MaSite+"'";
                string Query1 = "Delete From TaiKhoan where TaiKhoan='" + TaiKhoan + "'";
                DAL.stringConnection = DAL.connStringDic;
                m =  da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
                n = da.MyExecuteNonQuery(Query1, CommandType.Text, ref err);
                if (m == true && n == true)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
