using DoAn_QuanLyQuanCaPhe.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCaPhe.DataAccess.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private TableDAO() { }

        //Load danh sách bàn
        public List<Table> LoadTable()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.usp_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        //Load khu vực
        public List<string> LoadKhuVuc()
        {
            List<string> khuVucList = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT DISTINCT ViTri FROM dbo.Ban ORDER BY ViTri");

            foreach (DataRow row in data.Rows)
            {
                khuVucList.Add(row["ViTri"].ToString());
            }
            return khuVucList;
        }

        //Lọc bàn theo khu vực
        public List<Table> LoadTableByKhuVuc(string khuVuc)
        {
            List<Table> tableList = new List<Table>();

            string query = khuVuc == "Tất cả" ? "dbo.usp_GetTableList" : "SELECT * FROM dbo.Ban WHERE ViTri = N'" + khuVuc + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
