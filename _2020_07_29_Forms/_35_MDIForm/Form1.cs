using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;//자식창을 부모창에 포함할수있는가?(멀티플다큐먼트인터페이스)
        }

        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = this.ActiveMdiChild;//현재 활성화되어있는 폼 
            if (childForm != null)
                childForm.Close();
        }

        private void 계단식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);//계산식
        }

        private void 수평바둑판정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);//수평바둑판
        }

        private void 수직바둑판정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);//수직바둑판
        }
    }
}
