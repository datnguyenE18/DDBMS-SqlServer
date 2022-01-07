namespace DemoPhanTan
{
    partial class frm_NXB
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
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNguoiChuQuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(831, 505);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 37;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(729, 505);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(618, 505);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(273, 505);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(166, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(53, 505);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNXB
            // 
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChiNXB,
            this.SDTNXB,
            this.NguoiTiepNhan});
            this.dgvNXB.Location = new System.Drawing.Point(21, 150);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(927, 333);
            this.dgvNXB.TabIndex = 36;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(472, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(162, 27);
            this.txtDiaChi.TabIndex = 49;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNXB.Enabled = false;
            this.txtTenNXB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(179, 103);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(140, 27);
            this.txtTenNXB.TabIndex = 46;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDT.Enabled = false;
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(472, 106);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(162, 27);
            this.txtSoDT.TabIndex = 50;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNXB.Enabled = false;
            this.txtMaNXB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(178, 60);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(140, 27);
            this.txtMaNXB.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 44;
            this.label6.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên Nhà Xuất Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Nhà Xuất Bản";
            // 
            // txtNguoiChuQuan
            // 
            this.txtNguoiChuQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNguoiChuQuan.Enabled = false;
            this.txtNguoiChuQuan.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiChuQuan.Location = new System.Drawing.Point(781, 85);
            this.txtNguoiChuQuan.Name = "txtNguoiChuQuan";
            this.txtNguoiChuQuan.Size = new System.Drawing.Size(155, 27);
            this.txtNguoiChuQuan.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Người Chủ Quản";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(426, 505);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 35);
            this.btnTaiLai.TabIndex = 53;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 31);
            this.label4.TabIndex = 54;
            this.label4.Text = "Quản Lý Nhà Xuất Bản";
            // 
            // MaNXB
            // 
            this.MaNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            // 
            // TenNXB
            // 
            this.TenNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.Name = "TenNXB";
            // 
            // DiaChiNXB
            // 
            this.DiaChiNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChiNXB.DataPropertyName = "DiaChiNXB";
            this.DiaChiNXB.HeaderText = "Địa Chỉ NXB";
            this.DiaChiNXB.Name = "DiaChiNXB";
            // 
            // SDTNXB
            // 
            this.SDTNXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTNXB.DataPropertyName = "SDTNXB";
            this.SDTNXB.HeaderText = "SDT NXB";
            this.SDTNXB.Name = "SDTNXB";
            // 
            // NguoiTiepNhan
            // 
            this.NguoiTiepNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguoiTiepNhan.DataPropertyName = "NguoiTiepNhan";
            this.NguoiTiepNhan.HeaderText = "Người Tiếp";
            this.NguoiTiepNhan.Name = "NguoiTiepNhan";
            // 
            // frm_NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.txtNguoiChuQuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNXB);
            this.Name = "frm_NXB";
            this.Text = "frm_NXB";
            this.Load += new System.EventHandler(this.frm_NXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNguoiChuQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTiepNhan;
    }
}