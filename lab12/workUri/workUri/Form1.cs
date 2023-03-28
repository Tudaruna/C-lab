using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace workUri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://www.professorweb.ru");
            StreamReader sr = new StreamReader(stream);
            string newLine;
            while((newLine = sr.ReadLine()) != null)
            {
                richTextBox.Text += newLine;
            }
            stream.Close();
        }
    }
}
