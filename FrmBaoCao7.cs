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
    public partial class FrmBaoCao7 : Form
    {
        public FrmBaoCao7()
        {
            InitializeComponent();
        }

        DataTable Timkiem;

        private void FrmBaoCao7_Load(object sender, EventArgs e)
        {
            ResetValues();
            data_GV.DataSource = null;
            UpdateYear();
        }
        private void ResetValues()
        {
            foreach (RadioButton rdo in groupBox1.Controls)
            {
                rdo.Checked = false;
            }

            foreach (Control cbo in groupBox2.Controls)
            {
                if (cbo is ComboBox)
                {
                    ComboBox cbo1 = (ComboBox)cbo;
                    cbo1.SelectedIndex = -1;
                    cbo1.Enabled = false;
                }
            }
            data_GV.DataSource = null;
            txtDT.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!rdoNam.Checked && !rdoQuy.Checked && !rdoThang.Checked)
            {
                MessageBox.Show("Hay chon mot tuy chon di!");
                return;
            }

            string sql;
            sql = "SELECT * FROM HoSoTra WHERE 1=1 ";
            if (rdoThang.Checked)
            {
                if (cboThang.SelectedIndex == -1 || cboNam.SelectedIndex == -1)
                {
                    MessageBox.Show("Hay chon day du Thang va Nam!");
                    return;
                }

                sql = sql + " AND MONTH(NgayTra) = " + cboThang.Text + " AND YEAR(NgayTra) = " + cboNam.Text + "";
            }

            if (rdoQuy.Checked)
            {
                if (cboQuy.SelectedIndex == -1 || cboNam.SelectedIndex == -1)
                {
                    MessageBox.Show("Hay chon day du Quy va Nam!");
                    return;
                }

                switch (cboQuy.SelectedIndex)
                {
                    case 0:
                        {
                            sql = sql + " AND MONTH(NgayTra) BETWEEN 1 AND 3";
                            break;
                        }
                    case 1:
                        {
                            sql = sql + " AND MONTH(NgayTra) BETWEEN 4 AND 6";
                            break;
                        }
                    case 2:
                        {
                            sql = sql + " AND MONTH(Ngaytra) BETWEEN 7 AND 9";
                            break;
                        }
                    case 3:
                        {
                            sql = sql + " AND MONTH(NgayTra) BETWEEN 10 AND 12";
                            break;
                        }
                }
            }
            

            if (rdoNam.Checked)
            {
                if (cboNam.SelectedIndex == -1)
                {
                    MessageBox.Show("Ban chua chon nam");
                    return;
                }

                sql = sql + " AND YEAR(NgayTra) = " + cboNam.Text + "";
            }


            sql = sql + " AND YEAR(NgayTra) = " + cboNam.Text + "";
            Timkiem = Funtions.LoadDataToTable(sql);

            if (Timkiem.Rows.Count == 0)
            {
                MessageBox.Show("Khong co ban ghi thoa man dieu kien");
                ResetValues();
            }
            else
            {
                MessageBox.Show("Co " + Timkiem.Rows.Count + " ban ghi thoa man");
                data_GV.DataSource = Timkiem;
                Load_DGV();
                UpdateReverage();
            }
        }
        private void Load_DGV()
        {
            string[] Header = new string[6] { "MaHST", "MaHSM", "NgayTra", "TongTien", "SoTienThanhToan","MaThuTHu" };
            for (int i = 0; i < Header.Length; i++)
            {
                data_GV.Columns[i].HeaderText = Header[i];
            }
            data_GV.AllowUserToAddRows = false;
            data_GV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void UpdateYear()
        {
            DataTable tblYEAR;
            string sql;
            sql = "SELECT YEAR(NgayTra) FROM HoSoTra";
            tblYEAR = Funtions.LoadDataToTable(sql);
            for (int i = 0; i < tblYEAR.Rows.Count; i++)
            {
                if (i == 0)
                {
                    cboNam.Items.Add(tblYEAR.Rows[i][0].ToString());
                }
                else
                {
                    for (int j = 0; j < cboNam.Items.Count; j++)
                    {
                        if (cboNam.Items[j].ToString() == tblYEAR.Rows[i][0].ToString())
                        {
                            return;
                        }
                        cboNam.Items.Add(tblYEAR.Rows[i][0].ToString());
                    }
                }
            }
            cboNam.Sorted = true;
        }
      
        private void UpdateReverage()
        {
            double tien = 0;
            for (int i = 0; i < Timkiem.Rows.Count; i++)
            {
                tien += Convert.ToDouble(Timkiem.Rows[i][4].ToString());
            }
            txtDT.Text = tien.ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            data_GV.DataSource = null;
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            cboThang.Enabled = true;
            cboNam.Enabled = true;
            cboQuy.Enabled = false;
        }

        private void rdoQuy_CheckedChanged(object sender, EventArgs e)
        {
            cboThang.Enabled = false;
            cboNam.Enabled = true;
            cboQuy.Enabled = true;
        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            cboThang.Enabled = false;
            cboNam.Enabled = true;
            cboQuy.Enabled = false;
        }
       
    }
}
