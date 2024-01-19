using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtRed_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtRed.Checked == true)
            {
                txtNhapTen.ForeColor = Color.Red;
            }    
        }

        private void rbtGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtGreen.Checked == true)
            {
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void rbtBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBlue.Checked == true)
            {
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void rbtBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBlack.Checked == true)
            {
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size, 
                txtNhapTen.Font.Style ^ FontStyle.Bold); // ^ XOR 1 trong 2 cái chỉ 1 đúng
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size,
                txtNhapTen.Font.Style ^ FontStyle.Italic);
        }
        private void cbUnderli_CheckedChanged(object sender, EventArgs e)
        {
            txtNhapTen.Font = new Font(txtNhapTen.Font.Name, txtNhapTen.Font.Size,
                txtNhapTen.Font.Style ^ FontStyle.Underline);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không.", "Thông Báo", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (rs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
