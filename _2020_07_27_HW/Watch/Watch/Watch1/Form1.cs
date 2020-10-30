using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch1
{
    public partial class Form1 : Form
    {
        Timer watchTimer = new Timer();
        string NowTime { get;set; }
        int Hour { get; set; }
        int Minute { get; set; }
        int Second { get; set; }
        Point timePt = new Point(20, 20);
        Point centerPt;
        int rad;

        int secondX, secondY;


        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.Paint += Form1_Paint;

            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.Size = new Size(800, 800);

            watchTimer.Interval = 1000;
            watchTimer.Enabled = true;
            watchTimer.Tick += WatchTimer_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centerPt.X = this.ClientRectangle.Right / 2;
            centerPt.Y = this.ClientRectangle.Bottom / 2;
            rad = 200;

            GetNowTime();
            SetWatchSecondHand();
        }

        void DrawWatchNum(Graphics g)
        {
            Font font = new Font("굴림체", 25, FontStyle.Bold);
            Pen pen = new Pen(Brushes.Gold, 5);
            int num = 3;
            for (int angle = 0; angle < 360; angle += 30)
            {
                int x = centerPt.X + (int)(Math.Cos(angle * Math.PI / 180) * rad);
                int y = centerPt.Y + (int)(Math.Sin(angle * Math.PI / 180) * rad);
                g.FillEllipse(Brushes.DarkBlue, x-25, y-25, 50, 50);
                g.DrawEllipse(pen, x - 25, y - 25, 50, 50);
                g.DrawString(num.ToString(), font, Brushes.White, x - 20, y - 20);
                if (num == 12)
                    num = 0;
                num++;
            }
        }

        void SetWatchSecondHand()
        {
            int degreePerSecond = 360 / 60;
            int angle = Second >= 15 ? (Second-15)*degreePerSecond : (45+Second)*degreePerSecond;
            secondX = centerPt.X + (int)(Math.Cos(angle * Math.PI / 180) * rad);
            secondY = centerPt.Y + (int)(Math.Sin(angle * Math.PI / 180) * rad);
        }

        void DrawWatchSecondHand(Graphics g)
        {
            Pen pen = new Pen(Brushes.White, 3);
            g.DrawLine(pen, centerPt.X, centerPt.Y, secondX, secondY);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.White, 10);
            Font f = new Font("맑은 고딕", 36);

            g.DrawString(NowTime, f, Brushes.White, timePt);

            g.DrawEllipse(pen, centerPt.X-rad, centerPt.Y-rad, rad*2, rad*2);
            g.DrawEllipse(pen, centerPt.X - 5, centerPt.Y - 5, 10, 10);

            DrawWatchNum(g);
            DrawWatchSecondHand(g);
        }
        
        void GetNowTime()
        {
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
            Second = DateTime.Now.Second;

            NowTime = String.Format("{0,2:D2}:{1,2:D2}:{2,2:D2}", Hour, Minute, Second);
        }

        private void WatchTimer_Tick(object sender, EventArgs e)
        {
            GetNowTime();
            SetWatchSecondHand();
            Invalidate();
        }
    }
}

