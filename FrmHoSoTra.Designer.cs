namespace BTL_Nhom1
{
    partial class FrmHoSoTra
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
            this.groupHST = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHST = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.Đóng = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaThuThu2 = new System.Windows.Forms.ComboBox();
            this.cbMaHSM2 = new System.Windows.Forms.ComboBox();
            this.txtTongTien2 = new System.Windows.Forms.TextBox();
            this.txtSoTienThanhToan2 = new System.Windows.Forms.TextBox();
            this.txtMaHST2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupCTSHT = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHST = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.cbMaViPham9 = new System.Windows.Forms.ComboBox();
            this.cbMaSach9 = new System.Windows.Forms.ComboBox();
            this.cbMaHST9 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDong9 = new System.Windows.Forms.Button();
            this.btnBoQua9 = new System.Windows.Forms.Button();
            this.btnLuu9 = new System.Windows.Forms.Button();
            this.btnSua9 = new System.Windows.Forms.Button();
            this.btnXoa9 = new System.Windows.Forms.Button();
            this.btnThem9 = new System.Windows.Forms.Button();
            this.groupHST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHST)).BeginInit();
            this.groupCTSHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupHST
            // 
            this.groupHST.Controls.Add(this.dateTimePicker2);
            this.groupHST.Controls.Add(this.dataGridViewHST);
            this.groupHST.Controls.Add(this.btnXoa);
            this.groupHST.Controls.Add(this.label1);
            this.groupHST.Controls.Add(this.btnSua);
            this.groupHST.Controls.Add(this.btnLuu);
            this.groupHST.Controls.Add(this.btnBoQua);
            this.groupHST.Controls.Add(this.Đóng);
            this.groupHST.Controls.Add(this.btnThem);
            this.groupHST.Controls.Add(this.cbMaThuThu2);
            this.groupHST.Controls.Add(this.cbMaHSM2);
            this.groupHST.Controls.Add(this.txtTongTien2);
            this.groupHST.Controls.Add(this.txtSoTienThanhToan2);
            this.groupHST.Controls.Add(this.txtMaHST2);
            this.groupHST.Controls.Add(this.label6);
            this.groupHST.Controls.Add(this.label5);
            this.groupHST.Controls.Add(this.label4);
            this.groupHST.Controls.Add(this.label3);
            this.groupHST.Controls.Add(this.label2);
            this.groupHST.Location = new System.Drawing.Point(6, 2);
            this.groupHST.Name = "groupHST";
            this.groupHST.Size = new System.Drawing.Size(1013, 287);
            this.groupHST.TabIndex = 0;
            this.groupHST.TabStop = false;
            this.groupHST.Text = "Hồ sơ trả";
            this.groupHST.Enter += new System.EventHandler(this.groupHST_Enter);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dataGridViewHST
            // 
            this.dataGridViewHST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHST.Location = new System.Drawing.Point(458, 25);
            this.dataGridViewHST.Name = "dataGridViewHST";
            this.dataGridViewHST.RowHeadersWidth = 62;
            this.dataGridViewHST.RowTemplate.Height = 28;
            this.dataGridViewHST.Size = new System.Drawing.Size(549, 256);
            this.dataGridViewHST.TabIndex = 18;
            this.dataGridViewHST.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHST_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 79);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ trả";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(354, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(354, 159);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(354, 199);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 34);
            this.btnBoQua.TabIndex = 14;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // Đóng
            // 
            this.Đóng.Location = new System.Drawing.Point(354, 239);
            this.Đóng.Name = "Đóng";
            this.Đóng.Size = new System.Drawing.Size(75, 34);
            this.Đóng.TabIndex = 13;
            this.Đóng.Text = "Đóng";
            this.Đóng.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(354, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaThuThu2
            // 
            this.cbMaThuThu2.FormattingEnabled = true;
            this.cbMaThuThu2.Location = new System.Drawing.Point(203, 110);
            this.cbMaThuThu2.Name = "cbMaThuThu2";
            this.cbMaThuThu2.Size = new System.Drawing.Size(121, 28);
            this.cbMaThuThu2.TabIndex = 11;
            // 
            // cbMaHSM2
            // 
            this.cbMaHSM2.FormattingEnabled = true;
            this.cbMaHSM2.Location = new System.Drawing.Point(203, 68);
            this.cbMaHSM2.Name = "cbMaHSM2";
            this.cbMaHSM2.Size = new System.Drawing.Size(121, 28);
            this.cbMaHSM2.TabIndex = 10;
            // 
            // txtTongTien2
            // 
            this.txtTongTien2.Location = new System.Drawing.Point(203, 226);
            this.txtTongTien2.Name = "txtTongTien2";
            this.txtTongTien2.Size = new System.Drawing.Size(100, 26);
            this.txtTongTien2.TabIndex = 9;
            // 
            // txtSoTienThanhToan2
            // 
            this.txtSoTienThanhToan2.Location = new System.Drawing.Point(203, 188);
            this.txtSoTienThanhToan2.Name = "txtSoTienThanhToan2";
            this.txtSoTienThanhToan2.Size = new System.Drawing.Size(100, 26);
            this.txtSoTienThanhToan2.TabIndex = 8;
            // 
            // txtMaHST2
            // 
            this.txtMaHST2.Location = new System.Drawing.Point(203, 35);
            this.txtMaHST2.Name = "txtMaHST2";
            this.txtMaHST2.Size = new System.Drawing.Size(100, 26);
            this.txtMaHST2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền thanh toán ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày trả ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã thủ thư ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hồ sơ mượn ";
            // 
            // groupCTSHT
            // 
            this.groupCTSHT.Controls.Add(this.dataGridViewCTHST);
            this.groupCTSHT.Controls.Add(this.txtThanhTien);
            this.groupCTSHT.Controls.Add(this.cbMaViPham9);
            this.groupCTSHT.Controls.Add(this.cbMaSach9);
            this.groupCTSHT.Controls.Add(this.cbMaHST9);
            this.groupCTSHT.Controls.Add(this.label10);
            this.groupCTSHT.Controls.Add(this.label9);
            this.groupCTSHT.Controls.Add(this.label8);
            this.groupCTSHT.Controls.Add(this.label7);
            this.groupCTSHT.Controls.Add(this.btnDong9);
            this.groupCTSHT.Controls.Add(this.btnBoQua9);
            this.groupCTSHT.Controls.Add(this.btnLuu9);
            this.groupCTSHT.Controls.Add(this.btnSua9);
            this.groupCTSHT.Controls.Add(this.btnXoa9);
            this.groupCTSHT.Controls.Add(this.btnThem9);
            this.groupCTSHT.Location = new System.Drawing.Point(6, 305);
            this.groupCTSHT.Name = "groupCTSHT";
            this.groupCTSHT.Size = new System.Drawing.Size(1013, 300);
            this.groupCTSHT.TabIndex = 1;
            this.groupCTSHT.TabStop = false;
            this.groupCTSHT.Text = "Chi tiết hồ sơ trả ";
            this.groupCTSHT.Enter += new System.EventHandler(this.groupCTSHT_Enter);
            // 
            // dataGridViewCTHST
            // 
            this.dataGridViewCTHST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHST.Location = new System.Drawing.Point(458, 25);
            this.dataGridViewCTHST.Name = "dataGridViewCTHST";
            this.dataGridViewCTHST.RowHeadersWidth = 62;
            this.dataGridViewCTHST.RowTemplate.Height = 28;
            this.dataGridViewCTHST.Size = new System.Drawing.Size(549, 256);
            this.dataGridViewCTHST.TabIndex = 27;
            this.dataGridViewCTHST.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHST_CellClick);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(203, 159);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 26);
            this.txtThanhTien.TabIndex = 26;
            // 
            // cbMaViPham9
            // 
            this.cbMaViPham9.FormattingEnabled = true;
            this.cbMaViPham9.Location = new System.Drawing.Point(203, 119);
            this.cbMaViPham9.Name = "cbMaViPham9";
            this.cbMaViPham9.Size = new System.Drawing.Size(121, 28);
            this.cbMaViPham9.TabIndex = 25;
            // 
            // cbMaSach9
            // 
            this.cbMaSach9.FormattingEnabled = true;
            this.cbMaSach9.Location = new System.Drawing.Point(203, 79);
            this.cbMaSach9.Name = "cbMaSach9";
            this.cbMaSach9.Size = new System.Drawing.Size(121, 28);
            this.cbMaSach9.TabIndex = 24;
            // 
            // cbMaHST9
            // 
            this.cbMaHST9.FormattingEnabled = true;
            this.cbMaHST9.Location = new System.Drawing.Point(203, 39);
            this.cbMaHST9.Name = "cbMaHST9";
            this.cbMaHST9.Size = new System.Drawing.Size(121, 28);
            this.cbMaHST9.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Thành Tiền ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã vi phạm ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã sách ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mã hồ sơ trả ";
            // 
            // btnDong9
            // 
            this.btnDong9.Location = new System.Drawing.Point(354, 225);
            this.btnDong9.Name = "btnDong9";
            this.btnDong9.Size = new System.Drawing.Size(75, 34);
            this.btnDong9.TabIndex = 18;
            this.btnDong9.Text = "Đóng";
            this.btnDong9.UseVisualStyleBackColor = true;
            this.btnDong9.Click += new System.EventHandler(this.btnDong9_Click);
            // 
            // btnBoQua9
            // 
            this.btnBoQua9.Location = new System.Drawing.Point(354, 185);
            this.btnBoQua9.Name = "btnBoQua9";
            this.btnBoQua9.Size = new System.Drawing.Size(75, 34);
            this.btnBoQua9.TabIndex = 17;
            this.btnBoQua9.Text = "Bỏ qua";
            this.btnBoQua9.UseVisualStyleBackColor = true;
            this.btnBoQua9.Click += new System.EventHandler(this.btnBoQua9_Click);
            // 
            // btnLuu9
            // 
            this.btnLuu9.Location = new System.Drawing.Point(354, 145);
            this.btnLuu9.Name = "btnLuu9";
            this.btnLuu9.Size = new System.Drawing.Size(75, 34);
            this.btnLuu9.TabIndex = 16;
            this.btnLuu9.Text = "Lưu";
            this.btnLuu9.UseVisualStyleBackColor = true;
            this.btnLuu9.Click += new System.EventHandler(this.btnLuu9_Click);
            // 
            // btnSua9
            // 
            this.btnSua9.Location = new System.Drawing.Point(354, 105);
            this.btnSua9.Name = "btnSua9";
            this.btnSua9.Size = new System.Drawing.Size(75, 34);
            this.btnSua9.TabIndex = 15;
            this.btnSua9.Text = "Sửa";
            this.btnSua9.UseVisualStyleBackColor = true;
            this.btnSua9.Click += new System.EventHandler(this.btnSua9_Click);
            // 
            // btnXoa9
            // 
            this.btnXoa9.Location = new System.Drawing.Point(354, 65);
            this.btnXoa9.Name = "btnXoa9";
            this.btnXoa9.Size = new System.Drawing.Size(75, 34);
            this.btnXoa9.TabIndex = 14;
            this.btnXoa9.Text = "Xóa";
            this.btnXoa9.UseVisualStyleBackColor = true;
            this.btnXoa9.Click += new System.EventHandler(this.btnXoa9_Click);
            // 
            // btnThem9
            // 
            this.btnThem9.Location = new System.Drawing.Point(354, 25);
            this.btnThem9.Name = "btnThem9";
            this.btnThem9.Size = new System.Drawing.Size(75, 34);
            this.btnThem9.TabIndex = 13;
            this.btnThem9.Text = "Thêm";
            this.btnThem9.UseVisualStyleBackColor = true;
            this.btnThem9.Click += new System.EventHandler(this.btnThem9_Click);
            // 
            // FrmHoSoTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 617);
            this.Controls.Add(this.groupCTSHT);
            this.Controls.Add(this.groupHST);
            this.Name = "FrmHoSoTra";
            this.Text = "FrmHoSoTra";
            this.Load += new System.EventHandler(this.FrmHoSoTra_Load);
            this.groupHST.ResumeLayout(false);
            this.groupHST.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHST)).EndInit();
            this.groupCTSHT.ResumeLayout(false);
            this.groupCTSHT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupHST;
        private System.Windows.Forms.DataGridView dataGridViewHST;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button Đóng;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaThuThu2;
        private System.Windows.Forms.ComboBox cbMaHSM2;
        private System.Windows.Forms.TextBox txtTongTien2;
        private System.Windows.Forms.TextBox txtSoTienThanhToan2;
        private System.Windows.Forms.TextBox txtMaHST2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupCTSHT;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cbMaViPham9;
        private System.Windows.Forms.ComboBox cbMaSach9;
        private System.Windows.Forms.ComboBox cbMaHST9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDong9;
        private System.Windows.Forms.Button btnBoQua9;
        private System.Windows.Forms.Button btnLuu9;
        private System.Windows.Forms.Button btnSua9;
        private System.Windows.Forms.Button btnXoa9;
        private System.Windows.Forms.Button btnThem9;
        private System.Windows.Forms.DataGridView dataGridViewCTHST;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}