using System;
using System.Windows.Forms;

namespace calcMeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcM_Click(object sender, EventArgs e)
        {
            double cm = Double.Parse(input.Text);
            result.Text = $"Расстояние в метрах равно {(cm / 100):0.##}";
        }

        public void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == ',') return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;

        }
    }
}
