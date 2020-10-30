using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//4_마우스를 클릭할 때 마다 20x20 크기의 랜덤한 색상을 가진 사각형을 해당 좌표에 출력하세요
namespace _2020_07_27_Basic_04
{
    public partial class Form1 : Form
    {
        bool now = false;
        int x = 100, y = 100;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                now = !now;
            }
            this.x = e.X;
            this.y = e.Y;
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Red, 2);
            g.FillRectangle(Brushes.Red, 5, 5, 5, 5);
        }
    }
}
