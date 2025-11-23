using DoAn_QuanLyQuanCaPhe.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyQuanCaPhe.DataAccess.DAO
{
    internal class DanhMucDAO
    {
        private static DanhMucDAO instance;
        public static DanhMucDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DanhMucDAO();
                }
                return DanhMucDAO.instance;
            }
            private set { DanhMucDAO.instance = value; }

        }
        public DanhMucDAO() { }
        public List<DanhMuc> GetListDanhMuc()
        {
            List<DanhMuc> list= new List<DanhMuc>();
            string query = "Select *from DanhMuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMuc danhMuc = new DanhMuc(item);
                list.Add(danhMuc);

            }
            return list;

        }
        public DanhMuc GetDanhMucById(int id)
        {
            DanhMuc danhMuc= null;
            string query = "Select *from DanhMuc where id =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                 danhMuc = new DanhMuc(item);
                 return danhMuc;

            }
            return danhMuc;

        }
    }
}
