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
    public partial class TaskTwoForm : Form
    {
        private Pen pen = new Pen(Color.Black);
        private double x1, y1, x2, y2;
        private double i = 0;

        private void TaskTwoForm_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + 1;
            y2 = y1 + Math.Sin(x2);
        }

        public TaskTwoForm()
        {
            InitializeComponent();
        }

        private void TaskTwoForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawEllipse(pen, (float)x2, (float)y2, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 10;
            x2 = x1 + i/20.0;
            y2 = y1 + (y1 * Math.Sin(x2)/ 20.0);
            Invalidate();
        }
    }
}
