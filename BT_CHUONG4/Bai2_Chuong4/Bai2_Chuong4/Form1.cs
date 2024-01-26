using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai2_Chuong4
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
            string connectionString = ConfigurationManager.ConnectionStrings["MTconnectionString"]
                .ConnectionString.Replace("MINHTAN234", machineName);
            ThucHien(connectionString);
        }

        private void ThucHien(string connectionString)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TenSP FROM SanPham";
                using(SqlCommand cmd1 = new SqlCommand(query1, connection))
                {
                    using(SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                string t1 = reader.GetString(0);
                                comboBox1.Items.Add(t1);
                            }
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
