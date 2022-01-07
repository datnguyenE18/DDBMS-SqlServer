using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
namespace BALayer
{
    public class ThongKe
    {
        //chi tiết hóa đơn nhập sách
        DAL da = null;
        public static String TenDangNhap = "";
        public static String MatKhau = "";
        public static string MaSite = "";
        public ThongKe()
        {
            da = new DAL();
        }
        public DataTable LamThongKeHD(string NgayTu, string NgayDen)
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);

            //lấy danh sách mảnh chứa  chi tiết hóa đơn
            DataTable dtCT = new DataTable();
            dtCT = da.LayDSManhQuanHe("CTHDNhapSach", MaSite);

            ////thuộc tính của bảng CTHD
            string ThuocTinhOut = da.LayThuocTinhString("CTHDNhapSach");
            string ThuocTinh = "";
            int DauPhay = 0;
            for (int j = ThuocTinhOut.Length - 1; j >= 0; j--)
            {
                if (ThuocTinhOut[j] == ',')
                {
                    DauPhay = j;
                    j = -1;
                }
            }
            //bỏ MaNV
            for (int i = 0; i < DauPhay; i++)
            {
                ThuocTinh += ThuocTinhOut[i];
            }

            //lấy thuộc tính
            string Query = "";
            for (int i = 0; i < dtCT.Rows.Count; i++)
            {
                if (i != dtCT.Rows.Count - 1)
                    Query += "Select " + ThuocTinh + " from " + dtCT.Rows[i][0].ToString().Trim() + " union ";
                else
                    Query += "Select " + ThuocTinh + " from " + dtCT.Rows[i][0].ToString().Trim();
            }
            Query = "select " + ThuocTinh + " from (" + Query + ")as CTHD where CTHD.NgayNhap between '" + NgayTu + "' and '" + NgayDen + "'";
            DAL.stringConnection = conn;
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsSach.Tables[0];
        }

        public DataTable LamThongKeDH(string NgayTu, string NgayDen)
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);
            ////thuộc tính của bảng CTHD
            string ThuocTinh = da.LayThuocTinhString("CTHDBanSach");

            //lấy danh sách mảnh chứa  chi tiết hóa đơn
            DataTable dtCT = new DataTable();
            dtCT = da.LayDSManhQuanHe("CTHDBanSach", MaSite);

            //lấy thuộc tính
            string Query = "";
            for (int i = 0; i < dtCT.Rows.Count; i++)
            {
                if (i != dtCT.Rows.Count - 1)
                    Query += "Select " + ThuocTinh + " from " + dtCT.Rows[i][0].ToString().Trim() + " union ";
                else
                    Query += "Select " + ThuocTinh + " from " + dtCT.Rows[i][0].ToString().Trim();
            }
            DAL.stringConnection = conn;
            DataTable dt = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];

            Query = "select " + ThuocTinh + " from (" + Query + ")as CTHD where CTHD.NgayBan between '" + NgayTu + "' and '" + NgayDen + "'";
            //
            DAL.stringConnection = conn;
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);

            //
            return dsSach.Tables[0];
        }
    }
}
