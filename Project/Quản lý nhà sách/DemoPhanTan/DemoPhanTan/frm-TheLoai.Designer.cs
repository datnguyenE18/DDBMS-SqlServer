namespace DemoPhanTan
{
    partial class frm_TheLoai
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
            this.dgvTL = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxKe = new System.Windows.Forms.ComboBox();
            this.txtKhu = new System.Windows.Forms.TextBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTL
            // 
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTheLoai,
            this.TenTheLoai,
            this.MaKe});
            this.dgvTL.Location = new System.Drawing.Point(12, 140);
            this.dgvTL.Name = "dgvTL";
            this.dgvTL.Size = new System.Drawing.Size(936, 317);
            this.dgvTL.TabIndex = 73;
            this.dgvTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTL_CellClick);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(827, 481);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 63;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(725, 481);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 64;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(614, 481);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(269, 481);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 66;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(162, 481);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(49, 481);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Khu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "Kệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 84;
            this.label1.Text = "Vị trí: ";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTL.Enabled = false;
            this.txtTenTL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTL.Location = new System.Drawing.Point(269, 84);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(165, 27);
            this.txtTenTL.TabIndex = 81;
            // 
            // txtMaTL
            // 
            this.txtMaTL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTL.Enabled = false;
            this.txtMaTL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTL.Location = new System.Drawing.Point(269, 37);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(165, 27);
            this.txtMaTL.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tên Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Mã Thể Loại";
            // 
            // cbxKe
            // 
            this.cbxKe.Enabled = false;
            this.cbxKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKe.FormattingEnabled = true;
            this.cbxKe.Location = new System.Drawing.Point(708, 78);
            this.cbxKe.Name = "cbxKe";
            this.cbxKe.Size = new System.Drawing.Size(174, 28);
            this.cbxKe.TabIndex = 89;
            // 
            // txtKhu
            // 
            this.txtKhu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhu.Enabled = false;
            this.txtKhu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhu.Location = new System.Drawing.Point(708, 32);
            this.txtKhu.Name = "txtKhu";
            this.txtKhu.Size = new System.Drawing.Size(174, 27);
            this.txtKhu.TabIndex = 90;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(446, 481);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 35);
            this.btnTaiLai.TabIndex = 91;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.Name = "MaTheLoai";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // MaKe
            // 
            this.MaKe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKe.DataPropertyName = "MaKe";
            this.MaKe.HeaderText = "Đặt ở Kệ";
            this.MaKe.Name = "MaKe";
            // 
            // frm_TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 532);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.txtKhu);
            this.Controls.Add(this.cbxKe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTL);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frm_TheLoai";
            this.Text = "frm_TheLoai";
            this.Load += new System.EventHandler(this.frm_TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTL;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxKe;
        private System.Windows.Forms.TextBox txtKhu;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKe;
    }
}