using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2_이미지를 5장을 준비하고 마우스를 클릭할 때마다 이미지를 교체하세요
namespace _2020_07_27_Basic_02
{
    public partial class Form1 : Form
    {
        Image img = null;
        TextureBrush tBrush = null;
        int pic = 0;
        Rectangle aoao = new Rectangle(50, 50, 50, 50);
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
            this.MouseClick += Form1_MouseClick;
            

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
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
            this.tBrush = new TextureBrush(img);
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.img = Image.FromFile("../../다드다리오.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.tBrush = new TextureBrush(this.img);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(this.tBrush, this.ClientRectangle);

        }
    }
}
