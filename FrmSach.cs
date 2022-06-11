using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_Nhom1
{
    public partial class FrmSach : Form
    {
       
        public FrmSach()
        {
            InitializeComponent();
        }
       
        private void FrmSach_Load(object sender, EventArgs e)
        {
            
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataToGridview();
            string sqla = "Select MaTheLoai from TheLoai";
            Funtions.FillDataToCombo(sqla, cbMaTheLoai7, "MaTheLoai");
            string sqlb = "Select MaNgonNgu from NgonNgu";
            Funtions.FillDataToCombo(sqlb, cbMaNgonNgu7, "MaNgonNgu");
            string sqlc = "Select MaNXB from NHAXUATBAN";
            Funtions.FillDataToCombo(sqlc, cbMaNXB7, "MaNXB");

        }
        private void LoadDataToGridview()
        {
            string sql = "Select * from Sach";
            DataTable Sach = new DataTable();
            Sach = Funtions.LoadDataToTable(sql);
            dataGridViewS.DataSource = Sach;

            string[] Header = new string[14] { "MaSach", "TenSach", "TenTG", "NamXB", "KhoSach", "GiaSach", "LanTaiBan", "SoTrang","TomTatND","SoLuong","DonGiaThue","MaNgonNgu","MaTheLoai","MaNXB" };
            for (int i = 0; i < Header.Length; i++)
            {
                dataGridViewS.Columns[i].HeaderText = Header[i];
            }
            dataGridViewS.AllowUserToAddRows = false;
            dataGridViewS.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            txtMaSach7.Enabled = true;
            txtMaSach7.Focus();
            ResetValue();

        }
       

        private void dataGridViewS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach7.Text = dataGridViewS.CurrentRow.Cells[0].Value.ToString();
            txtTenSach7.Text = dataGridViewS.CurrentRow.Cells[1].Value.ToString();
            txtTenTG7.Text = dataGridViewS.CurrentRow.Cells[2].Value.ToString();
           // txtNamXB7.Text = dataGridViewS.CurrentRow.Cells[3].Value.ToString();
            txtNamXB7.Text = Funtions.ConvertDateTime(dataGridViewS.CurrentRow.Cells[3].Value.ToString());
            txtKhoSach7.Text = dataGridViewS.CurrentRow.Cells[4].Value.ToString();
            txtGiaSach7.Text = dataGridViewS.CurrentRow.Cells[5].Value.ToString();
            txtLanTaiBan7.Text = dataGridViewS.CurrentRow.Cells[6].Value.ToString();
            txtSoTrang7.Text = dataGridViewS.CurrentRow.Cells[7].Value.ToString();
            txtTomTat7.Text = dataGridViewS.CurrentRow.Cells[8].Value.ToString();
            txtSoLuong7.Text = dataGridViewS.CurrentRow.Cells[9].Value.ToString();
            txtDonGia7.Text = dataGridViewS.CurrentRow.Cells[10].Value.ToString();
            cbMaNgonNgu7.Text = dataGridViewS.CurrentRow.Cells[11].Value.ToString();
            cbMaTheLoai7.Text = dataGridViewS.CurrentRow.Cells[12].Value.ToString();
            cbMaNXB7.Text = dataGridViewS.CurrentRow.Cells[13].Value.ToString();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach7.Focus();
                return;
            }
            if (txtTenSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach7.Focus();
                return;
            }
            if (txtTenTG7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên tác giả ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG7.Focus();
                return;
            }
            if (txtNamXB7.Text.Trim() == "  /  /  ")
            {
                MessageBox.Show("Bạn phải nhập năm xuất bản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXB7.Focus();
                return;
            }
            if (txtGiaSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSach7.Focus();
                return;
            }
            if (txtSoLuong7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong7.Focus();
                return;
            }
            if (txtSoTrang7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số trang ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTrang7.Focus();
                return;
            }
            if (txtKhoSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập khổ sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoSach7.Focus();
                return;
            }
            if (txtDonGia7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá thuê ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia7.Focus();
                return;
            }
            if (txtLanTaiBan7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập khổ sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanTaiBan7.Focus();
                return;
            }
            if (cbMaNgonNgu7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaNgonNgu7.Focus();
                return;
            }
            if (cbMaNXB7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaNXB7.Focus();
                return;
            }
            if (cbMaTheLoai7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã thể loại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaTheLoai7.Focus();
                return;
            }
            if (txtTomTat7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tóm tắt ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTomTat7.Focus();
                return;
            }

            string sql = "SELECT MaSach FROM Sach WHERE MaSach = '" + txtMaSach7.Text + "'";
            if (Funtions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach7.Focus();
                txtMaSach7.Text = "";
                return;
            }

            if (!Funtions.CheckKey(sql))
            {
                try
                {
                    sql = "INSERT INTO Sach( MaSach,TenSach, TenTG , NamXB , KhoSach , GiaSach , LanTaiBan , SoTrang , TomTatND , SoLuong , DonGiaThue , MaNgonNgu , MaTheLoai , MaNXB) " +
                        "VALUES(N'" + txtMaSach7.Text + "', '" + txtTenSach7.Text + "' , '" + txtTenTG7.Text + "','" + txtNamXB7.Text + "','" + txtKhoSach7.Text + "',"+ float.Parse(txtGiaSach7.Text) + ",'" +
                         float.Parse(txtLanTaiBan7.Text) + "','" + float.Parse(txtSoTrang7.Text) + "','" + txtTomTat7 + "','" + float.Parse(txtSoLuong7.Text) + "','" + float.Parse(txtDonGia7.Text) + "','" + cbMaNgonNgu7.Text + "','" + cbMaTheLoai7.Text + "','" + cbMaNXB7.Text + "' )";

                    SqlCommand myCommand = new SqlCommand(sql, Funtions.con);                     // Khai báo đối tượng SqlCommand
                    myCommand.ExecuteNonQuery();
                    LoadDataToGridview();


                    //Sau khi thuc hien thanh cong thi lai hien cac nut len de su dung tiep
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Enabled = false;
                    txtMaSach7.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE from Sach WHERE MaSach = '" + txtMaSach7.Text + "'";
                    SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
                    myCommand.ExecuteNonQuery();
                    LoadDataToGridview();

                    ResetValue();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!" + ex.Message);
                }
            }
        }

        /* private void btnSua_Click(object sender, EventArgs e)
         {
             try 
             {

                 string sql = "update  Sach set TenSach= N'"+ txtTenSach7.Text.Trim().ToString() +"', TenTG= N'" + txtTenTG7.Text.Trim().ToString() + "', NamXB='" + txtNamXB7.Text.Trim().ToString() + "', KhoSach= N'" + txtKhoSach7.Text.Trim().ToString() + "' , GiaSach ='" +float.Parse( txtGiaSach7.Text) + "', LanTaiBan='" + float.Parse(txtLanTaiBan7.Text) + "' , SoTrang ='" + float.Parse(txtSoTrang7.Text) + "', TomTatND=N'" + txtTomTat7.Text.Trim().ToString() + "' , SoLuong= '" + float.Parse(txtSoLuong7.Text) + "', DonGiaThue ='" + float.Parse(txtDonGia7.Text) + "', MaNgonNgu ='" + cbMaNgonNgu7.Text.Trim().ToString() + "', MaTheLoai= '" + cbMaTheLoai7.Text.Trim().ToString() + "' , MaNXB='" + cbMaNXB7.Text.Trim().ToString() + "' WHERE MaSach =N '" + txtMaSach7.Text.Trim().ToString() + "'"; 
                 SqlCommand myCommand = new SqlCommand(sql, DAO.con);
                 myCommand.ExecuteNonQuery();
                 LoadDataToGridview();
             }
            catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
            }
         }*/
        private void btnSua_Click(object sender, EventArgs e)
        {
           

            if (txtMaSach7.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào");
                txtMaSach7.Focus();
                return;
            }

            if (txtTenSach7.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txtTenSach7.Focus();
                return;
            }
            if (txtTenTG7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên tác giả ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTG7.Focus();
                return;
            }
            if (txtNamXB7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập năm xuất bản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamXB7.Focus();
                return;
            }
            if (txtGiaSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaSach7.Focus();
                return;
            }
            if (txtSoLuong7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong7.Focus();
                return;
            }
            if (txtSoTrang7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số trang ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTrang7.Focus();
                return;
            }
            if (txtKhoSach7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập khổ sách ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoSach7.Focus();
                return;
            }
            if (txtDonGia7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá thuê ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia7.Focus();
                return;
            }
            if (txtLanTaiBan7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập lần tài bản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLanTaiBan7.Focus();
                return;
            }
            if (cbMaNgonNgu7.SelectedIndex == -1 )
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaNgonNgu7.Focus();
                return;
            }
            if (cbMaNXB7.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaNXB7.Focus();
                return;
            }
            if (cbMaTheLoai7.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaTheLoai7.Focus();
                return;
            }
            if (txtTomTat7.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tóm tắt ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTomTat7.Focus();
                return;
            }
            //, mtl, mnxb, mnn;

            /* sql = "SELECT MaTheLoai FROM THELOAI WHERE MaTheLoai = N'" + cbMaTheLoai7.Text + "'";
             mtl = DAO.GetFieldValues(sql);

             sql = "SELECT MaNXB FROM NHAXUATBAN WHERE MaNXB = N'" + cbMaNXB7.Text + "'";
             mnxb = DAO.GetFieldValues(sql);

             sql = "SELECT Mangonngu FROM Ngonngu WHERE Mangonngu = N'" + cbMaNgonNgu7.Text + "'";
             mnn = DAO.GetFieldValues(sql);
             try
             {
                 string sql = "UPDATE Sach SET  TenSach= N'" + txtTenSach7.Text.Trim() + "', TenTG= N'" + txtTenTG7.Text.Trim() + "', NamXB='" + txtNamXB7.Text.Trim() + "', KhoSach= N'" + txtKhoSach7.Text.Trim() + "' , GiaSach ='" + txtGiaSach7.Text.Trim() + "', LanTaiBan='" + txtLanTaiBan7.Text.Trim() + "' , SoTrang ='" + txtSoTrang7.Text.Trim() + "', TomTatND=N'" + txtTomTat7.Text.Trim() + "' , SoLuong= '" + txtSoLuong7.Text.Trim() + "', DonGiaThue ='" + txtDonGia7.Text.Trim() + "', MaNgonNgu ='" + cbMaNgonNgu7.Text.Trim() + "', MaTheLoai= '" + cbMaTheLoai7.Text.Trim() + "' , MaNXB='" + cbMaNXB7.Text.Trim() + "' WHERE MaSach =N '" + txtMaSach7.Text.Trim().ToString() + "'";
                 SqlCommand myCommand = new SqlCommand(sql, DAO.con);
                 myCommand.ExecuteNonQuery();
                 LoadDataToGridview();
             }
             catch( Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
            Funtions.Connect();
            string sql2 = "UPDATE Sach SET  TenSach= N'"+ txtTenSach7.Text + "', TenTG= N'" + txtTenTG7.Text + "', NamXB='" + txtNamXB7.Text + "', KhoSach= N'" + txtKhoSach7.Text + "' , GiaSach ='" + txtGiaSach7.Text + "', LanTaiBan='" + txtLanTaiBan7.Text + "' , SoTrang ='" + txtSoTrang7.Text+ "', TomTatND=N'" + txtTomTat7.Text + "' , SoLuong= '" + txtSoLuong7.Text + "', DonGiaThue ='" + txtDonGia7.Text + "', MaNgonNgu ='" + cbMaNgonNgu7.Text + "', MaTheLoai= '" + cbMaTheLoai7.Text + "' , MaNXB='" + cbMaNXB7.Text + "' WHERE MaSach ='" + txtMaSach7.Text+ "'";
            SqlCommand myCommandx = new SqlCommand(sql2, Funtions.con);
            myCommandx.ExecuteNonQuery();
            //MessageBox.Show(sql2);
            LoadDataToGridview();
            //ResetValue();
           // btnBoQua.Enabled = false;

        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        private void ResetValue()
        {
            txtMaSach7.Text = "";
            txtTenSach7.Text = "";
            txtTenTG7.Text = "";
            txtNamXB7.Text = "";
            txtKhoSach7.Text = "";
            txtGiaSach7.Text = "";
            txtLanTaiBan7.Text = "";
            txtSoTrang7.Text = "";
            txtTomTat7.Text = "";
           
            txtSoLuong7.Text = "";
            txtDonGia7.Text = "";
        
            
            cbMaNgonNgu7.Text = "";
            cbMaTheLoai7.Text = "";
            cbMaNXB7.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNamXB7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewS_Click(object sender, EventArgs e)
        {

        }
    }
}
