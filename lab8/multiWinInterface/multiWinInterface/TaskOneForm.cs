using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace multiWinInterface
{
    public partial class TaskOneForm : Form
    {
        public TaskOneForm()
        {
            InitializeComponent();
            DriveTreeInit();
        }

        private void DriveTreeInit ()
        {
            string[] driversArray = Directory.GetLogicalDrives();

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            foreach (string driver in driversArray)
            {
                TreeNode drive = new TreeNode(driver, 0 , 0);
                treeView1.Nodes.Add(drive);
                GetDirs(drive);
            }
            treeView1.EndUpdate();
        }

        private void GetDirs(TreeNode node)
        {
            DirectoryInfo[] dirArray;
            node.Nodes.Clear();
            string fullPath = node.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);

            try
            {
                dirArray = di.GetDirectories();
            }
            catch
            {
                return;
            }
            foreach(DirectoryInfo dirInfo in dirArray)
            {
                TreeNode dir = new TreeNode(dirInfo.Name, 0 , 0);
                node.Nodes.Add(dir);
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView1.BeginUpdate();
            foreach(TreeNode node in e.Node.Nodes) { 
                GetDirs(node);
            }
            treeView1.EndUpdate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string fullPath = selectedNode.FullPath;

            DirectoryInfo di = new DirectoryInfo(fullPath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;

            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch 
            { 
                return; 
            }
            listView1.Items.Clear();
            foreach(DirectoryInfo dirInfo in diArray)
            {
                ListViewItem lvi = new ListViewItem(dirInfo.Name);
                lvi.SubItems.Add("0");
                lvi.SubItems.Add(dirInfo.LastWriteTime.ToString());
                listView1.Items.Add(lvi);
            }

            foreach(FileInfo fileInfo in fiArray)
            {
                ListViewItem lvi = new ListViewItem(fileInfo.Name);
                lvi.SubItems.Add(fileInfo.Length.ToString());
                lvi.SubItems.Add(fileInfo.LastWriteTime.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in listView1.SelectedItems)
            {
                string ext = Path.GetExtension(lvi.Text).ToLower();
                string fullPath = treeView1.SelectedNode.FullPath;
                if (ext == ".txt" || ext == ".html" || ext == ".xml")
                {
                    try
                    {
                        richTextBox1.LoadFile(Path.Combine(fullPath, lvi.Text), RichTextBoxStreamType.PlainText);
                    }
                    catch 
                    {
                        return;
                    }

                }
            }
        }
    }
}
