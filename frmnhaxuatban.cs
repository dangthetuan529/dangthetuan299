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
namespace BTL_Nhom1
{
    public partial class frmnhaxuatban : Form
    {
        DataTable tblNXB;
        public frmnhaxuatban()
        {
            InitializeComponent();
        }

        private void frmnhaxuatban_Load(object sender, EventArgs e)
        {
            txtMaNXB5.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Load_DataGridView();
            
            
            ResetValues();

        }
        private void ResetValues()
        {
            txtMaNXB5.Text = "";
            txtTenNXB5.Text = "";
            txtDiaChi5.Text = "";
           txtDienThoai5.Text = "";
            txtMail5.Text = "";
            txtMaNXB5.Focus();  



        }
        private void Load_DataGridView()
        {
          /*  string sql;
            sql = "SELECT * FROM NHAXUATBAN";

            tblNXB = Functions.GetDataToTable(sql);
           // NXBdataGridview.DataSource = tblNXB;
            DataGridView.Columns[0].HeaderText = "Mã hàng";
            DataGridView.Columns[1].HeaderText = "Tên hàng";
            DataGridView.Columns[2].HeaderText = "Chất liệu";
            DataGridView.Columns[3].HeaderText = "Số lượng";
            DataGridView.Columns[4].HeaderText = "Đơn giá nhập";
            DataGridView.Columns[5].HeaderText = "Đơn giá bán";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 140;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;*/
        }



    }
}
