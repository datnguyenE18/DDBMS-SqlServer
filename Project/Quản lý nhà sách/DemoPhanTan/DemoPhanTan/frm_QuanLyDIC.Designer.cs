namespace DemoPhanTan
{
    partial class frm_QuanLyDIC
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnQLTK = new System.Windows.Forms.Panel();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiNhanh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnQLTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Data Dictionary";
            // 
            // pnQLTK
            // 
            this.pnQLTK.Controls.Add(this.btnTaiLai);
            this.pnQLTK.Controls.Add(this.dgvTaiKhoan);
            this.pnQLTK.Controls.Add(this.btnHuy);
            this.pnQLTK.Controls.Add(this.btnLuu);
            this.pnQLTK.Controls.Add(this.btnXoa);
            this.pnQLTK.Controls.Add(this.btnSua);
            this.pnQLTK.Controls.Add(this.btnThem);
            this.pnQLTK.Controls.Add(this.cbbQuyen);
            this.pnQLTK.Controls.Add(this.label6);
            this.pnQLTK.Controls.Add(this.cbbSite);
            this.pnQLTK.Controls.Add(this.label5);
            this.pnQLTK.Controls.Add(this.label4);
            this.pnQLTK.Controls.Add(this.label3);
            this.pnQLTK.Controls.Add(this.txtMatKhau);
            this.pnQLTK.Controls.Add(this.txtTenDN);
            this.pnQLTK.Controls.Add(this.label2);
            this.pnQLTK.Location = new System.Drawing.Point(12, 69);
            this.pnQLTK.Name = "pnQLTK";
            this.pnQLTK.Size = new System.Drawing.Size(747, 284);
            this.pnQLTK.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(39, 252);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(97, 23);
            this.btnTaiLai.TabIndex = 17;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoan,
            this.MatKhau,
            this.Quyen,
            this.ChiNhanh});
            this.dgvTaiKhoan.Location = new System.Drawing.Point(315, 52);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(429, 229);
            this.dgvTaiKhoan.TabIndex = 16;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellValidated);
            this.dgvTaiKhoan.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTaiKhoan_CellValidating);
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // Quyen
            // 
            this.Quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            // 
            // ChiNhanh
            // 
            this.ChiNhanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChiNhanh.DataPropertyName = "MaSite";
            this.ChiNhanh.HeaderText = "Chi Nhánh";
            this.ChiNhanh.Name = "ChiNhanh";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(166, 192);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 23);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(166, 163);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 23);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(166, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 223);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(39, 223);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.Enabled = false;
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(166, 136);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbbQuyen.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Site";
            // 
            // cbbSite
            // 
            this.cbbSite.Enabled = false;
            this.cbbSite.FormattingEnabled = true;
            this.cbbSite.Location = new System.Drawing.Point(166, 105);
            this.cbbSite.Name = "cbbSite";
            this.cbbSite.Size = new System.Drawing.Size(121, 21);
            this.cbbSite.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Location = new System.Drawing.Point(166, 78);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(121, 20);
            this.txtMatKhau.TabIndex = 3;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Enabled = false;
            this.txtTenDN.Location = new System.Drawing.Point(166, 52);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(121, 20);
            this.txtTenDN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // frm_QuanLyDIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 365);
            this.Controls.Add(this.pnQLTK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_QuanLyDIC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyDIC";
            this.Load += new System.EventHandler(this.frm_QuanLyDIC_Load);
            this.pnQLTK.ResumeLayout(false);
            this.pnQLTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnQLTK;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewComboBoxColumn ChiNhanh;
        private System.Windows.Forms.Button btnTaiLai;
    }
}