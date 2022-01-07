using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class TacGia
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public TacGia()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayThongTinTacGia()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("TacGia", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from TacGia";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        ////lấy tên Khu dựa trên mã Khu
        //Xoa TacGia
        public bool XoaTacGia(string MaTG)
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
                string Query = "Delete From TacGia where MaTacGia='" + MaTG + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //Them Khu De Sach
        public bool ThemTacGia(string MatacGia, string TenTacGia)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("TacGia", MaSite);
                //
                string Query = "INSERT INTO TacGia (" + TTTNV + ") VALUES ('" + MatacGia + "', N'" + TenTacGia +"')";
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
        public bool CapNhatTacGia(string MaTG, string TenTG)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);

                string Query = "update TacGia " +
                        " set TenTacGia = N'" + TenTG +"' where MaTacGia = '" + MaTG + "'";
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
