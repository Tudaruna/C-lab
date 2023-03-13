using System;
using System.Windows.Forms;

namespace CF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void translateTemp_Click(object sender, EventArgs e)
        {
            try
            {
                double tempF = Double.Parse(input_tempF.Text);
                double tempC = 5.0 / 9 * (tempF - 32);
                label_tempC.Text = $"Температура по Цельсию равна {tempC:0.##}";
            }
            catch
            {
                MessageBox.Show("Поле не заполнено", "Ошибка");
            }
        }
    }
}
