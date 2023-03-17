using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void switchToTaskOne_Click(object sender, EventArgs e)
        {
            var taskOneForm = new TaskOneForm();
            taskOneForm.Show();
        }

        private void switchToTaskTwo_Click(object sender, EventArgs e)
        {
            var taskTwoForm = new TaskTwoForm();
            taskTwoForm.Show();
        }

        private void switchToTaskThree_Click(object sender, EventArgs e)
        {
            var taskThreeForm = new TaskThreeForm();
            taskThreeForm.Show();
        }

        private void switchToIndependendTaskOne_Click(object sender, EventArgs e)
        {
            var independentTaskOneForm = new IndependentTaskOneForm();
            independentTaskOneForm.Show();
        }

        private void switchToIndependentTaskTwo_Click(object sender, EventArgs e)
        {
            var independentTaskTwoForm = new IndependentTaskTwoForm();
            independentTaskTwoForm.Show();
        }
    }
}
