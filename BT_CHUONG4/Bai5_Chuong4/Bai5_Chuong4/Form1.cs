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

namespace Bai5_Chuong4
{
    public partial class Form1 : Form
    {
        static string machinename = Environment.MachineName;
        static string connectionString = ConfigurationManager.ConnectionStrings["MTconnectionS"]
            .ConnectionString.Replace("MINHTAN234", machinename);
        public Form1()
        {
            InitializeComponent();
            
            ThucHien();
        }

        private void ThucHien()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TenLoai FROM LoaiSanPham";
                using(SqlCommand command = new SqlCommand(query1, connection)) 
                { 
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                cbxLSP.Items.Add(reader.GetString(0));
                            }
                        }    
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào.", "Cảnh báo");
                        }    
                    }
                }
                connection.Close();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query2 = "SELECT S.MaSP, S.TenSP, S.DVTinh, S.DonGia, S.MaLoai " +
                    "FROM SanPham S INNER JOIN LoaiSanPham LS ON " +
                    "S.MaLoai = LS.MaLoai WHERE " +
                    "LS.TenLoai = @CInfo";
                using(SqlCommand cmd = new SqlCommand(query2, connection))
                {
                    cmd.Parameters.AddWithValue("@CInfo", cbxLSP.SelectedItem.ToString());
                    DataTable db1 = new DataTable();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(db1);
                        dataGridView1.DataSource = db1;
                    }    
                }  
                    
                connection.Close();
            }    
        }
    }
}
