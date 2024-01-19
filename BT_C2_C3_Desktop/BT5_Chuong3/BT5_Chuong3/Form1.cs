using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                checkedListBox1.Items.Add(txtName.Text);
                HienThiTotal();
            }
            else
            {
                errorProvider1.SetError(txtName, "Vui lòng không để trống");
            }
        }

        private void HienThiTotal()
        {
            DispKB.Text = checkedListBox1.Items.Count.ToString();
        }

        private void Noti_War()
        {
            Noti_War();
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection ds_checkedi = checkedListBox1.CheckedItems;
            List<object> DC_list = new List<object>();

            if(ds_checkedi.Count > 0)
            {
                foreach (var item in ds_checkedi)
                {
                    DC_list.Add(item);
                }

                foreach (var item in DC_list)
                {
                    checkedListBox1.Items.Remove(item);
                }
                HienThiTotal();
            }  
            else
            {
                Noti_War();
            }    
        }

        private void btnDAll_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.Clear();
            }    
            else
            {
                Noti_War();
            }
            HienThiTotal();
        }

        private void btnDFirst_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(0);
            }
            else
            {
                Noti_War();
            }
            HienThiTotal();
        }

        private void btnDLast_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count - 1);
            }
            else
            {
                Noti_War();
            }
            HienThiTotal();
        }
    }
}
