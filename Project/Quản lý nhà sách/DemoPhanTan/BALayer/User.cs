using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class User
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        DAL db = null;
        
        public User()
        {
            db = new DAL();
            
        }

        public String LayPass(string TenUs)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsUs = db.ExecuteQueryDataSet(
                                "select MatKhau from TaiKhoan where TaiKhoan='" + TenUs + "'",
                                 CommandType.Text);
                DataTable dtUs = dsUs.Tables[0];
                if (dtUs == null)
                    return "!!!";
                return dtUs.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "!!!";
            }
        }

        public String LayMaSite(string TenUs)
        {
            string QuerySQl = "select MaSite from DSTaiKhoanSiteDuLieu where TaiKhoan='" + TenUs + "'";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsUs = db.ExecuteQueryDataSet(QuerySQl,
                                 CommandType.Text
                                            );
                DataTable dtUs = dsUs.Tables[0];
                if (dtUs == null)
                    return "!!!";
                return dtUs.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "!!!";
            }
        }

        //public String LayPassData(string MaSite,string MaNV)
        //{
        //    try
        //    {
        //        DAL.User = TenDangNhap;
        //        DAL.Pass = MatKhau;
        //        DAL da = new DAL();
        //        String conn = da.getConnectStrSite(MaSite);
        //        String Query = "select MatKhau from NhanVien where MaNV='" + MaNV + "'";
        //        //chuỗi két nối khác
        //        DAL.stringConnection = conn;
        //        DataSet dsPa = db.ExecuteQueryDataSet(Query, CommandType.Text);
        //        //
        //        DataTable dtPa = dsPa.Tables[0];
        //        //
        //        return dtPa.Rows[0][0].ToString();
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
        //
        public String LayPassData(string MaSite, string MaNV)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select MatKhau from NhanVien where MaNV='" + MaNV + "'";
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
