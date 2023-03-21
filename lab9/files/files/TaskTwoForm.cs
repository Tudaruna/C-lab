using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;

namespace files
{
    public partial class TaskTwoForm : Form
    {

        private string fileName = "tablets.dat";
        private List<Tablet> Tablets = new List<Tablet>();
        private int current = 0;


        private void TabletToTextBoxes(int current)
        {
            if (Tablets.Count > 0)
            {
               
                string[] TabletInfo = Tablets[current].GetStringValues();
                tbModel.Text = TabletInfo[0];
                tbDiagonal.Text = TabletInfo[1];
                tbOS.Text = TabletInfo[2];
                tbMemory.Text = TabletInfo[3];
                tbStorage.Text = TabletInfo[4];
                tbCPU.Text = TabletInfo[5];
            }
            else 
            {
                tbModel.Clear();
                tbDiagonal.Clear();
                tbOS.Clear();
                tbMemory.Clear();
                tbStorage.Clear();
                tbCPU.Clear();
            }
        }

        private void ScrollTablet(sbyte inc)
        {
            //inc - значение, на которое нужно изменить номер текущей записи
            //может принимать значения 1 и -1
            //если полученный номер записи больше нуля и меньше общего количества записей
            if ((current + inc <= Tablets.Count - 1) && (current + inc >= 0))
            {
                current += inc; //изменяем номер текущей записи
                TabletToTextBoxes(current); //отображаем эту запись
            }
        }

        private void AddTablet()
        {
            Tablet buf = new Tablet();                
            string[] TabletInfo = new string[6];
            TabletInfo[0] = tbModel.Text;
            TabletInfo[1] = tbDiagonal.Text;
            TabletInfo[2] = tbOS.Text;
            TabletInfo[3] = tbMemory.Text;
            TabletInfo[4] = tbStorage.Text;
            TabletInfo[5] = tbCPU.Text;
            buf.SetStringValues(TabletInfo);
            Tablets.Add(buf);
        }

        private void SaveFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(fileName,FileMode.OpenOrCreate, FileAccess.Write))
                {
                    bf.Serialize(fs, Tablets);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка ввода-вывода: " + ex.ToString());
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Ошибка сериализации: " + ex.ToString());
            }
        }

        private void DeleteTablet()
        {
            Tablets.RemoveAt(current);
            if (current > 0)
                current--; 
        }



        [Serializable]
        class Tablet
        {
            private string model;
            private double diagonal;
            private string operationSystem;
            private short memory;
            private short storage;
            private string cpu;
            
            public Tablet()
            {

            }

            public void SetStringValues(string[] array)
            {
                try
                {
                    model = array[0];
                    diagonal = Convert.ToDouble(array[1]);
                    operationSystem = array[2];
                    memory = Convert.ToInt16(array[3]);
                    storage = Convert.ToInt16(array[4]);
                    cpu = array[5];
                }
                catch
                {
                    MessageBox.Show("Данные введены неправильно", "Ошибка");
                }
            }

            public string[] GetStringValues()
            {
                string[] array = new string[6];
                array[0] = model;
                array[1] = diagonal.ToString();
                array[2] = operationSystem;
                array[3] = memory.ToString();
                array[4] = storage.ToString();
                array[5] = cpu;
                return array;
            }
        }


        public TaskTwoForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            tbModel.Clear();
            tbDiagonal.Clear();
            tbOS.Clear();
            tbMemory.Clear();
            tbStorage.Clear();
            tbCPU.Clear();
            btnSave.Visible = true;
            btnCancel.Visible = true;
            tslCount.Text = $"{Tablets.Count} запись из {Tablets.Count}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddTablet();
            SaveFile();
            current = Tablets.Count - 1;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            MessageBox.Show("Запись добавлена");
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            ScrollTablet(-1);
            tslCount.Text = $"{current+1} запись из {Tablets.Count}";
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            ScrollTablet(1);
            tslCount.Text = $"{current+1} запись из {Tablets.Count}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            TabletToTextBoxes(current);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Tablets.Count > 0)
            {
                DeleteTablet(); 
                if (Tablets.Count == 0)
                {
                    tbModel.Clear();
                    tbDiagonal.Clear();
                    tbOS.Clear();
                    tbMemory.Clear();
                    tbStorage.Clear();
                    tbCPU.Clear();
                }
                else
                {
                    TabletToTextBoxes(current);
                }
                SaveFile();
                MessageBox.Show("Запись удалена");
                if (Tablets.Count == 0)
                    tslCount.Text = $"Нет записей для отображения";
                else
                    tslCount.Text = $"{current+1} запись из {Tablets.Count}";
                
            }
        }

        private void TaskTwoForm_Load(object sender, EventArgs e)
        {
            tslCount.Text = $"Нет записей для отображения";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
