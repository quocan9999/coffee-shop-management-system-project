namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fDangNhap
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnDangKy = new Button();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblTitle = new Label();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.coffeesidebar1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 544);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblTenDangNhap);
            panel1.Location = new Point(362, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 555);
            panel1.TabIndex = 1;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(395, 289);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(107, 43);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(213, 289);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(107, 43);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(213, 221);
            txtMatKhau.Margin = new Padding(5, 5, 5, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(292, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(213, 151);
            txtTenDangNhap.Margin = new Padding(5, 5, 5, 5);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(292, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(234, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 38);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Coffee Shop";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(56, 221);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(93, 25);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangNhap.Location = new Point(56, 149);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(138, 25);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // fDangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 544);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1025, 591);
            MinimumSize = new Size(1025, 591);
            Name = "fDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += fDangNhap_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblTitle;
        private Label lblMatKhau;
        private Button btnDangKy;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
    }
}