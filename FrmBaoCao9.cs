using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTL_Nhom1
{
    public partial class FrmBaoCao9 : Form
    {
        DataTable HSMtheoTM;
        public FrmBaoCao9()
        {
            InitializeComponent();
        }

        private void FrmBaoCao9_Load(object sender, EventArgs e)
        {
            Funtions.Connect();
            Funtions.FillDataToCombo("SELECT distinct MaTheMuon FROM TheMuon", cbMaTheMuonBC, "MaTheMuon");
            cbMaTheMuonBC.SelectedIndex = -1;
        }
        private void loadDataTimKiemHSM()
        {
            Funtions.Connect();
            String SQL = "select MaHSM, TheMuon.MaTheMuon,  TamUng,MaThuThu , NgayMuon From TheMuon join HoSoMuon on TheMuon.MaTheMuon = HoSoMuon.MaTheMuon ";
            HSMtheoTM = Funtions.LoadDataToTable(SQL);
            dataGridViewHSMtheoTM.DataSource = HSMtheoTM;
            dataGridViewHSMtheoTM.Columns[0].HeaderText = " Mã hồ sơ mượn";
            dataGridViewHSMtheoTM.Columns[1].HeaderText = " Mã thẻ mượn ";
            dataGridViewHSMtheoTM.Columns[2].HeaderText = " Tạm ứng";
            dataGridViewHSMtheoTM.Columns[3].HeaderText = " Mã thủ thư";
            dataGridViewHSMtheoTM.Columns[4].HeaderText = " Ngày mượn";
            dataGridViewHSMtheoTM.AllowUserToAddRows = false;
            dataGridViewHSMtheoTM.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimKiemBC_Click(object sender, EventArgs e)
        {
            Funtions.Connect();

            if (cbMaTheMuonBC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã thẻ mượn", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaTheMuonBC.Focus();
                return;
            }
            string SQL = " select MaHSM, TheMuon.MaTheMuon,  TamUng,MaThuThu , NgayMuon From TheMuon join HoSoMuon on TheMuon.MaTheMuon = HoSoMuon.MaTheMuon  Where 1=1";
            if (cbMaTheMuonBC.Text != "")
                SQL = SQL + " AND TheMuon.MaTheMuon Like N'%" + cbMaTheMuonBC.Text + "%'";
            HSMtheoTM = Funtions.LoadDataToTable(SQL);
            dataGridViewHSMtheoTM.DataSource = HSMtheoTM;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridViewHSMtheoTM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
