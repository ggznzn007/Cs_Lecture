using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_28_HW_01
{
    public partial class Form1 : Form
    {
        class Line
        {
            public int startX { get; set; } // 시작x좌표 10
            public int startY { get; set; } // 시작y좌표 10
            public int endX { get; set; } // 끝x좌표 100
            public int endY { get; set; } // 끝y좌표 100
            public Line(int x1, int y1, int x2, int y2) // 10, 10, 100, 100
            {
                startX = x1;
                startY = y1;
                endX = x2;
                endY = y2;
            }
        }
        List<Line> list = new List<Line>();
        int x; int y; int ex; int ey;
        bool mclick = false;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                list.Add(new Line(x, y, e.X, e.Y));
                mclick = false;
            }
          
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mclick == false)
                return;
            {
                this.ex = e.X;
                this.ey = e.Y;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mclick = true;
                this.x = e.X;
                this.y = e.Y;
            }
           
            //Invalidate();//마우스 움직일때만 그리기
            /*list.Add(cnt);
            cnt++;
            for (int i = 0; i < list.Count; i++)
            { Console.WriteLine(list[i].ToString()); }*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //if (mclick == true)
             //{
            e.Graphics.DrawLine(new Pen(Brushes.Red, 12), x, y, ex, ey);
            for (int i = 0; i < list.Count; i++)
                e.Graphics.DrawLine(new Pen(Brushes.Red, 12),
                list[i].startX, list[i].startY, list[i].endX, list[i].endY);
           // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
        }
    }
}
