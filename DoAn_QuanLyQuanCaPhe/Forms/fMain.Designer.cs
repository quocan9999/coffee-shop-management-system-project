namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fMain
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
            menuStrip1.Size = new Size(1371, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            menuHeThong.DropDownItems.AddRange(new ToolStripItem[] { menuDangXuat, menuThoat });
            menuHeThong.Name = "menuHeThong";
            menuHeThong.Size = new Size(85, 24);
            menuHeThong.Text = "Hệ thống";
            // 
            // menuDangXuat
            // 
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(160, 26);
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(160, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // menuQuanLy
            // 
            menuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { menuQuanLyBan, menuQuanLyMon, menuQuanLyNhanVien, quảnLýDanhMụcToolStripMenuItem });
            menuQuanLy.Name = "menuQuanLy";
            menuQuanLy.Size = new Size(73, 24);
            menuQuanLy.Text = "Quản lý";
            // 
            // menuQuanLyBan
            // 
            menuQuanLyBan.Name = "menuQuanLyBan";
            menuQuanLyBan.Size = new Size(211, 26);
            menuQuanLyBan.Text = "Quản lý bàn";
            menuQuanLyBan.Click += menuQuanLyBan_Click;
            // 
            // menuQuanLyMon
            // 
            menuQuanLyMon.Name = "menuQuanLyMon";
            menuQuanLyMon.Size = new Size(211, 26);
            menuQuanLyMon.Text = "Quản lý món";
            menuQuanLyMon.Click += menuQuanLyMon_Click;
            // 
            // menuQuanLyNhanVien
            // 
            menuQuanLyNhanVien.Name = "menuQuanLyNhanVien";
            menuQuanLyNhanVien.Size = new Size(211, 26);
            menuQuanLyNhanVien.Text = "Quản lý nhân viên";
            menuQuanLyNhanVien.Click += menuQuanLyNhanVien_Click;
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            quảnLýDanhMụcToolStripMenuItem.Size = new Size(211, 26);
            quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            quảnLýDanhMụcToolStripMenuItem.Click += menuQuanLyDanhMuc_Click;
            // 
            // menuBaoCao
            // 
            menuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { menuBaoCaoDoanhThu, menuBaoCaoMonBanChay });
            menuBaoCao.Name = "menuBaoCao";
            menuBaoCao.Size = new Size(77, 24);
            menuBaoCao.Text = "Báo cáo";
            // 
            // menuBaoCaoDoanhThu
            // 
            menuBaoCaoDoanhThu.Name = "menuBaoCaoDoanhThu";
            menuBaoCaoDoanhThu.Size = new Size(243, 26);
            menuBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            menuBaoCaoDoanhThu.Click += menuBaoCaoDoanhThu_Click;
            // 
            // menuBaoCaoMonBanChay
            // 
            menuBaoCaoMonBanChay.Name = "menuBaoCaoMonBanChay";
            menuBaoCaoMonBanChay.Size = new Size(243, 26);
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
            pnlLeft.Location = new Point(0, 28);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new Padding(11, 13, 11, 13);
            pnlLeft.Size = new Size(800, 905);
            pnlLeft.TabIndex = 0;
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.BackColor = Color.White;
            flpBan.BorderStyle = BorderStyle.FixedSingle;
            flpBan.Dock = DockStyle.Fill;
            flpBan.Location = new Point(11, 133);
            flpBan.Margin = new Padding(3, 4, 3, 4);
            flpBan.Name = "flpBan";
            flpBan.Padding = new Padding(11, 13, 11, 13);
            flpBan.Size = new Size(778, 692);
            flpBan.TabIndex = 3;
            // 
            // pnlBanInfo
            // 
            pnlBanInfo.Controls.Add(lblTrangThaiHienTai);
            pnlBanInfo.Controls.Add(lblThongTinBan);
            pnlBanInfo.Dock = DockStyle.Bottom;
            pnlBanInfo.Location = new Point(11, 825);
            pnlBanInfo.Margin = new Padding(3, 4, 3, 4);
            pnlBanInfo.Name = "pnlBanInfo";
            pnlBanInfo.Size = new Size(778, 67);
            pnlBanInfo.TabIndex = 2;
            // 
            // lblTrangThaiHienTai
            // 
            lblTrangThaiHienTai.AutoSize = true;
            lblTrangThaiHienTai.Font = new Font("Segoe UI", 10F);
            lblTrangThaiHienTai.Location = new Point(0, 37);
            lblTrangThaiHienTai.Name = "lblTrangThaiHienTai";
            lblTrangThaiHienTai.Size = new Size(0, 23);
            lblTrangThaiHienTai.TabIndex = 1;
            // 
            // lblThongTinBan
            // 
            lblThongTinBan.AutoSize = true;
            lblThongTinBan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThongTinBan.ForeColor = Color.FromArgb(0, 102, 204);
            lblThongTinBan.Location = new Point(0, 7);
            lblThongTinBan.Name = "lblThongTinBan";
            lblThongTinBan.Size = new Size(146, 25);
            lblThongTinBan.TabIndex = 0;
            lblThongTinBan.Text = "Chưa chọn bàn";
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboKhuVuc);
            pnlFilter.Controls.Add(lblKhuVuc);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(11, 80);
            pnlFilter.Margin = new Padding(3, 4, 3, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(0, 7, 0, 7);
            pnlFilter.Size = new Size(778, 53);
            pnlFilter.TabIndex = 1;
            // 
            // cboKhuVuc
            // 
            cboKhuVuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhuVuc.Font = new Font("Segoe UI", 10F);
            cboKhuVuc.FormattingEnabled = true;
            cboKhuVuc.Location = new Point(137, 9);
            cboKhuVuc.Margin = new Padding(3, 4, 3, 4);
            cboKhuVuc.Name = "cboKhuVuc";
            cboKhuVuc.Size = new Size(171, 31);
            cboKhuVuc.TabIndex = 1;
            cboKhuVuc.SelectedIndexChanged += cboKhuVuc_SelectedIndexChanged;
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKhuVuc.Location = new Point(0, 13);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(124, 25);
            lblKhuVuc.TabIndex = 0;
            lblKhuVuc.Text = "Lọc khu vực:";
            // 
            // pnlBanHeader
            // 
            pnlBanHeader.Controls.Add(lblTitle);
            pnlBanHeader.Dock = DockStyle.Top;
            pnlBanHeader.Location = new Point(11, 13);
            pnlBanHeader.Margin = new Padding(3, 4, 3, 4);
            pnlBanHeader.Name = "pnlBanHeader";
            pnlBanHeader.Size = new Size(778, 67);
            pnlBanHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(778, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ BÀN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(248, 249, 250);
            pnlRight.Controls.Add(pnlThanhToan);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(800, 28);
            pnlRight.Margin = new Padding(3, 4, 3, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(11, 13, 11, 13);
            pnlRight.Size = new Size(571, 905);
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
            pnlThanhToan.Location = new Point(11, 13);
            pnlThanhToan.Margin = new Padding(3, 4, 3, 4);
            pnlThanhToan.Name = "pnlThanhToan";
            pnlThanhToan.Padding = new Padding(17, 20, 17, 20);
            pnlThanhToan.Size = new Size(549, 879);
            pnlThanhToan.TabIndex = 0;
            // 
            // pnlThanhToanButton
            // 
            pnlThanhToanButton.Controls.Add(btnThanhToan);
            pnlThanhToanButton.Dock = DockStyle.Bottom;
            pnlThanhToanButton.Location = new Point(17, 723);
            pnlThanhToanButton.Margin = new Padding(3, 4, 3, 4);
            pnlThanhToanButton.Name = "pnlThanhToanButton";
            pnlThanhToanButton.Size = new Size(513, 67);
            pnlThanhToanButton.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThanhToan.BackColor = Color.FromArgb(0, 102, 204);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(262, 7);
            btnThanhToan.Margin = new Padding(3, 4, 3, 4);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(137, 53);
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
            pnlTongTien.Location = new Point(17, 790);
            pnlTongTien.Margin = new Padding(3, 4, 3, 4);
            pnlTongTien.Name = "pnlTongTien";
            pnlTongTien.Size = new Size(513, 67);
            pnlTongTien.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(220, 20, 60);
            lblTongTien.Location = new Point(126, 20);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(88, 32);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTienText.Location = new Point(0, 20);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(131, 32);
            lblTongTienText.TabIndex = 0;
            lblTongTienText.Text = "Tổng tiền:";
            // 
            // pnlHoaDon
            // 
            pnlHoaDon.Controls.Add(pnlHoaDonControls);
            pnlHoaDon.Controls.Add(dgvHoaDon);
            pnlHoaDon.Dock = DockStyle.Fill;
            pnlHoaDon.Location = new Point(17, 126);
            pnlHoaDon.Margin = new Padding(3, 4, 3, 4);
            pnlHoaDon.Name = "pnlHoaDon";
            pnlHoaDon.Size = new Size(513, 731);
            pnlHoaDon.TabIndex = 2;
            // 
            // pnlHoaDonControls
            // 
            pnlHoaDonControls.Controls.Add(btnXoaMon);
            pnlHoaDonControls.Controls.Add(btnThemMon);
            pnlHoaDonControls.Dock = DockStyle.Bottom;
            pnlHoaDonControls.Location = new Point(0, 664);
            pnlHoaDonControls.Margin = new Padding(3, 4, 3, 4);
            pnlHoaDonControls.Name = "pnlHoaDonControls";
            pnlHoaDonControls.Size = new Size(513, 67);
            pnlHoaDonControls.TabIndex = 1;
            // 
            // btnXoaMon
            // 
            btnXoaMon.BackColor = Color.FromArgb(220, 20, 60);
            btnXoaMon.FlatStyle = FlatStyle.Flat;
            btnXoaMon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoaMon.ForeColor = Color.White;
            btnXoaMon.Location = new Point(126, 13);
            btnXoaMon.Margin = new Padding(3, 4, 3, 4);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(103, 47);
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
            btnThemMon.Location = new Point(0, 13);
            btnThemMon.Margin = new Padding(3, 4, 3, 4);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(114, 47);
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
            dgvHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 25;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(513, 731);
            dgvHoaDon.TabIndex = 0;
            // 
            // pnlBanDangChon
            // 
            pnlBanDangChon.Controls.Add(lblBanDangChon);
            pnlBanDangChon.Controls.Add(lblBanDangChonText);
            pnlBanDangChon.Dock = DockStyle.Top;
            pnlBanDangChon.Location = new Point(17, 73);
            pnlBanDangChon.Margin = new Padding(3, 4, 3, 4);
            pnlBanDangChon.Name = "pnlBanDangChon";
            pnlBanDangChon.Size = new Size(513, 53);
            pnlBanDangChon.TabIndex = 1;
            // 
            // lblBanDangChon
            // 
            lblBanDangChon.AutoSize = true;
            lblBanDangChon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBanDangChon.ForeColor = Color.FromArgb(220, 20, 60);
            lblBanDangChon.Location = new Point(149, 13);
            lblBanDangChon.Name = "lblBanDangChon";
            lblBanDangChon.Size = new Size(0, 28);
            lblBanDangChon.TabIndex = 1;
            // 
            // lblBanDangChonText
            // 
            lblBanDangChonText.AutoSize = true;
            lblBanDangChonText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBanDangChonText.Location = new Point(0, 13);
            lblBanDangChonText.Name = "lblBanDangChonText";
            lblBanDangChonText.Size = new Size(159, 28);
            lblBanDangChonText.TabIndex = 0;
            lblBanDangChonText.Text = "Bàn đang chọn:";
            // 
            // lblThanhToanTitle
            // 
            lblThanhToanTitle.Dock = DockStyle.Top;
            lblThanhToanTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThanhToanTitle.ForeColor = Color.FromArgb(0, 102, 204);
            lblThanhToanTitle.Location = new Point(17, 20);
            lblThanhToanTitle.Name = "lblThanhToanTitle";
            lblThanhToanTitle.Size = new Size(513, 53);
            lblThanhToanTitle.TabIndex = 0;
            lblThanhToanTitle.Text = "KHU VỰC THANH TOÁN";
            lblThanhToanTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 933);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main - Quản lý quán cà phê";
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