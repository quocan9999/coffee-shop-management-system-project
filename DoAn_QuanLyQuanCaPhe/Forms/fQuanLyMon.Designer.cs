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
            panel4 = new Panel();
            panel10 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            label6 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            txtTrangThai = new TextBox();
            txtDVT = new TextBox();
            btnTimKiem = new Button();
            txtGia = new TextBox();
            txtTenSanPham = new TextBox();
            txtTimKiemMon = new TextBox();
            cboDanhMuc = new ComboBox();
            txtID = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvMon).BeginInit();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
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
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 6);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
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
            panel2.Location = new Point(0, 640);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 113);
            panel2.TabIndex = 1;
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.Bottom;
            btnXem.BackColor = SystemColors.Info;
            btnXem.Location = new Point(730, 35);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 62);
            btnXem.TabIndex = 7;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = SystemColors.Info;
            btnXoa.Location = new Point(466, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 62);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // Sửa
            // 
            Sửa.Anchor = AnchorStyles.Bottom;
            Sửa.BackColor = SystemColors.Info;
            Sửa.Location = new Point(596, 35);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(102, 62);
            Sửa.TabIndex = 5;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = false;
            Sửa.Click += Sửa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = SystemColors.Info;
            btnThem.Location = new Point(336, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 62);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            grvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvMon.Dock = DockStyle.Fill;
            grvMon.Location = new Point(0, 0);
            grvMon.Name = "grvMon";
            grvMon.RowHeadersWidth = 51;
            grvMon.Size = new Size(908, 623);
            grvMon.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtTrangThai);
            panel4.Controls.Add(txtDVT);
            panel4.Controls.Add(btnTimKiem);
            panel4.Controls.Add(txtGia);
            panel4.Controls.Add(txtTenSanPham);
            panel4.Controls.Add(txtTimKiemMon);
            panel4.Controls.Add(cboDanhMuc);
            panel4.Controls.Add(txtID);
            panel4.Location = new Point(914, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 620);
            panel4.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonFace;
            panel10.Controls.Add(label2);
            panel10.Location = new Point(23, 117);
            panel10.Name = "panel10";
            panel10.Size = new Size(114, 27);
            panel10.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 3);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(label4);
            panel9.Location = new Point(23, 178);
            panel9.Name = "panel9";
            panel9.Size = new Size(114, 27);
            panel9.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 3);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên Món";
            label4.Click += label4_Click;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(label6);
            panel8.Location = new Point(23, 236);
            panel8.Name = "panel8";
            panel8.Size = new Size(114, 27);
            panel8.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 3);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 12;
            label6.Text = "Giá";
            label6.Click += label6_Click;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(label5);
            panel7.Location = new Point(23, 302);
            panel7.Name = "panel7";
            panel7.Size = new Size(114, 27);
            panel7.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 3);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 17;
            label5.Text = "Đơn vị tính ";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(23, 364);
            panel6.Name = "panel6";
            panel6.Size = new Size(114, 27);
            panel6.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 3);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Danh Mục";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(23, 440);
            panel5.Name = "panel5";
            panel5.Size = new Size(114, 27);
            panel5.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 19;
            label7.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(173, 440);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(172, 27);
            txtTrangThai.TabIndex = 20;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(173, 302);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(172, 27);
            txtDVT.TabIndex = 18;
            txtDVT.TextChanged += txtDVT_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.Info;
            btnTimKiem.Location = new Point(262, 19);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(102, 63);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(173, 236);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(172, 27);
            txtGia.TabIndex = 15;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(173, 178);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(172, 27);
            txtTenSanPham.TabIndex = 14;
            // 
            // txtTimKiemMon
            // 
            txtTimKiemMon.Location = new Point(23, 46);
            txtTimKiemMon.Name = "txtTimKiemMon";
            txtTimKiemMon.Size = new Size(220, 27);
            txtTimKiemMon.TabIndex = 13;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(173, 367);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(172, 28);
            cboDanhMuc.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(173, 117);
            txtID.Name = "txtID";
            txtID.Size = new Size(172, 27);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
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
            Load += fQuanLyMon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvMon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView grvMon;
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
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel10;
        private Panel panel9;
    }
}