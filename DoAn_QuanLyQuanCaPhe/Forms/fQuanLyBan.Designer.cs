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
            panel1 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnXem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            grvQuanLyBan = new DataGridView();
            panel3 = new Panel();
            txtTrangThai = new TextBox();
            panel8 = new Panel();
            label5 = new Label();
            txtID = new TextBox();
            panel7 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            txtTenBan = new TextBox();
            txtViTri = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvQuanLyBan).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1276, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 26);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Bàn ";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(btnXem);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnThem);
            panel4.Location = new Point(0, 616);
            panel4.Name = "panel4";
            panel4.Size = new Size(1276, 148);
            panel4.TabIndex = 3;
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.Bottom;
            btnXem.BackColor = SystemColors.Info;
            btnXem.Location = new Point(743, 22);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(112, 78);
            btnXem.TabIndex = 3;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Bottom;
            btnSua.BackColor = SystemColors.Info;
            btnSua.Location = new Point(579, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 78);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = SystemColors.Info;
            btnXoa.Location = new Point(423, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 78);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = SystemColors.Info;
            btnThem.Location = new Point(265, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 78);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(grvQuanLyBan);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 542);
            panel2.TabIndex = 4;
            // 
            // grvQuanLyBan
            // 
            grvQuanLyBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvQuanLyBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvQuanLyBan.Dock = DockStyle.Fill;
            grvQuanLyBan.Location = new Point(0, 0);
            grvQuanLyBan.Name = "grvQuanLyBan";
            grvQuanLyBan.RowHeadersWidth = 51;
            grvQuanLyBan.Size = new Size(843, 542);
            grvQuanLyBan.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(txtViTri);
            panel3.Controls.Add(txtTrangThai);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(txtTenBan);
            panel3.Location = new Point(843, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(433, 542);
            panel3.TabIndex = 5;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(212, 307);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(151, 27);
            txtTrangThai.TabIndex = 12;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(76, 172);
            panel8.Name = "panel8";
            panel8.Size = new Size(116, 28);
            panel8.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 4);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 4;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(212, 172);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(label2);
            panel7.Location = new Point(76, 108);
            panel7.Name = "panel7";
            panel7.Size = new Size(116, 28);
            panel7.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 3);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Vị trí";
            label2.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(76, 235);
            panel6.Name = "panel6";
            panel6.Size = new Size(116, 28);
            panel6.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 4);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên bàn";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(76, 307);
            panel5.Name = "panel5";
            panel5.Size = new Size(116, 28);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 3);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Trạng thái";
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(212, 235);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(151, 27);
            txtTenBan.TabIndex = 1;
            // 
            // txtViTri
            // 
            txtViTri.Location = new Point(212, 108);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(151, 27);
            txtViTri.TabIndex = 13;
            // 
            // fQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 764);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "fQuanLyBan";
            Text = "fQuanLyBan";
            Load += fQuanLyBan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvQuanLyBan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DataGridView grvQuanLyBan;
        private TextBox txtTenBan;
        private Label label2;
        private Button btnXem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label4;
        private Label label3;
        private Panel panel8;
        private Label label5;
        private TextBox txtID;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private TextBox txtTrangThai;
        private TextBox txtViTri;
    }
}