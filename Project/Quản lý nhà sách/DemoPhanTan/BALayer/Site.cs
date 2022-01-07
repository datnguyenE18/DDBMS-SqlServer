using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;

namespace BALayer
{
    public class Site
    {
        DAL db = null;
        public static String TenDanNhap = "";
        public static String MatKhau = "";

        public Site()
        {
            db = new DAL();
        }

        public DataSet LayTenSite()
        {
            DAL.User = TenDanNhap;
            DAL.Pass = MatKhau;
            DAL.stringConnection = DAL.connStringDic;
            return db.ExecuteQueryDataSet("select MaSite,TenSite from SiteDuLieu",CommandType.Text);
        }
    }
}
