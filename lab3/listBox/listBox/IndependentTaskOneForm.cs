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
    public partial class IndependentTaskOneForm : Form
    {
        public IndependentTaskOneForm()
        {
            InitializeComponent();
        }


        private void addGnom_Click(object sender, EventArgs e)
        {
            double height = Double.Parse(input.Text);
            if (height > 55)
            {
                MessageBox.Show("На данный рост нет рубашки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (height <= 35)
                listBox.Items.Add(String.Format("{0,-5}{1,30}", height, "I"));
            else if (height > 35 && height <= 45)
                listBox.Items.Add(String.Format("{0,-5}{1,30}", height, "II"));
            else
                listBox.Items.Add(String.Format("{0,-5}{1,30}", height, "III"));
        }

        private void IndependentTaskOneForm_Load(object sender, EventArgs e)
        {
            listBox.Items.Add(String.Format("{0,-5}{1,30}", "Рост", "Размер рубашки"));
        }

        private void delGnom_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clearListBox_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == ',') return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
