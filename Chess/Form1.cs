using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        Rectangle rect;
        Brush brush;
        Image image;
        RectangleF srcRect;
        int drawDesk;
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            pen = new Pen(Color.Red, 1);
            rect = new Rectangle();
            brush = new SolidBrush(Color.White);
            drawDesk = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //graphics = e.Graphics;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Pihak_Click(object sender, EventArgs e)
        {

            graphics.DrawRectangle(pen, 10, 10, 10, 10);

        }

        private void Desk_Creat_button_Click(object sender, EventArgs e)
        {
            drawDesk++;
            if (drawDesk <=1)
            {
                bool isBlack = false;
                int sizedesk = 50;
                int pos = 1;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (isBlack)
                        {
                            pen = new Pen(Color.White);
                            brush = new SolidBrush(Color.White);
                            rect = new Rectangle((i * sizedesk) + pos, (j * sizedesk) + pos, sizedesk, sizedesk);
                            graphics.DrawRectangle(pen, rect);
                            graphics.FillRectangle(brush, rect);
                            isBlack = false;
                        }
                        else
                        {
                            isBlack = true;
                            pen = new Pen(Color.Gray);  // на чорних кліточках не видно чорних пешок тому сірий 
                            brush = new SolidBrush(Color.Gray);
                            rect = new Rectangle((i * sizedesk) + pos, (j * sizedesk) + pos, sizedesk, sizedesk);
                            graphics.DrawRectangle(pen, rect);
                            graphics.FillRectangle(brush, rect);
                        }

                    }
                    isBlack = !isBlack;  // ну буває)) 
                }
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            contextMenuStrip1.Show(new Point(Cursor.Position.X, Cursor.Position.Y));
        }

        private void пешкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0 , j = 0; i < 8; i++)
            {
                Seting("PeshkaWhite.png", 3+j, 303, rect.Size.Width - 5, rect.Size.Height - 5);
                j += 50;
            }
        }
        private void Seting(string a , int x , int y , int weight , int height)
        {
            image = Image.FromFile(a);

            srcRect = new RectangleF(x, y, weight, height );

            graphics.DrawImage(image, srcRect);
        }
        private void корольToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seting("WhiteKing.png", 153, 353 , rect.Size.Width - 5, rect.Size.Height - 5);
        }


        private void королеваToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seting("queenWhite.png", 203, 353, rect.Size.Width - 5, rect.Size.Height - 5);
        }

        private void офіцерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seting("Slon.png", 253, 353, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("Slon.png", 103, 353, rect.Size.Width - 5, rect.Size.Height - 5);
        }

        private void кіньToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seting("HorseWhite.png", 303, 353, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("HorseWhite.png", 53, 353, rect.Size.Width - 5, rect.Size.Height - 5);

        }

        private void тураToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Seting("TyraWhite.png", 353, 353, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("TyraWhite.png", 3, 353, rect.Size.Width - 5, rect.Size.Height - 5);

        }

        private void пешкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 0; i < 8; i++)
            {
                Seting("PeshkaBlack.png", 3 + j, 53, rect.Size.Width - 5, rect.Size.Height - 5);
                j += 50;
            }
        }

        private void BlackкорольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seting("BlackKing.png", 153, 3, rect.Size.Width - 5, rect.Size.Height - 5);
        }

        private void тураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seting("TyraBlack.png", 3, 3, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("TyraBlack.png", 353, 3, rect.Size.Width - 5, rect.Size.Height - 5);

        }

        private void королеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seting("QueenBlack.png", 203, 3, rect.Size.Width - 5, rect.Size.Height - 5);
        }

        private void кіньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seting("HorseBlack.png", 303, 3, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("HorseBlack.png", 53, 3, rect.Size.Width - 5, rect.Size.Height - 5);

        }

        private void офіцерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seting("SlonBlack.png", 253, 3, rect.Size.Width - 5, rect.Size.Height - 5);
            Seting("SlonBlack.png", 103, 3, rect.Size.Width - 5, rect.Size.Height - 5);
        }
    }
}
