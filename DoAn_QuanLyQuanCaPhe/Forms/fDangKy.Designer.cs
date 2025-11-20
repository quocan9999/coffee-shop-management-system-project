namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fDangKy
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
            txtXacNhanMatKhau = new TextBox();
            lblXacNhanMatKhau = new Label();
            btnDangKy = new Button();
            txtMatKhau = new TextBox();
            txtTenDangKy = new TextBox();
            lblTitle = new Label();
            lblMatKhau = new Label();
            lblTenDangKy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coffeesidebar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 416);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtXacNhanMatKhau);
            panel1.Controls.Add(lblXacNhanMatKhau);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangKy);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblMatKhau);
            panel1.Controls.Add(lblTenDangKy);
            panel1.Location = new Point(323, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 416);
            panel1.TabIndex = 1;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(204, 211);
            txtXacNhanMatKhau.Margin = new Padding(4);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(256, 23);
            txtXacNhanMatKhau.TabIndex = 14;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMatKhau
            // 
            lblXacNhanMatKhau.AutoSize = true;
            lblXacNhanMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXacNhanMatKhau.Location = new Point(48, 211);
            lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            lblXacNhanMatKhau.Size = new Size(143, 20);
            lblXacNhanMatKhau.TabIndex = 13;
            lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(189, 281);
            btnDangKy.Margin = new Padding(3, 2, 3, 2);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 32);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(204, 158);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(256, 23);
            txtMatKhau.TabIndex = 10;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangKy
            // 
            txtTenDangKy.Location = new Point(204, 105);
            txtTenDangKy.Margin = new Padding(4);
            txtTenDangKy.Name = "txtTenDangKy";
            txtTenDangKy.Size = new Size(256, 23);
            txtTenDangKy.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(173, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(138, 30);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Coffee Shop";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(48, 158);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 20);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangKy
            // 
            lblTenDangKy.AutoSize = true;
            lblTenDangKy.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDangKy.Location = new Point(48, 104);
            lblTenDangKy.Name = "lblTenDangKy";
            lblTenDangKy.Size = new Size(112, 20);
            lblTenDangKy.TabIndex = 6;
            lblTenDangKy.Text = "Tên đăng nhập";
            // 
            // fDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 416);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "fDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox txtXacNhanMatKhau;
        private Label lblXacNhanMatKhau;
        private Button btnDangKy;
        private TextBox txtMatKhau;
        private TextBox txtTenDangKy;
        private Label lblTitle;
        private Label lblMatKhau;
        private Label lblTenDangKy;
    }
}