using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BT7_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_sv()
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.Clear();
                if (comboBox1.Text == comboBox1.Items[0].ToString())
                {
                    LbAclass.Items.Add(textBox1.Text);
                } 
                else
                {
                    LbBclass.Items.Add(textBox1.Text);
                }    
            }
            else
            {
                errorProvider1.SetError(textBox1, "Không được để trống.");
            }
        }

        private void Send_EMess(Control control1, string text)
        {
            errorProvider1.SetError(control1, text);
        }

        private void One_Right_Left(ListBox lb_1, ListBox lb_2, Control btnRL, string text)
        {
            ListBox.SelectedIndexCollection ds_dc = lb_1.SelectedIndices;
            if (ds_dc.Count > 0)
            {
                int num = ds_dc.Count - 1;
                for (int i = num; i >= 0; i--)
                {
                    lb_2.Items.Add(lb_1.Items[ds_dc[i]]);
                    lb_1.Items.RemoveAt(ds_dc[i]);
                }
            }
            else
            {
                Send_EMess(btnRL, $"Chưa chọn sinh viên nào trong lớp {text}");
            }
        }

        private void Double_Right_Left(ListBox lb_1, ListBox lb_2, Control btnRL, string text)
        {
            if (lb_1.Items.Count > 0)
            {
                foreach (var item in lb_1.Items)
                {
                    lb_2.Items.Add(item);
                }
                lb_1.Items.Clear();
            }
            else
            {
                Send_EMess(btnRL, $"Chưa chọn sinh viên nào trong lớp {text}");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Add_sv();
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Add_sv();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            One_Right_Left(LbAclass, LbBclass, btnRight, "A");    
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            One_Right_Left(LbBclass, LbAclass, btnLeft, "B");
        }

        private void btnDRight_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Double_Right_Left(LbAclass, LbBclass, btnDRight, "A");
        }

        private void btnDLeft_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Double_Right_Left(LbBclass, LbAclass, btnDLeft, "B");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection ds_dc = LbAclass.SelectedIndices;
            if (ds_dc.Count > 0)
            {
                int num = ds_dc.Count - 1;
                for (int i = num; i >= 0; i--)
                {
                    LbAclass.Items.RemoveAt(ds_dc[i]);
                }
            }
            else
            {
                Send_EMess(btnD, "Chưa chọn sinh viên nào trong lớp A");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không.", "Thông Báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
