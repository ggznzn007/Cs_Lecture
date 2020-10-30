using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        string[] arrNames =
        {
            "홍길동", "임꺽정", "장길산",
            "일지매", "차돌바위", "장옥정"
        };
        string[] arrWords =
        {
            "감사합니다",
            "고맙습니다",
            "사랑합니다",
            "존경합니다",
            "보고싶습니다",
            "행복하세요"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRightMove_Click(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            int idx = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(idx);
            listBox1.SelectedIndex = idx;
            comboBox1.Items.Add(str);
        }

        private void btnLeftMove_Click(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            int idx = comboBox1.SelectedIndex;
            comboBox1.Items.RemoveAt(idx);
            comboBox1.SelectedIndex = idx;
            listBox1.Items.Add(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string name in arrNames)
                listBox1.Items.Add(name);

            foreach (string word in arrWords)
                comboBox1.Items.Add(word);
        }
    }
}
