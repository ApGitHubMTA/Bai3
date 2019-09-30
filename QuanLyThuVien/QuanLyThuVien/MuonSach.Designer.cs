namespace QuanLyThuVien
{
    partial class MuonSach
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
            this.lblMaBD = new System.Windows.Forms.Label();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.btnMuon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbSachMuon = new System.Windows.Forms.GroupBox();
            this.gbBanDoc = new System.Windows.Forms.GroupBox();
            this.dgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.gbSachMuon.SuspendLayout();
            this.gbBanDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaBD
            // 
            this.lblMaBD.AutoSize = true;
            this.lblMaBD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBD.Location = new System.Drawing.Point(404, 110);
            this.lblMaBD.Name = "lblMaBD";
            this.lblMaBD.Size = new System.Drawing.Size(135, 19);
            this.lblMaBD.TabIndex = 1;
            this.lblMaBD.Text = "Nhập Mã Bạn Đọc";
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTL.Location = new System.Drawing.Point(357, 41);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(130, 16);
            this.lblMaTL.TabIndex = 3;
            this.lblMaTL.Text = "Nhập Mã Tài Liệu";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(510, 40);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(173, 20);
            this.txtMaTL.TabIndex = 4;
            // 
            // btnMuon
            // 
            this.btnMuon.Location = new System.Drawing.Point(297, 81);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(101, 31);
            this.btnMuon.TabIndex = 5;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnOK);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 232);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(16, 164);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(73, 59);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(16, 81);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 50);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Hoàn Tất Mượn";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // gbSachMuon
            // 
            this.gbSachMuon.Controls.Add(this.gbBanDoc);
            this.gbSachMuon.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbSachMuon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSachMuon.Location = new System.Drawing.Point(-2, 0);
            this.gbSachMuon.Name = "gbSachMuon";
            this.gbSachMuon.Size = new System.Drawing.Size(1007, 529);
            this.gbSachMuon.TabIndex = 7;
            this.gbSachMuon.TabStop = false;
            this.gbSachMuon.Text = "Sách Vừa Nhập";
            // 
            // gbBanDoc
            // 
            this.gbBanDoc.Controls.Add(this.dgvSachDaMuon);
            this.gbBanDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBanDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBanDoc.Location = new System.Drawing.Point(3, 22);
            this.gbBanDoc.Name = "gbBanDoc";
            this.gbBanDoc.Size = new System.Drawing.Size(415, 504);
            this.gbBanDoc.TabIndex = 4;
            this.gbBanDoc.TabStop = false;
            this.gbBanDoc.Text = "Sách Bạn Đọc Đã Mượn";
            // 
            // dgvSachDaMuon
            // 
            this.dgvSachDaMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDaMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column15,
            this.Column6});
            this.dgvSachDaMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachDaMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.Location = new System.Drawing.Point(3, 22);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.Size = new System.Drawing.Size(409, 479);
            this.dgvSachDaMuon.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDauSach";
            this.Column1.HeaderText = "Mã Đầu Sách";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NhanDe";
            this.Column2.HeaderText = "Nhan Đề";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TacGia";
            this.Column3.HeaderText = "Tác Giả";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayMuon";
            this.Column4.HeaderText = "Ngày Mượn";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayTra";
            this.Column5.HeaderText = "Ngày Trả";
            this.Column5.Name = "Column5";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "HanTra";
            this.Column15.HeaderText = "Hạn Trả";
            this.Column15.Name = "Column15";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GhiChu";
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.Name = "Column6";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 529);
            this.Controls.Add(this.gbSachMuon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.lblMaTL);
            this.Controls.Add(this.lblMaBD);
            this.Name = "MuonSach";
            this.Text = "MuonSach";
            this.groupBox2.ResumeLayout(false);
            this.gbSachMuon.ResumeLayout(false);
            this.gbBanDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaBD;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbSachMuon;
        private System.Windows.Forms.GroupBox gbBanDoc;
        private System.Windows.Forms.DataGridView dgvSachDaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}