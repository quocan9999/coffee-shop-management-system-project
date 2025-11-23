using DoAn_QuanLyQuanCaPhe.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaPhe.Forms
{
    public partial class fQuanLyDanhMuc : Form
    {
        public fQuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListBan();
            AddDanhMucBinding();
        }
        void LoadListBan()
        {
            grvDanhMuc.DataSource = DanhMucDAO.Instance.GetListDanhMuc();
           
        }
        void AddDanhMucBinding()
        {

            txtID.DataBindings.Clear();
           
            txtDanhMuc.DataBindings.Clear();
            txtID.DataBindings.Add(new Binding("text", grvDanhMuc.DataSource, "Id"));
            txtDanhMuc.DataBindings.Add(new Binding("text", grvDanhMuc.DataSource, "TenDanhMuc"));




        }
    }
}
