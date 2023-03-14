using System;
using System.Windows.Forms;

namespace clickBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 1";
            textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок на кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Magenta;
        }
    }
}
