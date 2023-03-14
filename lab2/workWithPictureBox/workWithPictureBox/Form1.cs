using System;
using System.Drawing;
using System.Windows.Forms;
namespace workWithPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenPicture_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            openFileDialog1.Filter = "Picture (*.jpg, *.png, *.svg, *.jpeg)|";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void ClearPicture_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = false;
        }
    }
}
