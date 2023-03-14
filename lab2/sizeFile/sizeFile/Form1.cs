using System;
using System.Windows.Forms;

namespace sizeFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcSizeKB_Click(object sender, EventArgs e)
        {
            double bt = Double.Parse(input.Text);
            result.Text = $"Размер файла в КБ равен {(bt / 1024):0.##}";
        }
    }
}
