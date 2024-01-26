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

namespace Bai1_Chuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string machineName = Environment.MachineName;
            string connection = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString
                .Replace("MINHTAN234", machineName);
            Load_file(connection);
        }

        private void Load_file(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query1 = "SELECT TenSP FROM SanPham";
                using(SqlCommand cmd1 = new SqlCommand(query1, connection))
                {
                    using(SqlDataReader rd1 = cmd1.ExecuteReader())
                    {
                        if(rd1.HasRows)
                        {
                            while(rd1.Read())
                            {
                                string tensp = rd1.GetString(0);
                                lbx1.Items.Add(tensp);
                            }
                        }   
                        else
                        {
                            MessageBox.Show("Không tồn tại dữ liệu nào.", "Cảnh báo");
                        }    
                    }    
                }    
                connection.Close();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
