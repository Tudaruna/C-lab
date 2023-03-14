using System;
using System.Windows.Forms;

namespace calcExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcExpression_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(input.Text);
            double y;

            if (x < 0) y = x * x + 1;
            else if (x >= 0 && x <= 1) y = 2 * x + 1;
            else y = 4 * x - 1;
            result.Text = $"Y = {y:0.##}";
        }

        public void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == ',') return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;

        }

        private void calcExpression2_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(input2.Text);
            double y;

            if (x <= 3) y = Math.Pow(x, 2) - 3 * x + 9;
            else y = 1 / (Math.Pow(x, 3) + 1);
            result2.Text = $"Y = {y:0.##}";
        }
    }
}
