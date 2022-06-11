namespace BTL_Nhom1
{
    partial class FrmHoSoMuon
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewHSM = new System.Windows.Forms.DataGridView();
            this.txtTamUng3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaThuThu3 = new System.Windows.Forms.ComboBox();
            this.cbMaTheMuon3 = new System.Windows.Forms.ComboBox();
            this.txtMaHSM3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCTHSM = new System.Windows.Forms.DataGridView();
            this.btnThem7 = new System.Windows.Forms.Button();
            this.btnXoa7 = new System.Windows.Forms.Button();
            this.btnSua7 = new System.Windows.Forms.Button();
            this.btnLuu7 = new System.Windows.Forms.Button();
            this.btnDong7 = new System.Windows.Forms.Button();
            this.btnBoqua7 = new System.Windows.Forms.Button();
            this.cbMaHSM7 = new System.Windows.Forms.ComboBox();
            this.cbMaSach7 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupHSM = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCTHSM = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHSM)).BeginInit();
            this.groupHSM.SuspendLayout();
            this.groupBoxCTHSM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(307, 29);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 28);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(307, 74);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 29);
            this.btnBoQua.TabIndex = 15;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(307, 114);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(307, 174);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(307, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(307, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewHSM
            // 
            this.dataGridViewHSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSM.Location = new System.Drawing.Point(451, 25);
            this.dataGridViewHSM.Name = "dataGridViewHSM";
            this.dataGridViewHSM.RowHeadersWidth = 62;
            this.dataGridViewHSM.RowTemplate.Height = 28;
            this.dataGridViewHSM.Size = new System.Drawing.Size(543, 276);
            this.dataGridViewHSM.TabIndex = 10;
            this.dataGridViewHSM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHSM_CellClick);
            this.dataGridViewHSM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHSM_CellContentClick);
            // 
            // txtTamUng3
            // 
            this.txtTamUng3.Location = new System.Drawing.Point(166, 196);
            this.txtTamUng3.Name = "txtTamUng3";
            this.txtTamUng3.Size = new System.Drawing.Size(100, 26);
            this.txtTamUng3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tạm ứng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày mượn ";
            // 
            // cbMaThuThu3
            // 
            this.cbMaThuThu3.FormattingEnabled = true;
            this.cbMaThuThu3.Location = new System.Drawing.Point(166, 114);
            this.cbMaThuThu3.Name = "cbMaThuThu3";
            this.cbMaThuThu3.Size = new System.Drawing.Size(121, 28);
            this.cbMaThuThu3.TabIndex = 7;
            // 
            // cbMaTheMuon3
            // 
            this.cbMaTheMuon3.FormattingEnabled = true;
            this.cbMaTheMuon3.Location = new System.Drawing.Point(166, 74);
            this.cbMaTheMuon3.Name = "cbMaTheMuon3";
            this.cbMaTheMuon3.Size = new System.Drawing.Size(121, 28);
            this.cbMaTheMuon3.TabIndex = 6;
            // 
            // txtMaHSM3
            // 
            this.txtMaHSM3.Location = new System.Drawing.Point(166, 37);
            this.txtMaHSM3.Name = "txtMaHSM3";
            this.txtMaHSM3.Size = new System.Drawing.Size(100, 26);
            this.txtMaHSM3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thủ thư ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thẻ mượn ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ mượn ";
            // 
            // dataGridViewCTHSM
            // 
            this.dataGridViewCTHSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHSM.Location = new System.Drawing.Point(451, 11);
            this.dataGridViewCTHSM.Name = "dataGridViewCTHSM";
            this.dataGridViewCTHSM.RowHeadersWidth = 62;
            this.dataGridViewCTHSM.RowTemplate.Height = 28;
            this.dataGridViewCTHSM.Size = new System.Drawing.Size(543, 270);
            this.dataGridViewCTHSM.TabIndex = 22;
            this.dataGridViewCTHSM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHSM_CellClick);
            // 
            // btnThem7
            // 
            this.btnThem7.Location = new System.Drawing.Point(307, 206);
            this.btnThem7.Name = "btnThem7";
            this.btnThem7.Size = new System.Drawing.Size(75, 31);
            this.btnThem7.TabIndex = 21;
            this.btnThem7.Text = "Thêm";
            this.btnThem7.UseVisualStyleBackColor = true;
            this.btnThem7.Click += new System.EventHandler(this.btnThem7_Click);
            // 
            // btnXoa7
            // 
            this.btnXoa7.Location = new System.Drawing.Point(307, 160);
            this.btnXoa7.Name = "btnXoa7";
            this.btnXoa7.Size = new System.Drawing.Size(75, 30);
            this.btnXoa7.TabIndex = 20;
            this.btnXoa7.Text = "Xóa";
            this.btnXoa7.UseVisualStyleBackColor = true;
            this.btnXoa7.Click += new System.EventHandler(this.btnXoa7_Click);
            // 
            // btnSua7
            // 
            this.btnSua7.Location = new System.Drawing.Point(307, 125);
            this.btnSua7.Name = "btnSua7";
            this.btnSua7.Size = new System.Drawing.Size(75, 29);
            this.btnSua7.TabIndex = 19;
            this.btnSua7.Text = "Sửa";
            this.btnSua7.UseVisualStyleBackColor = true;
            this.btnSua7.Click += new System.EventHandler(this.btnSua7_Click);
            // 
            // btnLuu7
            // 
            this.btnLuu7.Location = new System.Drawing.Point(307, 86);
            this.btnLuu7.Name = "btnLuu7";
            this.btnLuu7.Size = new System.Drawing.Size(75, 30);
            this.btnLuu7.TabIndex = 18;
            this.btnLuu7.Text = "Lưu";
            this.btnLuu7.UseVisualStyleBackColor = true;
            this.btnLuu7.Click += new System.EventHandler(this.btnLuu7_Click);
            // 
            // btnDong7
            // 
            this.btnDong7.Location = new System.Drawing.Point(307, 19);
            this.btnDong7.Name = "btnDong7";
            this.btnDong7.Size = new System.Drawing.Size(75, 28);
            this.btnDong7.TabIndex = 17;
            this.btnDong7.Text = "Đóng";
            this.btnDong7.UseVisualStyleBackColor = true;
            this.btnDong7.Click += new System.EventHandler(this.btnDong7_Click);
            // 
            // btnBoqua7
            // 
            this.btnBoqua7.Location = new System.Drawing.Point(307, 51);
            this.btnBoqua7.Name = "btnBoqua7";
            this.btnBoqua7.Size = new System.Drawing.Size(75, 29);
            this.btnBoqua7.TabIndex = 16;
            this.btnBoqua7.Text = "Bỏ qua";
            this.btnBoqua7.UseVisualStyleBackColor = true;
            this.btnBoqua7.Click += new System.EventHandler(this.btnBoqua7_Click);
            // 
            // cbMaHSM7
            // 
            this.cbMaHSM7.FormattingEnabled = true;
            this.cbMaHSM7.Location = new System.Drawing.Point(152, 40);
            this.cbMaHSM7.Name = "cbMaHSM7";
            this.cbMaHSM7.Size = new System.Drawing.Size(121, 28);
            this.cbMaHSM7.TabIndex = 4;
            // 
            // cbMaSach7
            // 
            this.cbMaSach7.FormattingEnabled = true;
            this.cbMaSach7.Location = new System.Drawing.Point(152, 94);
            this.cbMaSach7.Name = "cbMaSach7";
            this.cbMaSach7.Size = new System.Drawing.Size(121, 28);
            this.cbMaSach7.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tình trạng ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã hồ sơ mượn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sách";
            // 
            // groupHSM
            // 
            this.groupHSM.Controls.Add(this.dateTimePicker1);
            this.groupHSM.Controls.Add(this.label1);
            this.groupHSM.Controls.Add(this.label2);
            this.groupHSM.Controls.Add(this.label3);
            this.groupHSM.Controls.Add(this.dataGridViewHSM);
            this.groupHSM.Controls.Add(this.label4);
            this.groupHSM.Controls.Add(this.btnThem);
            this.groupHSM.Controls.Add(this.label6);
            this.groupHSM.Controls.Add(this.txtMaHSM3);
            this.groupHSM.Controls.Add(this.btnXoa);
            this.groupHSM.Controls.Add(this.cbMaTheMuon3);
            this.groupHSM.Controls.Add(this.cbMaThuThu3);
            this.groupHSM.Controls.Add(this.btnSua);
            this.groupHSM.Controls.Add(this.txtTamUng3);
            this.groupHSM.Controls.Add(this.btnLuu);
            this.groupHSM.Controls.Add(this.btnDong);
            this.groupHSM.Controls.Add(this.btnBoQua);
            this.groupHSM.Location = new System.Drawing.Point(1, 3);
            this.groupHSM.Name = "groupHSM";
            this.groupHSM.Size = new System.Drawing.Size(994, 310);
            this.groupHSM.TabIndex = 23;
            this.groupHSM.TabStop = false;
            this.groupHSM.Text = "Hồ sơ mượn ";
            this.groupHSM.Enter += new System.EventHandler(this.groupHSM_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // groupBoxCTHSM
            // 
            this.groupBoxCTHSM.Controls.Add(this.cbTinhTrang);
            this.groupBoxCTHSM.Controls.Add(this.label7);
            this.groupBoxCTHSM.Controls.Add(this.dataGridViewCTHSM);
            this.groupBoxCTHSM.Controls.Add(this.btnThem7);
            this.groupBoxCTHSM.Controls.Add(this.label5);
            this.groupBoxCTHSM.Controls.Add(this.label8);
            this.groupBoxCTHSM.Controls.Add(this.btnXoa7);
            this.groupBoxCTHSM.Controls.Add(this.cbMaHSM7);
            this.groupBoxCTHSM.Controls.Add(this.btnSua7);
            this.groupBoxCTHSM.Controls.Add(this.cbMaSach7);
            this.groupBoxCTHSM.Controls.Add(this.btnLuu7);
            this.groupBoxCTHSM.Controls.Add(this.btnBoqua7);
            this.groupBoxCTHSM.Controls.Add(this.btnDong7);
            this.groupBoxCTHSM.Location = new System.Drawing.Point(1, 319);
            this.groupBoxCTHSM.Name = "groupBoxCTHSM";
            this.groupBoxCTHSM.Size = new System.Drawing.Size(1007, 287);
            this.groupBoxCTHSM.TabIndex = 17;
            this.groupBoxCTHSM.TabStop = false;
            this.groupBoxCTHSM.Text = "Chi tiết hồ sơ mượn ";
            this.groupBoxCTHSM.Enter += new System.EventHandler(this.groupBoxCTHSM_Enter);
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Chưa trả",
            "Đã Trả"});
            this.cbTinhTrang.Location = new System.Drawing.Point(152, 145);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 28);
            this.cbTinhTrang.TabIndex = 23;
            // 
            // FrmHoSoMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.groupBoxCTHSM);
            this.Controls.Add(this.groupHSM);
            this.Name = "FrmHoSoMuon";
            this.Text = "FrmHoSoMuon";
            this.Load += new System.EventHandler(this.FrmHoSoMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHSM)).EndInit();
            this.groupHSM.ResumeLayout(false);
            this.groupHSM.PerformLayout();
            this.groupBoxCTHSM.ResumeLayout(false);
            this.groupBoxCTHSM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHSM;
        private System.Windows.Forms.TextBox txtTamUng3;
        private System.Windows.Forms.ComboBox cbMaThuThu3;
        private System.Windows.Forms.ComboBox cbMaTheMuon3;
        private System.Windows.Forms.TextBox txtMaHSM3;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua7;
        private System.Windows.Forms.ComboBox cbMaHSM7;
        private System.Windows.Forms.ComboBox cbMaSach7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem7;
        private System.Windows.Forms.Button btnXoa7;
        private System.Windows.Forms.Button btnSua7;
        private System.Windows.Forms.Button btnLuu7;
        private System.Windows.Forms.Button btnDong7;
        private System.Windows.Forms.DataGridView dataGridViewCTHSM;
        private System.Windows.Forms.GroupBox groupHSM;
        private System.Windows.Forms.GroupBox groupBoxCTHSM;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbTinhTrang;
    }
}