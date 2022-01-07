namespace DemoPhanTan
{
    partial class frm_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChiNhanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.lbLuong = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.btnAnHien = new System.Windows.Forms.Button();
            this.lbTimNhanVien = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimNhanVien = new System.Windows.Forms.Button();
            this.cbxTieuChiTim = new System.Windows.Forms.ComboBox();
            this.cbxChucVuDuocTim = new System.Windows.Forms.ComboBox();
            this.lbTieuChiTim = new System.Windows.Forms.Label();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCaTruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(603, 634);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 35);
            this.btnLoad.TabIndex = 41;
            this.btnLoad.Text = "Tải Lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.Location = new System.Drawing.Point(734, 634);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(90, 35);
            this.btnChuyen.TabIndex = 42;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(863, 634);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 43;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(492, 634);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 44;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(380, 634);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(263, 634);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(151, 634);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(34, 634);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaChiNhanh,
            this.MaChucVu,
            this.NgayVaoLam,
            this.Luong,
            this.SDT,
            this.DiaChi,
            this.QueQuan,
            this.SoCaTruc});
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 329);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(941, 282);
            this.dgvNhanVien.TabIndex = 40;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(624, 123);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(202, 27);
            this.txtDiaChi.TabIndex = 57;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(203, 71);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(195, 27);
            this.txtTenNV.TabIndex = 52;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(624, 73);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(201, 27);
            this.txtSoDT.TabIndex = 60;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(203, 26);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(195, 27);
            this.txtMaNV.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Chi nhánh";
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiNhanh.Enabled = false;
            this.txtChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiNhanh.Location = new System.Drawing.Point(203, 119);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(195, 27);
            this.txtChiNhanh.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Chức vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ngày vào làm";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayVaoLam.Enabled = false;
            this.dtpNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(203, 223);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(193, 27);
            this.dtpNgayVaoLam.TabIndex = 59;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuong.Location = new System.Drawing.Point(488, 29);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(53, 19);
            this.lbLuong.TabIndex = 50;
            this.lbLuong.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuong.Enabled = false;
            this.txtLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(624, 28);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(201, 27);
            this.txtLuong.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.Enabled = false;
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(624, 172);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(202, 27);
            this.txtQueQuan.TabIndex = 57;
            // 
            // btnAnHien
            // 
            this.btnAnHien.Location = new System.Drawing.Point(494, 205);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(36, 23);
            this.btnAnHien.TabIndex = 90;
            this.btnAnHien.Text = "↓";
            this.btnAnHien.UseVisualStyleBackColor = true;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            // 
            // lbTimNhanVien
            // 
            this.lbTimNhanVien.AutoSize = true;
            this.lbTimNhanVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimNhanVien.Location = new System.Drawing.Point(490, 236);
            this.lbTimNhanVien.Name = "lbTimNhanVien";
            this.lbTimNhanVien.Size = new System.Drawing.Size(63, 19);
            this.lbTimNhanVien.TabIndex = 89;
            this.lbTimNhanVien.Text = "Tìm NV";
            this.lbTimNhanVien.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(624, 228);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(202, 27);
            this.txtTimKiem.TabIndex = 88;
            this.txtTimKiem.Visible = false;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // btnTimNhanVien
            // 
            this.btnTimNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNhanVien.Location = new System.Drawing.Point(850, 249);
            this.btnTimNhanVien.Name = "btnTimNhanVien";
            this.btnTimNhanVien.Size = new System.Drawing.Size(96, 35);
            this.btnTimNhanVien.TabIndex = 87;
            this.btnTimNhanVien.Text = "Tìm Kiếm";
            this.btnTimNhanVien.UseVisualStyleBackColor = true;
            this.btnTimNhanVien.Visible = false;
            this.btnTimNhanVien.Click += new System.EventHandler(this.btnTimNhanVien_Click);
            // 
            // cbxTieuChiTim
            // 
            this.cbxTieuChiTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTieuChiTim.FormattingEnabled = true;
            this.cbxTieuChiTim.Location = new System.Drawing.Point(624, 272);
            this.cbxTieuChiTim.Name = "cbxTieuChiTim";
            this.cbxTieuChiTim.Size = new System.Drawing.Size(202, 27);
            this.cbxTieuChiTim.TabIndex = 85;
            this.cbxTieuChiTim.Visible = false;
            this.cbxTieuChiTim.TextChanged += new System.EventHandler(this.cbxTieuChiTim_TextChanged);
            // 
            // cbxChucVuDuocTim
            // 
            this.cbxChucVuDuocTim.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChucVuDuocTim.FormattingEnabled = true;
            this.cbxChucVuDuocTim.Location = new System.Drawing.Point(624, 228);
            this.cbxChucVuDuocTim.Name = "cbxChucVuDuocTim";
            this.cbxChucVuDuocTim.Size = new System.Drawing.Size(201, 27);
            this.cbxChucVuDuocTim.TabIndex = 86;
            this.cbxChucVuDuocTim.Visible = false;
            // 
            // lbTieuChiTim
            // 
            this.lbTieuChiTim.AutoSize = true;
            this.lbTieuChiTim.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuChiTim.Location = new System.Drawing.Point(488, 275);
            this.lbTieuChiTim.Name = "lbTieuChiTim";
            this.lbTieuChiTim.Size = new System.Drawing.Size(90, 19);
            this.lbTieuChiTim.TabIndex = 84;
            this.lbTieuChiTim.Text = "Tiêu chí tìm";
            this.lbTieuChiTim.Visible = false;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Enabled = false;
            this.cbxChucVu.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(203, 167);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(193, 27);
            this.cbxChucVu.TabIndex = 85;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.Enabled = false;
            this.cbxChiNhanh.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(203, 119);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(195, 27);
            this.cbxChiNhanh.TabIndex = 91;
            this.cbxChiNhanh.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.FillWeight = 200F;
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaChiNhanh
            // 
            this.MaChiNhanh.DataPropertyName = "MaChiNhanh";
            this.MaChiNhanh.HeaderText = "Chi nhánh";
            this.MaChiNhanh.Name = "MaChiNhanh";
            this.MaChiNhanh.ReadOnly = true;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Chức vụ";
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "TGianVaoLam";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.NgayVaoLam.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Luong.DefaultCellStyle = dataGridViewCellStyle2;
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê quán ";
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.ReadOnly = true;
            // 
            // SoCaTruc
            // 
            this.SoCaTruc.DataPropertyName = "SoCaTruc";
            this.SoCaTruc.HeaderText = "Số ca trực";
            this.SoCaTruc.Name = "SoCaTruc";
            this.SoCaTruc.ReadOnly = true;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 684);
            this.Controls.Add(this.cbxChiNhanh);
            this.Controls.Add(this.btnAnHien);
            this.Controls.Add(this.lbTimNhanVien);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimNhanVien);
            this.Controls.Add(this.cbxChucVu);
            this.Controls.Add(this.cbxTieuChiTim);
            this.Controls.Add(this.cbxChucVuDuocTim);
            this.Controls.Add(this.lbTieuChiTim);
            this.Controls.Add(this.dtpNgayVaoLam);
            this.Controls.Add(this.txtChiNhanh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiNhanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Button btnAnHien;
        private System.Windows.Forms.Label lbTimNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimNhanVien;
        private System.Windows.Forms.ComboBox cbxTieuChiTim;
        private System.Windows.Forms.ComboBox cbxChucVuDuocTim;
        private System.Windows.Forms.Label lbTieuChiTim;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCaTruc;
    }
}