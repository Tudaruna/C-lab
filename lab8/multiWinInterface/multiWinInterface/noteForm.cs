using System;
using System.Windows.Forms;
using System.IO;

namespace multiWinInterface
{
    public partial class noteForm : Form
    {
        private string fileName = "";
        public static int countNotes;
        public void NewNote()
        {
            countNotes++;
            Text = "Новая заметка" + countNotes.ToString();
        }

        public noteForm()
        {
            InitializeComponent();
        }

        public bool OpenNote()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                fileName = openFileDialog1.FileName;
                try
                {
                    rtbNote.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    Text = Path.GetFileNameWithoutExtension(fileName);
                    return true;
                }
                catch(ArgumentException ex)
                {
                    rtbNote.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    return true;
                }
                catch (IOException ex) 
                {
                    MessageBox.Show("Не удалось открыть файл" + ex.ToString(), "Ошибка");
                    return false;
                }
            }
            else 
            { 
                return false; 
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if  (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                fileName = saveFileDialog1.FileName;
                try
                {
                    if (saveFileDialog1.FilterIndex == 2)
                    {
                        rtbNote.SaveFile(fileName);
                    }
                    else
                    {
                        rtbNote.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                    }
                }
                catch 
                {
                    MessageBox.Show("Не удалось сохранить", "Ошибка");
                    return;
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                try
                {
                    File.Delete(fileName);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить", "Ошибка");
                    return;
                }
            }
        }

        private void tsbFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbNote.SelectionFont = fontDialog1.Font;
                rtbNote.SelectionColor = fontDialog1.Color;
            }
        }
    }
}
