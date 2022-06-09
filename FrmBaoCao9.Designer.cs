namespace BTL_Nhom1
{
    partial class FrmBaoCao9
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHSMtheoTM = new System.Windows.Forms.DataGridView();
            this.btnTimKiemBC = new System.Windows.Forms.Button();
            this.cbMaTheMuonBC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSMtheoTM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thẻ mượn ";
            // 
            // dataGridViewHSMtheoTM
            // 
            this.dataGridViewHSMtheoTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHSMtheoTM.Location = new System.Drawing.Point(99, 203);
            this.dataGridViewHSMtheoTM.Name = "dataGridViewHSMtheoTM";
            this.dataGridViewHSMtheoTM.RowHeadersWidth = 62;
            this.dataGridViewHSMtheoTM.RowTemplate.Height = 28;
            this.dataGridViewHSMtheoTM.Size = new System.Drawing.Size(776, 262);
            this.dataGridViewHSMtheoTM.TabIndex = 2;
            this.dataGridViewHSMtheoTM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHSMtheoTM_CellContentClick);
            // 
            // btnTimKiemBC
            // 
            this.btnTimKiemBC.Location = new System.Drawing.Point(445, 119);
            this.btnTimKiemBC.Name = "btnTimKiemBC";
            this.btnTimKiemBC.Size = new System.Drawing.Size(88, 32);
            this.btnTimKiemBC.TabIndex = 3;
            this.btnTimKiemBC.Text = "Tìm kiếm ";
            this.btnTimKiemBC.UseVisualStyleBackColor = true;
            this.btnTimKiemBC.Click += new System.EventHandler(this.btnTimKiemBC_Click);
            // 
            // cbMaTheMuonBC
            // 
            this.cbMaTheMuonBC.FormattingEnabled = true;
            this.cbMaTheMuonBC.Location = new System.Drawing.Point(246, 119);
            this.cbMaTheMuonBC.Name = "cbMaTheMuonBC";
            this.cbMaTheMuonBC.Size = new System.Drawing.Size(121, 28);
            this.cbMaTheMuonBC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(338, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm Kiếm Hồ Sơ Mượn ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // FrmBaoCao9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaTheMuonBC);
            this.Controls.Add(this.btnTimKiemBC);
            this.Controls.Add(this.dataGridViewHSMtheoTM);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCao9";
            this.Text = "FrmBaoCao9";
            this.Load += new System.EventHandler(this.FrmBaoCao9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHSMtheoTM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHSMtheoTM;
        private System.Windows.Forms.Button btnTimKiemBC;
        private System.Windows.Forms.ComboBox cbMaTheMuonBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}