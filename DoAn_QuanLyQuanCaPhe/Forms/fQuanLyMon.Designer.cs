namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fQuanLyMon
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnXem = new Button();
            btnXoa = new Button();
            Sửa = new Button();
            btnThem = new Button();
            panel3 = new Panel();
            grvMon = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colDVT = new DataGridViewTextBoxColumn();
            colMaDM = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            txtTrangThai = new TextBox();
            label7 = new Label();
            txtDVT = new TextBox();
            label5 = new Label();
            btnTimKiem = new Button();
            txtGia = new TextBox();
            txtTenSanPham = new TextBox();
            txtTimKiemMon = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboDanhMuc = new ComboBox();
            txtID = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvMon).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Món ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnXem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(Sửa);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 663);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 90);
            panel2.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.Bottom;
            btnXem.Location = new Point(730, 10);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(84, 68);
            btnXem.TabIndex = 7;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(466, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 62);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            Sửa.Anchor = AnchorStyles.Bottom;
            Sửa.Location = new Point(596, 12);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(96, 62);
            Sửa.TabIndex = 5;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(336, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 62);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(grvMon);
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(908, 623);
            panel3.TabIndex = 2;
            // 
            // grvMon
            // 
            grvMon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvMon.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSP, colDonGia, colDVT, colMaDM, colTrangThai });
            grvMon.Location = new Point(0, 0);
            grvMon.Name = "grvMon";
            grvMon.RowHeadersWidth = 51;
            grvMon.Size = new Size(908, 623);
            grvMon.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSP
            // 
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colDVT
            // 
            colDVT.HeaderText = "Đơn vị tính";
            colDVT.MinimumWidth = 6;
            colDVT.Name = "colDVT";
            // 
            // colMaDM
            // 
            colMaDM.HeaderText = "Mã Danh Mục";
            colMaDM.MinimumWidth = 6;
            colMaDM.Name = "colMaDM";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(txtTrangThai);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtDVT);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnTimKiem);
            panel4.Controls.Add(txtGia);
            panel4.Controls.Add(txtTenSanPham);
            panel4.Controls.Add(txtTimKiemMon);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cboDanhMuc);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(914, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 623);
            panel4.TabIndex = 3;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(126, 343);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 27);
            txtTrangThai.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 346);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 19;
            label7.Text = "Trạng thái";
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(126, 229);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(125, 27);
            txtDVT.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 236);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 17;
            label5.Text = "Đơn vị tính ";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(259, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(96, 53);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(118, 178);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(172, 27);
            txtGia.TabIndex = 15;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(118, 121);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(172, 27);
            txtTenSanPham.TabIndex = 14;
            // 
            // txtTimKiemMon
            // 
            txtTimKiemMon.Location = new Point(58, 18);
            txtTimKiemMon.Name = "txtTimKiemMon";
            txtTimKiemMon.Size = new Size(182, 27);
            txtTimKiemMon.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 185);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 12;
            label6.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 124);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên Món";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 276);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Danh Mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 70);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 8;
            label2.Text = "ID";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(126, 268);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(172, 28);
            cboDanhMuc.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(96, 27);
            txtID.TabIndex = 6;
            // 
            // fQuanLyMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 753);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1200, 800);
            Name = "fQuanLyMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý món";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvMon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView grvMon;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colDVT;
        private DataGridViewTextBoxColumn colMaDM;
        private DataGridViewTextBoxColumn colTrangThai;
        private Button btnXem;
        private Button btnXoa;
        private Button Sửa;
        private Button btnThem;
        private TextBox txtGia;
        private TextBox txtTenSanPham;
        private TextBox txtTimKiemMon;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboDanhMuc;
        private TextBox txtID;
        private Button btnTimKiem;
        private TextBox txtTrangThai;
        private Label label7;
        private TextBox txtDVT;
        private Label label5;
    }
}