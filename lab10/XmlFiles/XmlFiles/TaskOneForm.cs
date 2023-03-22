using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XmlFiles
{
    public partial class TaskOneForm : Form
    {
        private string filename = "../../results.xml";

        public TaskOneForm()
        {
            InitializeComponent();
        }

        List<string>  entryes = new List<string>();

        private void loadXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            foreach (XmlNode xmlNode in xmlRoot)
            {
                string id = "";
                string name = "";
                string score = "";
                DateTime time = DateTime.Now;
                if (xmlNode.Attributes.Count > 0)
                {
                    XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                    if (attr != null)
                        id = attr.Value;
                }

                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {

                    if (childNode.Name == "name")
                    {
                        name = childNode.InnerText.ToString();
                    }
                    if (childNode.Name == "score")
                    {
                        score = childNode.InnerText.ToString();
                    }
                }
                addPlayerToList(id, name, score, time);
            }
        }

        private void addPlayerToList(string id, string name, string score, DateTime time)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(score);
            lvi.SubItems.Add(time.ToString());
            listOfPlayers.Items.Add(lvi);
        }

        private void TaskOneForm_Load(object sender, EventArgs e)
        {
            loadXml();
        }

        private void addToXml()
        {
            DateTime time = DateTime.Now;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            XmlElement playerElem = xmlDoc.CreateElement("player");
            XmlAttribute idAttr = xmlDoc.CreateAttribute("id");

            XmlElement nameElem = xmlDoc.CreateElement("name");
            XmlElement scoreElem = xmlDoc.CreateElement("score");
            XmlElement timeElem = xmlDoc.CreateElement("time");


            XmlText idText = xmlDoc.CreateTextNode((xmlRoot.ChildNodes.Count + 1).ToString());
            XmlText nameText = xmlDoc.CreateTextNode(txtName.Text);
            XmlText scoreText = xmlDoc.CreateTextNode(txtScore.Text);
            XmlText timeText = xmlDoc.CreateTextNode(time.ToString());

            idAttr.AppendChild(idText);
            nameElem.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);
            timeElem.AppendChild(timeText);


            playerElem.Attributes.Append(idAttr);
            playerElem.AppendChild(nameElem);
            playerElem.AppendChild(scoreElem);
            playerElem.AppendChild(timeElem);

            xmlRoot.AppendChild(playerElem);

            xmlDoc.Save(filename);

            string id = (xmlRoot.ChildNodes.Count).ToString();
            string name = txtName.Text;
            string score = txtScore.Text;

            addPlayerToList(id, name, score, time);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addToXml();
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void btnOutWhere_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNumEnd.Text == "" || tbNumStart.Text == "")
                {
                    throw new Exception("Поля не заполнены");
                }
                if ((Int32.Parse(tbNumStart.Text) > Int32.Parse(tbNumEnd.Text)))
                {
                    throw new Exception("Не правильно введены значения");
                }



                listOfPlayers.Items.Clear();



                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);
                XmlElement xmlRoot = xmlDoc.DocumentElement;
                foreach (XmlNode xmlNode in xmlRoot)
                {
                    string id = "";
                    string name = "";
                    string score = "";
                    DateTime time = DateTime.Now;
                    if (xmlNode.Attributes.Count > 0)
                    {
                        XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            id = attr.Value;
                    }

                    foreach (XmlNode childNode in xmlNode.ChildNodes)
                    {

                        if (childNode.Name == "name")
                        {
                            name = childNode.InnerText.ToString();
                        }
                        if (childNode.Name == "score")
                        {
                            score = childNode.InnerText.ToString();
                        }
                    }
                    if (score != "" && Int32.Parse(score) >= Int32.Parse(tbNumStart.Text) && Int32.Parse(score) <= Int32.Parse(tbNumEnd.Text))
                    {
                        addPlayerToList(id, name, score, time);
                    }
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }

        }

        private void viewList_Click(object sender, EventArgs e)
        {
            loadXml();
        }
    }
}
