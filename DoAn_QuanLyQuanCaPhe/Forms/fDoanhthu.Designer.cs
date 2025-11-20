namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fDoanhthu
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
            panel2 = new Panel();
            btn_ShowDoanhthu = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel3 = new Panel();
            dgvDoanhthu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhthu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 473);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btn_ShowDoanhthu);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 49);
            panel2.TabIndex = 0;
            // 
            // btn_ShowDoanhthu
            // 
            btn_ShowDoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ShowDoanhthu.Location = new Point(665, 7);
            btn_ShowDoanhthu.Name = "btn_ShowDoanhthu";
            btn_ShowDoanhthu.Size = new Size(127, 36);
            btn_ShowDoanhthu.TabIndex = 2;
            btn_ShowDoanhthu.Text = "Thống kê";
            btn_ShowDoanhthu.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Anchor = AnchorStyles.Top;
            dtpkToDate.Location = new Point(390, 12);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(213, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Anchor = AnchorStyles.Top;
            dtpkFromDate.Location = new Point(75, 12);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(214, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dgvDoanhthu);
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 424);
            panel3.TabIndex = 1;
            // 
            // dgvDoanhthu
            // 
            dgvDoanhthu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoanhthu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhthu.Location = new Point(0, 0);
            dgvDoanhthu.Name = "dgvDoanhthu";
            dgvDoanhthu.Size = new Size(888, 424);
            dgvDoanhthu.TabIndex = 4;
            // 
            // fDoanhthu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 473);
            Controls.Add(panel1);
            MinimumSize = new Size(904, 512);
            Name = "fDoanhthu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fDoanhthu";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoanhthu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_ShowDoanhthu;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel3;
        private DataGridView dgvDoanhthu;
    }
}