using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeFiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaskOne_Click(object sender, EventArgs e)
        {
            TaskOneForm taskOneForm = new TaskOneForm();
            taskOneForm.Show();
        }

        private void btnTaskTwo_Click(object sender, EventArgs e)
        {
            TaskTwoForm taskTwoForm = new TaskTwoForm();
            taskTwoForm.Show();
        }
    }
}
