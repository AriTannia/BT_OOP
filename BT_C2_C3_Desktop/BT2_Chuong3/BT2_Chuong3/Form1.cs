using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Noti_Er(TextBox txt1, string text)
        {
            this.errorProvider1.SetError(txt1, text);
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtTnd.Text, "admin") && String.Equals(txtMk.Text, "UEHBIT"))
            {
                this.errorProvider1.Clear();
                MessageBox.Show("Đăng nhập thành công", "Thông Báo");
            } 
            else
            {
                if(!String.Equals(txtTnd.Text, "admin"))
                {
                    Noti_Er(txtTnd, "Tài Khoản Không đúng");
                }    
                else
                {
                    this.errorProvider1.Clear();
                    Noti_Er(txtMk, "Mật khẩu không đúng");
                }        
            }    
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không.", "Thông báo", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
