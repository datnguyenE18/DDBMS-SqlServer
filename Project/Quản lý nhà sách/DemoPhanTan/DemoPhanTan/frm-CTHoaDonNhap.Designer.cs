namespace DemoPhanTan
{
    partial class frm_CTHoaDonNhap
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
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaCTHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTienSachNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSachNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHDNhap,
            this.MaHDNhap,
            this.NgayNhap,
            this.GiaTienSachNhap,
            this.SoLuongSachNhap,
            this.MaSach});
            this.dgvCTHDN.Location = new System.Drawing.Point(12, 73);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.Size = new System.Drawing.Size(939, 442);
            this.dgvCTHDN.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 72;
            this.label1.Text = "Chi Tiết Hóa Đơn Nhập Sách";
            // 
            // MaCTHDNhap
            // 
            this.MaCTHDNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCTHDNhap.DataPropertyName = "MaCTHDNhap";
            this.MaCTHDNhap.HeaderText = "Mã CTHDN";
            this.MaCTHDNhap.Name = "MaCTHDNhap";
            // 
            // MaHDNhap
            // 
            this.MaHDNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDNhap.DataPropertyName = "MaHDNhap";
            this.MaHDNhap.HeaderText = "Mã HDN";
            this.MaHDNhap.Name = "MaHDNhap";
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // GiaTienSachNhap
            // 
            this.GiaTienSachNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTienSachNhap.DataPropertyName = "GiaTienSachNhap";
            this.GiaTienSachNhap.HeaderText = "Giá Tiền";
            this.GiaTienSachNhap.Name = "GiaTienSachNhap";
            // 
            // SoLuongSachNhap
            // 
            this.SoLuongSachNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongSachNhap.DataPropertyName = "SoLuongSachNhap";
            this.SoLuongSachNhap.HeaderText = "Số Lượng";
            this.SoLuongSachNhap.Name = "SoLuongSachNhap";
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Sách";
            this.MaSach.Name = "MaSach";
            // 
            // frm_CTHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTHDN);
            this.Name = "frm_CTHoaDonNhap";
            this.Text = "frm_CTHoaDonNhap";
            this.Load += new System.EventHandler(this.frm_CTHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTienSachNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSachNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.Label label1;
    }
}