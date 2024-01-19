using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT9_Chuong3
{
    public partial class Form1 : Form
    {
        private TextBox[] hopdungtxt;
        private MaskedTextBox[] hopdungMtxt;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbC.Items.Clear();
            if (cbCountry.Text == cbCountry.Items[0].ToString())
            {
                lbC.Items.AddRange(new object[] { "Ho Chi Minh", "Ha Noi", "Nha Trang" });
            }
            else
            {
                lbC.Items.AddRange(new object[] { "Pattaya", "ChiengMai", "BangKok" });
            }
        }
        private void Notnulltxt_grade(int num_dk, int Mtxt_num = -1,
             int CB_num = -1, int LB_num = -1)
        {
            hopdungtxt = new TextBox[] { txtName, txtDC, textBox1, txtE };
            hopdungMtxt = new MaskedTextBox[] { mtbDOB, mtbPhone };


            for (int i = 0; i <= num_dk; i++)
            {
                if (String.IsNullOrEmpty(hopdungtxt[num_dk].Text))
                {
                    this.hopdungtxt[num_dk].Focus();
                    errorProvider1.SetError(hopdungtxt[num_dk], "Vui lòng không để trống.");
                }
            }

            for (int i = 0; i <= Mtxt_num; i++)
            {
                if (!hopdungMtxt[Mtxt_num].MaskFull)
                {
                    this.hopdungMtxt[Mtxt_num].Focus();
                    errorProvider1.SetError(hopdungMtxt[Mtxt_num], "Vui lòng không để trống.");
                }
            }

            if (CB_num != -1 && String.IsNullOrEmpty(cbCountry.Text))
            {
                this.cbCountry.Focus();
                errorProvider1.SetError(cbCountry, "Vui lòng không để trống.");
            }

            if (LB_num != -1 && lbC.SelectedItem == null)
            {
                this.lbC.Focus();
                errorProvider1.SetError(lbC, "Vui lòng chọn 1.");
            }
        }

        private void mtbDOB_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Ngày nhập không hợp lệ";
                toolTip1.Show("Dữ liệu bạn cung cấp phải là ngày hợp lệ ở định dạng mm/dd/yyyy.",
                    mtbDOB, 0, -35, 2000);
                this.mtbDOB.Focus();
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now)
                {
                    toolTip1.ToolTipTitle = "Ngày nhập không hợp lệ";
                    toolTip1.Show("Dữ liệu bạn cung cấp phải là nhỏ hơn hoặc bằng ngày hôm nay.",
                        mtbDOB, 0, -35, 2000);
                    this.mtbDOB.Focus();
                }
            }
        }

        private void mtbDOB_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(mtbDOB);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(0);
        }

        private void mtbDOB_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(0, 0);
        }

        private void txtDC_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(1, 0);
        }

        private void cbCountry_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(1, 0, 0);
        }

        private void lbC_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(1, 0, 0, 0);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(2, 0, 0, 0);
        }

        private void txtE_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(3, 1, 0, 0);
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Notnulltxt_grade(2, 1, 0, 0);
        }

        private void dtpDOJ_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (dtpDOJ.Value.CompareTo(DateTime.Now) > 0)
            {
                dtpDOJ.Focus();
                errorProvider1.SetError(dtpDOJ, "Phải nhỏ hơn hoặc bằng ngày hiện tại");
            }    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string text_MB = "";
            text_MB += $"Name: {txtName.Text}\nDate of Birth: {mtbDOB.Text}\n" +
                $"Adrress: {txtDC.Text}\nCountry: {cbCountry.Text}\nCity: {lbC.SelectedItem.ToString()}\n" +
                $"Qualification:\n{textBox1.Text}\n\nPhone: {mtbPhone.Text}\nEmail: {txtE.Text}\n" +
                $"Date of Joining: {dtpDOJ.Text}";

            MessageBox.Show(text_MB, "Employee Information");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát.", "Thông Báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    }
