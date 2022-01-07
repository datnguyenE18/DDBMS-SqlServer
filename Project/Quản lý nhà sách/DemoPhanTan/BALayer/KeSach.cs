using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
namespace BALayer
{
    public class KeSach
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public KeSach()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayThongTinKeSach()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("KeSach", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from KeSach";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        ////lấy tên Khu dựa trên mã Khu
        public String LayTenKhu(string MaKhu)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenKhu from KhuDeSach where MaKhu = '" + MaKhu + "'";
                DAL.stringConnection = conn;
                DataTable dtSach = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtSach.Rows[0][0].ToString();

            }
            catch (Exception)
            {
                return "N/A";
            }
        }
        //
        //lấy danh sách chức vụ
        public DataTable LayDanhSachKhu()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("KhuDeSach", MaSite);
                string Query = "select " + ThuocTinh + " from KhuDeSach";
                DAL.stringConnection = conn;
                DataTable dtSach = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtSach;

            }
            catch (Exception)
            {
                return null;
            }
        }
        //Xoa Ke Sach
        public bool XoaKeSach(string MaKe)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                //string TTTSachach = da.LayThuocTinhString("Sach");
                //
                string Query = "Delete From KeSach where MaKe='" + MaKe + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //tìm Ma Khu dựa trên tên Khu
        public string TimMaKhu(string tenKhu)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select MaKhu from KhuDeSach where TenKhu = '" + tenKhu + "'";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "K-A";
            }
        }
        //Them Ke Sach
        public bool ThemKeSach(string MaKe, string TenKe, string MaKhu)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("KeSach", MaSite);
                //
                string Query = "INSERT INTO KeSach (" + TTTNV + ") VALUES ('"+ MaKe +"', N'"+ TenKe +"' , '"+ MaKhu +"')";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //cập nhật Kệ
        public bool CapNhatKe(string MaKe, string TenKe, string MaKhu)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
               
                string Query = "update KeSach " +
                        " set TenKe = N'" + TenKe + "',MaKhu='" + MaKhu + "' where MaKe = '" + MaKe + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
