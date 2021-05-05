using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int a, position, row, h;
        string path, c;
        FontDialog fontDialog1;
        public Form1()
        {
            InitializeComponent();
            position = row = a =  0;
            fontDialog1 = new FontDialog();
            h = (int)textBox_Blocknot.Font.Size;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = "/System32/rundll32.exe powrprof.dll,SetSuspendState 0,1,0";
        }
        private void textBox_Blocknot_TextChanged(object sender, EventArgs e)
        {
            a++;
            toolStripStatusLabel1.Text = "Symbol  " + Convert.ToString(a);
        }

        private void textBox_Blocknot_KeyPress(object sender, KeyPressEventArgs e)  
        {
          
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Back))
                a--;
            if (textBox_Blocknot.Text == "")
                a = 0;
        }

        private void textBox_Blocknot_MouseClick(object sender, MouseEventArgs e) //показує рядок де знаходиться курсор
        {
            textBox1.Visible = false;
            textBox1.Clear();

            position = textBox_Blocknot.SelectionStart;
            row = textBox_Blocknot.GetLineFromCharIndex(position);
            toolStripStatusLabel3.Text = "Сurrent line  " + Convert.ToString(row + 1);
        }

        private void сertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOUR PC WILL TURN OFF IN 5 SECONDS ☠");   
            System.Diagnostics.Process.Start("cmd",c);
        }
        private void scalePlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h++;
            textBox_Blocknot.Font = new Font(textBox_Blocknot.Font.Name, h);
        }
        private void newWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_Blocknot.Text != "")
            {
                DialogResult result = MessageBox.Show("Save?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else
                    textBox_Blocknot.Clear();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(path))
            {
                File.WriteAllText(path, textBox_Blocknot.Text);
            }
            else
            {
                saveAsToolStripMenuItem_Click_1(sender, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newWindowsToolStripMenuItem_Click(sender, e);

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_Blocknot.Text = File.ReadAllText(open.FileName, Encoding.Default);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Blocknot.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Blocknot.Cut();
        }


        private void pustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Blocknot.Paste(Clipboard.GetText());
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void cutAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Blocknot.SelectAll();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // хотів зробити шоб найдене слово замалювало кольором але TextBox таке робити не може 
        {
            int  i = textBox_Blocknot.Text.IndexOf(textBox1.Text);
 
            if (i != 0)
            {
                textBox_Blocknot.Select(i, textBox1.Text.Length);

                 textBox_Blocknot.SelectionStart = i;
                 textBox_Blocknot.SelectionLength = textBox1.Text.Length;
                textBox_Blocknot.ForeColor = Color.Red;

            }
        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Blocknot.Undo();  //типу ctrl+z
        }

        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "text (*.txt)|*.txt | PDF (*.pdf)|*.pdf | docx (*.doc)|*.doc";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox_Blocknot.Text);
                path = saveFile.FileName;
            }
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h--;
            textBox_Blocknot.Font = new Font(textBox_Blocknot.Font.Name, h);
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox_Blocknot.Font;
            fontDialog1.Color = textBox_Blocknot.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox_Blocknot.Font = fontDialog1.Font;
                textBox_Blocknot.ForeColor = fontDialog1.Color;
            }
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox_Blocknot.Size = new Size(this.Width-40, this.Height-97);
        }      
    }
}
