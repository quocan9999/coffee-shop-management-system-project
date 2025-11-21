using DoAn_QuanLyQuanCaPhe.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaPhe.Forms
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        bool Login(string userName, string passWord) 
        {
            return Account.Instance.Login(userName, passWord);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(userName, passWord))
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            fDangKy f = new fDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
