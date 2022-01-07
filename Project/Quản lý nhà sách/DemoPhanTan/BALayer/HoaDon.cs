using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class HoaDon
    {
        DAL da = null;
        public static String TenDangNhap = "";
        public static String MatKhau = "";
        public static string MaSite = "";
        public HoaDon()
        {
            da = new DAL();
        }

        //lấy danh sách hóa đơn
        public DataTable LayDanhSachHoaDon()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);
            //lấy thuộc tính
            string thuocTinh = da.LayThuocTinhStringManhMaSite("HoaDonBanSach", MaSite);
            //            
            string Query = "select " + thuocTinh + " from HoaDonBanSach";
            DAL.stringConnection = conn;
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsSach.Tables[0];
        }
        //tạo hóa đơn mới
        public bool TaoHoaDon(string MaHD, string TongGiaTri, string MaNV)
        {
            try
            {
                string err = "Error TaoHoaDon";
                //DAL
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //conn
                String conn = da.getConnectStrSite(MaSite);
                //
                //lấy thuộc tính
                string thuocTinh = da.LayThuocTinhStringManhMaSite("HoaDonBanSach", MaSite);
                //
                string Query = "insert into HoaDonBanSach values ('" + MaHD + "','" + TongGiaTri + "' ,'" + MaNV + "')";
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
