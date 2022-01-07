using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class Sach
    {
        DAL da = null;
        public static String TenDangNhap = "";
        public static String MatKhau = "";
        public static string MaSite = "";
        public Sach()
        {
            da = new DAL();
        }
        //lấy tên sách
        public String LayTenSach(string MaSach)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);

                //các mảnh chứa DL
                DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

                //thuộc tính của bảng Sách
                string ThuocTinh = da.LayThuocTinhString("Sach");
                //câu try vấn
                string Query = "";

                for (int i = 0; i < DSManhQH.Rows.Count; i++)
                {
                    if (i != DSManhQH.Rows.Count - 1)
                        Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " where TenSach not like '!!!%'" + " union ";
                    else
                        Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " where TenSach not like '!!!%'";
                }

                string TC = "Sach.TenSach";
                //            
                string QueryEx = "select " + TC + " from (" + Query + ") as Sach where Sach.MaSach = '" + MaSach + "'";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(QueryEx, CommandType.Text);
                DataTable dt = dsSach.Tables[0];
                //
                return dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
        //lấy khu chứa sách
        public String LayKhuChuaSach(string MaSach)
        {
            try
            {//
                string kq = "";
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();

                //bộ sách mới
                //thuộc tính của sách
                string ThuocTinhSach = da.LayThuocTinhString("Sach");
                //các mảnh chứa DL
                DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

                //câu try vấn
                string QuerySach = "";

                for (int i = 0; i < DSManhQH.Rows.Count; i++)
                {
                    if (i != DSManhQH.Rows.Count - 1)
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                    else
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim();
                }
                //
                String conn = da.getConnectStrSite(MaSite);

                //các thuộc tính chung của các bảng
                String SachTheLoai = da.LayThuocTinhChung("Sach", "TheLoai", MaSite);
                String TheLoaiKe = da.LayThuocTinhChung("TheLoai", "KeSach", MaSite);
                String KeSachKhu = da.LayThuocTinhChung("KeSach", "KhuDeSach", MaSite);
                //
                String Query = "select KhuDeSach.TenKhu from (" + QuerySach + ") as Sach,TheLoai,KeSach,KhuDeSach " +
                            "where  Sach." + SachTheLoai + " = TheLoai." + SachTheLoai + " and " +
                            "TheLoai." + TheLoaiKe + " = KeSach." + TheLoaiKe + " and " +
                            "KeSach." + KeSachKhu + "=KhuDeSach." + KeSachKhu + " and " +
                            "Sach.MaSach = '" + MaSach + "'";
                //thực thi
                DAL.stringConnection = conn;
                DataSet dsKhu = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable dtKhu = dsKhu.Tables[0];

                kq = dtKhu.Rows[0][0].ToString();
                return kq.Trim();
            }
            catch (Exception)
            {
                return "N/A";
            }
        }

        //lấy danh sách kệ sách
        public DataTable LayDanhSachKhu()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                string TC = da.LayThuocTinhString("KhuDeSach");
                //            
                string Query = "select " + TC + " from KhuDeSach";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsSach.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        //lấy kệ chứa sách
        public String LayKeChuaSach(string MaSach)
        {
            try
            {
                string kq = "";
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);

                //bộ sách mới
                //thuộc tính của sách
                string ThuocTinhSach = da.LayThuocTinhString("Sach");
                //các mảnh chứa DL
                DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

                //câu try vấn
                string QuerySach = "";

                for (int i = 0; i < DSManhQH.Rows.Count; i++)
                {
                    if (i != DSManhQH.Rows.Count - 1)
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                    else
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim();
                }

                //các thuộc tính chung của các bảng
                String SachTheLoai = da.LayThuocTinhChung("Sach", "TheLoai", MaSite);
                String TheLoaiKe = da.LayThuocTinhChung("TheLoai", "KeSach", MaSite);
                String KeSachKhu = da.LayThuocTinhChung("KeSach", "KhuDeSach", MaSite);
                //
                String Query = "select KeSach.TenKe from (" + QuerySach + ") as Sach,TheLoai,KeSach " +
                            "where Sach." + SachTheLoai + " = TheLoai." + SachTheLoai + " and " +
                            "TheLoai." + TheLoaiKe + " = KeSach." + TheLoaiKe + " and " +
                            "Sach.MaSach = '" + MaSach + "'";
                //thực thi
                DAL.stringConnection = conn;
                DataSet dsKe = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable dtKe = dsKe.Tables[0];

                kq = dtKe.Rows[0][0].ToString();
                return kq.Trim();
            }
            catch (Exception)
            {
                return "N/A";
            }
        }

        //lấy danh sách kệ sách
        public DataTable LayDanhSachKe()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                string TC = da.LayThuocTinhString("KeSach");
                //            
                string Query = "select " + TC + " from KeSach";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsSach.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        //lấy tên thể loại dựa trên mã thể loại
        public String LayTenTheloai(string MaTL)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenTheLoai from TheLoai where MaTheLoai = '" + MaTL + "'";
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

        //lấy mã thể loại dựa trên tên thể loại
        public String LayMaTheloai(string TenTL)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select MaTheLoai from TheLoai where TenTheLoai = N'" + TenTL + "'";
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

        //lấy danh sách thể loại
        public DataTable LayDanhSachTheLoai()
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);
            //            
            string Query = "select MaTheLoai,TenTheLoai from TheLoai";
            DAL.stringConnection = conn;
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsSach.Tables[0];
        }

        //lấy tên tác giả dựa trên Mã tác giả
        public String LayTenTacGia(string MaTG)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenTacGia from TacGia where MaTacGia = '" + MaTG + "'";
                DAL.stringConnection = conn;
                DataTable dtTG = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
                //
                return dtTG.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "N/A";
            }

        }

        //lấy Mã tác giả dựa trên tên tác giả
        public String LayMaTacGia(string TenTG)
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();
            String conn = da.getConnectStrSite(MaSite);
            //            
            string Query = "select MaTacGia from TacGia where TenTacGia = '" + TenTG + "'";
            DAL.stringConnection = conn;
            DataTable dtTG = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];
            //
            return dtTG.Rows[0][0].ToString();
        }

        //lấy danh sách tác giả
        public DataTable LayDanhSachTacGia()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                string TC = da.LayThuocTinhString("TacGia");
                //            
                string Query = "select " + TC + " from TacGia";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsSach.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        //tìm kiếm sách
        public DataSet TimKiem(string chuoiTim,string Bang,string ThuocTinh)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //thuộc tính của bảng sách
                string ThuocTinhSachThem = da.LayThuocTinhStringThem("Sach");
                
                //thuộc tính chung
                string ThuocTinhChung = da.LayThuocTinhChung("Sach", Bang, MaSite);

                //thuộc tính của sách
                string ThuocTinhSach = da.LayThuocTinhString("Sach");
                //các mảnh chứa DL
                DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

                //câu try vấn
                string QuerySach = "";

                for (int i = 0; i < DSManhQH.Rows.Count; i++)
                {
                    if (i != DSManhQH.Rows.Count - 1)
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                    else
                        QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim();
                }
                //

                //câu try vấn
                string Query = "";
                //
                if (Bang != "Sach")
                {
                    if (ThuocTinhChung == ThuocTinh)
                        Query = "select distinct " + ThuocTinhSachThem +
                            " from " + Bang + ", ("+QuerySach+") as Sach where Sach." + ThuocTinhChung + " = " + Bang + "." + ThuocTinhChung +
                               " and " + " Sach." + ThuocTinh + " like N'%" + chuoiTim + "%' and TenSach not like '!!!%'";
                    else
                    {
                        Query = "select distinct " + ThuocTinhSachThem +
                            " from " + Bang + ",(" + QuerySach + ") as Sach where Sach." + ThuocTinhChung + " = " + Bang + "." + ThuocTinhChung +
                              " and " + ThuocTinh + " like N'%" + chuoiTim + "%' and TenSach not like '!!!%'";
                    }
                }
                else
                {
                    Query = "select distinct " + ThuocTinhSachThem +
                            " from (" + QuerySach + ") as Sach where Sach." + ThuocTinh + " like N'%" + chuoiTim + "%' and TenSach not like '!!!%'";
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
                string Query = " select TenQuanHe " +
                                " from DSQuanHeThuocTinh " +
                                " where ThuocTinh = '"+ThuocTinh+"'";
                DAL.stringConnection = DAL.connStringDic;
                DataSet dsTK = da.ExecuteQueryDataSet(Query, CommandType.Text);
                DataTable st = dsTK.Tables[0];
                //
                return st.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "N/A";
            }
        }

        //lấy tên NCC dựa trên mã NCC
        public String LayTenNCC(string MaNCC)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenNCC from NhaCungCapSach where MaNCC = '" + MaNCC + "'";
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

        //lấy danh sách NCC
        public DataTable LayDanhSachNCC()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                string TC = da.LayThuocTinhString("NhaCungCapSach");
                //            
                string Query = "select " + TC + " from NhaCungCapSach";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsSach.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        //lấy tên NXB dựa trên mã NXB
        public String LayTenNXB(string MaNXB)
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string Query = "select TenNXB from NhaXuatBanSach where MaNXB = '" + MaNXB + "'";
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

        //lấy danh sách NXB
        public DataTable LayDanhSachNXB()
        {
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                string TC = da.LayThuocTinhString("NhaXuatBanSach");
                //            
                string Query = "select " + TC + " from NhaXuatBanSach ";
                DAL.stringConnection = conn;
                DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
                //
                return dsSach.Tables[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        //tìm kiếm theo thể loại
        public DataTable TimTheoTheLoai(string TheLoai)
        {
            DAL.User = TenDangNhap;
            DAL.Pass = MatKhau;
            DAL da = new DAL();

            //
            //bộ sách mới
            //thuộc tính của sách
            string ThuocTinhSach = da.LayThuocTinhString("Sach");
            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

            //câu try vấn
            string QuerySach = "";

            for (int i = 0; i < DSManhQH.Rows.Count; i++)
            {
                if (i != DSManhQH.Rows.Count - 1)
                    QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " union ";
                else
                    QuerySach += "Select " + ThuocTinhSach + " from " + DSManhQH.Rows[i][0].ToString().Trim();
            }
            //
            String conn = da.getConnectStrSite(MaSite);
            //thuộc tính của sách
            string TCSach = da.LayThuocTinhStringThem("Sach");
            //thuộc tính chung
            string TCC = da.LayThuocTinhChung("Sach", "TheLoai", MaSite);
            //            
            string Query = "select " + TCSach + " from (" + QuerySach + ") as Sach,TheLoai where Sach." + TCC + "=TheLoai." + TCC +
                                " and TheLoai.MaTheLoai='" + TheLoai + "' and TenSach not like '!!!%'";
            DAL.stringConnection = conn;
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //
            return dsSach.Tables[0];
        }


        //thêm sách mới
        public bool ThemSach(string MaSach, string TenSach, string SoLuong, string NXB, string NCC, string TheLoai,
            string TacGia, string GiaBan, string SoTrang, string NgonNgu, string ISBN, string GiaNhap)
        {
            string err="";
            //try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //thuộc tính của Sách
                string ThuocTinhSach = da.LayThuocTinhString("Sach");
                //các mảnh chứa DL
                DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);
                //tên mảnh thêm vào
                string TenManh = "";
                //tìm tên mảnh
                for (int i = 0; i < DSManhQH.Rows.Count; i++)
                {
                    string LoaiTrongDK = LayLoaiTrongDK(DSManhQH.Rows[i][0].ToString().Trim()).ToString().Trim();
                    //
                    if(LoaiTrongDK==TheLoai.Trim())
                    {
                        TenManh = DSManhQH.Rows[i][0].ToString().Trim();
                        i = DSManhQH.Rows.Count;
                    }
                }

                //
                string Query = "INSERT INTO "+TenManh+"  VALUES ('" + MaSach +
                    "', N'" + TenSach + "' , " + SoLuong + " , '" + NXB + "' , '" + NCC + "'  , '" + TheLoai + "' , '"
                    + TacGia + "' , '" + GiaBan + "' , " + SoTrang + " , N'" + NgonNgu + "' , '" + ISBN + "' , " + GiaNhap + " )";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text,ref err);

            }
            //catch (Exception)
            {
                //return false;
            }
        }

        //cập nhật sách mới
        public bool CapNhatSach(string MaSach, string TenSach, string SoLuong, string NXB, string NCC, string TheLoai,
            string TacGia, string GiaBan, string SoTrang, string NgonNgu, string ISBN, string GiaNhap)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTSachach = da.LayThuocTinhString("Sach");
                string TenManh = ManhChuaDuLieu(MaSach);
                //
                string Query = "update " + TenManh + " " +
                        " set TenSach = N'"+TenSach+"',SoLuong="+SoLuong+" ," +
                        " MaNXB = '"+NXB+"',MaNCC = '"+NCC+"',MaTheLoai = '"+TheLoai+"',MaTacGia = '"+TacGia+"',GiaBan = '"+GiaBan+"'," +
                        " SoTrang = "+SoTrang+",NgonNgu = N'"+NgonNgu+"',ISBN = '"+ISBN+"',GiaNhap = "+GiaNhap+"" +
                        " where MaSach = '"+MaSach+"'";
                DAL.stringConnection = conn;
                return da.MyExecuteNonQuery(Query, CommandType.Text, ref err);

            }
            catch (Exception)
            {
                return false;
            }
        }

        //xóa một cuốn sách
        public bool XoaSach(string MaSach, string TenSach)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTSachach = da.LayThuocTinhString("Sach");
                //cuốn sách
                Sach sach=new Sach();
                
                //mảnh chứa DL cần update
                string ManhChuaDL=sach.ManhChuaDuLieu(MaSach);
                string Query = "update "+ManhChuaDL+
                        " set TenSach = N'!!!" + TenSach + "'"+
                        " where MaSach = '" + MaSach + "'";
                DAL.stringConnection = conn;
                bool b= da.MyExecuteNonQuery(Query, CommandType.Text, ref err);
                return b;

            }
            catch (Exception)
            {
                return false;
            }
        }

        //lấy toàn bộ Dl của sách
        public DataTable LayDLBangSach()
        {
            DAL da = new DAL();
            DataTable dtKQ = new DataTable();

            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);

            //thuộc tính của bảng Sách
            string ThuocTinh = da.LayThuocTinhString("Sach");
            //câu try vấn
            string Query = "";

            for (int i=0;i<DSManhQH.Rows.Count;i++)
            {
                if (i != DSManhQH.Rows.Count - 1)
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " where TenSach not like '!!!%'" + " union ";
                else
                    Query += "Select " + ThuocTinh + " from " + DSManhQH.Rows[i][0].ToString().Trim() + " where TenSach not like '!!!%'";
            }

            //chuỗi kết nối
            String conn = da.getConnectStrSite(MaSite);
            DAL.stringConnection = conn;
            //thực thi
            DataSet dsSach = da.ExecuteQueryDataSet(Query, CommandType.Text);
            //table
            dtKQ = dsSach.Tables[0];

            return dtKQ;
        }

        //lấy dữ liệu trên một mảnh cụ thể
        public DataTable LayDLManhSach(string tenBang)
        {
            DAL da = new DAL();
            //thuộc tính Sách
            string thuocTinh=da.LayThuocTinhString("Sach");
            //chuỗi kết nối
            String conn = da.getConnectStrSite(MaSite);
            DAL.stringConnection = conn;
            string Query="select " +thuocTinh+" from " +tenBang;
            DataTable dt = da.ExecuteQueryDataSet(Query, CommandType.Text).Tables[0];

            return dt;
        }

        //lấy tên mảnh chứa dữ liệu bất kì
        public string ManhChuaDuLieu(string MS)
        {
            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);
            string Conn = da.getConnectStrSite(MaSite);

            for(int i=0 ; i<DSManhQH.Rows.Count ; i++ )
            {
                DAL.stringConnection = Conn;
                int SoLan=int.Parse(da.SoMaQuanHe("MaSach",DSManhQH.Rows[i][0].ToString().Trim(),MS));
                if(SoLan>0)
                    return DSManhQH.Rows[i][0].ToString().Trim();
            }
            return "N/A";
        }

        //lấy tên MaTheLoai trong Đk phân mảnh của mảnh chứa sách theo tên
        public string LayLoaiTrongDK(string TenManh)
        {
            //các mảnh chứa DL
            DataTable DSManhQH = da.LayDSManhQuanHe("Sach", MaSite);
            string Conn = da.getConnectStrSite(MaSite);
            string TenLoai="";
            for (int i = 0; i < DSManhQH.Rows.Count; i++)
            {
                if(DSManhQH.Rows[i][0].ToString().Trim()==TenManh)
                {
                    string dk = DSManhQH.Rows[i][1].ToString().Trim();
                    for (int j = 0; j < dk.Length; j++)
                    {
                        if (dk[j].ToString() == "=")
                            TenLoai = " ";
                        else
                            if (TenLoai != "")
                                TenLoai += dk[j].ToString();
                    }
                }
            }
            return TenLoai;
        }


        //cập nhật số lượng của sách
        //cập nhật sách mới
        public bool CapNhatSoLuongSach(string MaSach,  string SoLuong)
        {
            string err = "";
            try
            {
                DAL.User = TenDangNhap;
                DAL.Pass = MatKhau;
                DAL da = new DAL();
                String conn = da.getConnectStrSite(MaSite);
                //            
                string TTTSachach = da.LayThuocTinhString("Sach");
                string TenManh = ManhChuaDuLieu(MaSach);
                //
                string Query = "update " + TenManh + " " +
                        " set SoLuong=" + SoLuong + 
                        " where MaSach = '" + MaSach + "'";
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
