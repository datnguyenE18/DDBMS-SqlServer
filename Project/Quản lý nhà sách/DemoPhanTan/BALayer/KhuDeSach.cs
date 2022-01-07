using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class KhuDeSach
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public KhuDeSach()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayThongTinKhuDeSach()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("KhuDeSach", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from KhuDeSach";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        ////lấy tên Nhan Vien dựa trên ma Nhan Vien
        public String LayTenNhanVien(string MaNV)
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
                return "N/A";
            }
        }
        //
        //lấy danh sách Nhan Vien
        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("NhanVien", MaSite);
                string Query = "select " + ThuocTinh + " from NhanVien";
                DAL.stringConnection = conn;
                DataTable dtNhanVien = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtNhanVien;

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        //Xoa Ke Sach
        public bool XoaKhuDeSach(string MaKhu)
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
                string Query = "Delete From KhuDeSach where MaKhu='" + MaKhu + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //tìm Ma NV dựa trên tên NV
        public string TimMaNV(string tenNV)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select MaNV from NhanVien where TenNV = N'" + tenNV + "'";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        //Them Khu De Sach
        public bool ThemKhuDeSach(string MaKhu, string TenKhu, string MaNV)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("KhuDeSach", MaSite);
                //
                string Query = "INSERT INTO KhuDeSach (" + TTTNV + ") VALUES ('" + MaKhu + "', N'" + TenKhu + "' , '" + MaNV + "')";
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
        public bool CapNhatKhuDeSach(string MaKhu, string TenKhu, string maNV)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);

                string Query = "update KhuDeSach " +
                        " set TenKhu = N'" + TenKhu + "',MaNV='" + maNV + "' where MaKhu = '" + MaKhu + "'";
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
