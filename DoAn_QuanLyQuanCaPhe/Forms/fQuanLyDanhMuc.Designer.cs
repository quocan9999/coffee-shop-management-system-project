namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fQuanLyDanhMuc
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
            grvDanhMuc = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colDanhMuc = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            cboDanhMuc = new ComboBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            btnXem = new Button();
            btnXoa = new Button();
            Sửa = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvDanhMuc).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 47);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 12);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Quán Lý Danh Mục";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(grvDanhMuc);
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 616);
            panel2.TabIndex = 1;
            // 
            // grvDanhMuc
            // 
            grvDanhMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { colID, colDanhMuc });
            grvDanhMuc.Location = new Point(-3, 3);
            grvDanhMuc.Name = "grvDanhMuc";
            grvDanhMuc.RowHeadersWidth = 51;
            grvDanhMuc.Size = new Size(740, 613);
            grvDanhMuc.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colDanhMuc
            // 
            colDanhMuc.HeaderText = "Danh Mục";
            colDanhMuc.MinimumWidth = 6;
            colDanhMuc.Name = "colDanhMuc";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(cboDanhMuc);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(737, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(445, 616);
            panel3.TabIndex = 2;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(191, 125);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(151, 28);
            cboDanhMuc.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Location = new Point(191, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 133);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "Danh Mục";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 69);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnXem);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(Sửa);
            panel4.Controls.Add(btnThem);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 663);
            panel4.Name = "panel4";
            panel4.Size = new Size(1182, 90);
            panel4.TabIndex = 3;
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.Bottom;
            btnXem.Location = new Point(746, 11);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(100, 68);
            btnXem.TabIndex = 11;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(486, 13);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(99, 62);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            Sửa.Anchor = AnchorStyles.Bottom;
            Sửa.Location = new Point(612, 13);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(96, 62);
            Sửa.TabIndex = 9;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(352, 13);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 62);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // fQuanLyDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            MinimumSize = new Size(1200, 800);
            Name = "fQuanLyDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvDanhMuc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView grvDanhMuc;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colDanhMuc;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cboDanhMuc;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private Button btnXem;
        private Button btnXoa;
        private Button Sửa;
        private Button btnThem;
    }
}