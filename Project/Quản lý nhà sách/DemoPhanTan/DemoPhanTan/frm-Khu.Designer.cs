namespace DemoPhanTan
{
    partial class frm_Khu
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
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttenKhu = new System.Windows.Forms.TextBox();
            this.txtmaKhu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntaiLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(828, 491);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 47;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(717, 491);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 48;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(605, 491);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(259, 491);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(147, 491);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(30, 491);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhu
            // 
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhu,
            this.TenKhu,
            this.MaNV});
            this.dgvKhu.Location = new System.Drawing.Point(12, 128);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.Size = new System.Drawing.Size(917, 334);
            this.dgvKhu.TabIndex = 46;
            this.dgvKhu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhu_CellClick);
            // 
            // MaKhu
            // 
            this.MaKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhu.DataPropertyName = "MaKhu";
            this.MaKhu.HeaderText = "Mã Khu";
            this.MaKhu.Name = "MaKhu";
            // 
            // TenKhu
            // 
            this.TenKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhu.DataPropertyName = "TenKhu";
            this.TenKhu.HeaderText = "Tên Khu";
            this.TenKhu.Name = "TenKhu";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên Phụ Trách";
            this.MaNV.Name = "MaNV";
            // 
            // txttenKhu
            // 
            this.txttenKhu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenKhu.Enabled = false;
            this.txttenKhu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenKhu.Location = new System.Drawing.Point(414, 80);
            this.txttenKhu.Name = "txttenKhu";
            this.txttenKhu.Size = new System.Drawing.Size(164, 27);
            this.txttenKhu.TabIndex = 55;
            // 
            // txtmaKhu
            // 
            this.txtmaKhu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaKhu.Enabled = false;
            this.txtmaKhu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaKhu.Location = new System.Drawing.Point(144, 80);
            this.txtmaKhu.Name = "txtmaKhu";
            this.txtmaKhu.Size = new System.Drawing.Size(149, 27);
            this.txtmaKhu.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên Khu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã Khu";
            // 
            // btntaiLai
            // 
            this.btntaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaiLai.Location = new System.Drawing.Point(414, 491);
            this.btntaiLai.Name = "btntaiLai";
            this.btntaiLai.Size = new System.Drawing.Size(67, 35);
            this.btntaiLai.TabIndex = 57;
            this.btntaiLai.Text = "Tải Lại";
            this.btntaiLai.UseVisualStyleBackColor = true;
            this.btntaiLai.Click += new System.EventHandler(this.btntaiLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tên Nhân Viên";
            // 
            // cbxTenNhanVien
            // 
            this.cbxTenNhanVien.Enabled = false;
            this.cbxTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenNhanVien.FormattingEnabled = true;
            this.cbxTenNhanVien.Location = new System.Drawing.Point(750, 79);
            this.cbxTenNhanVien.Name = "cbxTenNhanVien";
            this.cbxTenNhanVien.Size = new System.Drawing.Size(179, 28);
            this.cbxTenNhanVien.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "Quản Lý Khu Để Sách";
            // 
            // frm_Khu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTenNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntaiLai);
            this.Controls.Add(this.txttenKhu);
            this.Controls.Add(this.txtmaKhu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvKhu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Khu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Khu";
            this.Load += new System.EventHandler(this.frm_Khu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.TextBox txttenKhu;
        private System.Windows.Forms.TextBox txtmaKhu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntaiLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
    }
}