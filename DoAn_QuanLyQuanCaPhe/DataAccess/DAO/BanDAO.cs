using DoAn_QuanLyQuanCaPhe.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCaPhe.DataAccess.DAO
{
    internal class BanDAO
    {
        private static BanDAO instance;
        public static BanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ();
                }
                return BanDAO.instance;
            }
            private set { BanDAO.instance = value; }

        }
        private BanDAO() { }
        public List<Ban> GetBanByCategoryID(int ViTri)
        {
            List<Ban> list = new List<Ban>();
            string query = "select *from Ban where ViTri =" + ViTri;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);

            }
            return list;

        }
        public List<Ban> GetListBan()
        {
            List<Ban> list = new List<Ban>();
            string query = "select *from Ban ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                list.Add(ban);

            }
            return list;
        }
    }
}
