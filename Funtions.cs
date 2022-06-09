using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BTL_Nhom1
{
    internal class Funtions
    {
        private static string ConnectionString = "Data Source = DESKTOP-VUN3CO5\\EQLEXPRESS; " +
                                         "Initial Catalog = QuanLyThuVien ;" +
                                         "Integrated Security = True";

        public static SqlConnection con = new SqlConnection(ConnectionString);

        public static void Connect()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Close()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable LoadDataToTable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            return mytable;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void FillDataToCombo(string sql, ComboBox cb, string ma)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            cb.DataSource = mytable;
            cb.ValueMember = ma;
            
        }
        public static void RunSQL(string SQL)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = SQL;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string GetFieldValues(string sql)
        {
            string value = "";
            SqlCommand sc = new SqlCommand(sql, con);
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
                value = sdr.GetValue(0).ToString();
            }
            sdr.Close();
            return value;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static bool Login(string userName, string userPassword)
        {
            Connect();
            DataTable tbl = new DataTable();
            string query;

           
            query = "SELECT * FROM DangNhap WHERE TenDangNhap = N'" + userName + "' AND MatKhau = N'" + userPassword + "'"; //-- SQL Injection
                                                                                                                            //try
                                                                                                                            //{
            tbl = LoadDataToTable(query);
            

            if (tbl.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
