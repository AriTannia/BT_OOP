using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = m + n;
            txtKetqua.Text = Tong.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSom.Text = "";
            txtSon.Text = "";
            txtKetqua.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = m - n;
            txtKetqua.Text = Tong.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = m * n;
            txtKetqua.Text = Tong.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            double Tong = (double)m / n;
            txtKetqua.Text = Tong.ToString();
        }
    }
}
