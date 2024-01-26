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

namespace Bai7_Chuong4
{
    public partial class Form1 : Form
    {
        static string machinename = Environment.MachineName;
        static string connectionString = ConfigurationManager.ConnectionStrings["MTconnectionString"]
            .ConnectionString.Replace("MINHTAN234", machinename);
        static DataTable dt = new DataTable();
        static int curr_po = 0;
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
                using(SqlCommand command = new SqlCommand(query1, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
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
        private void Display_data(DataTable dt, int index_row)
        {
            txtMaSP.Text = dt.Rows[index_row]["MaSP"].ToString();
            txtTenSP.Text = dt.Rows[index_row]["TenSP"].ToString();
            txtDVTinh.Text = dt.Rows[index_row]["DVTinh"].ToString();
            txtDonGia.Text = dt.Rows[index_row]["DonGia"].ToString();
        }

        private void cbxLoaiSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                dt.Clear();
                string query2 = "SELECT S.MaSP, S.TenSP, S.DVTinh, S.DonGia FROM SanPham S " +
                    "INNER JOIN LoaiSanPham LS ON S.MaLoai = LS.MaLoai " +
                    "WHERE LS.TenLoai = @KeyInfo";

                using (SqlCommand cmd = new SqlCommand(query2, connection))
                {
                    cmd.Parameters.AddWithValue("@KeyInfo", cbxLoaiSP.SelectedItem.ToString());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        Display_data(dt, 0);
                    }
                }
                connection.Close();
            }
        }

        private void btn1L_Click(object sender, EventArgs e)
        {
            curr_po--;
            if(curr_po >= 0)
            {
                Display_data(dt, curr_po);
            }    
            else
            {
                curr_po = dt.Rows.Count - 1;
                Display_data(dt, curr_po);
            }    
        }

        private void btn2L_Click(object sender, EventArgs e)
        {
            curr_po-= 2;
            if (curr_po >= 0)
            {
                Display_data(dt, curr_po);
            }
            else
            {
                curr_po = dt.Rows.Count - 1;
                Display_data(dt, curr_po);
            }
        }

        private void btn1R_Click(object sender, EventArgs e)
        {
            curr_po++;
            if(curr_po < dt.Rows.Count)
            {
                Display_data(dt, curr_po);
            }    
            else
            {
                curr_po = 0;
                Display_data(dt, curr_po);
            }    
        }

        private void btn2R_Click(object sender, EventArgs e)
        {
            curr_po+= 2;
            if (curr_po < dt.Rows.Count)
            {
                Display_data(dt, curr_po);
            }
            else
            {
                curr_po = 0;
                Display_data(dt, curr_po);
            }
        }
    }
}
