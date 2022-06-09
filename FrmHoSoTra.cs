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
    public partial class FrmHoSoTra : Form
    {
        public FrmHoSoTra()
        {
            InitializeComponent();
        }

        private void groupHST_Enter(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataToGridviewHST();
            string sqla = "Select MaHSM  from HoSoMuon";
            Funtions.FillDataToCombo(sqla, cbMaHSM2, "MaHSM");
            string sqlb = "Select MaThuThu from ThuThu";
            Funtions.FillDataToCombo(sqlb, cbMaThuThu2, "MaThuThu");
            
        }
        private void LoadDataToGridviewHST()
        {
            string sql = "Select * from HoSoTra";
            DataTable HoSoTra = new DataTable();
            HoSoTra = Funtions.LoadDataToTable(sql);
            dataGridViewHST.DataSource = HoSoTra;
        }

        private void groupCTSHT_Enter(object sender, EventArgs e)
        {
            btnLuu9.Enabled = false;
            btnBoQua9.Enabled = false;
            LoadDataToGridviewCTHST();
            string sqla = "Select MaHST from HoSoTra";
            Funtions.FillDataToCombo(sqla, cbMaHST9, "MaHST");
            string sqlb = "Select MaSach from Sach";
            Funtions.FillDataToCombo(sqlb, cbMaSach9, "MaSach");
            string sqlc = "Select MaViPham from ViPham";
            Funtions.FillDataToCombo(sqlc, cbMaViPham9, "MaViPham");
        }
        private void LoadDataToGridviewCTHST()
        {
            string sql = "Select * from ChiTietHST where mahst='"+txtMaHST2.Text+"'";
            DataTable ChiTietHST = new DataTable();
            ChiTietHST = Funtions.LoadDataToTable(sql);
            dataGridViewCTHST.DataSource = ChiTietHST;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            txtMaHST2.Text = "";
            cbMaThuThu2.Text = "";
            cbMaHSM2.Text = "";
            
            txtSoTienThanhToan2.Text = "";
            txtTongTien2.Text = "";
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from  hosotra  where mahst= '" + txtMaHST2.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewHST();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaHST FROM HoSoTra WHERE MaHST = '" + txtMaHST2.Text + "'";
            if (Funtions.CheckKey(sql))
            {
                MessageBox.Show("Mã hồ sơ trả này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHST2.Focus();
                txtMaHST2.Text = "";
                return;
            }

            if (!Funtions.CheckKey(sql))
            {
                try
                {
                    Funtions.Connect();
                    string sql2;
                    sql2 = "INSERT INTO HoSoTra(MaHST,MaHSM, NgayTra , TongTien , SoTienThanhToan , MaThuThu) VALUES('" + txtMaHST2.Text + "', '" + cbMaHSM2.Text + "' , '" + dateTimePicker2.Text + "','" + txtTongTien2.Text + "','" + txtSoTienThanhToan2.Text + "','"+cbMaThuThu2.Text +"')";

                    SqlCommand myCommand = new SqlCommand(sql2, Funtions.con);                     // Khai báo đối tượng SqlCommand
                    myCommand.ExecuteNonQuery();
                    LoadDataToGridviewHST();


                    //Sau khi thuc hien thanh cong thi lai hien cac nut len de su dung tiep
                    /*  btnXoa.Enabled = true;
                      btnThem.Enabled = true;
                      btnSua.Enabled = true;
                      btnLuu.Enabled = false;*/
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void dataGridViewHST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHST2.Text = dataGridViewHST.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker2.Text = dataGridViewHST.CurrentRow.Cells[2].Value.ToString();
            cbMaHSM2.Text = dataGridViewHST.CurrentRow.Cells[1].Value.ToString();
            cbMaThuThu2.Text = dataGridViewHST.CurrentRow.Cells[5].Value.ToString();
            txtTongTien2.Text= dataGridViewHST.CurrentRow.Cells[3].Value.ToString();
            txtSoTienThanhToan2.Text = dataGridViewHST.CurrentRow.Cells[4].Value.ToString();
            LoadDataToGridviewCTHST();

        }

        private void dataGridViewCTHST_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaHST9.Text = dataGridViewCTHST.CurrentRow.Cells[0].Value.ToString();
            cbMaSach9.Text = dataGridViewCTHST.CurrentRow.Cells[1].Value.ToString();
            cbMaViPham9.Text = dataGridViewCTHST.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dataGridViewCTHST.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void FrmHoSoTra_Load(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update hosotra set MaHSM='" + cbMaHSM2.Text + "',NgayTra ='" + dateTimePicker2.Text + "',tongtien ='" + txtTongTien2.Text + "', sotienthanhtoan='" + txtSoTienThanhToan2.Text + "', mathuthu='" + cbMaThuThu2.Text + " ' where mahst= '" + txtMaHST2.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewHST();
        }

        private void btnThem9_Click(object sender, EventArgs e)
        {
            btnLuu9.Enabled = true;
            btnBoQua9.Enabled = true;
        }

        private void btnXoa9_Click(object sender, EventArgs e)
        {
            string sql = "delete from chitiethst where mahst= '" + txtMaHST2.Text + "'and masach='"+cbMaSach9.Text+"'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewCTHST();
        }

        private void btnSua9_Click(object sender, EventArgs e)
        {
            string sql = "update chitiethst set MaviPHAM='" + cbMaViPham9.Text + "',thanhtien ='" + txtThanhTien.Text + "' where mahst= '" + txtMaHST2.Text + "'and masach='" + cbMaSach9.Text + "'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridviewCTHST();
        }

        private void btnLuu9_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into chitiethst (mahst,masach,thanhtien,mavipham) values('" + cbMaHST9.Text + "','" + cbMaSach9.Text + "','" + txtThanhTien.Text + "','" + cbMaViPham9.Text + "')";
                SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
                myCommand.ExecuteNonQuery();
                LoadDataToGridviewCTHST();
                string sql2, sql3;
                sql2 = "update themuon set soluongmuon= soluongmuon-1 where mathemuon= (select mathemuon from hosomuon where mahsm='" + cbMaHSM2.Text + "')";
                SqlCommand myCommand2 = new SqlCommand(sql2, Funtions.con);
                myCommand2.ExecuteNonQuery();
                sql3 = "update sach set soluong = soluong +1 where masach='"+cbMaSach9.Text+"'";
                SqlCommand myCommand3 = new SqlCommand(sql3, Funtions.con);
                myCommand3.ExecuteNonQuery();
            }
            catch (Exception ex)
           {
                MessageBox.Show("Khong the luu");
          }
           
        }

        private void btnBoQua9_Click(object sender, EventArgs e)
        {
            btnLuu9.Enabled = false;
            btnBoQua9.Enabled = false;
            cbMaHST9.Text = "";
            cbMaSach9.Text = "";
            cbMaViPham9.Text = "";
            txtThanhTien.Text = "";
        }

        private void btnDong9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
