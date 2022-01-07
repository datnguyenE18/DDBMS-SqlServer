namespace DemoPhanTan
{
    partial class frm_HoaDonNhap
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
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiaTriHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHDN
            // 
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDNhap,
            this.TongGiaTriHDNhap,
            this.MaNCC,
            this.MaNV});
            this.dgvHDN.Location = new System.Drawing.Point(26, 76);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.Size = new System.Drawing.Size(916, 461);
            this.dgvHDN.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "Hóa Đơn Nhập";
            // 
            // MaHDNhap
            // 
            this.MaHDNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDNhap.DataPropertyName = "MaHDNhap";
            this.MaHDNhap.HeaderText = "Mã Hóa Đơn Nhập";
            this.MaHDNhap.Name = "MaHDNhap";
            // 
            // TongGiaTriHDNhap
            // 
            this.TongGiaTriHDNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongGiaTriHDNhap.DataPropertyName = "TongGiaTriHDNhap";
            this.TongGiaTriHDNhap.HeaderText = "Tổng Giá Trị Hóa Đơn Nhập";
            this.TongGiaTriHDNhap.Name = "TongGiaTriHDNhap";
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên Nhập";
            this.MaNV.Name = "MaNV";
            // 
            // frm_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHDN);
            this.Name = "frm_HoaDonNhap";
            this.Text = "frm_HoaDonNhap";
            this.Load += new System.EventHandler(this.frm_HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiaTriHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}