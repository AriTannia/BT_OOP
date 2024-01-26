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

namespace Bai3_Chuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string machinename = Environment.MachineName;
            string connectionString = ConfigurationManager.ConnectionStrings["MTconnec"]
                .ConnectionString.Replace("MINHTAN234", machinename);
            HienThuc(connectionString);
        }

        private void HienThuc(string connectionString)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string truyvan = "SELECT * FROM SanPham";
                using(SqlCommand cmd = new SqlCommand(truyvan, connection))
                {
                    DataTable dbt1 = new DataTable();
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dbt1);
                        dataGridView1.DataSource = dbt1;
                    }    
                }
                connection.Close();
            }
        }
    }
}
