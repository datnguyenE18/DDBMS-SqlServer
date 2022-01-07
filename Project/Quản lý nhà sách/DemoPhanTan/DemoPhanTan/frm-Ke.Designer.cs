namespace DemoPhanTan
{
    partial class frm_Ke
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
            this.dgvKe = new System.Windows.Forms.DataGridView();
            this.MaKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txttenKe = new System.Windows.Forms.TextBox();
            this.txtmaKe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKhu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKe
            // 
            this.dgvKe.AllowUserToAddRows = false;
            this.dgvKe.AllowUserToDeleteRows = false;
            this.dgvKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKe,
            this.TenKe,
            this.MaKhu});
            this.dgvKe.Location = new System.Drawing.Point(12, 135);
            this.dgvKe.Name = "dgvKe";
            this.dgvKe.ReadOnly = true;
            this.dgvKe.Size = new System.Drawing.Size(918, 331);
            this.dgvKe.TabIndex = 51;
            this.dgvKe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKe_CellClick);
            // 
            // MaKe
            // 
            this.MaKe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKe.DataPropertyName = "MaKe";
            this.MaKe.HeaderText = "Mã Kệ Sách";
            this.MaKe.Name = "MaKe";
            this.MaKe.ReadOnly = true;
            // 
            // TenKe
            // 
            this.TenKe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKe.DataPropertyName = "TenKe";
            this.TenKe.HeaderText = "Tên Kệ";
            this.TenKe.Name = "TenKe";
            this.TenKe.ReadOnly = true;
            // 
            // MaKhu
            // 
            this.MaKhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKhu.DataPropertyName = "MaKhu";
            this.MaKhu.HeaderText = "Khu";
            this.MaKhu.Name = "MaKhu";
            this.MaKhu.ReadOnly = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(799, 489);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(90, 35);
            this.btnTroVe.TabIndex = 41;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(683, 489);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 35);
            this.btnHuy.TabIndex = 42;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(571, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 35);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(281, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(169, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(52, 489);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txttenKe
            // 
            this.txttenKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenKe.Enabled = false;
            this.txttenKe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenKe.Location = new System.Drawing.Point(402, 63);
            this.txttenKe.Name = "txttenKe";
            this.txttenKe.Size = new System.Drawing.Size(187, 27);
            this.txttenKe.TabIndex = 54;
            // 
            // txtmaKe
            // 
            this.txtmaKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaKe.Enabled = false;
            this.txtmaKe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaKe.Location = new System.Drawing.Point(104, 64);
            this.txtmaKe.Name = "txtmaKe";
            this.txtmaKe.Size = new System.Drawing.Size(174, 27);
            this.txtmaKe.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Kệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã Kệ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(621, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Khu";
            // 
            // cbxKhu
            // 
            this.cbxKhu.Enabled = false;
            this.cbxKhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhu.FormattingEnabled = true;
            this.cbxKhu.Location = new System.Drawing.Point(737, 63);
            this.cbxKhu.Name = "cbxKhu";
            this.cbxKhu.Size = new System.Drawing.Size(193, 28);
            this.cbxKhu.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 31);
            this.label4.TabIndex = 59;
            this.label4.Text = "Quản Lý Kệ Sách";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(420, 489);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 35);
            this.btnTaiLai.TabIndex = 60;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // frm_Ke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxKhu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenKe);
            this.Controls.Add(this.txtmaKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKe);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Ke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ke";
            this.Load += new System.EventHandler(this.frm_Ke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKe;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txttenKe;
        private System.Windows.Forms.TextBox txtmaKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKhu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiLai;
    }
}