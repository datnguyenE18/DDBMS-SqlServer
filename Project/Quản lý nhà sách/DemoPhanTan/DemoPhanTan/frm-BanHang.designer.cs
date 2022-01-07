namespace DemoPhanTan
{
    partial class frm_BanHang
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgonNgu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnHien = new System.Windows.Forms.Button();
            this.lbTimSach = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTKSach = new System.Windows.Forms.Button();
            this.cbxTieuChiTim = new System.Windows.Forms.ComboBox();
            this.cbxTheLoaiDuocTim = new System.Windows.Forms.ComboBox();
            this.lbTieuChiTim = new System.Windows.Forms.Label();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnMua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.lbSoLuongBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKe = new System.Windows.Forms.TextBox();
            this.Khu = new System.Windows.Forms.Label();
            this.txtKhu = new System.Windows.Forms.TextBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.MaSachGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoaiGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGiaGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBanGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnBoKhoiGio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
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
            this.dgvSach.Location = new System.Drawing.Point(12, 299);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.Size = new System.Drawing.Size(904, 282);
            this.dgvSach.TabIndex = 57;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "MaNXB";
            this.TenNXB.HeaderText = "NXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "MaNCC";
            this.TenNCC.HeaderText = "NCC";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "MaTheLoai";
            this.TenTheLoai.HeaderText = "Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            this.TenTheLoai.ReadOnly = true;
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "MaTacGia";
            this.TenTacGia.HeaderText = "Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // SoTrang
            // 
            this.SoTrang.DataPropertyName = "SoTrang";
            this.SoTrang.HeaderText = "Số Trang";
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.ReadOnly = true;
            // 
            // NgonNgu
            // 
            this.NgonNgu.DataPropertyName = "NgonNgu";
            this.NgonNgu.HeaderText = "Ngôn Ngữ";
            this.NgonNgu.Name = "NgonNgu";
            this.NgonNgu.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Tác Giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "Thể Loại";
            // 
            // btnAnHien
            // 
            this.btnAnHien.Location = new System.Drawing.Point(444, 164);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(36, 23);
            this.btnAnHien.TabIndex = 111;
            this.btnAnHien.Text = "↓";
            this.btnAnHien.UseVisualStyleBackColor = true;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            // 
            // lbTimSach
            // 
            this.lbTimSach.AutoSize = true;
            this.lbTimSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimSach.Location = new System.Drawing.Point(443, 199);
            this.lbTimSach.Name = "lbTimSach";
            this.lbTimSach.Size = new System.Drawing.Size(70, 19);
            this.lbTimSach.TabIndex = 110;
            this.lbTimSach.Text = "Tìm sách";
            this.lbTimSach.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(575, 191);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(196, 27);
            this.txtTimKiem.TabIndex = 109;
            this.txtTimKiem.Visible = false;
            // 
            // btnTKSach
            // 
            this.btnTKSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSach.Location = new System.Drawing.Point(802, 205);
            this.btnTKSach.Name = "btnTKSach";
            this.btnTKSach.Size = new System.Drawing.Size(96, 35);
            this.btnTKSach.TabIndex = 108;
            this.btnTKSach.Text = "Tìm Kiếm";
            this.btnTKSach.UseVisualStyleBackColor = true;
            this.btnTKSach.Visible = false;
            this.btnTKSach.Click += new System.EventHandler(this.btnTKSach_Click);
            // 
            // cbxTieuChiTim
            // 
            this.cbxTieuChiTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTieuChiTim.FormattingEnabled = true;
            this.cbxTieuChiTim.Location = new System.Drawing.Point(575, 227);
            this.cbxTieuChiTim.Name = "cbxTieuChiTim";
            this.cbxTieuChiTim.Size = new System.Drawing.Size(196, 27);
            this.cbxTieuChiTim.TabIndex = 106;
            this.cbxTieuChiTim.Visible = false;
            this.cbxTieuChiTim.TextChanged += new System.EventHandler(this.cbxTieuChiTim_TextChanged);
            // 
            // cbxTheLoaiDuocTim
            // 
            this.cbxTheLoaiDuocTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoaiDuocTim.FormattingEnabled = true;
            this.cbxTheLoaiDuocTim.Location = new System.Drawing.Point(578, 191);
            this.cbxTheLoaiDuocTim.Name = "cbxTheLoaiDuocTim";
            this.cbxTheLoaiDuocTim.Size = new System.Drawing.Size(193, 27);
            this.cbxTheLoaiDuocTim.TabIndex = 107;
            this.cbxTheLoaiDuocTim.Visible = false;
            // 
            // lbTieuChiTim
            // 
            this.lbTieuChiTim.AutoSize = true;
            this.lbTieuChiTim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuChiTim.Location = new System.Drawing.Point(443, 229);
            this.lbTieuChiTim.Name = "lbTieuChiTim";
            this.lbTieuChiTim.Size = new System.Drawing.Size(90, 19);
            this.lbTieuChiTim.TabIndex = 105;
            this.lbTieuChiTim.Text = "Tiêu chí tìm";
            this.lbTieuChiTim.Visible = false;
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgonNgu.Enabled = false;
            this.txtNgonNgu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgonNgu.Location = new System.Drawing.Point(575, 135);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(196, 27);
            this.txtNgonNgu.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(443, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 103;
            this.label12.Text = "Ngôn ngữ";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTrang.Enabled = false;
            this.txtSoTrang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(575, 14);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(196, 27);
            this.txtSoTrang.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 104;
            this.label4.Text = "Số trang";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacGia.Enabled = false;
            this.txtTacGia.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(157, 137);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(196, 27);
            this.txtTacGia.TabIndex = 99;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(157, 55);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(196, 27);
            this.txtTenSach.TabIndex = 98;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTheLoai.Enabled = false;
            this.txtTheLoai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(157, 96);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(196, 27);
            this.txtTheLoai.TabIndex = 96;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(157, 18);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(196, 27);
            this.txtMaSach.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "Mã Sách";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(302, 630);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(96, 35);
            this.btnTaiLai.TabIndex = 108;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnMua
            // 
            this.btnMua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.Location = new System.Drawing.Point(436, 630);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(96, 35);
            this.btnMua.TabIndex = 108;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(744, 630);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 35);
            this.btnThoat.TabIndex = 108;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuongMua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongMua.Location = new System.Drawing.Point(401, 589);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(131, 27);
            this.txtSoLuongMua.TabIndex = 99;
            this.txtSoLuongMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongBan_KeyPress);
            // 
            // lbSoLuongBan
            // 
            this.lbSoLuongBan.AutoSize = true;
            this.lbSoLuongBan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuongBan.Location = new System.Drawing.Point(298, 591);
            this.lbSoLuongBan.Name = "lbSoLuongBan";
            this.lbSoLuongBan.Size = new System.Drawing.Size(102, 19);
            this.lbSoLuongBan.TabIndex = 113;
            this.lbSoLuongBan.Text = "Số lượng mua";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(157, 178);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(196, 27);
            this.txtGiaBan.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 113;
            this.label7.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 104;
            this.label8.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(157, 220);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(196, 27);
            this.txtSoLuong.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(443, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 104;
            this.label9.Text = "Kệ";
            // 
            // txtKe
            // 
            this.txtKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKe.Enabled = false;
            this.txtKe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKe.Location = new System.Drawing.Point(575, 98);
            this.txtKe.Name = "txtKe";
            this.txtKe.Size = new System.Drawing.Size(196, 27);
            this.txtKe.TabIndex = 102;
            // 
            // Khu
            // 
            this.Khu.AutoSize = true;
            this.Khu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khu.Location = new System.Drawing.Point(443, 62);
            this.Khu.Name = "Khu";
            this.Khu.Size = new System.Drawing.Size(37, 19);
            this.Khu.TabIndex = 104;
            this.Khu.Text = "Khu";
            // 
            // txtKhu
            // 
            this.txtKhu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhu.Enabled = false;
            this.txtKhu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhu.Location = new System.Drawing.Point(575, 58);
            this.txtKhu.Name = "txtKhu";
            this.txtKhu.Size = new System.Drawing.Size(196, 27);
            this.txtKhu.TabIndex = 102;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSachGio,
            this.TenSachGio,
            this.SoLuongMua,
            this.TheLoaiGio,
            this.TacGiaGio,
            this.GiaBanGio,
            this.TrangThai});
            this.dgvGioHang.Location = new System.Drawing.Point(12, 299);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.Size = new System.Drawing.Size(904, 282);
            this.dgvGioHang.TabIndex = 114;
            this.dgvGioHang.Visible = false;
            // 
            // MaSachGio
            // 
            this.MaSachGio.DataPropertyName = "MaSach";
            this.MaSachGio.HeaderText = "Mã Sách";
            this.MaSachGio.Name = "MaSachGio";
            this.MaSachGio.ReadOnly = true;
            // 
            // TenSachGio
            // 
            this.TenSachGio.DataPropertyName = "TenSach";
            this.TenSachGio.HeaderText = "Tên Sách";
            this.TenSachGio.Name = "TenSachGio";
            this.TenSachGio.ReadOnly = true;
            // 
            // SoLuongMua
            // 
            this.SoLuongMua.DataPropertyName = "SoLuong";
            this.SoLuongMua.HeaderText = "Số Lượng Mua";
            this.SoLuongMua.Name = "SoLuongMua";
            this.SoLuongMua.ReadOnly = true;
            // 
            // TheLoaiGio
            // 
            this.TheLoaiGio.DataPropertyName = "MaTheLoai";
            this.TheLoaiGio.HeaderText = "Thể Loại";
            this.TheLoaiGio.Name = "TheLoaiGio";
            this.TheLoaiGio.ReadOnly = true;
            // 
            // TacGiaGio
            // 
            this.TacGiaGio.DataPropertyName = "MaTacGia";
            this.TacGiaGio.HeaderText = "Tác Giả";
            this.TacGiaGio.Name = "TacGiaGio";
            this.TacGiaGio.ReadOnly = true;
            // 
            // GiaBanGio
            // 
            this.GiaBanGio.DataPropertyName = "GiaBan";
            this.GiaBanGio.HeaderText = "Giá Bán";
            this.GiaBanGio.Name = "GiaBanGio";
            this.GiaBanGio.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnGioHang
            // 
            this.btnGioHang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(33, 265);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(73, 23);
            this.btnGioHang.TabIndex = 111;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.UseVisualStyleBackColor = true;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(227, 261);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(182, 27);
            this.txtTenNV.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 104;
            this.label6.Text = "Nhân viên";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(172, 630);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 35);
            this.btnHuy.TabIndex = 108;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnBoKhoiGio
            // 
            this.btnBoKhoiGio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoKhoiGio.Location = new System.Drawing.Point(12, 630);
            this.btnBoKhoiGio.Name = "btnBoKhoiGio";
            this.btnBoKhoiGio.Size = new System.Drawing.Size(117, 35);
            this.btnBoKhoiGio.TabIndex = 108;
            this.btnBoKhoiGio.Text = "Bỏ khỏi giỏ";
            this.btnBoKhoiGio.UseVisualStyleBackColor = true;
            this.btnBoKhoiGio.Visible = false;
            this.btnBoKhoiGio.Click += new System.EventHandler(this.btnBoKhoiGio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(443, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 104;
            this.label10.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(575, 266);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(196, 27);
            this.txtTongTien.TabIndex = 102;
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 677);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.lbSoLuongBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.btnAnHien);
            this.Controls.Add(this.lbTimSach);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.btnBoKhoiGio);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnTKSach);
            this.Controls.Add(this.cbxTieuChiTim);
            this.Controls.Add(this.cbxTheLoaiDuocTim);
            this.Controls.Add(this.lbTieuChiTim);
            this.Controls.Add(this.txtNgonNgu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtKhu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.Khu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuongMua);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BanHang";
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgonNgu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnHien;
        private System.Windows.Forms.Label lbTimSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTKSach;
        private System.Windows.Forms.ComboBox cbxTieuChiTim;
        private System.Windows.Forms.ComboBox cbxTheLoaiDuocTim;
        private System.Windows.Forms.Label lbTieuChiTim;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Label lbSoLuongBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKe;
        private System.Windows.Forms.Label Khu;
        private System.Windows.Forms.TextBox txtKhu;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnBoKhoiGio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSachGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoaiGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGiaGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBanGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}