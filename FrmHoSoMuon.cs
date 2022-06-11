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
    public partial class FrmHoSoMuon : Form
    {
        public FrmHoSoMuon()
        {
            InitializeComponent();
        }
        private void FrmHoSoMuon_Load(object sender, EventArgs e)
        {

        }
        
        private void groupHSM_Enter(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataToGridviewHSM();
            string sqla = "Select MaTheMuon from TheMuon";
            Funtions.FillDataToCombo(sqla, cbMaTheMuon3, "MaTheMuon");
            string sqlb = "Select MaThuThu from ThuThu";
            Funtions.FillDataToCombo(sqlb, cbMaThuThu3, "MaThuThu");
        }
        private void LoadDataToGridviewHSM()
        {
            string sql = "Select * from HoSoMuon";
            DataTable HoSoMuon = new DataTable();
            HoSoMuon = Funtions.LoadDataToTable(sql);
            dataGridViewHSM.DataSource = HoSoMuon;
            LoadDataToGridviewCTHSM();
        }
        private void dataGridViewHSM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHSM3.Text = dataGridViewHSM.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridViewHSM.CurrentRow.Cells[1].Value.ToString();
            txtTamUng3.Text = dataGridViewHSM.CurrentRow.Cells[2].Value.ToString();
            cbMaTheMuon3.Text = dataGridViewHSM.CurrentRow.Cells[4].Value.ToString();
            cbMaThuThu3.Text = dataGridViewHSM.CurrentRow.Cells[3].Value.ToString();
            LoadDataToGridviewCTHSM();
        }

        private void groupBoxCTHSM_Enter(object sender, EventArgs e)
        {

            btnLuu7.Enabled = false;
            btnBoqua7.Enabled = false;
            LoadDataToGridviewCTHSM();
            string sqlc = "Select MaHSM from HoSoMuon";
            Funtions.FillDataToCombo(sqlc, cbMaHSM7, "MaHSM");
            string sqld = "Select MaSach from Sach";
            Funtions.FillDataToCombo(sqld, cbMaSach7, "MaSach");
        }
        private void LoadDataToGridviewCTHSM()
        {
            string sql = "Select * from ChiTietHSM where mahsm='"+txtMaHSM3.Text+"'";
            DataTable ChiTietHSM = new DataTable();
            ChiTietHSM = Funtions.LoadDataToTable(sql);
            dataGridViewCTHSM.DataSource = ChiTietHSM;
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHSM3.Text = "";
            cbMaTheMuon3.Text = "";
            cbMaThuThu3.Text = "";
            txtTamUng3.Text = "";
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaHSM FROM HoSoMuon WHERE MaHSM = '" + txtMaHSM3.Text + "'";
            if (Funtions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHSM3.Focus();
                txtMaHSM3.Text = "";
                return;
            }

            if (!Funtions.CheckKey(sql))
            {
                try
                {
                    Funtions.Connect();
                    string sql2;
                    sql2 = "INSERT INTO HoSoMuon(MaHSM,NgayMuon, TamUng , MaThuThu , MaTheMuon) VALUES('" + txtMaHSM3.Text + "', '" + dateTimePicker1.Text + "' , '" + txtTamUng3.Text + "','" + cbMaThuThu3.Text + "','" + cbMaTheMuon3.Text + "')";

                    SqlCommand myCommand = new SqlCommand(sql2, Funtions.con);                     // Khai báo đối tượng SqlCommand
                    myCommand.ExecuteNonQuery();
                    LoadDataToGridviewHSM();


                    //Sau khi thuc hien thanh cong thi lai hien cac nut len de su dung tiep
                    /*  btnXoa.Enabled = true;
                      btnThem.Enabled = true;
                      btnSua.Enabled = true;
                      btnLuu.Enabled = false;*/
                }

                catch (Exception ex) 
                {
                    MessageBox.Show("Khong the them!");
                }
                
               
            }
        }

        private void btnThem7_Click(object sender, EventArgs e)
        {
            btnLuu7.Enabled = true;
            btnBoqua7.Enabled = true;

        }
        //ham kiem tra the muon co thoa man yeu cau khong
        public bool KiemtraTheMuon(String mahosomuon)
        {
            string sql = "Select soluongmuon,ngayhethan from themuon where mathemuon=(select mathemuon from hosomuon where mahsm='" + mahosomuon + "')";
            DataTable themuon = new DataTable();
            themuon = Funtions.LoadDataToTable(sql);
            int soluong;
            DateTime hsd;
            soluong =int.Parse(themuon.Rows[0][0].ToString());
            hsd = DateTime.Parse(themuon.Rows[0][1].ToString());
            
            if(hsd<DateTime.Now|| soluong > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool KiemtraSach(string masach)
        {
            string sql = "Select soluong from sach where masach='" + masach + "'";
            DataTable sach = new DataTable();
            sach = Funtions.LoadDataToTable(sql);
            int soluong;
            soluong = int.Parse(sach.Rows[0][0].ToString());
            if(soluong>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }    
        private void btnLuu7_Click(object sender, EventArgs e)
        {
            try
            {
                if(KiemtraSach(cbMaSach7.Text)==false||KiemtraTheMuon(cbMaHSM7.Text)==false)
                {
                    MessageBox.Show("Khong du dieu kien muon sach!");

                }
                else
                {
                    Funtions.Connect();
                    string sql2;
                    sql2 = "INSERT INTO ChiTietHSM(MaHSM,MaSach, TinhTrang ) VALUES('" + cbMaHSM7.Text + "', '" + cbMaSach7.Text + "' , N'" + cbTinhTrang.Text + "')";
                    SqlCommand myCommand = new SqlCommand(sql2, Funtions.con);
                    myCommand.ExecuteNonQuery();
                    

                   // LoadDataToGridviewHSM();
                    LoadDataToGridviewCTHSM();
                    string sql3, sql4;
                   Funtions.Connect();
                    sql3 = "update themuon set soluongmuon= soluongmuon + 1 where mathemuon=(select mathemuon from hosomuon where mahsm='" + cbMaHSM7.Text + "')";
                    MessageBox.Show(sql3);
                    SqlCommand myCommand2 = new SqlCommand(sql3, Funtions.con);
                    myCommand2.ExecuteNonQuery();
                    Funtions.Connect();
                    sql4 = "update sach set soluong= soluong-1 where masach='" + cbMaSach7.Text.Trim() + "'";
                    SqlCommand myCommand3 = new SqlCommand(sql4, Funtions.con);                    
                    myCommand3.ExecuteNonQuery();
                }
                
           }
           catch(Exception ex)
            {
                MessageBox.Show("Khong thanh cong!");
                }
                


                //Sau khi thuc hien thanh cong thi lai hien cac nut len de su dung tiep
                /*  btnXoa.Enabled = true;
                  btnThem.Enabled = true;
                  btnSua.Enabled = true;
                  btnLuu.Enabled = false;*/

            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaHSM3.Text = "";
            cbMaTheMuon3.Text = "";
            cbMaThuThu3.Text = "";
            txtTamUng3.Text = "";
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }
        private void ResetValueHSM()
        {
            txtMaHSM3.Text = "";
            cbMaTheMuon3.Text = "";
            cbMaThuThu3.Text = "";
            txtTamUng3.Text = "";
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }
        private void ResetValueCTHSM()
        {
            cbMaHSM7.Text = "";
            cbMaSach7.Text = "";
            cbTinhTrang.Text = "";
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql = "update hosomuon set ngaymuon='"+dateTimePicker1.Text+"',tamung='"+txtTamUng3.Text+"',mathuthu='"+cbMaThuThu3.Text+"',mathemuon='"+cbMaTheMuon3.Text+"' where mahsm= '"+txtMaHSM3.Text+"'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewHSM();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from hosomuon  where mahsm= '" + txtMaHSM3.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewHSM();
            ResetValueHSM();
        }

        private void btnXoa7_Click(object sender, EventArgs e)
        {
            Funtions.Connect();
            string sqlnew = "delete from chitiethsm  where mahsm= '" + cbMaHSM7.Text + "' and masach= '" +cbMaSach7.Text+ "'";
            SqlCommand myCommand2 = new SqlCommand(sqlnew, Funtions.con);
            myCommand2.ExecuteNonQuery();
            LoadDataToGridviewCTHSM();
            ResetValueCTHSM();
        }

        private void btnDong7_Click(object sender, EventArgs e)
        {
            DialogResult dlg = new DialogResult();
            dlg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBoqua7_Click(object sender, EventArgs e)
        {
            ResetValueCTHSM();
            btnLuu7.Enabled = false;
            btnBoqua7.Enabled = false;
        }

        private void btnSua7_Click(object sender, EventArgs e)
        {
            string sql = "update chitiethsm set tinhtrang=N'" + cbTinhTrang.Text + "' where mahsm= '" + cbMaHSM7.Text + "'and masach='"+cbMaSach7.Text+"'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewCTHSM();
        }

        private void dataGridViewCTHSM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbTinhTrang.Text = dataGridViewCTHSM.CurrentRow.Cells[2].Value.ToString();
            cbMaHSM7.Text = dataGridViewCTHSM.CurrentRow.Cells[0].Value.ToString();
            cbMaSach7.Text = dataGridViewCTHSM.CurrentRow.Cells[1].Value.ToString();

        }

        private void dataGridViewHSM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
