using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT6_Chuong3
{
    public partial class Form1 : Form
    {
        List<int> ds_moitam = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            Add_listbox();
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //  được sử dụng để thông báo cho hệ thống rằng sự kiện phím này đã được xử lý
                                           //  và không cần phải được xử lý tiếp bởi hệ thống.
                Add_listbox();
            }
        }

        private void Add_listbox()
        {
            if (int.TryParse(txtNhap.Text, out int n))
            {
                errorProvider1.Clear();
                listBox1.Items.Add(n);
                ds_moitam.Add(n);
            }
            else
            {
                Noti_W();
            }
        }

        private void Noti_W()
        {
            errorProvider1.SetError(txtNhap, "Chỉ được nhập số kiểu int.");
        }

        private void btnAllE_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                int total = 0;
                foreach (int num in listBox1.Items)
                {
                    total += num;
                }
                MessageBox.Show($"Tổng các phần tử trong List:\n{total}", "Kết quả");
            }    
            else
            {
                Noti_W();
            }    
        }

        private void btnDDC_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
            }    
            else
            {
                Noti_W();
            }    
        }

        private void btnDFL_Click(object sender, EventArgs e)
        {
            int slpt = listBox1.Items.Count;
            
            if(slpt > 1)
            {
                listBox1.Items.RemoveAt(slpt - 1);
                listBox1.Items.RemoveAt(0);
            } 
            else if(slpt == 1)
            {
                listBox1.Items.RemoveAt(0);
            }   
            else
            {
                Noti_W();
            }    
        }

        private void btnUL2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    int num = Convert.ToInt32(listBox1.Items[i]);
                    listBox1.Items[i] = ((num + 2) < Int32.MaxValue) ?
                        (num + 2) : Int32.MaxValue;
                }    
            }
            else
            {
                Noti_W();
            }
        }

        private void btnRBB_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int num = Convert.ToInt32(listBox1.Items[i]);
                    listBox1.Items[i] = (Math.Pow(num, 2) < Int32.MaxValue) ? 
                        Math.Pow(num , 2) : Int32.MaxValue;
                }
            }
            else
            {
                Noti_W();
            }
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                ds_moitam.ToList().ForEach(x =>
                {
                    if(x % 2 == 0)
                    {
                        listBox1.Items.Add(x);
                    }    
                });
            }
            else
            {
                Noti_W();
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                ds_moitam.ToList().ForEach(x =>
                {
                    if (x % 2 != 0)
                    {
                        listBox1.Items.Add(x);
                    }
                });
            }
            else
            {
                Noti_W();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn kết thúc ứng dụng không.", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
