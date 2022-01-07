namespace DemoPhanTan
{
    partial class frm_ChucVu
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenCV = new System.Windows.Forms.TextBox();
            this.txtmaCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lương = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(859, 503);
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
            this.btnHuy.Location = new System.Drawing.Point(748, 503);
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
            this.btnLuu.Location = new System.Drawing.Point(636, 503);
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
            this.btnSua.Location = new System.Drawing.Point(290, 503);
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
            this.btnXoa.Location = new System.Drawing.Point(178, 503);
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
            this.btnThem.Location = new System.Drawing.Point(61, 503);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 35);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvCV
            // 
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChucVu,
            this.TenChucVu,
            this.Lương});
            this.dgvCV.Location = new System.Drawing.Point(34, 137);
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.Size = new System.Drawing.Size(911, 324);
            this.dgvCV.TabIndex = 42;
            this.dgvCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCV_CellClick);
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuong.Enabled = false;
            this.txtLuong.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(761, 94);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(184, 27);
            this.txtLuong.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Lương";
            // 
            // txttenCV
            // 
            this.txttenCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttenCV.Enabled = false;
            this.txttenCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenCV.Location = new System.Drawing.Point(461, 94);
            this.txttenCV.Name = "txttenCV";
            this.txttenCV.Size = new System.Drawing.Size(170, 27);
            this.txttenCV.TabIndex = 51;
            // 
            // txtmaCV
            // 
            this.txtmaCV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaCV.Enabled = false;
            this.txtmaCV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaCV.Location = new System.Drawing.Point(153, 94);
            this.txtmaCV.Name = "txtmaCV";
            this.txtmaCV.Size = new System.Drawing.Size(170, 27);
            this.txtmaCV.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tên Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 55;
            this.label4.Text = "Quản Lý Chức Vụ";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(444, 503);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 35);
            this.btnTaiLai.TabIndex = 56;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // MaChucVu
            // 
            this.MaChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.Name = "MaChucVu";
            // 
            // TenChucVu
            // 
            this.TenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Tên Chức Vụ";
            this.TenChucVu.Name = "TenChucVu";
            // 
            // Lương
            // 
            this.Lương.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lương.DataPropertyName = "MucLuong";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Lương.DefaultCellStyle = dataGridViewCellStyle1;
            this.Lương.HeaderText = "Lương Cơ Bản";
            this.Lương.Name = "Lương";
            // 
            // frm_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 584);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenCV);
            this.Controls.Add(this.txtmaCV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCV);
            this.Name = "frm_ChucVu";
            this.Text = "frm_ChucVu";
            this.Load += new System.EventHandler(this.frm_ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenCV;
        private System.Windows.Forms.TextBox txtmaCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lương;
    }
}