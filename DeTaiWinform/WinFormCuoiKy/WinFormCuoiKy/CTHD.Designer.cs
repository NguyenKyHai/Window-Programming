namespace WinFormCuoiKy
{
    partial class CTHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuongHD = new System.Windows.Forms.TextBox();
            this.txtSoLuongXe = new System.Windows.Forms.TextBox();
            this.btnSoLuongHD = new System.Windows.Forms.Button();
            this.btnSoLuongXe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxMaXe = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTHD);
            this.panel1.Location = new System.Drawing.Point(645, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 570);
            this.panel1.TabIndex = 90;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaXe,
            this.SoLuong});
            this.dgvCTHD.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(625, 570);
            this.dgvCTHD.TabIndex = 0;
            this.dgvCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            this.MaXe.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(188, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 104;
            this.label1.Text = "Chi tiết hóa đơn\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(143, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 32);
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHD.Location = new System.Drawing.Point(260, 118);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(243, 15);
            this.txtMaHD.TabIndex = 109;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(143, 197);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(360, 32);
            this.pictureBox5.TabIndex = 112;
            this.pictureBox5.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Location = new System.Drawing.Point(260, 199);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(243, 15);
            this.txtSoLuong.TabIndex = 113;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTaiLai.BackgroundImage = global::WinFormCuoiKy.Properties.Resources.btn_Tảilai;
            this.btnTaiLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaiLai.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Location = new System.Drawing.Point(33, 425);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(150, 50);
            this.btnTaiLai.TabIndex = 114;
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.BackgroundImage = global::WinFormCuoiKy.Properties.Resources.btn_Sửa1;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(223, 425);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 50);
            this.btnSua.TabIndex = 116;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.BackgroundImage = global::WinFormCuoiKy.Properties.Resources.btn_Xóa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(416, 425);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 50);
            this.btnXoa.TabIndex = 117;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 119;
            this.label5.Text = "Mã xe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 120;
            this.label6.Text = "Số lượng:";
            // 
            // txtSoLuongHD
            // 
            this.txtSoLuongHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSoLuongHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongHD.Location = new System.Drawing.Point(238, 270);
            this.txtSoLuongHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongHD.Multiline = true;
            this.txtSoLuongHD.Name = "txtSoLuongHD";
            this.txtSoLuongHD.Size = new System.Drawing.Size(265, 22);
            this.txtSoLuongHD.TabIndex = 121;
            // 
            // txtSoLuongXe
            // 
            this.txtSoLuongXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSoLuongXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuongXe.Location = new System.Drawing.Point(238, 317);
            this.txtSoLuongXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongXe.Multiline = true;
            this.txtSoLuongXe.Name = "txtSoLuongXe";
            this.txtSoLuongXe.Size = new System.Drawing.Size(265, 22);
            this.txtSoLuongXe.TabIndex = 122;
            // 
            // btnSoLuongHD
            // 
            this.btnSoLuongHD.Location = new System.Drawing.Point(105, 267);
            this.btnSoLuongHD.Name = "btnSoLuongHD";
            this.btnSoLuongHD.Size = new System.Drawing.Size(103, 25);
            this.btnSoLuongHD.TabIndex = 123;
            this.btnSoLuongHD.Text = "Số lượng HD";
            this.btnSoLuongHD.UseVisualStyleBackColor = true;
            this.btnSoLuongHD.Click += new System.EventHandler(this.btnSoLuongHD_Click);
            // 
            // btnSoLuongXe
            // 
            this.btnSoLuongXe.Location = new System.Drawing.Point(105, 317);
            this.btnSoLuongXe.Name = "btnSoLuongXe";
            this.btnSoLuongXe.Size = new System.Drawing.Size(103, 23);
            this.btnSoLuongXe.TabIndex = 124;
            this.btnSoLuongXe.Text = "Số lượng xe";
            this.btnSoLuongXe.UseVisualStyleBackColor = true;
            this.btnSoLuongXe.Click += new System.EventHandler(this.btnSoLuongXe_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.cbxMaXe);
            this.panel2.Controls.Add(this.btnSoLuongXe);
            this.panel2.Controls.Add(this.btnSoLuongHD);
            this.panel2.Controls.Add(this.txtSoLuongXe);
            this.panel2.Controls.Add(this.txtSoLuongHD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnTaiLai);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 570);
            this.panel2.TabIndex = 3;
            // 
            // cbxMaXe
            // 
            this.cbxMaXe.FormattingEnabled = true;
            this.cbxMaXe.Location = new System.Drawing.Point(220, 157);
            this.cbxMaXe.Name = "cbxMaXe";
            this.cbxMaXe.Size = new System.Drawing.Size(283, 24);
            this.cbxMaXe.TabIndex = 125;
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormCuoiKy.Properties.Resources.Untitled_11;
            this.ClientSize = new System.Drawing.Size(1282, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTHD";
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuongHD;
        private System.Windows.Forms.TextBox txtSoLuongXe;
        private System.Windows.Forms.Button btnSoLuongHD;
        private System.Windows.Forms.Button btnSoLuongXe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxMaXe;
    }
}