using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string str = tbWord.Text;
            tbView.Text += str;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbView.Clear();
            //tbView.Text = "";
        }

        private void tbWord_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                {
                    string str = tbWord.Text;
                    tbWord.Clear();
                    tbView.Text += str;
                    tbView.Text += "\r\n";
                }
                break;
            }
        }
    }
}
