using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3_이미지를 5장을 준비하고 1초마다 이미지가 바뀌도록 작성하세요
namespace _2020_07_27_Basic_03
{
    public partial class Form1 : Form
    {
        Image img = null;//이미지변수
        TextureBrush tBrush = null;//이미지그리기변수
        Timer timer = new Timer();//타이머
        int pic = 0;//이미지 개수
        Rectangle aoao = new Rectangle(50, 50, 50, 50);// 이미지출력틀

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//깜빡임 보정
            this.Paint += Form1_Paint;//출력
            this.Load += Form1_Load;//초기출력
            timer.Interval = 1000;//이미지 출력간격
            timer.Tick += Timer_Tick1;//타이머동작
            timer.Start();//스타뜨
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            timer.Start();
            switch (pic)
            {
                case 1:
                this.img = Image.FromFile("../../다드다리오.jpg");
                break;
                case 2:
                this.img = Image.FromFile("../../로즈번.jpg");
                break;
                case 3:
                this.img = Image.FromFile("../../엘리자베스 올슨.jpg");
                break;
                case 4:
                this.img = Image.FromFile("../../브라이스.jpg");
                break;
                case 5:
                this.img = Image.FromFile("../../키이라.jpg");
                break;
                case 6:
                break;
            }
            pic++;
            if (pic == 6)
                pic = 1;
            Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.img = Image.FromFile("../../다드다리오.jpg");
            this.tBrush = new TextureBrush(this.img);//이미지그리기


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.tBrush = new TextureBrush(this.img);
            e.Graphics.FillRectangle(this.tBrush, this.ClientRectangle);//이미지채우기
            


        }
    }
}

