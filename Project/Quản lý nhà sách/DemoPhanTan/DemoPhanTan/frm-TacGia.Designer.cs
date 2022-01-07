namespace DemoPhanTan
{
    partial class frm_TacGia
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
            this.dgvTG = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTG
            // 
            this.dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.TenTacGia});
            this.dgvTG.Location = new System.Drawing.Point(34, 145);
            this.dgvTG.Name = "dgvTG";
            this.dgvTG.Size = new System.Drawing.Size(936, 317);
            this.dgvTG.TabIndex = 57;
            this.dgvTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTG_CellClick);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(849, 485);
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
            this.btnHuy.Location = new System.Drawing.Point(747, 485);
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
            this.btnLuu.Location = new System.Drawing.Point(636, 485);
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
            this.btnSua.Location = new System.Drawing.Point(291, 485);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 35);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(184, 485);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 35);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(71, 485);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTG.Enabled = false;
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(732, 96);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(140, 27);
            this.txtTenTG.TabIndex = 61;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(300, 96);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(140, 27);
            this.txtMaTG.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tên Tác Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "Mã Tác Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Quản Lý Tác Giả - Nhóm Tác Giả";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(448, 485);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 35);
            this.btnTaiLai.TabIndex = 65;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // MaTacGia
            // 
            this.MaTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã Tác Giả";
            this.MaTacGia.Name = "MaTacGia";
            // 
            // TenTacGia
            // 
            this.TenTacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // frm_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 541);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTG);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_TacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TacGia";
            this.Load += new System.EventHandler(this.frm_TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTG;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
    }
}