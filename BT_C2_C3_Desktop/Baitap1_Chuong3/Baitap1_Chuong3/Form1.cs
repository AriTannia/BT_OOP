using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap1_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_Er(TextBox txt1)
        {
            this.errorProvider1.SetError(txt1, "Không được để trống");
        }

        private void btnHoLot(object sender, EventArgs e)
        {
            Display_Er(txtHoLot);
            if (!String.IsNullOrEmpty(txtHoLot.Text))
            {
                this.errorProvider1.Clear();
                lblHoVaTen.Text = txtHoLot.Text;
            }
        }

        private void btnTen(object sender, EventArgs e)
        {
            Display_Er(txtTen);
            if (!String.IsNullOrEmpty(txtTen.Text))
            {
                this.errorProvider1.Clear();
                lblHoVaTen.Text = txtTen.Text;
            }
        }

        private void btnHoVaTen(object sender, EventArgs e)
        {
            Display_Er(txtHoLot);
            Display_Er(txtTen);
            if (!String.IsNullOrEmpty(txtHoLot.Text) && !String.IsNullOrEmpty(txtTen.Text))
            {
                this.errorProvider1.Clear();
                lblHoVaTen.Text = $"{txtHoLot.Text} {txtTen.Text}";
            }
        }

        private void btnEnd(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng form không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
