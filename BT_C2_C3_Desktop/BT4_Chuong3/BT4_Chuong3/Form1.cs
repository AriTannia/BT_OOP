using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT4_Chuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHobby_Click(object sender, EventArgs e)
        {
            string line_txt = "";
            if (cbMusic.Checked == true) line_txt += cbMusic.Text + "\n";
            if (cbWFilm.Checked == true) line_txt += cbWFilm.Text + "\n";
            if (cbSport.Checked == true) line_txt += cbSport.Text + "\n";
            if (cbShopping.Checked == true) line_txt += cbShopping.Text + "\n";
            if (cbTravel.Checked == true) line_txt += cbTravel.Text + "\n";

            if(line_txt.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là:\n" + line_txt);
            }  
            else
            {
                MessageBox.Show("Không có sở thích nào.");
            }    
        }

        private void btnFColo_Click(object sender, EventArgs e)
        {
            string txt_l = "";
            if (rbRed.Checked == true) txt_l += rbRed.Text;
            else if (rbWhite.Checked == true) txt_l += rbWhite.Text;
            else if (rbYellow.Checked == true) txt_l += rbYellow.Text;
            else if (rbPink.Checked == true) txt_l += rbPink.Text;
            else if (rbPurple.Checked == true) txt_l += rbPurple.Text;

            if(txt_l.Length > 0)
            {
                MessageBox.Show("Màu yêu thích của bạn là:\n" + txt_l);
            }
            else
            {
                MessageBox.Show("Không có màu yêu thích nào.");
            }
        }
    }
}
