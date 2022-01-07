using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class TheLoai
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        //
        public TheLoai()
        {
            da = new DAL();     
        }
        //
        //lấy thông tin Ke Sach
        public DataSet LayThongTinTheLoai()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("TheLoai", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from TheLoai";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }
        //
        ////lấy tên Nhan Vien dựa trên ma Nhan Vien
        public String LayTenKeSach(string MaKe)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenKe from KeSach where MaKe = '" + MaKe + "'";
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
        //lấy danh sách Ke
        public DataTable LayDanhSachKe()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("KeSach", MaSite);
                string Query = "select " + ThuocTinh + " from KeSach";
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
        public String LayMaKhu(string tenKe)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select MaKhu from KeSach where TenKe = N'" + tenKe + "'";
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
        //Lay TenKhu
        public String LayTenKhu(string maKhu)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenKhu from KhuDeSach where MaKhu = '" + maKhu + "'";
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
    }
}
