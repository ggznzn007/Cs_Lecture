using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageForm;

namespace ViewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJang_Click(object sender, EventArgs e)
        {
            ImageForm.Form1 frm = new ImageForm.Form1();
            frm.Show();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            DogForm dfrm = new DogForm();
            dfrm.Show();
        }
    }
}
