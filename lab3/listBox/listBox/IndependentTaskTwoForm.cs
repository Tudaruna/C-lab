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
    public partial class IndependentTaskTwoForm : Form
    {
        public IndependentTaskTwoForm()
        {
            InitializeComponent();
        }

        public double calcDeposit(ref double deposit, double percent)
        {
            deposit += deposit / 100 * (percent / 12.0);
            return deposit;
        }

        private void IndependentTaskTwoForm_Load(object sender, EventArgs e)
        {

        }

        private void calcTotal_Click(object sender, EventArgs e)
        {
            try
            {
                double deposit = Double.Parse(inputDeposit.Text);
                double percent = Double.Parse(inputPercent.Text);
                DateTime time = DateTime.Now;

                listBox.Items.Add(String.Format("{0,5}{1,30}", "Сумма вклада", "Дата вклада"));
                for (int i = 0; i < 12; i++)
                {
                    time = time.AddDays(30);
                    listBox.Items.Add(String.Format("{0,5}{1,50}", $"{calcDeposit(ref deposit, percent):0.##}", time));
                }
            } catch (Exception ex) {

                MessageBox.Show(Convert.ToString(ex), "Ошибка");
            }
        }
    }
}
