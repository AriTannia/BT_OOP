using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Buoi2
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Pen pen;
        private bool flag = false;
        private List<Point> points;
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            bmp = new Bitmap(640, 480);

            using (Graphics g = Graphics.FromImage(bmp))
                g.Clear(Color.White); // Let's make it white, like paper

            points = new List<Point>(); // Here we will remember the whole path
            pen = new Pen(Color.Black, 2f);

            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            points.Add(e.Location);
            points.Add(e.Location);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                points[points.Count - 1] = e.Location;
                Invalidate();
            }    
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            SaveToBitmap();
            points.Clear();
        }

        private void SaveToBitmap()
        {
            if (points.Count == 0)
                return;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLines(pen, points.ToArray()); // Just draw current line on bitmap
            }  
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0); // Show what is drawn
            if (points.Count > 0)
            {
                e.Graphics.DrawLines(pen, points.ToArray()); // Show what is currently being drawn
            }
        }
    }
}
