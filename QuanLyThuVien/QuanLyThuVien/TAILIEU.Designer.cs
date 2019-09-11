namespace QuanLyThuVien
{
    partial class TAILIEU
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
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtNhanDe = new System.Windows.Forms.TextBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaTheLoai = new System.Windows.Forms.ComboBox();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.txtDoMat = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTG
            // 
            this.txtTG.Location = new System.Drawing.Point(196, 94);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(133, 20);
            this.txtTG.TabIndex = 37;
            // 
            // txtNhanDe
            // 
            this.txtNhanDe.Location = new System.Drawing.Point(196, 56);
            this.txtNhanDe.Name = "txtNhanDe";
            this.txtNhanDe.Size = new System.Drawing.Size(133, 20);
            this.txtNhanDe.TabIndex = 36;
            // 
            // txtMaTL
            // 
            this.txtMaTL.Enabled = false;
            this.txtMaTL.Location = new System.Drawing.Point(196, 18);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(133, 20);
            this.txtMaTL.TabIndex = 35;
            this.txtMaTL.TextChanged += new System.EventHandler(this.txtMaTL_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cbMaTheLoai);
            this.groupBox1.Controls.Add(this.cbMaNXB);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtNgonNgu);
            this.groupBox1.Controls.Add(this.txtDoMat);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTG);
            this.groupBox1.Controls.Add(this.txtNhanDe);
            this.groupBox1.Controls.Add(this.txtMaTL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cbMaTheLoai
            // 
            this.cbMaTheLoai.FormattingEnabled = true;
            this.cbMaTheLoai.Items.AddRange(new object[] {
            "TL001",
            "TL002",
            "TL003",
            "TL004",
            "TL005",
            "TL006",
            "TL007",
            "TL008",
            "TL009",
            "TL010",
            "TL011",
            "TL012",
            "TL013",
            "TL014"});
            this.cbMaTheLoai.Location = new System.Drawing.Point(483, 55);
            this.cbMaTheLoai.Name = "cbMaTheLoai";
            this.cbMaTheLoai.Size = new System.Drawing.Size(133, 21);
            this.cbMaTheLoai.TabIndex = 49;
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Items.AddRange(new object[] {
            "NXB001",
            "NXB002",
            "NXB003",
            "NXB004",
            "NXB005",
            "NXB006",
            "NXB007",
            "NXB008",
            "NXB009",
            "NXB010"});
            this.cbMaNXB.Location = new System.Drawing.Point(483, 94);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(133, 21);
            this.cbMaNXB.TabIndex = 48;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(765, 64);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(765, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(664, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(664, 64);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(664, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(483, 18);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(133, 20);
            this.txtNgonNgu.TabIndex = 40;
            // 
            // txtDoMat
            // 
            this.txtDoMat.Location = new System.Drawing.Point(196, 170);
            this.txtDoMat.Name = "txtDoMat";
            this.txtDoMat.Size = new System.Drawing.Size(133, 20);
            this.txtDoMat.TabIndex = 39;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(196, 132);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(133, 20);
            this.txtSoLuong.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mã nhà xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mã thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngôn ngữ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Độ mật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhan đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã tài liệu";
            // 
            // TAILIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 457);
            this.Controls.Add(this.groupBox1);
            this.Name = "TAILIEU";
            this.Text = "TAILIEU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.TextBox txtNhanDe;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaTheLoai;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.TextBox txtDoMat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}