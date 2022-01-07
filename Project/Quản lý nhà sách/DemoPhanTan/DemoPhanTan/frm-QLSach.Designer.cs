namespace DemoPhanTan
{
    partial class frm_QLSach
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
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
            this.lbTimSach = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTKSach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.lbTieuChiTim = new System.Windows.Forms.Label();
            this.cbxTieuChiTim = new System.Windows.Forms.ComboBox();
            this.cbxTheLoaiDuocTim = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbxNhaCC = new System.Windows.Forms.ComboBox();
            this.cbxNXB = new System.Windows.Forms.ComboBox();
            this.cbxTacGia = new System.Windows.Forms.ComboBox();
            this.cbxKhu = new System.Windows.Forms.ComboBox();
            this.cbxKe = new System.Windows.Forms.ComboBox();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.btnThemTacGia = new System.Windows.Forms.Button();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.btnThemKe = new System.Windows.Forms.Button();
            this.btnAnHien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(830, 650);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 57;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(556, 650);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(427, 650);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 59;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(294, 650);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 60;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(168, 650);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(53, 650);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.dgvSach.Location = new System.Drawing.Point(23, 357);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.Size = new System.Drawing.Size(910, 282);
            this.dgvSach.TabIndex = 56;
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
            // lbTimSach
            // 
            this.lbTimSach.AutoSize = true;
            this.lbTimSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimSach.Location = new System.Drawing.Point(469, 283);
            this.lbTimSach.Name = "lbTimSach";
            this.lbTimSach.Size = new System.Drawing.Size(70, 19);
            this.lbTimSach.TabIndex = 82;
            this.lbTimSach.Text = "Tìm sách";
            this.lbTimSach.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(601, 279);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(193, 27);
            this.txtTimKiem.TabIndex = 81;
            this.txtTimKiem.Visible = false;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // btnTKSach
            // 
            this.btnTKSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSach.Location = new System.Drawing.Point(827, 299);
            this.btnTKSach.Name = "btnTKSach";
            this.btnTKSach.Size = new System.Drawing.Size(96, 35);
            this.btnTKSach.TabIndex = 80;
            this.btnTKSach.Text = "Tìm Kiếm";
            this.btnTKSach.UseVisualStyleBackColor = true;
            this.btnTKSach.Visible = false;
            this.btnTKSach.Click += new System.EventHandler(this.btnTKSach_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "Kệ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Khu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tác Giả";
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.Enabled = false;
            this.cbxTheLoai.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(182, 215);
            this.cbxTheLoai.Name = "cbxTheLoai";
            this.cbxTheLoai.Size = new System.Drawing.Size(193, 27);
            this.cbxTheLoai.TabIndex = 71;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(181, 58);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(196, 27);
            this.txtTenSach.TabIndex = 68;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(181, 19);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(196, 27);
            this.txtMaSach.TabIndex = 66;
            this.txtMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSach_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Thể Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "Số trang";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTrang.Enabled = false;
            this.txtSoTrang.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(598, 22);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(196, 27);
            this.txtSoTrang.TabIndex = 76;
            this.txtSoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTrang_KeyPress);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Location = new System.Drawing.Point(692, 650);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(84, 35);
            this.btnReLoad.TabIndex = 60;
            this.btnReLoad.Text = "Tải lại";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "NXB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "Nhà cung cấp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(179, 302);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(196, 27);
            this.txtGiaBan.TabIndex = 72;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(466, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 77;
            this.label12.Text = "Ngôn ngữ";
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgonNgu.Enabled = false;
            this.txtNgonNgu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgonNgu.Location = new System.Drawing.Point(598, 63);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(196, 27);
            this.txtNgonNgu.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(466, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "ISBN ";
            // 
            // txtISBN
            // 
            this.txtISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtISBN.Enabled = false;
            this.txtISBN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(598, 103);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(196, 27);
            this.txtISBN.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 77;
            this.label14.Text = "Giá Nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaNhap.Enabled = false;
            this.txtGiaNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(598, 141);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(196, 27);
            this.txtGiaNhap.TabIndex = 76;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // lbTieuChiTim
            // 
            this.lbTieuChiTim.AutoSize = true;
            this.lbTieuChiTim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuChiTim.Location = new System.Drawing.Point(469, 326);
            this.lbTieuChiTim.Name = "lbTieuChiTim";
            this.lbTieuChiTim.Size = new System.Drawing.Size(90, 19);
            this.lbTieuChiTim.TabIndex = 69;
            this.lbTieuChiTim.Text = "Tiêu chí tìm";
            this.lbTieuChiTim.Visible = false;
            // 
            // cbxTieuChiTim
            // 
            this.cbxTieuChiTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTieuChiTim.FormattingEnabled = true;
            this.cbxTieuChiTim.Location = new System.Drawing.Point(601, 322);
            this.cbxTieuChiTim.Name = "cbxTieuChiTim";
            this.cbxTieuChiTim.Size = new System.Drawing.Size(193, 27);
            this.cbxTieuChiTim.TabIndex = 71;
            this.cbxTieuChiTim.Visible = false;
            this.cbxTieuChiTim.TextChanged += new System.EventHandler(this.cbxTieuChiTim_TextChanged);
            // 
            // cbxTheLoaiDuocTim
            // 
            this.cbxTheLoaiDuocTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTheLoaiDuocTim.FormattingEnabled = true;
            this.cbxTheLoaiDuocTim.Location = new System.Drawing.Point(601, 279);
            this.cbxTheLoaiDuocTim.Name = "cbxTheLoaiDuocTim";
            this.cbxTheLoaiDuocTim.Size = new System.Drawing.Size(193, 27);
            this.cbxTheLoaiDuocTim.TabIndex = 71;
            this.cbxTheLoaiDuocTim.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 19);
            this.label16.TabIndex = 70;
            this.label16.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(182, 96);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(196, 27);
            this.txtSoLuong.TabIndex = 68;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cbxNhaCC
            // 
            this.cbxNhaCC.Enabled = false;
            this.cbxNhaCC.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNhaCC.FormattingEnabled = true;
            this.cbxNhaCC.Location = new System.Drawing.Point(181, 173);
            this.cbxNhaCC.Name = "cbxNhaCC";
            this.cbxNhaCC.Size = new System.Drawing.Size(193, 27);
            this.cbxNhaCC.TabIndex = 71;
            // 
            // cbxNXB
            // 
            this.cbxNXB.Enabled = false;
            this.cbxNXB.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNXB.FormattingEnabled = true;
            this.cbxNXB.Location = new System.Drawing.Point(181, 137);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Size = new System.Drawing.Size(193, 27);
            this.cbxNXB.TabIndex = 71;
            // 
            // cbxTacGia
            // 
            this.cbxTacGia.Enabled = false;
            this.cbxTacGia.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTacGia.FormattingEnabled = true;
            this.cbxTacGia.Location = new System.Drawing.Point(179, 258);
            this.cbxTacGia.Name = "cbxTacGia";
            this.cbxTacGia.Size = new System.Drawing.Size(193, 27);
            this.cbxTacGia.TabIndex = 71;
            // 
            // cbxKhu
            // 
            this.cbxKhu.Enabled = false;
            this.cbxKhu.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhu.FormattingEnabled = true;
            this.cbxKhu.Location = new System.Drawing.Point(601, 178);
            this.cbxKhu.Name = "cbxKhu";
            this.cbxKhu.Size = new System.Drawing.Size(193, 27);
            this.cbxKhu.TabIndex = 71;
            // 
            // cbxKe
            // 
            this.cbxKe.Enabled = false;
            this.cbxKe.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKe.FormattingEnabled = true;
            this.cbxKe.Location = new System.Drawing.Point(598, 219);
            this.cbxKe.Name = "cbxKe";
            this.cbxKe.Size = new System.Drawing.Size(193, 27);
            this.cbxKe.TabIndex = 71;
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(385, 141);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(36, 23);
            this.btnThemNXB.TabIndex = 83;
            this.btnThemNXB.Text = "...";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(385, 180);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(36, 23);
            this.btnThemNCC.TabIndex = 83;
            this.btnThemNCC.Text = "...";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(385, 217);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(36, 23);
            this.btnThemTheLoai.TabIndex = 83;
            this.btnThemTheLoai.Text = "...";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            // 
            // btnThemTacGia
            // 
            this.btnThemTacGia.Location = new System.Drawing.Point(385, 257);
            this.btnThemTacGia.Name = "btnThemTacGia";
            this.btnThemTacGia.Size = new System.Drawing.Size(36, 23);
            this.btnThemTacGia.TabIndex = 83;
            this.btnThemTacGia.Text = "...";
            this.btnThemTacGia.UseVisualStyleBackColor = true;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(824, 180);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(36, 23);
            this.btnThemKhu.TabIndex = 83;
            this.btnThemKhu.Text = "...";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            // 
            // btnThemKe
            // 
            this.btnThemKe.Location = new System.Drawing.Point(824, 218);
            this.btnThemKe.Name = "btnThemKe";
            this.btnThemKe.Size = new System.Drawing.Size(36, 23);
            this.btnThemKe.TabIndex = 83;
            this.btnThemKe.Text = "...";
            this.btnThemKe.UseVisualStyleBackColor = true;
            // 
            // btnAnHien
            // 
            this.btnAnHien.Location = new System.Drawing.Point(471, 255);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(36, 23);
            this.btnAnHien.TabIndex = 83;
            this.btnAnHien.Text = "↓";
            this.btnAnHien.UseVisualStyleBackColor = true;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            // 
            // frm_QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 693);
            this.Controls.Add(this.btnAnHien);
            this.Controls.Add(this.btnThemKe);
            this.Controls.Add(this.btnThemKhu);
            this.Controls.Add(this.btnThemTacGia);
            this.Controls.Add(this.btnThemTheLoai);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnThemNXB);
            this.Controls.Add(this.lbTimSach);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTKSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtNgonNgu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTieuChiTim);
            this.Controls.Add(this.cbxTheLoaiDuocTim);
            this.Controls.Add(this.cbxNXB);
            this.Controls.Add(this.cbxKe);
            this.Controls.Add(this.cbxKhu);
            this.Controls.Add(this.cbxNhaCC);
            this.Controls.Add(this.cbxTacGia);
            this.Controls.Add(this.cbxTheLoai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lbTieuChiTim);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_QLSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QLSach";
            this.Load += new System.EventHandler(this.frm_QLSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label lbTimSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTKSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lbTieuChiTim;
        private System.Windows.Forms.ComboBox cbxTieuChiTim;
        private System.Windows.Forms.ComboBox cbxTheLoaiDuocTim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxNhaCC;
        private System.Windows.Forms.ComboBox cbxNXB;
        private System.Windows.Forms.ComboBox cbxTacGia;
        private System.Windows.Forms.ComboBox cbxKhu;
        private System.Windows.Forms.ComboBox cbxKe;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.Button btnThemKe;
        private System.Windows.Forms.Button btnAnHien;
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
    }
}