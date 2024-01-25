using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int sa = int.Parse(txtA.Text);
            int sb = int.Parse(txtB.Text);

            if(rbtnUCLN.Checked)
            {
                txtKQ.Text = UCLN(sa, sb).ToString();
            }   
            else
            {
                txtKQ.Text = BCNN(sa, sb).ToString();
            } 
        }

        private int UCLN(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKQ.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
