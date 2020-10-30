using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2020_07_28_HW_02
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
        List<Line> xy = new List<Line>();
        //int x; int y; int ex; int ey;
        bool mclick = false;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += Form1_Load;
            this.MouseMove += Form1_MouseMove;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < xy.Count; i++)
            {
                e.Graphics.DrawLine(new Pen(Brushes.AntiqueWhite, 1),
                    xy[i].startX, xy[i].startY, xy[i].endX, xy[i].endY);
                Console.WriteLine("x: {0} y: {1} x1: {2} y2: {3}",
                    xy[i].startX, xy[i].startY, xy[i].endX, xy[i].endY);
            }
            /*e.Graphics.DrawLine(new Pen(Brushes.AntiqueWhite, 1), x, y, ex, ey);*/


        }

        private void add_EXY(Line line, int ex, int ey)
        {
            line.startX = ex;
            line.startY = ey;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                mclick = false;
                add_EXY(xy[xy.Count - 1], e.X, e.Y);
                xy.Add(new Line(e.X, e.Y, e.X, e.Y));
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mclick = true;
                xy.Add(new Line(e.X, e.Y, e.X, e.Y));
                Invalidate();

            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mclick)
            {
                add_EXY(xy[xy.Count - 1], e.X, e.Y);
                xy.Add(new Line(e.X, e.Y, e.X, e.Y));
                Invalidate();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Navy;
        }

    }
}
