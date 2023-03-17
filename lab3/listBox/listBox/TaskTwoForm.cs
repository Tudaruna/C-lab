using System;
using System.Windows.Forms;

namespace listBox
{
    public partial class TaskTwoForm : Form
    {
        public TaskTwoForm()
        {
            InitializeComponent();
        }

        private void searchNum_Click(object sender, EventArgs e)
        {
            try {
                var rand = new Random();
                listBox.Items.Clear();
                int n = int.Parse(input.Text);
                int pol = 0, otr = 0, zer = 0;
                for (int i = 0; i <= n; i++)
                {
                    int a = rand.Next(-50, 50);
                    listBox.Items.Add(a);
                    if (a == 0) zer++;
                    if (a > 0) pol++;
                    if (a < 0) otr++;
                }
                result.Text = $"Положительныйх чисел {pol} \n Отрицательных чисел: {otr} \n Количество чисел равных нулю: {zer}";
            }
            catch {
                MessageBox.Show("Поле не заполнено", "Ошибка");
            }
        }
    }
}
