using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaPhe.Forms
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            this.Text = "Quản lý bàn - Quản lý quán cà phê";
            this.WindowState = FormWindowState.Maximized;

            KhoiTaoBan();
            LoadComboBoxKhuVuc();
        }

        private void KhoiTaoBan()
        {
            // Thêm dữ liệu mẫu cho bàn
            flpBan.Controls.Clear();

            // Tạo bàn mẫu cho từng khu vực
            TaoBan("Bàn 01", "Tầng trệt", 0); // Trống
            TaoBan("Bàn 02", "Tầng trệt", 1); // Có khách
            TaoBan("Bàn 03", "Tầng trệt", 0);
            TaoBan("Bàn 04", "Tầng trệt", 0);
            TaoBan("Bàn 05", "Lầu 1", 1);
            TaoBan("Bàn 06", "Lầu 1", 0);
            TaoBan("Bàn 07", "Lầu 1", 0);
            TaoBan("Bàn 08", "Lầu 2", 0);
            TaoBan("Bàn 09", "Lầu 2", 1);
            TaoBan("Bàn 10", "Lầu 2", 0);
        }

        private void TaoBan(string tenBan, string khuVuc, int trangThai)
        {
            Button btnBan = new Button();
            btnBan.Size = new Size(120, 80);
            btnBan.Text = tenBan + "\n" + khuVuc;
            btnBan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBan.Tag = new { TenBan = tenBan, KhuVuc = khuVuc, TrangThai = trangThai };
            btnBan.Margin = new Padding(5);
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.FlatAppearance.BorderSize = 2;

            if (trangThai == 0) // Trống
            {
                btnBan.BackColor = Color.LightGreen;
                btnBan.ForeColor = Color.DarkGreen;
                btnBan.FlatAppearance.BorderColor = Color.Green;
            }
            else // Có khách
            {
                btnBan.BackColor = Color.LightCoral;
                btnBan.ForeColor = Color.DarkRed;
                btnBan.FlatAppearance.BorderColor = Color.Red;
            }

            btnBan.Click += BtnBan_Click;
            flpBan.Controls.Add(btnBan);
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            dynamic banInfo = btn.Tag;

            lblThongTinBan.Text = $"Thông tin: {banInfo.TenBan} - {banInfo.KhuVuc}";
            lblTrangThaiHienTai.Text = $"Trạng thái: {(banInfo.TrangThai == 0 ? "Trống" : "Có khách")}";

            // Hiển thị thông tin bàn được chọn và kích hoạt khu vực thanh toán
            pnlThanhToan.Enabled = true;
            lblBanDangChon.Text = banInfo.TenBan;

            // Load dữ liệu mẫu cho hóa đơn nếu bàn có khách
            if (banInfo.TrangThai == 1)
            {
                LoadHoaDonMau();
            }
            else
            {
                dgvHoaDon.DataSource = null;
                lblTongTien.Text = "0 VNĐ";
            }
        }

        private void LoadComboBoxKhuVuc()
        {
            cboKhuVuc.Items.Clear();
            cboKhuVuc.Items.Add("Tất cả");
            cboKhuVuc.Items.Add("Tầng trệt");
            cboKhuVuc.Items.Add("Lầu 1");
            cboKhuVuc.Items.Add("Lầu 2");
            cboKhuVuc.SelectedIndex = 0;
        }

        private void LoadHoaDonMau()
        {
            // Tạo dữ liệu mẫu cho hóa đơn
            var hoaDonData = new[]
            {
                new { STT = 1, TenSP = "Cà phê đen", SoLuong = 2, DonGia = 25000, ThanhTien = 50000 },
                new { STT = 2, TenSP = "Cà phê sữa", SoLuong = 1, DonGia = 30000, ThanhTien = 30000 },
                new { STT = 3, TenSP = "Trà sữa", SoLuong = 1, DonGia = 35000, ThanhTien = 35000 }
            };

            dgvHoaDon.DataSource = hoaDonData;
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khuVucChon = cboKhuVuc.SelectedItem.ToString();

            foreach (Control control in flpBan.Controls)
            {
                if (control is Button btn)
                {
                    dynamic banInfo = btn.Tag;
                    if (khuVucChon == "Tất cả" || banInfo.KhuVuc == khuVucChon)
                    {
                        btn.Visible = true;
                    }
                    else
                    {
                        btn.Visible = false;
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblBanDangChon.Text))
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận thanh toán cho {lblBanDangChon.Text}?", "Xác nhận thanh toán",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset bàn về trạng thái trống
                ResetBan();
            }
        }

        private void ResetBan()
        {
            dgvHoaDon.DataSource = null;
            lblTongTien.Text = "0 VNĐ";
            lblBanDangChon.Text = "";
            lblThongTinBan.Text = "Chưa chọn bàn";
            lblTrangThaiHienTai.Text = "";
            pnlThanhToan.Enabled = false;

            // Cập nhật lại màu bàn (tìm bàn và đổi trạng thái)
            // TODO: Cập nhật database
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // TODO: Mở form chọn món
            MessageBox.Show("Chức năng thêm món đang được phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // TODO: Xóa món khỏi hóa đơn
                    MessageBox.Show("Đã xóa món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fQuanLyBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // Event handlers cho MenuStrip
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận đăng xuất",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                // TODO: Mở lại form đăng nhập
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Xác nhận thoát",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuQuanLyBan_Click(object sender, EventArgs e)
        {
            // Đã ở form quản lý bàn rồi
            MessageBox.Show("Bạn đang ở trong form Quản lý bàn!", "Thông báo",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuQuanLyMon_Click(object sender, EventArgs e)
        {
            fQuanLyMon f = new fQuanLyMon();
            f.ShowDialog();
            // TODO: Mở form quản lý món
        }

        private void menuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            fQuanLyNhanVien f = new fQuanLyNhanVien();
            f.ShowDialog();
            // TODO: Mở form quản lý nhân viên
        }

        private void menuBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Báo cáo doanh thu đang được phát triển!", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Mở form báo cáo doanh thu
        }

        private void menuBaoCaoMonBanChay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Báo cáo món bán chạy đang được phát triển!", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // TODO: Mở form báo cáo món bán chạy
        }

        private void menuQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            fQuanLyDanhMuc f = new fQuanLyDanhMuc();
            f.ShowDialog();
        }
    }
}