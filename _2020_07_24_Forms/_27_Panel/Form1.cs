using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Panel
{
    public partial class Form1 : Form
    {
       int move_val = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Left += move_val;
            if (this.panel1.Right >= this.ClientRectangle.Right
                || this.panel1.Left <= this.ClientRectangle.Left)
                move_val = -move_val;
        }
    }
}
