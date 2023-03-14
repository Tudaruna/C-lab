using System;
using System.Windows.Forms;

namespace propertiesBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Текст выведен на метку";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }
    }
}
