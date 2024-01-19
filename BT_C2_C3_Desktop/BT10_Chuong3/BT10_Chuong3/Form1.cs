using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT10_Chuong3
{
    public partial class Form1 : Form
    {
        private int num_stTime = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(IsOdd_Even() && progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            } 
            else if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                DialogResult rs = MessageBox.Show("Đã xong.\n" +
                    "Làm lại hay kết thúc", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

                if (rs == DialogResult.Retry)
                {
                    progressBar1.Value = progressBar1.Minimum;
                    timer1.Enabled = true;
                }
                else
                {
                    this.Close();
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_stTime = (num_stTime == 3) ? 2 : num_stTime + 1;
            int num1 = num_stTime;
        }

        private bool IsOdd_Even()
        {
            if(num_stTime % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
