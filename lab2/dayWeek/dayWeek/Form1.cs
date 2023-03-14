using System;
using System.Windows.Forms;

namespace dayWeek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum dayWeek { Понедельник = 1, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье }

        private void calcDayWeek_Click(object sender, EventArgs e)
        {

            int x = int.Parse(input.Text);
            dayWeek day = (dayWeek)x;
            label2.Text = day.ToString();

        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
