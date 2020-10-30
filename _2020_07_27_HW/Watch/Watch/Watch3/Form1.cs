using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch3
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
        int minuteX, minuteY;
        int hourX, hourY;

        int selImage = 0, selCount = 0;

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
            SetWatchMinuteHand();
            SetWatchHourHand();
        }

        void SecondSound()
        {
            SoundPlayer simpleSound = new SoundPlayer("짤깍.wav");
            simpleSound.Play();
        }

        void DrawBackground(Graphics bg, int x, int y, int width, int height, int sec)
        {
            selCount++;
            if (sec == selCount)
            {
                selCount = 0;
                selImage++;
                if (selImage > 12)
                    selImage = 0;
            }

            // // 소스이미지 가져오기
            string imageName = String.Format("{0}.jpg", selImage);
            var src = (Bitmap)Bitmap.FromFile(imageName);

            // 소스이미지 크기와 동일한 타겟이미지 생성
            Bitmap tgt = new Bitmap(width, height);

            // 타겟이미지의 Graphics 객체 얻기        
            using (Graphics g = Graphics.FromImage(tgt))
            {
                // 원모양으로 Clip
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, tgt.Width, tgt.Height);
                g.SetClip(path);

                // 소스이미지를 원모양으로 잘라 타겟이미지에 출력
                g.DrawImage(src, 0, 0, tgt.Width, tgt.Height);
            }

            bg.DrawImage(tgt, x, y, width, height);
        }

        void DrawWatchNum(Graphics g)
        {
            Font font = new Font("굴림체", 25, FontStyle.Bold);
            Pen pen = new Pen(Brushes.Gold, 2);
            int num = 3;
            for (int angle = 0; angle < 360; angle += 30)
            {
                int x = centerPt.X + (int)(Math.Cos(angle * Math.PI / 180) * rad);
                int y = centerPt.Y + (int)(Math.Sin(angle * Math.PI / 180) * rad);
                g.DrawString(num.ToString(), font, Brushes.Black, x - 20 + 2, y - 20 + 2);
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
            Pen pen = new Pen(Brushes.Aqua, 3);
            Pen pen1 = new Pen(Brushes.DarkBlue, 5);
            g.DrawLine(pen1, centerPt.X-2, centerPt.Y-2, secondX, secondY);
            g.DrawLine(pen, centerPt.X, centerPt.Y, secondX, secondY);
        }

        void SetWatchMinuteHand()
        {
            int degreePerMinute = 360 / 60;
            int angle = Minute >= 15 ? (Minute - 15) * degreePerMinute : (45 + Minute) * degreePerMinute;
            angle += (int)((double)degreePerMinute / 60D * (double)Second);
            minuteX = centerPt.X + (int)(Math.Cos(angle * Math.PI / 180) * (rad-40));
            minuteY = centerPt.Y + (int)(Math.Sin(angle * Math.PI / 180) * (rad-40));
        }

        void DrawWatchMinuteHand(Graphics g)
        {
            Pen pen = new Pen(Brushes.Green, 7);
            Pen pen1 = new Pen(Brushes.Ivory, 7);
            g.DrawLine(pen1, centerPt.X - 2, centerPt.Y - 2, minuteX, minuteY);
            g.DrawLine(pen, centerPt.X, centerPt.Y, minuteX, minuteY);
        }

        void SetWatchHourHand()
        {
            int degreePerHour = 360 / 12;
            int angle = Hour >= 3 ? (Hour - 3) * degreePerHour : (9 + Hour) * degreePerHour;
            angle += (int)((double)degreePerHour/60D * (double)Minute);
            hourX = centerPt.X + (int)(Math.Cos(angle * Math.PI / 180) * (rad-90));
            hourY = centerPt.Y + (int)(Math.Sin(angle * Math.PI / 180) * (rad-90));
        }

        void DrawWatchHourHand(Graphics g)
        {
            Pen pen = new Pen(Brushes.Gold, 10);
            Pen pen1 = new Pen(Brushes.BlueViolet, 12);
            g.DrawLine(pen1, centerPt.X - 3, centerPt.Y - 3, hourX, hourY);
            g.DrawLine(pen, centerPt.X, centerPt.Y, hourX, hourY);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.White, 5);
            Pen pen1 = new Pen(Brushes.DarkBlue, 2);
            Pen pen2 = new Pen(Brushes.Gold, 1);
            Font f = new Font("맑은 고딕", 36);

            DrawBackground(g, centerPt.X - rad - 20, centerPt.Y - rad - 20, rad * 2 + 40, rad * 2 + 40, 1);
                        
            g.DrawString(NowTime, f, Brushes.White, timePt);

            g.DrawEllipse(pen, centerPt.X-rad-23, centerPt.Y-rad- 23, rad*2+46, rad*2+46);
            g.DrawEllipse(pen1, centerPt.X - rad - 21, centerPt.Y - rad - 21, rad * 2 + 42, rad * 2 + 42);
            g.DrawEllipse(pen2, centerPt.X - rad - 20, centerPt.Y - rad - 20, rad * 2 + 40, rad * 2 + 40);
            g.DrawEllipse(pen, centerPt.X - 5, centerPt.Y - 5, 10, 10);

            DrawWatchNum(g);
            DrawWatchSecondHand(g);
            DrawWatchMinuteHand(g);
            DrawWatchHourHand(g);

            
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
            SetWatchMinuteHand();
            SetWatchHourHand();
            SecondSound();
            Invalidate();
        }
    }
}

