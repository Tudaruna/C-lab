using System;
using System.Drawing;
using System.Windows.Forms;

namespace trafficSignal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum trafficLight { Красный, Желтый, Зеленый }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trafficLight signal = (trafficLight)comboBox1.SelectedIndex;
            switch(signal)
            {
                case trafficLight.Красный:
                    label1.Text = "Стойте!";
                    label1.BackColor = Color.Red;
                    break;
                case trafficLight.Желтый:
                    label1.Text = "Ждите";
                    label1.BackColor = Color.Yellow;
                    break;
                case trafficLight.Зеленый:
                    label1.Text = "Идите";
                    label1.BackColor = Color.Green;
                    break;
                default:
                    MessageBox.Show("Светофор сломан");
                    break;
            }
        }
    }
}
