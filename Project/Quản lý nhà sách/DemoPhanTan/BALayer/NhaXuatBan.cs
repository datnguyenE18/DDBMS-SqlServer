using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class NhaXuatBan
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public NhaXuatBan()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayThongTinNXB()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("NhaXuatBanSach", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from NhaXuatBanSach";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        //Xoa NXB
        public bool XoaNXB(string MaNXB)
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
                string Query = "Delete From NhaXuatBanSach where MaNXB='" + MaNXB + "'";
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
        public bool ThemNhaXuatBan(string MaNXB, string TenNXB, string DiaChi, string SDT, string Nguoi)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("NhaXuatBanSach", MaSite);
                //
                string Query = "INSERT INTO NhaXuatBanSach (" + TTTNV + ") VALUES ('" + MaNXB + "', N'" + TenNXB + "' , N'" + DiaChi + "' ,N'" + SDT + "' ,N'" + Nguoi + "')";
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
        public bool CapNhatNXB(string MaNXB, string TenNXB, string DiaChi, string SDT, string Nguoi)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);

                string Query = "update NhaXuatBanSach " +
                        " set TenNXB = N'" + TenNXB + "',DiaChiNXB=N'" + DiaChi + "',SDTNXB=N'" + SDT + "',NguoiTiepNhan=N'" + Nguoi + "' where MaNXB = '" + MaNXB + "'";
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
