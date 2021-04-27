using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Provodnik
{
    public partial class Form1 : Form
    {
        string path1;
    
        public Form1()
        {
            InitializeComponent();
            path1 = "";
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            FillDriveNodes();

        }

        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    path1 = drive.Name;
                    FillTreeNode(driveNode, drive.Name);
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception ex) { }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            textBox1.Text = path1;
            Add(e);
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            textBox1.Text = path1;
            Add(e);
        }
        private void Add(TreeViewCancelEventArgs e)
        {
            
            e.Node.Nodes.Clear();
            string[] dirs;

            if (Directory.Exists(e.Node.FullPath))
            {
                dirs = Directory.GetDirectories(e.Node.FullPath);
                path1 = e.Node.FullPath;

                if (dirs.Length != 0)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                        FillTreeNode(dirNode, dirs[i]);
                        e.Node.Nodes.Add(dirNode);
                    }
                }
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            Process.Start(path1);
        }


        private void button_Next_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeViewItem parentItem = new TreeViewItem();
            if (e.KeyCode == Keys.Enter)
            {
                parentItem.IsExpanded = true;
            }
            
           
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
           
        }

    }
}
