using System;
using System.Windows.Forms;
namespace workWithNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcNum_Click(object sender, EventArgs e)
        {
            int x = int.Parse(inputNum.Text);
            resultNum.Text = (x >= 0) ? (x + 10).ToString() : (x-5).ToString();
        }

        private void inputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '-') return;
            e.Handled = true;
        }

        private void CheckNum_Click(object sender, EventArgs e)
        {
            var str = inputNum2.Text;
            if (str.Contains("3") || str.Contains("6") || str.Contains("9"))
                resultCheck.Text = $"Числа 3, 6 или 9 имеются в числе {str}";
            else
                resultCheck.Text = $"Числа 3, 6 или 9 не имеются в числе {str}";
        }
    }
}
