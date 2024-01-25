using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lbxAccessLog.Items.Clear();
            System.IO.File.WriteAllText("Access_logf.txt", string.Empty);
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            Thucthi();
        }

        private void Thucthi()
        {
            string[] loj = new string[] { "Technician", "Custodian", "Scientist" };
            switch (txtSecurityCode.Text)
            {
                case "1645":
                case "1689":
                    PrintAdd(loj[0]);
                    break;
                case "8345":
                    PrintAdd(loj[1]);
                    break;
                case "9998":
                case "1006":
                case "1008":
                    PrintAdd(loj[2]);
                    break;
                default:
                    PrintAdd("Restricted Access!");
                    break;
            }
            txtSecurityCode.Text = "";
        }

        private void PrintAdd(string text1)
        {
            DateTime dt1 = DateTime.Now;
            string textto = $"{dt1}\t{text1}";
            System.IO.File.AppendAllText("Access_logf.txt", textto + "\n");
            lbxAccessLog.Items.Add(textto);
        }

        private void btnC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.ToUpper(e.KeyChar) == 'C')
            {
                Thucthi();
            }    
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Shift && e.KeyCode == Keys.D3)
            {
                Thucthi();
                return;
            }    

            switch (e.KeyCode)
            {
                case Keys.D1:
                    txtSecurityCode.Text += "1";
                    break;
                case Keys.D2:
                    txtSecurityCode.Text += "2";
                    break;
                case Keys.D3:
                    txtSecurityCode.Text += "3";
                    break;
                case Keys.D4:
                    txtSecurityCode.Text += "4";
                    break;
                case Keys.D5:
                    txtSecurityCode.Text += "5";
                    break;
                case Keys.D6:
                    txtSecurityCode.Text += "6";
                    break;
                case Keys.D7:
                    txtSecurityCode.Text += "7";
                    break;
                case Keys.D8:
                    txtSecurityCode.Text += "8";
                    break;
                case Keys.D9:
                    txtSecurityCode.Text += "9";
                    break;
                case Keys.D0:
                    txtSecurityCode.Text += "0";
                    break;
                case Keys.C:
                    lbxAccessLog.Items.Clear();
                    System.IO.File.WriteAllText("Access_logf.txt", string.Empty);
                    break;
            }
        }
    }
}
