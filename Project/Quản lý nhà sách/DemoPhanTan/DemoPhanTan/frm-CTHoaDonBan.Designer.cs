namespace DemoPhanTan
{
    partial class frm_CTHoaDonBan
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
            this.dgvCTHDB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaCTHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTienSachBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSachBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHDB
            // 
            this.dgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHDBan,
            this.MaHDBan,
            this.NgayBan,
            this.GiaTienSachBan,
            this.SoLuongSachBan,
            this.MaSach});
            this.dgvCTHDB.Location = new System.Drawing.Point(23, 83);
            this.dgvCTHDB.Name = "dgvCTHDB";
            this.dgvCTHDB.Size = new System.Drawing.Size(948, 509);
            this.dgvCTHDB.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "Chi Tiết Hóa Đơn Bán";
            // 
            // MaCTHDBan
            // 
            this.MaCTHDBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCTHDBan.DataPropertyName = "MaCTHDBan";
            this.MaCTHDBan.HeaderText = "Mã CTHDB";
            this.MaCTHDBan.Name = "MaCTHDBan";
            // 
            // MaHDBan
            // 
            this.MaHDBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDBan.DataPropertyName = "MaHDBan";
            this.MaHDBan.HeaderText = "Mã HDB";
            this.MaHDBan.Name = "MaHDBan";
            // 
            // NgayBan
            // 
            this.NgayBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            // 
            // GiaTienSachBan
            // 
            this.GiaTienSachBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTienSachBan.DataPropertyName = "GiaTienSachBan";
            this.GiaTienSachBan.HeaderText = "Giá Tiền";
            this.GiaTienSachBan.Name = "GiaTienSachBan";
            // 
            // SoLuongSachBan
            // 
            this.SoLuongSachBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongSachBan.DataPropertyName = "SoLuongSachBan";
            this.SoLuongSachBan.HeaderText = "Số Lượng";
            this.SoLuongSachBan.Name = "SoLuongSachBan";
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Sách";
            this.MaSach.Name = "MaSach";
            // 
            // frm_CTHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTHDB);
            this.Name = "frm_CTHoaDonBan";
            this.Text = "frm_CTHoaDonBan";
            this.Load += new System.EventHandler(this.frm_CTHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTienSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
    }
}