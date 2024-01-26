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

namespace Bai6_Chuong4
{
    public partial class Form1 : Form
    {
        static string machinename = Environment.MachineName;
        static string connectionString = ConfigurationManager.ConnectionStrings["MTconnectionString"]
            .ConnectionString.Replace("MINHTAN234", machinename);
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query2 = "SELECT S.MaSP, S.TenSP, S.DVTinh, S.DonGia, S.MaLoai " +
                    "FROM SanPham S INNER JOIN LoaiSanPham LS ON " +
                    "S.MaLoai = LS.MaLoai " +
                    "WHERE LS.TenLoai = @KeyIn";

                using (SqlCommand cmd2 = new SqlCommand(query2, connection))
                {
                    cmd2.Parameters.AddWithValue("@KeyIn", e.Node.Text);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
                    {
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT TenLoai FROM LoaiSanPham";
                using (SqlCommand cmd = new SqlCommand(query1, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                treeView1.Nodes.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
