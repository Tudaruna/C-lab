using System;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void input_KeyPress (object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == ',') return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
            
        }


        private void btnCalcAvg_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(inputNum1ForAvg.Text);
            double num2 = Double.Parse(inputNum2ForAvg.Text);
            double num3 = Double.Parse(inputNum3ForAvg.Text);

            double avg = (num1 + num2 + num3) / 3;
            labelAvg.Text = $"Сред.арифметическое равно {avg:0.##}";
        }

        private void btnCalcMinMax_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(inputNum1ForMaxMin.Text);
            double num2 = Double.Parse(inputNum2ForMaxMin.Text);

            labelMaxNum.Text = $"Максимальное число: {Math.Max(num1, num2)}";
            labelMinNum.Text = $"Минимальное число: {Math.Min(num1, num2)}";
        }

        private void btnCheckInterval_Click(object sender, EventArgs e)
        {
            double numCheck = Double.Parse(inputNumCheckIsInterval.Text);
            double startInterval = Double.Parse(inputStartInterval.Text);
            double endInterval = Double.Parse(inputEndInterval.Text);

            if (numCheck >= startInterval && numCheck <= endInterval)
            {
                labelNumIsInterval.Text = $"Число {numCheck} входит в интервал";
            }
            else
            {
                labelNumIsInterval.Text = $"Число {numCheck} не входит в интервал";
            }
        }
    }
}
