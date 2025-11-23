using DoAn_QuanLyQuanCaPhe.BusinessLogic;
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
    public partial class fQuanLyMon : Form
    {
        BindingSource sanPhamList = new BindingSource();

        public fQuanLyMon()
        {
            InitializeComponent();
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListSanPham();
            AddSanPhamBinding();
        }

        private void Sửa_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        void LoadListSanPham()
        {


            grvMon.DataSource = SanPhamDAO.Instance.GetListSanPham();
            if (grvMon.Columns["TrangThai"] != null)
            {
                foreach (DataGridViewRow row in grvMon.Rows)
                {
                    if (row.Cells["TrangThai"].Value != null && row.Cells["TrangThai"].Value != DBNull.Value)
                    {
                        int tt = int.Parse(row.Cells["TrangThai"].Value.ToString());
                        row.Cells["TrangThai"].Value = (tt != 0) ? "Còn bàn" : "Hết bàn";
                    }
                }
            }
        }
        void AddSanPhamBinding()
        {
            txtTenSanPham.DataBindings.Clear();
            txtID.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtDVT.DataBindings.Clear();
            txtTrangThai.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add(new Binding("text", grvMon.DataSource, "TenSP"));
            txtID.DataBindings.Add(new Binding("text", grvMon.DataSource, "Id"));
            txtGia.DataBindings.Add(new Binding("text", grvMon.DataSource, "DonGia"));
            txtDVT.DataBindings.Add(new Binding("text", grvMon.DataSource, "DonViTinh"));
            txtTrangThai.DataBindings.Add(new Binding("text", grvMon.DataSource, "TrangThai"));
        }
        void LoadDanhMucComBoBox(ComboBox cb)
        {
            cb.DataSource = DanhMucDAO.Instance.GetListDanhMuc();
            cb.DisplayMember = "TenDanhMuc";
        }


        private void fQuanLyMon_Load(object sender, EventArgs e)
        {
          
            LoadDanhMucComBoBox(cboDanhMuc);


        }
       


        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (grvMon.SelectedCells.Count > 0)
            {
  
                int maDanhMuc = (int)grvMon.SelectedCells[0].OwningRow.Cells["MaDanhMuc"].Value;

                DanhMuc danhMuc = DanhMucDAO.Instance.GetDanhMucById(maDanhMuc);

                if (danhMuc != null)
                {
                   
                    int index = -1;
                    for (int i = 0; i < cboDanhMuc.Items.Count; i++)
                    {
                        DanhMuc item = cboDanhMuc.Items[i] as DanhMuc;
                        if (item != null && item.Id == danhMuc.Id)
                        {
                            index = i;
                            break;
                        }
                    }

                    if (index >= 0)
                        cboDanhMuc.SelectedIndex = index;
                }
            }
        }
    }
}
