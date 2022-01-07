namespace DemoPhanTan
{
    partial class Frm_ThongKeDonHang
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTu = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(132, 388);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 26);
            this.txtTongTien.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tổng tiền :";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(15, 55);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(654, 319);
            this.dgvThongKe.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày :";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(367, 6);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(112, 26);
            this.dtpNgayDen.TabIndex = 16;
            this.dtpNgayDen.Value = new System.DateTime(2016, 6, 18, 0, 0, 0, 0);
            // 
            // dtpNgayTu
            // 
            this.dtpNgayTu.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTu.Location = new System.Drawing.Point(132, 5);
            this.dtpNgayTu.Name = "dtpNgayTu";
            this.dtpNgayTu.Size = new System.Drawing.Size(112, 26);
            this.dtpNgayTu.TabIndex = 17;
            this.dtpNgayTu.Value = new System.DateTime(2016, 6, 18, 0, 0, 0, 0);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(511, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(511, 6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(108, 30);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Frm_ThongKeDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.dtpNgayTu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Frm_ThongKeDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThongKeDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayTu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKe;
    }
}