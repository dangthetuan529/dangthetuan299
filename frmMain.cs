using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Ban co muon thoat khong ?",
                 "canh bao !", MessageBoxButtons.OKCancel) == DialogResult.OK) ;
            Application.Exit();
            Funtions.Close();
        }

        private void tsSach_Click(object sender, EventArgs e)
        {
            FrmSach frm = new FrmSach();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Funtions.Connect();
        }

        private void tsTheMuon_Click(object sender, EventArgs e)
        {
            FrmTheMuon frm = new FrmTheMuon();
            frm.ShowDialog();
        }

        private void HoSoMuon_Click(object sender, EventArgs e)
        {
            FrmHoSoMuon frm = new FrmHoSoMuon();
            frm.ShowDialog();
        }

        private void HoSoTra_Click(object sender, EventArgs e)
        {
            FrmHoSoTra frm = new FrmHoSoTra();
            frm.ShowDialog();
        }

     
        private void mãHSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCao7 frm = new FrmBaoCao7();
            frm.ShowDialog();
        }

        private void tsDanhSachHSMtheoTM_Click(object sender, EventArgs e)
        {
            FrmBaoCao9 frm = new FrmBaoCao9();
            frm.ShowDialog();
        }
    }
}
