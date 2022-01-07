using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class NhanVien
    {
        public static string TenDangNhap = "";
        public static string MatKhau = "";
        public static string MaSite = "";
        DAL da = null;
        
        public NhanVien()
        {
            da = new DAL();
            
        }

        //lấy thông tin Nhân viên
        public DataSet LayThongTinNV()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            String conn = da.getConnectStrSite(MaSite);
            //            
            DataTable dtThuocTinh = da.LayThuocTinhDataSet("NhanVien", MaSite).Tables[0];
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
            string QueRy = "select " + SelectZone + " from NhanVien where TenNV not like '!!!%'";
            DataSet dsOut = da.ExecuteQueryDataSet(QueRy, CommandType.Text);
            return dsOut;
        }

        ////lấy tên Chi nhánh dựa trên mã chi nhánh
        public String LayTenChiNhanh(string MaCN)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenChiNhanh from ChiNhanh where MaChiNhanh = '" + MaCN + "'";
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

        //lấy tên chức vụ
        public String LayTenChucVu(string MaCV)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenChucVu from ChucVu where MaChucVu = '" + MaCV + "'";
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

        //lấy danh sách chức vụ
        public DataTable LayDanhSachChucVu()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("ChucVu", MaSite);
                string Query = "select "+ThuocTinh+" from ChucVu";
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

        //
        //lấy danh sách chức vụ
        public DataTable LayDanhSachChucVuDich(string MaSiteDich)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSiteDich);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("ChucVu", MaSiteDich);
                string Query = "select " + ThuocTinh + " from ChucVu";
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
        //
        //lấy tên nhân viên
        public String LayTenNV(string MaNV)
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
        //lấy danh sách chức vụ
        public DataTable LayDanhSachChiNhanh()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string ThuocTinh = da.LayThuocTinhStringManhMaSite("ChiNhanh", MaSite);
                string Query = "select " + ThuocTinh + " from ChiNhanh";
                DAL.stringConnection = conn;
                DataTable dtChiNhanh = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtChiNhanh;

            }
            catch (Exception)
            {
                return null;
            }
        }
        //
        //lấy danh sách Chi Nhánh Dic
        public DataTable LayDanhSachChiNhanhDIC()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                //string ThuocTinh = da.LayThuocTinhString("ChiNhanh");
                string Query = "select * from SiteDuLieu";
                DAL.stringConnection = DAL.connStringDic;
                DataTable dtChiNhanh = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtChiNhanh;

            }
            catch (Exception)
            {
                return null;
            }
        }
        //Tìm Kiếm
        public DataSet TimKiem(string chuoiTim, string Bang, string ThuocTinh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //thuộc tính của bảng sách
                string ThuocTinhNhanVien = da.LayThuocTinhStringThemManhMaSite("NhanVien", MaSite);
                //thuộc tính chung
                string ThuocTinhChung = da.LayThuocTinhChung("NhanVien", Bang, MaSite);
                string Query = "";
                if (Bang != "NhanVien")
                {
                    if (ThuocTinhChung == ThuocTinh)
                        Query = "select distinct " + ThuocTinhNhanVien +
                            " from " + Bang + ",Sach where NhanVien." + ThuocTinhChung + " = " + Bang + "." + ThuocTinhChung +
                               " and " + " NhanVien." + ThuocTinh + " like N'%" + chuoiTim + "%' and TenNV not like '!!!%'";
                    else
                    {
                        Query = "select distinct " + ThuocTinhNhanVien +
                            " from " + Bang + ",NhanVien where NhanVien." + ThuocTinhChung + " = " + Bang + "." + ThuocTinhChung +
                              " and " + ThuocTinh + " like N'%" + chuoiTim + "%' and TenNV not like '!!!%'";
                    }
                }
                else
                {
                    Query = "select distinct " + ThuocTinhNhanVien +
                            " from NhanVien where NhanVien." + ThuocTinh + " like N'%" + chuoiTim + "%' and NhanVien.TenNV not like '!!!%'";
                }
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsTK;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //tìm tên bảng dựa trên tên thuộc tính
        public string TimTenBang(string ThuocTinh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select TenManhDL from ManhDuLieu where ManhDuLieu.MaMDL = (select MaMDL  from DSManhDLTTManh  where ThuocTinhManh = '" + ThuocTinh + "')";
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "NhanVien";
            }
        }
        //tìm Ma CHi Nhanh dựa trên tên Chi Nhanh
        public string TimMaChiNhanh(string TenChiNhanh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select MaChiNhanh from ChiNhanh where TenChiNhanh = N'" + TenChiNhanh + "'";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "CN-HN";
            }
        }
        //
        //tìm Ma CHi Nhanh dựa trên tên Chi Nhanh
        public string TimMaChucVu(string TenChucVu)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select MaChucVu from ChucVu where TenChucVu = N'" + TenChucVu + "'";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "CN-HN";
            }
        }
        //Lấy mã Chi Nhánh
        public string LayMaChiNhanhODic(string MaSiteDic, string tenChiNhanh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSiteDic);
                //
                string Query = "Select MaChiNhanh from ChiNhanh where TenChiNhanh = N'" + tenChiNhanh + "'";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "CN-HN";
            }
        }

        //tìm kiếm theo Chuc Vu
        public DataTable TimTheoChucVu(string ChucVu)
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);
            //thuộc tính của sách
            string TTNV = da.LayThuocTinhStringThemManhMaSite("NhanVien", MaSite);
            //thuộc tính chung
            string TTC = da.LayThuocTinhChung("NhanVien", "ChucVu", MaSite);
            //            
            string Query = "select " + TTNV.ToString().Trim() + " from NhanVien,ChucVu where NhanVien." + TTC.ToString().Trim() + "=ChucVu." + TTC.ToString().Trim() +
                                " and ChucVu.MaChucVu='" + ChucVu.ToString().Trim() + "' and TenNV not like '!!!%'";
            DAL.stringConnection = conn;
            DataSet dsNV = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsNV.Tables[0];
        }
        //
        //xóa một cuốn sách
        public bool XoaNV(string MaNV, string TenNV)
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
                string Query = "update NhanVien " +
                        " set TenNV = N'!!!" + TenNV + "'" +
                        " where MaNV = '" + MaNV + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
        public void XoaNVF(string MaNV, string maSite)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(maSite);
                string Query = "Delete From NhanVien where MaNV='"+MaNV+"'";
                DAL.stringConnection = conn;
                da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                
            }
        }
        //
        //thêm NV mới
        public bool ThemNV(string MaNV, string TenNV, string MaChiNhanh, string MaChucVu, string TGVaoLam, string Luong,
            string SDT, string DiaChi, string QueQuan, int SoCaTruc, string MatKhau)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("NhanVien", MaSite);
                //
                string Query = "INSERT INTO NhanVien (" + TTTNV + ") VALUES ('" + MaNV +
                    "', N'" + TenNV + "' , '" + MaChiNhanh + "' , '" + MaChucVu + "' , '" + TGVaoLam + "'  , '" + Luong + "' , '"
                    + SDT + "' , N'" + DiaChi + "' , N'" + QueQuan + "' , " + SoCaTruc + " , '" + MatKhau + "' )";
                DAL.stringConnection = conn;
                da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //cập nhật sách mới
        public bool CapNhatNV(string MaNV, string TenNV, string ChiNhanh, string ChucVu, string NgayVaoLam, string Luong,
            string SDT, string DiaChi, string QueQuan)
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
                string Query = "update NhanVien " +
                        " set TenNV = N'" + TenNV + "',MaChiNhanh='" + ChiNhanh + "' ," +
                        " MaChucVu = '" + ChucVu + "',TGianVaoLam = '" + NgayVaoLam + "',Luong = '" + Luong + "',DiaChi = N'" + DiaChi + "',SDT = '" + SDT + "'," +
                        " QueQuan = N'" + QueQuan +
                        "' where MaNV = '" + MaNV + "'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }
        //
        //tìm IP dựa trên Ma Site
        public string LayIP(string MaSiteDich)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select DiaChiIP from SiteDuLieu Where MaSite = '" + MaSiteDich + "'";
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "(local)";
            }
        }
        //tìm IP dựa trên Ma Site
        public string LaytenDatabase(string MaSiteDich)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select TenDataBase from SiteDuLieu Where MaSite = '" + MaSiteDich + "'";
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "CNHN";
            }
        }
        // Lay ma Site Dich
        public string layMaSiteDich(string TenChiNhanh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //
                string Query = "Select MaSite from SiteDuLieu Where TenSite = '" + TenChiNhanh + "'";
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "1";
            }
        }
        //
        public int DemSoNhanVien(String MaSiteDich)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSiteDich);
                //
                string Query = "Select MAX(A) From	(SELECT A = SUBSTRING(MaNV, pos, LEN(MaNV)) FROM (SELECT MaNV, pos = PATINDEX('%[0-9]%', MaNV) FROM NhanVien) d) c";
                DAL.stringConnection = conn;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return int.Parse(st.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //Chyen NhV
        public bool ChuyenNV(string MaNV, string TenNV, string MaChiNhanh, string MaChucVu, string TGVaoLam, double Luong,
            string SDT, string DiaChi, string QueQuan, int SoCaTruc, string MatKhau, String maSiteDich)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(maSiteDich);
                //            
                string TTTNV = da.LayThuocTinhStringManhMaSite("NhanVien", maSiteDich);
                //
                string Query = "INSERT INTO NhanVien (" + TTTNV + ") VALUES ('" + MaNV +
                    "', N'" + TenNV + "' , '" + MaChiNhanh + "' , '" + MaChucVu + "' , '" + TGVaoLam + "'  , '" + Luong + "' , '"
                    + SDT + "' , N'" + DiaChi + "' , N'" + QueQuan + "' , " + SoCaTruc + " , '" + MatKhau + "' )";
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
