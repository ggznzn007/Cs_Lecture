using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1_원을 마우스 클릭하면 색칠하기
namespace _2020_07_27_Basic_01
{

    public partial class Form1 : Form
    {
        const int RAD = 200;
        int x = 70, y = 70;
        bool click = false;


        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
        }
        
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.click = false;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.x = e.X - 100;
                this.y = e.Y - 100;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.click = true;
                this.x = e.X - 100;
                this.y = e.Y - 100;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Red, 7);
            g.DrawEllipse(myPen, x, y, RAD, RAD);
             if(click == true)
            {                
                g.FillEllipse(Brushes.Red,x,y, RAD+4, RAD+4);
            }

           // g.FillEllipse(Brushes.Red, x, y, RAD + 4, RAD + 4);
        }
    }
}
