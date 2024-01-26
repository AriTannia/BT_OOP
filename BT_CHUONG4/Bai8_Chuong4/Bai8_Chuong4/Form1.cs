using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Chuong4
{
    public partial class Form1 : Form
    {
        static string machinename = Environment.MachineName;
        static string connectionString = ConfigurationManager.ConnectionStrings["MTconnectionString"]
            .ConnectionString.Replace("MINHTAN234", machinename);
        static DataTable dtb = new DataTable();
        static string Malo = "";
        static DataTable dt_phu = new DataTable();
        static int Click_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TenLoai FROM LoaiSanPham";
                using(SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                cbxLoaiSP.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void cbxLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dtb.Clear();
                dt_phu.Clear();
                Malo = string.Empty;

                string query1 = "SELECT S.MaSP, S.TenSP, S.DVTinh, S.DonGia, S.MaLoai FROM SanPham S " +
                    "INNER JOIN LoaiSanPham LS ON S.MaLoai = LS.MaLoai " +
                    "WHERE LS.TenLoai = @KeyInfo";
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    cmd.Parameters.AddWithValue("@KeyInfo", cbxLoaiSP.SelectedItem.ToString());
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dtb.Load(reader);
                        dt_phu = dtb.Copy();
                        dataGridView1.DataSource = dtb;
                    }    
                }
                connection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dtb.Rows[e.RowIndex]["MaSP"].ToString();
            txtTenSP.Text = dtb.Rows[e.RowIndex]["TenSP"].ToString();
            txtDVTinh.Text = dtb.Rows[e.RowIndex]["DVTinh"].ToString();
            txtDonGia.Text = dtb.Rows[e.RowIndex]["DonGia"].ToString();
            Malo = dtb.Rows[e.RowIndex]["MaLoai"].ToString();
            Click_num = e.RowIndex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtb.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtDVTinh.Text, 
                txtDonGia.Text, Malo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in dt_phu.Rows)
                {
                    string query_d = "DELETE FROM SanPham WHERE MaSP = @MaSP";

                    using (SqlCommand cmd = new SqlCommand(query_d, connection))
                    {
                        string text = row[0].ToString().TrimEnd();
                        cmd.Parameters.AddWithValue("@MaSP", text);
                        cmd.ExecuteNonQuery();
                    }
                }

                foreach (DataRow row in dtb.Rows)
                {
                    string query_i = "INSERT INTO SanPham (MaSP, TenSP, DVTinh, DonGia, MaLoai) " +
                    "VALUES (@MaSP, @TenSP, @DVTinh, @DonGia, @MaLoai)";

                    using (SqlCommand cmd_i = new SqlCommand(query_i, connection))
                    {
                        foreach(DataColumn col in dtb.Columns)
                        {
                            cmd_i.Parameters.AddWithValue("@" + col.ColumnName, row[col].ToString().TrimEnd());
                        }
                        cmd_i.ExecuteNonQuery();
                    }
                }    
                
                connection.Close();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if(Malo != string.Empty)
            {
                dtb.Rows[Click_num]["MaSP"] = txtMaSP.Text;
                dtb.Rows[Click_num]["TenSP"] = txtTenSP.Text;
                dtb.Rows[Click_num]["DVTinh"] = txtDVTinh.Text;
                dtb.Rows[Click_num]["DonGia"] = txtDonGia.Text;
            }    
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng dữ liệu nào.", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            if (Malo != string.Empty)
            {
                dtb.Rows.RemoveAt(Click_num);
                txtMaSP.Text = string.Empty;
                txtTenSP.Text = string.Empty;
                txtDVTinh.Text = string.Empty;
                txtDonGia.Text = string.Empty;
                Malo = string.Empty;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng dữ liệu nào.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
