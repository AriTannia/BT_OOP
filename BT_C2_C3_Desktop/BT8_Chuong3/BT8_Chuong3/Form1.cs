using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT8_Chuong3
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer1.Enabled = true;
            flag = true;
            UpdateProgressBar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag && progressBar1.Value != progressBar1.Maximum)
            {
                DateTime now = DateTime.Now;
                UpdateProgressBar();
                label5.Text = now.ToString();
            } 
            else if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                flag = false;
                Form2 tab_n = new Form2();
                tab_n.Show();
            }    
        }

        private void UpdateProgressBar()
        {
            progressBar1.PerformStep();
            label4.Text = $"Connecting to from {progressBar1.Value.ToString()} %";
        }
    }
}
