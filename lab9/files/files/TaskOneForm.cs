using System;
using System.Windows.Forms;
using System.IO;

namespace files
{
    public partial class TaskOneForm : Form
    {
        private FileInfo fiSource;
        private string fileName;
        private FileStream fsSource;
        private StreamReader srSource;
        private StreamWriter swSource;

        public TaskOneForm()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            fileName = tbInput.Text;
            fiSource = new FileInfo(fileName);
            tbInfo.Clear();
            tbEdit.Clear();
            tbInput.Clear();
            try
            {
                if (fiSource.Exists)
                {
                    lblFilename.Text = $"Информация о файле: {fileName}";
                    tbInfo.Text += $"Время создания файла {fiSource.CreationTime} \r\n";
                    tbInfo.Text += $"Размер файла {fiSource.Length} байт \r\n";
                    tbInfo.Text += $"Полный путь к файлу: {fiSource.FullName} \r\n";
                    if (fiSource.IsReadOnly)
                    {
                        tbInfo.Text += $"Файл доступен только для чтения";
                    }
                    else
                        tbInfo.Text += "Файл доступен для изменения";
                }
            }
            catch (IOException ex) 
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

            if (Path.GetExtension(fileName) == ".txt")
            {
                btnSave.Enabled = true;
                tbEdit.Enabled = true;
                tbEdit.ReadOnly = false;
                fsSource = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                srSource = new StreamReader(fsSource);
                string line;

                line = srSource.ReadLine();
                while(line != null )
                {
                    tbEdit.Text += $"{line} \r\n";
                    line = srSource.ReadLine();
                }
                srSource.Close();
            }
            else
            {
                tbEdit.Text += "Файл не является текстовым";
                btnSave.Enabled = false;
                tbEdit.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                fsSource = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                swSource = new StreamWriter(fsSource);

                for (int i = 0; i < tbEdit.Lines.Length; i++)
                {
                    swSource.WriteLine(tbEdit.Lines[i]);
                }
                swSource.Close();
                MessageBox.Show("Изменения сохранены!");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Произошла ошибка доступа {ex.Message}");
            }
        }
    }
}
