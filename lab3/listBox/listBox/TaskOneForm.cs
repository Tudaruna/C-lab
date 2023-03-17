using System;
using System.Windows.Forms;

namespace listBox
{
    public partial class TaskOneForm : Form
    {
        public TaskOneForm()
        {
            InitializeComponent();
        }

        private void calcFunc_Click(object sender, EventArgs e)
        {
            double y;
            listBox1.Items.Add(String.Format("{0,5}{1,20}", "x", "y"));
            listBox1.Items.Add("---------------------------");
            for (double x =1; x <= 2; x+=0.2)
            {
                y = Math.Sin(x);
                listBox1.Items.Add(String.Format("\r\n{0,-5:F1}{1,20:F2}", x, y));
            }
        }
    }
}
