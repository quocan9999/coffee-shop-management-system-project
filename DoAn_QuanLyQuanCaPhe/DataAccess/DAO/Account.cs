using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn_QuanLyQuanCaPhe.DataAccess.DAO
{
    internal class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Account();
                }
                return instance;
            }
            private set { instance = value; }
        }
        private Account() { }
        public bool Login(string username, string password)
        {
            string query = "usp_Login @userName, @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[]
            {
                new SqlParameter("@userName", username),
                new SqlParameter("@passWord", password)
            });
            return result.Rows.Count > 0;
        }
    }
}
