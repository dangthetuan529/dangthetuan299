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
    public partial class FrmTheMuon : Form
    {
        public FrmTheMuon()
        {
            InitializeComponent();
        }

        private void FrmTheMuon_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataToGridview();
            string sqla = "Select MaQue from Que";
            Funtions.FillDataToCombo(sqla, cbMaQue4, "MaQue");
            string sqlb = "Select MaDanToc from DanToc";
            Funtions.FillDataToCombo(sqlb, cbMaDanToc4, "MaDanToc");
        }
        private void LoadDataToGridview()
        {
            string sql = "Select * from TheMuon";
            DataTable TheMuon = new DataTable();
            TheMuon = Funtions.LoadDataToTable(sql);
            dataGridViewTM.DataSource = TheMuon;
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
        private void Reset_Values()
        {
            txtMaThe4.Clear();
            txtHoTen4.Clear();
            txtGioiTinh.Clear();
            txtNgaySinh4.Clear();
            txtDiaChi4.Clear();
            txtCMT4.Clear();
            txtNgayLamThe4.Clear();
            txtNgayHetHan4.Clear();
            cbMaQue4.SelectedIndex = -1;
            cbMaDanToc4.SelectedIndex = -1;
      
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            Reset_Values();
            txtMaThe4.Enabled = true;
            txtMaThe4.Focus();
        }

        private void dataGridViewTM_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaThe4.Text = dataGridViewTM.CurrentRow.Cells[0].Value.ToString();
            txtHoTen4.Text = dataGridViewTM.CurrentRow.Cells[1].Value.ToString();
            txtGioiTinh.Text = dataGridViewTM.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh4.Text = dataGridViewTM.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi4.Text = dataGridViewTM.CurrentRow.Cells[4].Value.ToString();
            txtCMT4.Text = dataGridViewTM.CurrentRow.Cells[5].Value.ToString();
            txtNgayLamThe4.Text = dataGridViewTM.CurrentRow.Cells[6].Value.ToString();
            txtNgayHetHan4.Text = dataGridViewTM.CurrentRow.Cells[7].Value.ToString();
            txtSoLuongMuon.Text = dataGridViewTM.CurrentRow.Cells[8].Value.ToString();
            cbMaQue4.Text = dataGridViewTM.CurrentRow.Cells[9].Value.ToString();
            cbMaDanToc4.Text = dataGridViewTM.CurrentRow.Cells[10].Value.ToString();
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (txtMaThe4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaThe4.Focus();
                return;
            }
            if (txtHoTen4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen4.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGioiTinh.Focus();
                return;
            }
            if (txtNgaySinh4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh4.Focus();
                return;
            }
            if (txtDiaChi4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi4.Focus();
                return;
            }
            if (txtCMT4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập CMT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCMT4.Focus();
                return;
            }
            if (txtNgayLamThe4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày làm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayLamThe4.Focus();
                return;
            }
            if (txtNgayHetHan4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayHetHan4.Focus();
                return;
            }
            if (txtSoLuongMuon.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongMuon.Focus();
                return;
            }
            if (cbMaQue4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã quê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMaQue4.Focus();
                return;
            }
            if (cbMaDanToc4.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMaDanToc4.Focus();
                return;
            }
            
              string sql = "SELECT MaTheMuon FROM TheMuon WHERE MaTheMuon=N'" + txtMaThe4.Text.Trim() + "'";

            if (Funtions.CheckKey(sql))
            {
                MessageBox.Show("Mã thẻ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaThe4.Focus();
                txtMaThe4.Text = "";
                return;
            }

            if (!Funtions.CheckKey(sql))
            {
                try
                {
                    sql = "INSERT INTO TheMuon (MaTheMuon,HoTen,Gioitinh, NgaySinh, DiaChiHienTai , CMTND , NgayLamThe , NgayHetHan , SoLuongMuon , MaQue , MaDanToc) " +
                  "VALUES(N'" + txtMaThe4.Text.Trim() + "', N'" + txtHoTen4.Text.Trim() + "', N'" + txtGioiTinh.Text.Trim() + "', N'" + txtNgaySinh4.Text.Trim() + "', N'" + txtDiaChi4.Text.Trim() + "',N'" + txtCMT4.Text.Trim() + "',N'" + txtNgayLamThe4.Text.Trim() + "',N'" + txtNgayHetHan4.Text.Trim() + "',N'" + txtSoLuongMuon.Text.Trim() + "',N'" + cbMaQue4.Text.Trim() + "',N'" + cbMaDanToc4.Text.Trim() + "')";

                    SqlCommand myCommand = new SqlCommand(sql, Funtions.con);                     // Khai báo đối tượng SqlCommand
                    myCommand.ExecuteNonQuery();
                    LoadDataToGridview();
                    Reset_Values();


                    //Sau khi thuc hien thanh cong thi lai hien cac nut len de su dung tiep
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnBoQua.Enabled = false;
                    btnLuu.Enabled = false;
                    txtMaThe4.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



           /* sql = "SELECT MaTheMuon FROM TheMuon WHERE MaTheMuon=N'" + txtMaThe4.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã thẻ này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaThe4.Focus();
                txtMaThe4.Text = "";
                return;
            }
            sql = "INSERT INTO TheMuon (MaTheMuon,HoTen,Gioitinh, NgaySinh, DiaChiHienTai , CMTND , NgayLamThe , NgayHetHan , SoLuongMuon , MaQue , MaDanToc) " +
                "VALUES(N'" +txtMaThe4.Text.Trim() + "', N'" + txtHoTen4.Text.Trim() + "', N'" + txtGioiTinh.Text.Trim() + "', N'" + txtNgaySinh4.Text.Trim() + "', N'" + txtDiaChi4.Text.Trim() + "',N'" + txtCMT4.Text.Trim()+"',N'"+ txtNgayLamThe4.Text.Trim()+ "',N'"+ txtNgayHetHan4.Text.Trim()+"',N'"+ txtSoLuongMuon.Text.Trim()+"',N'"+cbMaQue4.Text.Trim()+"',N'"+cbMaDanToc4.Text.Trim()+"'";

            DAO.RunSQL(sql);
            LoadDataToGridview();
            Reset_Values();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaThe4.Enabled = false;*/
        }

        
        private void btnXoa_Click(object sender, EventArgs e)
        {
           string sql;
            //if (TheMuon.Rows.Count == 0)
           // {
             //   MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  return;
            //}
            if (txtMaThe4.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete TheMuon where MaTheMuon=N'" + txtMaThe4.Text + "'";
                SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
                myCommand.ExecuteNonQuery();
                LoadDataToGridview();
                Reset_Values();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update themuon set hoten=N'"+txtHoTen4.Text+"', gioitinh=N'"+txtGioiTinh.Text+"',ngaysinh='"+txtNgaySinh4.Text+"',diachihientai=N'"+txtDiaChi4.Text+"',cmtnd=N'"+txtCMT4.Text+"',ngaylamthe='"+txtNgayLamThe4.Text+"',ngayhethan='"+txtNgayHetHan4.Text+"',soluongmuon='"+txtSoLuongMuon.Text+"',maque='"+cbMaQue4.Text+"',madantoc='"+cbMaDanToc4.Text+"' where mathemuon='"+txtMaThe4.Text+"'";
            SqlCommand myCommand = new SqlCommand(sql, Funtions.con);
            myCommand.ExecuteNonQuery();
            LoadDataToGridview();
           // Reset_Values();
        }
    }
}
