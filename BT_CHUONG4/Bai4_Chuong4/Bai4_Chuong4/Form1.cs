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

namespace Bai4_Chuong4
{
    public partial class Form1 : Form
    {
        static string machinename = Environment.MachineName;
        static string connectionString = ConfigurationManager.ConnectionStrings["MTC"]
            .ConnectionString.Replace("MINHTAN234", machinename);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt1 = Search_F(txtSearch.Text);
            if(dt1.Rows.Count > 0 )
            {
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nào.", "Cảnh Báo");
            }    
        }

        private DataTable Search_F(string search)
        {
            DataTable rs_dttb = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query_tim = "SELECT * FROM SanPham WHERE TenSP LIKE @FindT";
                using (SqlCommand cmd = new SqlCommand(query_tim, connection))
                {
                    cmd.Parameters.AddWithValue("@FindT", "%" + search + "%");
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(rs_dttb);
                    }    
                }
                connection.Close();
            }

            return rs_dttb;
        }
    }
}
