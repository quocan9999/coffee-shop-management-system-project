namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fQuanLyBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuHeThong = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            menuQuanLy = new ToolStripMenuItem();
            menuQuanLyBan = new ToolStripMenuItem();
            menuQuanLyMon = new ToolStripMenuItem();
            menuQuanLyNhanVien = new ToolStripMenuItem();
            quảnLýDanhMụcToolStripMenuItem = new ToolStripMenuItem();
            menuBaoCao = new ToolStripMenuItem();
            menuBaoCaoDoanhThu = new ToolStripMenuItem();
            menuBaoCaoMonBanChay = new ToolStripMenuItem();
            pnlLeft = new Panel();
            flpBan = new FlowLayoutPanel();
            pnlBanInfo = new Panel();
            lblTrangThaiHienTai = new Label();
            lblThongTinBan = new Label();
            pnlFilter = new Panel();
            cboKhuVuc = new ComboBox();
            lblKhuVuc = new Label();
            pnlBanHeader = new Panel();
            lblTitle = new Label();
            pnlRight = new Panel();
            pnlThanhToan = new Panel();
            pnlThanhToanButton = new Panel();
            btnThanhToan = new Button();
            pnlTongTien = new Panel();
            lblTongTien = new Label();
            lblTongTienText = new Label();
            pnlHoaDon = new Panel();
            pnlHoaDonControls = new Panel();
            btnXoaMon = new Button();
            btnThemMon = new Button();
            dgvHoaDon = new DataGridView();
            pnlBanDangChon = new Panel();
            lblBanDangChon = new Label();
            lblBanDangChonText = new Label();
            lblThanhToanTitle = new Label();
            menuStrip1.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlBanInfo.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlBanHeader.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlThanhToan.SuspendLayout();
            pnlThanhToanButton.SuspendLayout();
            pnlTongTien.SuspendLayout();
            pnlHoaDon.SuspendLayout();
            pnlHoaDonControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            pnlBanDangChon.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuHeThong, menuQuanLy, menuBaoCao });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1200, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuDangXuat, menuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(69, 20);
            menuHeThong.Text = "Hệ thống";
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(127, 22);
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(127, 22);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // menuQuanLy
            // 
            menuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { menuQuanLyBan, menuQuanLyMon, menuQuanLyNhanVien, quảnLýDanhMụcToolStripMenuItem });
            menuQuanLy.Name = "menuQuanLy";
            menuQuanLy.Size = new Size(60, 20);
            menuQuanLy.Text = "Quản lý";
            // 
            // menuQuanLyBan
            // 
            menuQuanLyBan.Name = "menuQuanLyBan";
            menuQuanLyBan.Size = new Size(180, 22);
            menuQuanLyBan.Text = "Quản lý bàn";
            menuQuanLyBan.Click += menuQuanLyBan_Click;
            // 
            // menuQuanLyMon
            // 
            menuQuanLyMon.Name = "menuQuanLyMon";
            menuQuanLyMon.Size = new Size(180, 22);
            menuQuanLyMon.Text = "Quản lý món";
            menuQuanLyMon.Click += menuQuanLyMon_Click;
            // 
            // menuQuanLyNhanVien
            // 
            menuQuanLyNhanVien.Name = "menuQuanLyNhanVien";
            menuQuanLyNhanVien.Size = new Size(180, 22);
            menuQuanLyNhanVien.Text = "Quản lý nhân viên";
            menuQuanLyNhanVien.Click += menuQuanLyNhanVien_Click;
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            quảnLýDanhMụcToolStripMenuItem.Size = new Size(180, 22);
            quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // menuBaoCao
            // 
            menuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { menuBaoCaoDoanhThu, menuBaoCaoMonBanChay });
            menuBaoCao.Name = "menuBaoCao";
            menuBaoCao.Size = new Size(61, 20);
            menuBaoCao.Text = "Báo cáo";
            // 
            // menuBaoCaoDoanhThu
            // 
            menuBaoCaoDoanhThu.Name = "menuBaoCaoDoanhThu";
            menuBaoCaoDoanhThu.Size = new Size(195, 22);
            menuBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            menuBaoCaoDoanhThu.Click += menuBaoCaoDoanhThu_Click;
            // 
            // menuBaoCaoMonBanChay
            // 
            menuBaoCaoMonBanChay.Name = "menuBaoCaoMonBanChay";
            menuBaoCaoMonBanChay.Size = new Size(195, 22);
            menuBaoCaoMonBanChay.Text = "Báo cáo món bán chạy";
            menuBaoCaoMonBanChay.Click += menuBaoCaoMonBanChay_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(240, 248, 255);
            pnlLeft.Controls.Add(flpBan);
            pnlLeft.Controls.Add(pnlBanInfo);
            pnlLeft.Controls.Add(pnlFilter);
            pnlLeft.Controls.Add(pnlBanHeader);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 24);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(10);
            pnlLeft.Size = new Size(700, 676);
            pnlLeft.TabIndex = 0;
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.BackColor = Color.White;
            flpBan.BorderStyle = BorderStyle.FixedSingle;
            flpBan.Dock = DockStyle.Fill;
            flpBan.Location = new Point(10, 100);
            flpBan.Name = "flpBan";
            flpBan.Padding = new Padding(10);
            flpBan.Size = new Size(680, 516);
            flpBan.TabIndex = 3;
            // 
            // pnlBanInfo
            // 
            pnlBanInfo.Controls.Add(lblTrangThaiHienTai);
            pnlBanInfo.Controls.Add(lblThongTinBan);
            pnlBanInfo.Dock = DockStyle.Bottom;
            pnlBanInfo.Location = new Point(10, 616);
            pnlBanInfo.Name = "pnlBanInfo";
            pnlBanInfo.Size = new Size(680, 50);
            pnlBanInfo.TabIndex = 2;
            // 
            // lblTrangThaiHienTai
            // 
            lblTrangThaiHienTai.AutoSize = true;
            lblTrangThaiHienTai.Font = new Font("Segoe UI", 10F);
            lblTrangThaiHienTai.Location = new Point(0, 28);
            lblTrangThaiHienTai.Name = "lblTrangThaiHienTai";
            lblTrangThaiHienTai.Size = new Size(0, 19);
            lblTrangThaiHienTai.TabIndex = 1;
            // 
            // lblThongTinBan
            // 
            lblThongTinBan.AutoSize = true;
            lblThongTinBan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThongTinBan.ForeColor = Color.FromArgb(0, 102, 204);
            lblThongTinBan.Location = new Point(0, 5);
            lblThongTinBan.Name = "lblThongTinBan";
            lblThongTinBan.Size = new Size(113, 20);
            lblThongTinBan.TabIndex = 0;
            lblThongTinBan.Text = "Chưa chọn bàn";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboKhuVuc);
            pnlFilter.Controls.Add(lblKhuVuc);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(10, 60);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(0, 5, 0, 5);
            pnlFilter.Size = new Size(680, 40);
            pnlFilter.TabIndex = 1;
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhuVuc.Font = new Font("Segoe UI", 10F);
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(120, 7);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(150, 25);
            cboKhuVuc.TabIndex = 1;
            cboKhuVuc.SelectedIndexChanged += cboKhuVuc_SelectedIndexChanged;
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKhuVuc.Location = new Point(0, 10);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(96, 20);
            lblKhuVuc.TabIndex = 0;
            lblKhuVuc.Text = "Lọc khu vực:";
            // 
            // pnlBanHeader
            // 
            pnlBanHeader.Controls.Add(lblTitle);
            pnlBanHeader.Dock = DockStyle.Top;
            pnlBanHeader.Location = new Point(10, 10);
            pnlBanHeader.Name = "pnlBanHeader";
            pnlBanHeader.Size = new Size(680, 50);
            pnlBanHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(680, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ BÀN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(248, 249, 250);
            pnlRight.Controls.Add(pnlThanhToan);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(700, 24);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(10);
            pnlRight.Size = new Size(500, 676);
            pnlRight.TabIndex = 1;
            // 
            // pnlThanhToan
            // 
            pnlThanhToan.BackColor = Color.White;
            pnlThanhToan.BorderStyle = BorderStyle.FixedSingle;
            pnlThanhToan.Controls.Add(pnlThanhToanButton);
            pnlThanhToan.Controls.Add(pnlTongTien);
            pnlThanhToan.Controls.Add(pnlHoaDon);
            pnlThanhToan.Controls.Add(pnlBanDangChon);
            pnlThanhToan.Controls.Add(lblThanhToanTitle);
            pnlThanhToan.Dock = DockStyle.Fill;
            pnlThanhToan.Enabled = false;
            pnlThanhToan.Location = new Point(10, 10);
            pnlThanhToan.Name = "pnlThanhToan";
            pnlThanhToan.Padding = new Padding(15);
            pnlThanhToan.Size = new Size(480, 656);
            pnlThanhToan.TabIndex = 0;
            // 
            // pnlThanhToanButton
            // 
            pnlThanhToanButton.Controls.Add(btnThanhToan);
            pnlThanhToanButton.Dock = DockStyle.Bottom;
            pnlThanhToanButton.Location = new Point(15, 539);
            pnlThanhToanButton.Name = "pnlThanhToanButton";
            pnlThanhToanButton.Size = new Size(448, 50);
            pnlThanhToanButton.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThanhToan.BackColor = Color.FromArgb(0, 102, 204);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(228, 5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(120, 40);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // pnlTongTien
            // 
            pnlTongTien.Controls.Add(lblTongTien);
            pnlTongTien.Controls.Add(lblTongTienText);
            pnlTongTien.Dock = DockStyle.Bottom;
            pnlTongTien.Location = new Point(15, 589);
            pnlTongTien.Name = "pnlTongTien";
            pnlTongTien.Size = new Size(448, 50);
            pnlTongTien.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(220, 20, 60);
            lblTongTien.Location = new Point(110, 15);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(70, 25);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTienText.Location = new Point(0, 15);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(103, 25);
            lblTongTienText.TabIndex = 0;
            lblTongTienText.Text = "Tổng tiền:";
            // 
            // pnlHoaDon
            // 
            pnlHoaDon.Controls.Add(pnlHoaDonControls);
            pnlHoaDon.Controls.Add(dgvHoaDon);
            pnlHoaDon.Dock = DockStyle.Fill;
            pnlHoaDon.Location = new Point(15, 95);
            pnlHoaDon.Name = "pnlHoaDon";
            pnlHoaDon.Size = new Size(448, 544);
            pnlHoaDon.TabIndex = 2;
            // 
            // pnlHoaDonControls
            // 
            pnlHoaDonControls.Controls.Add(btnXoaMon);
            pnlHoaDonControls.Controls.Add(btnThemMon);
            pnlHoaDonControls.Dock = DockStyle.Bottom;
            pnlHoaDonControls.Location = new Point(0, 494);
            pnlHoaDonControls.Name = "pnlHoaDonControls";
            pnlHoaDonControls.Size = new Size(448, 50);
            pnlHoaDonControls.TabIndex = 1;
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = Color.FromArgb(220, 20, 60);
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaMon.ForeColor = Color.White;
            btnXoaMon.Location = new Point(110, 10);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(90, 35);
            btnXoaMon.TabIndex = 1;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = false;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.FromArgb(34, 139, 34);
            btnThemMon.FlatStyle = FlatStyle.Flat;
            btnThemMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThemMon.ForeColor = Color.White;
            btnThemMon.Location = new Point(0, 10);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(100, 35);
            btnThemMon.TabIndex = 0;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(0, 0);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(448, 544);
            dgvHoaDon.TabIndex = 0;
            // 
            // pnlBanDangChon
            // 
            pnlBanDangChon.Controls.Add(lblBanDangChon);
            pnlBanDangChon.Controls.Add(lblBanDangChonText);
            pnlBanDangChon.Dock = DockStyle.Top;
            pnlBanDangChon.Location = new Point(15, 55);
            pnlBanDangChon.Name = "pnlBanDangChon";
            pnlBanDangChon.Size = new Size(448, 40);
            pnlBanDangChon.TabIndex = 1;
            // 
            // lblBanDangChon
            // 
            lblBanDangChon.AutoSize = true;
            lblBanDangChon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBanDangChon.ForeColor = Color.FromArgb(220, 20, 60);
            lblBanDangChon.Location = new Point(130, 10);
            lblBanDangChon.Name = "lblBanDangChon";
            lblBanDangChon.Size = new Size(0, 21);
            lblBanDangChon.TabIndex = 1;
            // 
            // lblBanDangChonText
            // 
            lblBanDangChonText.AutoSize = true;
            lblBanDangChonText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBanDangChonText.Location = new Point(0, 10);
            lblBanDangChonText.Name = "lblBanDangChonText";
            lblBanDangChonText.Size = new Size(128, 21);
            lblBanDangChonText.TabIndex = 0;
            lblBanDangChonText.Text = "Bàn đang chọn:";
            // 
            // lblThanhToanTitle
            // 
            lblThanhToanTitle.Dock = DockStyle.Top;
            lblThanhToanTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThanhToanTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblThanhToanTitle.Location = new Point(15, 15);
            lblThanhToanTitle.Name = "lblThanhToanTitle";
            lblThanhToanTitle.Size = new Size(448, 40);
            lblThanhToanTitle.TabIndex = 0;
            lblThanhToanTitle.Text = "KHU VỰC THANH TOÁN";
            lblThanhToanTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1000, 598);
            Name = "fQuanLyBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bàn - Quản lý quán cà phê";
            FormClosing += fQuanLyBan_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlBanInfo.ResumeLayout(false);
            pnlBanInfo.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlBanHeader.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlThanhToan.ResumeLayout(false);
            pnlThanhToanButton.ResumeLayout(false);
            pnlTongTien.ResumeLayout(false);
            pnlTongTien.PerformLayout();
            pnlHoaDon.ResumeLayout(false);
            pnlHoaDonControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            pnlBanDangChon.ResumeLayout(false);
            pnlBanDangChon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuHeThong;
        private ToolStripMenuItem menuDangXuat;
        private ToolStripMenuItem menuThoat;
        private ToolStripMenuItem menuQuanLy;
        private ToolStripMenuItem menuQuanLyBan;
        private ToolStripMenuItem menuQuanLyMon;
        private ToolStripMenuItem menuQuanLyNhanVien;
        private ToolStripMenuItem menuBaoCao;
        private ToolStripMenuItem menuBaoCaoDoanhThu;
        private ToolStripMenuItem menuBaoCaoMonBanChay;
        private Panel pnlLeft;
        private FlowLayoutPanel flpBan;
        private Panel pnlBanInfo;
        private Label lblTrangThaiHienTai;
        private Label lblThongTinBan;
        private Panel pnlFilter;
        private ComboBox cboKhuVuc;
        private Label lblKhuVuc;
        private Panel pnlBanHeader;
        private Label lblTitle;
        private Panel pnlRight;
        private Panel pnlThanhToan;
        private Panel pnlThanhToanButton;
        private Button btnThanhToan;
        private Panel pnlTongTien;
        private Label lblTongTien;
        private Label lblTongTienText;
        private Panel pnlHoaDon;
        private Panel pnlHoaDonControls;
        private Button btnXoaMon;
        private Button btnThemMon;
        private DataGridView dgvHoaDon;
        private Panel pnlBanDangChon;
        private Label lblBanDangChon;
        private Label lblBanDangChonText;
        private Label lblThanhToanTitle;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
    }
}