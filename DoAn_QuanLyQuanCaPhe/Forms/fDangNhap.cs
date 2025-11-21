using DoAn_QuanLyQuanCaPhe.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
        //Kiểm tra tên đăng nhập hoặc mật khẩu không được để trống và không được có khoảng trắng
        private bool ValidateInput(string userName, string passWord)
        {
            // Kiểm tra để trống
            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra có khoảng trắng không
            if (userName.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được chứa khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (passWord.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;

            if (!ValidateInput(userName, passWord))
            {
                return;
            }    

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
