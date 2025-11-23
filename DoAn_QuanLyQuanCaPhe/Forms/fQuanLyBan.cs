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
using System.Xml.Linq;

namespace DoAn_QuanLyQuanCaPhe.Forms
{
    public partial class fQuanLyBan : Form
    {
        public fQuanLyBan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListBan();
            AddBanBindings();
           
        }
        void LoadListBan()
        {
            grvQuanLyBan.DataSource = BanDAO.Instance.GetListBan();
            if (grvQuanLyBan.Columns["TrangThai"] != null)
            {
                foreach (DataGridViewRow row in grvQuanLyBan.Rows)
                {
                    if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value != DBNull.Value)
                    {
                        int tt = int.Parse(row.Cells["TrangThai"].Value.ToString());
                        row.Cells["TrangThai"].Value = (tt != 0) ? "Còn bàn" : "Hết bàn";
                    }
                }
            }
        }

        private void fQuanLyBan_Load(object sender, EventArgs e)
        {

        }
        void AddBanBindings()
        {

            txtID.DataBindings.Clear();
            txtTenBan.DataBindings.Clear();
            txtTrangThai.DataBindings.Clear();
            txtViTri.DataBindings.Clear();
            txtID.DataBindings.Add(new Binding("text", grvQuanLyBan.DataSource, "Id"));
            txtTenBan.DataBindings.Add(new Binding("text", grvQuanLyBan.DataSource, "TenBan"));
            txtTrangThai.DataBindings.Add(new Binding("text", grvQuanLyBan.DataSource, "TrangThai"));
            txtViTri.DataBindings.Add(new Binding("text", grvQuanLyBan.DataSource, "ViTri"));




        }
    } 
}
