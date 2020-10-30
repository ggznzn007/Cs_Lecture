using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_30_HW_01
{
    public partial class Form1 : Form
    {
        int x = 0; int y = 0; int ex = 1920; int ey = 0;
        int WID_SIZE = 150; int HEI_SIZE = 175;
        /* Image img1 = null;
        Image img2 = null;
        Image img3 = null;*/
        bool dClick = false;
        int iMove = 10;
        int chekStart = 0;
        const int MOVE_VAL = 10;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseDoubleClick += Form1_MouseDoubleClick;

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             if (dClick==true)
            {
                if(x + 100 >= this.ClientRectangle.Right)
                {
                    iMove = -iMove;
                    chekStart = 1;
                }
                else if (x <= this.ClientRectangle.Left && chekStart == 1)
                {
                    iMove = -iMove;
                }
                x += iMove;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Gold, 5), x, y, ex, ey);
            g.DrawLine(new Pen(Brushes.Gold, 5), x, y + 188, ex, ey + 188);
            g.DrawLine(new Pen(Brushes.Gold, 5), x, y + 378, ex, ey + 378);
            Image img1 = Image.FromFile("../../박보영.jpg");
            Image img2 = Image.FromFile("../../장나라.jpg");
            Image img3 = Image.FromFile("../../아이유.jpg");            
            g.DrawImage(img1, x+7, y+7,WID_SIZE,HEI_SIZE);
            g.DrawImage(img2, x+7,y+195, WID_SIZE, HEI_SIZE);
            g.DrawImage(img3, x+7, y+385, WID_SIZE, HEI_SIZE);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

        }
    }
}
