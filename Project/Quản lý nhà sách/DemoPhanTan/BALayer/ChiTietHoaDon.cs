using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class ChiTietHoaDon
    {
        DAL da = null;
        public static String TenDangNhap = "";
        public static String MatKhau = "";
        public static string MaSite = "";
        public ChiTietHoaDon()
        {
            da = new DAL();
        }

        //lấy danh sách chi tiết hóa đơn
        public DataTable LayDanhSachChiTietHoaDon()
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
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsSach.Tables[0];
        }
        //tạo chi tiết hóa đơn mới
        public bool TaoChiTietHoaDon(string MaTheLoai, string MaCTHD, string MaHD, string NgayBan, string GiaTien, string SoLuong, string MaSach)
        {
            try
            {
                string err = "Error TaoChiTietHoaDon";
                //DAL
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //conn
                String conn = da.getConnectStrSite(MaSite);
                //
                string likeManh = "", TenManh = "";
                //lấy danh sách mảnh chứa  chi tiết hóa đơn
                DataTable dtCT = new DataTable();
                dtCT = da.LayDSManhQuanHe("CTHDBanSach", MaSite);
                //
                bool f = false;
                for (int i = 0; i < MaTheLoai.Length; i++)
                {
                    if (f)
                    {
                        likeManh += MaTheLoai[i].ToString();
                    }
                    if (MaTheLoai[i].ToString() == "-")
                        f = true;
                }
                //câu truy vấn
                string QueRy = "select TenManhDL,DKPhanManh" +
                                " from ManhDuLieu " +
                                " where TenQuanHe = 'CTHDBanSach' and MaSite= '" + MaSite + "' and TenManhDL like '%" + likeManh + "%' ";
                //thực thi
                DataTable dtKQ = da.ExecuteQueryDataSet(QueRy, CommandType.Text).Tables[0];
                //lấy tên mảnh
                TenManh = dtKQ.Rows[0][0].ToString().Trim();
                //lấy thuộc tính
                string thuocTinh = da.LayThuocTinhString("CTHDBanSach");
                //
                string Query = "insert into " + TenManh + " values ('" + MaCTHD + "','" + MaHD + "' ,'" + NgayBan + "','" + GiaTien + "','" + SoLuong + "','" + MaSach + "')";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
            }
            catch (Exception)
            {
                return false;
            }
        }

        //tìm mảnh hóa đơn tương ứng với mảnh Sách
        public string LayManhHoaDon(string TenManhSach)
        {
            try
            {
                //DAL
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                //sách
                Sach sach = new Sach();
                Sach.MaSite = MaSite;
                Sach.MatKhau = MatKhau;
                Sach.TenDangNhap = TenDangNhap;
                //conn
                String conn = DAL.connStringDic;
                //
                string Query = "";
                //
                DAL.stringConnection = conn;

                string DK = sach.LayLoaiTrongDK(TenManhSach);
                DataTable dtKQ = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                return dtKQ.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "N/A";
            }
        }
    }
}
