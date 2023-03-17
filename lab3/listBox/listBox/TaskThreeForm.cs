using System;

using System.Windows.Forms;

namespace listBox
{
    public partial class TaskThreeForm : Form
    {
        public TaskThreeForm()
        {
            InitializeComponent();
        }

        private void TaskThreeForm_Load(object sender, EventArgs e)
        {

        }

        private void addRow_Click(object sender, EventArgs e)
        {
            int  n = listBox.Items.Count;
            if (n <= 9 && input.Text != "")
                listBox.Items.Add(int.Parse(input.Text));
            else
                MessageBox.Show("Добавлять числа нельзя, т.к список уже содержит 10 чисел", "Ввод запрещен", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            input.Text = "";
        }

        private void checkAndChange_Click(object sender, EventArgs e)
        {
            int n = listBox.Items.Count;
            if (n < 9)
                MessageBox.Show("Проверить список нельзя, т.к списко содержит менее 10 чисел",
                                "Введите недостающие числа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                for (int i = 0; i < n; i++)
                {
                    if (Convert.ToInt32(listBox.Items[i]) > 15)
                        listBox.Items[i] = 15;
                }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                MessageBox.Show("Введите число в текстовый блок",
                                "Введите заменяемое число",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
            else
                listBox.Items[listBox.SelectedIndex] = Convert.ToInt32(input.Text);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }
    }
}
