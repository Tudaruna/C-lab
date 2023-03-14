using System;
using System.Drawing;
using System.Windows.Forms;

namespace workComboBoxTransport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Vitaliy\Desktop\C# lab course 3\lab2\src\auto.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Vitaliy\Desktop\C# lab course 3\lab2\src\ship.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Vitaliy\Desktop\C# lab course 3\lab2\src\plane.jpg");
                        break;
                    }
            }
        }
    }
}
