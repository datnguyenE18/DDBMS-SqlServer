namespace DemoPhanTan
{
    partial class frm_HoaDonBan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiaTriHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.TongGiaTriHDBan,
            this.MaNV});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa Đơn Bán";
            // 
            // MaHDBan
            // 
            this.MaHDBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHDBan.DataPropertyName = "MaHDBan";
            this.MaHDBan.HeaderText = "Mã Hóa Đơn Bán";
            this.MaHDBan.Name = "MaHDBan";
            // 
            // TongGiaTriHDBan
            // 
            this.TongGiaTriHDBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongGiaTriHDBan.DataPropertyName = "TongGiaTriHDBan";
            this.TongGiaTriHDBan.HeaderText = "Tổng Giá Trị Hóa Đơn Bán";
            this.TongGiaTriHDBan.Name = "TongGiaTriHDBan";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Nhân Viên Bán";
            this.MaNV.Name = "MaNV";
            // 
            // frm_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_HoaDonBan";
            this.Text = "frm_HoaDonBan";
            this.Load += new System.EventHandler(this.frm_HoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiaTriHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;

    }
}