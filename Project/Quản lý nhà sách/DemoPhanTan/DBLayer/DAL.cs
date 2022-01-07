using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DAL
    {
        public static String DefaultServer = "(local)";
        // chuỗi kết nối datadictionary
        public static string connStringDic = "Server = " + DefaultServer+ "; Database = QuanLyNhaSachDic; Integrated Security = True";
        
        //conn khi xử lý
        public static string stringConnection = "";
        //
        public static string User = "";
        public static string Pass = "";
        //
        SqlConnection conn = null;
        //lấy chuỗi kết nối dựa trên site và server
        public string getConnectStrSite(String MaSite )
        {
            string str = "";
            DAL.stringConnection = connStringDic;
            string IP = "";
            string NameDB = "";
            //
            String querySQL="select MaSite,TenSite,DiaChiIP,TenDataBase from SiteDuLieu where MaSite= '"+MaSite+"'";

            DAL db = new DAL();
            DataTable dt = new DataTable();
            dt = db.ExecuteQueryDataSet(querySQL,CommandType.Text).Tables[0];
            foreach (DataRow t in dt.Rows)
            {
                IP = t[2].ToString().Trim();
                NameDB = t[3].ToString().Trim();
            }
            str = String.Format("Server = {0}; Database = {1} ; uid = {2}; pwd = {3}; Integrated Security = False", IP, NameDB, User, Pass);
            //
            return str;
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            conn = new SqlConnection(stringConnection);
            //
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            SqlCommand comm = conn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            comm.CommandType = ct;
            comm.CommandText = strSQL;
            comm.Parameters.Clear();
            if (param != null)
                foreach (SqlParameter p in param)
                    comm.Parameters.Add(p);
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }


        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            conn = new SqlConnection(stringConnection);
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();

            SqlCommand comm = conn.CreateCommand();

            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);

            try
            {
                int a= comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        //lấy thuộc tính của bảng
        public DataSet LayThuocTinhDataSet(String TenBang, string MaSite)
        {
            if (TenBang.Trim() == "Sach")
                TenBang = "S_TuDien";
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL= (Select MaMDL From ManhDuLieu where TenManhDL = '" + TenBang + "' and MaSite ='" + MaSite + "')";
            return db.ExecuteQueryDataSet(querySQL, CommandType.Text);
        }

        //lấy thuộc tính
        public String LayThuocTinhString(String TenBang)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinh from DSQuanHeThuocTinh where TenQuanHe='" + TenBang + "'";
            DataTable dtSach= db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];
            
            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
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
            return SelectZone;
        }

        public String LayThuocTinhStringManh(String TenBang)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL= (Select MaMDL From ManhDuLieu where TenManhDL = '" + TenBang + "')";
            DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
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
            return SelectZone;
        }
        //
        public String LayThuocTinhStringManhMaSite(String TenBang, string maSite)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL= (Select MaMDL From ManhDuLieu where TenManhDL = '" + TenBang + "'and MaSite='"+maSite+"')";
            DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
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
            return SelectZone;
        }
        //public String LayThuocTinhStringManhMaSite(String TenBang, string Masite)
        //{
        //    DAL db = new DAL();
        //    DAL.stringConnection = connStringDic;
        //    String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL= (Select MaMDL From ManhDuLieu where TenManhDL = '" + TenBang + "' and MaSite ='"+Masite+"')";
        //    DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

        //    //
        //    String SeZone = "";
        //    String SelectZone = "";
        //    //
        //    foreach (DataRow sa in dtSach.Rows)
        //    {
        //        SeZone += sa[0].ToString().Trim() + ",";
        //    }
        //    //bỏ dấu phẩy
        //    int length = SeZone.Length;
        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        SelectZone += SeZone[i];
        //    }
        //    //
        //    return SelectZone;
        //}
        //lấy thuộc tính đầy đủ
        public String LayThuocTinhStringThem(String TenBang)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinh from DSQuanHeThuocTinh where TenQuanHe='" + TenBang + "'";
            DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
            {
                SeZone += TenBang+"."+sa[0].ToString().Trim() + ",";
            }
            //bỏ dấu phẩy
            int length = SeZone.Length;
            for (int i = 0; i < length - 1; i++)
            {
                SelectZone += SeZone[i];
            }
            //
            return SelectZone;
        }

        //
        //lấy thuộc tính đầy đủ
        public String LayThuocTinhStringThemManh(String TenBang)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL=(Select MaMDL from ManhDuLieu where TenManhDL = '" + TenBang + "')";
            DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
            {
                SeZone += TenBang + "." + sa[0].ToString().Trim() + ",";
            }
            //bỏ dấu phẩy
            int length = SeZone.Length;
            for (int i = 0; i < length - 1; i++)
            {
                SelectZone += SeZone[i];
            }
            //
            return SelectZone;
        }
        //
        public String LayThuocTinhStringThemManhMaSite(String TenBang, string MaSite)
        {
            DAL db = new DAL();
            DAL.stringConnection = connStringDic;
            String querySQL = "select ThuocTinhManh from DSManhDLTTManh where MaMDL=(Select MaMDL from ManhDuLieu where TenManhDL = '" + TenBang + "' and MaSite='"+MaSite+"')";
            DataTable dtSach = db.ExecuteQueryDataSet(querySQL, CommandType.Text).Tables[0];

            //
            String SeZone = "";
            String SelectZone = "";
            //
            foreach (DataRow sa in dtSach.Rows)
            {
                SeZone += TenBang + "." + sa[0].ToString().Trim() + ",";
            }
            //bỏ dấu phẩy
            int length = SeZone.Length;
            for (int i = 0; i < length - 1; i++)
            {
                SelectZone += SeZone[i];
            }
            //
            return SelectZone;
        }

        //lấy thuộc tính chung của 2 bảng
        public string LayThuocTinhChung(String TenBang1, String TenBang2, string MaSite)
        {
            DAL da = new DAL();
            DataTable dtBang1 = da.LayThuocTinhDataSet(TenBang1, MaSite).Tables[0];
            DataTable dtBang2 = da.LayThuocTinhDataSet(TenBang2, MaSite).Tables[0];
            foreach (DataRow b1 in dtBang1.Rows)
            {
                foreach (DataRow b2 in dtBang2.Rows)
                {
                    if (b1[0].ToString().Trim() == b2[0].ToString().Trim())
                        return b1[0].ToString().Trim();
                }
            }
            return "!!!";
        }

        //lấy các mảnh của quan hệ
        public DataTable LayDSManhQuanHe(string QuanHe, string MaSite)
        {
            try
            {
                //
                DAL da = new DAL();
                DAL.stringConnection = DAL.connStringDic;
                //câu truy vấn
                string QueRy = "select TenManhDL,DKPhanManh" +
                                " from ManhDuLieu " +
                                " where TenQuanHe = '" + QuanHe + "' and MaSite= '" + MaSite + "' ";
                DataTable dtKQ = da.ExecuteQueryDataSet(QueRy, CommandType.Text).Tables[0];
                
                return dtKQ;
            }
            catch(Exception)
            {
                return null;
            }
        }

        //tìm số dòng chứa dữ liệu 
        public string SoMaQuanHe(string MaQuanHe,string TenQuanHe,string DL)
        {
            string kq = "";
            try
            {
                //
                DAL da = new DAL();

                //
                //câu truy vấn
                string QueRy = "select count("+MaQuanHe+") from "+TenQuanHe+" where "+MaQuanHe+" = '"+DL+"'";
                DataTable dtKQ = da.ExecuteQueryDataSet(QueRy, CommandType.Text).Tables[0];
                kq = dtKQ.Rows[0][0].ToString();
                return kq;
            }
            catch (Exception)
            {
                return kq;
            }
        }
        //
        public string LayTenDB(string MaSites)
        {
            string kq = "";
            try
            {
                //
                DAL da = new DAL();

                //
                //câu truy vấn
                string QueRy = "Select TenDataBase from SiteDuLieu where MaSite = '"+MaSites+"'";
                DataTable dtKQ = da.ExecuteQueryDataSet(QueRy, CommandType.Text).Tables[0];
                kq = dtKQ.Rows[0][0].ToString();
                return kq;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
