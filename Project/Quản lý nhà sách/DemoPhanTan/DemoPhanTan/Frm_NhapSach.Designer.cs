namespace DemoPhanTan
{
    partial class Frm_NhapSach
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
            this.btnAnHien = new System.Windows.Forms.Button();
            this.lbTimSach = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTKSach = new System.Windows.Forms.Button();
            this.cbxTieuChiTim = new System.Windows.Forms.ComboBox();
            this.lbTieuChiTim = new System.Windows.Forms.Label();
            this.cbxMaSach = new System.Windows.Forms.ComboBox();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTheLoaiDuocTim = new System.Windows.Forms.ComboBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnHien
            // 
            this.btnAnHien.Location = new System.Drawing.Point(546, 14);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(36, 23);
            this.btnAnHien.TabIndex = 109;
            this.btnAnHien.Text = "↓";
            this.btnAnHien.UseVisualStyleBackColor = true;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            // 
            // lbTimSach
            // 
            this.lbTimSach.AutoSize = true;
            this.lbTimSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimSach.Location = new System.Drawing.Point(544, 42);
            this.lbTimSach.Name = "lbTimSach";
            this.lbTimSach.Size = new System.Drawing.Size(70, 19);
            this.lbTimSach.TabIndex = 108;
            this.lbTimSach.Text = "Tìm sách";
            this.lbTimSach.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(676, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 27);
            this.txtTimKiem.TabIndex = 107;
            this.txtTimKiem.Visible = false;
            // 
            // btnTKSach
            // 
            this.btnTKSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSach.Location = new System.Drawing.Point(764, 124);
            this.btnTKSach.Name = "btnTKSach";
            this.btnTKSach.Size = new System.Drawing.Size(96, 35);
            this.btnTKSach.TabIndex = 106;
            this.btnTKSach.Text = "Tìm Kiếm";
            this.btnTKSach.UseVisualStyleBackColor = true;
            this.btnTKSach.Visible = false;
            this.btnTKSach.Click += new System.EventHandler(this.btnTKSach_Click);
            // 
            // cbxTieuChiTim
            // 
            this.cbxTieuChiTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTieuChiTim.FormattingEnabled = true;
            this.cbxTieuChiTim.Location = new System.Drawing.Point(676, 81);
            this.cbxTieuChiTim.Name = "cbxTieuChiTim";
            this.cbxTieuChiTim.Size = new System.Drawing.Size(193, 27);
            this.cbxTieuChiTim.TabIndex = 104;
            this.cbxTieuChiTim.Visible = false;
            this.cbxTieuChiTim.TextChanged += new System.EventHandler(this.cbxTieuChiTim_TextChanged);
            // 
            // lbTieuChiTim
            // 
            this.lbTieuChiTim.AutoSize = true;
            this.lbTieuChiTim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuChiTim.Location = new System.Drawing.Point(544, 85);
            this.lbTieuChiTim.Name = "lbTieuChiTim";
            this.lbTieuChiTim.Size = new System.Drawing.Size(90, 19);
            this.lbTieuChiTim.TabIndex = 103;
            this.lbTieuChiTim.Text = "Tiêu chí tìm";
            this.lbTieuChiTim.Visible = false;
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaSach.FormattingEnabled = true;
            this.cbxMaSach.Location = new System.Drawing.Point(163, 14);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(292, 28);
            this.cbxMaSach.TabIndex = 102;
            this.cbxMaSach.TextChanged += new System.EventHandler(this.cbxMaSach_TextChanged);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(711, 551);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(84, 35);
            this.btnTroVe.TabIndex = 101;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.Location = new System.Drawing.Point(477, 14);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(34, 24);
            this.btnThemSach.TabIndex = 100;
            this.btnThemSach.Text = "...";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(356, 99);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(84, 35);
            this.btnNhap.TabIndex = 99;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(144, 551);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(84, 35);
            this.btnReLoad.TabIndex = 98;
            this.btnReLoad.Text = "Tải lại";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // NgonNgu
            // 
            this.NgonNgu.DataPropertyName = "NgonNgu";
            this.NgonNgu.HeaderText = "Ngôn Ngữ";
            this.NgonNgu.Name = "NgonNgu";
            this.NgonNgu.ReadOnly = true;
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            this.SoTrang.HeaderText = "Số Trang";
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "MaTacGia";
            this.TenTacGia.HeaderText = "Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "MaTheLoai";
            this.TenTheLoai.HeaderText = "Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "MaNCC";
            this.TenNCC.HeaderText = "NCC";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "MaNXB";
            this.TenNXB.HeaderText = "NXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // cbxTheLoaiDuocTim
            // 
            this.cbxTheLoaiDuocTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoaiDuocTim.FormattingEnabled = true;
            this.cbxTheLoaiDuocTim.Location = new System.Drawing.Point(676, 38);
            this.cbxTheLoaiDuocTim.Name = "cbxTheLoaiDuocTim";
            this.cbxTheLoaiDuocTim.Size = new System.Drawing.Size(193, 27);
            this.cbxTheLoaiDuocTim.TabIndex = 105;
            this.cbxTheLoaiDuocTim.Visible = false;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.TenNXB,
            this.TenNCC,
            this.TenTheLoai,
            this.TenTacGia,
            this.GiaBan,
            this.SoTrang,
            this.NgonNgu,
            this.ISBN,
            this.GiaNhap});
            this.dgvSach.Location = new System.Drawing.Point(2, 192);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.Size = new System.Drawing.Size(910, 334);
            this.dgvSach.TabIndex = 97;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(163, 99);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(148, 27);
            this.txtSoLuongNhap.TabIndex = 93;
            this.txtSoLuongNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNhap_KeyPress);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(163, 55);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(285, 27);
            this.txtTenSach.TabIndex = 94;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 19);
            this.label16.TabIndex = 95;
            this.label16.Text = "Số lượng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "Mã Sách";
            // 
            // Frm_NhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 606);
            this.Controls.Add(this.btnAnHien);
            this.Controls.Add(this.lbTimSach);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTKSach);
            this.Controls.Add(this.cbxTieuChiTim);
            this.Controls.Add(this.lbTieuChiTim);
            this.Controls.Add(this.cbxMaSach);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.cbxTheLoaiDuocTim);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.txtSoLuongNhap);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_NhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NhapSach";
            this.Load += new System.EventHandler(this.Frm_NhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnHien;
        private System.Windows.Forms.Label lbTimSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTKSach;
        private System.Windows.Forms.ComboBox cbxTieuChiTim;
        private System.Windows.Forms.Label lbTieuChiTim;
        private System.Windows.Forms.ComboBox cbxMaSach;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.ComboBox cbxTheLoaiDuocTim;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}