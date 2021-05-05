using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintDZ
{
    public enum DrawlingObject
    {
        Pen, triengle, Rect, Circle, Line, Fill,
        Zalivka,  text
    }


    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        ColorDialog color;
        bool draw = false;
        TextBox textBox ;
        Point point;
        Rectangle rectangle;
        DrawlingObject drawlingObject;
        Point[] points;
        int x, y;
        int w = 0;
        int h = 0;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            color = new ColorDialog();
            pen = new Pen(button_color.BackColor, 1);
            //label_PenWidth.Text = trackBar1.Value.ToString();
            graphics = pictureBox1.CreateGraphics();
            point = new Point();
            x = y = 0;
            points = new Point[3];
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Pen_Click(object sender, EventArgs e)
        {
            pen.Color = button_color.BackColor;

            drawlingObject = DrawlingObject.Pen;
        }



        private void button_CLear_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox1.BackColor;
        }

        private void buttonColorPalitra_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
                button_color.BackColor = color.Color;
            pen.Color = button_color.BackColor;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

       
        private void button_Color_All_Click(object sender, EventArgs e)
        {
            if (drawlingObject == DrawlingObject.Rect)
            {
                drawlingObject = DrawlingObject.Zalivka;
                SolidBrush solidBrush = new SolidBrush(button_color.BackColor);
                graphics.FillRectangle(solidBrush, x, y, w, h);
            }
            else pictureBox1.BackColor = button_color.BackColor;
        }

    
        private void button_Text_Click(object sender, EventArgs e)
        {
            drawlingObject = DrawlingObject.text;
        }

        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            drawlingObject = DrawlingObject.Rect;
        }

        private void button_circle_Click(object sender, EventArgs e)
        {
            drawlingObject = DrawlingObject.Circle;
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            drawlingObject = DrawlingObject.Line;


        }



      
        private void button_triangle_Click(object sender, EventArgs e)
        {
            drawlingObject = DrawlingObject.triengle;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp|GIF|*.gif";
      

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap newBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(newBitmap, pictureBox1.ClientRectangle);
                newBitmap.Save(saveFileDialog.FileName);
            }
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                graphics = Graphics.FromImage(bitmap);
                if (drawlingObject == DrawlingObject.Pen)
                {
                    graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                    point.X = e.X;
                    point.Y = e.Y;
                    pictureBox1.Image = bitmap;
                }

                if (drawlingObject == DrawlingObject.Rect || drawlingObject == DrawlingObject.Circle)
                {
                    pen.Color = button_color.BackColor;
                    x = Math.Min(point.X, e.X);
                    y = Math.Min(point.Y, e.Y);
                    w = Math.Max(point.X, e.X) - x;
                    h = Math.Max(point.Y, e.Y) - y;
                    rectangle.X = x;
                    rectangle.Y = y;
                    rectangle.Width = w;
                    rectangle.Height = h;
                }
                if (drawlingObject == DrawlingObject.triengle)
                {
                    points[0].X = point.X; points[0].Y = point.Y;
                    points[1].X = e.X; points[1].Y = e.Y;
                    points[2].X = point.X; points[2].Y = e.Y;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                pictureBox1.Image = bitmap;
            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            draw = false;
            if (drawlingObject == DrawlingObject.Line)
            {
                graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                pictureBox1.Image = bitmap;
            }
            if (drawlingObject == DrawlingObject.Circle)
            {
                graphics.DrawEllipse(pen, rectangle);
                pictureBox1.Image = bitmap;

            }
            if (drawlingObject == DrawlingObject.Rect)
            {
                graphics.DrawRectangle(pen, rectangle);
                pictureBox1.Image = bitmap;

            }
            if (drawlingObject == DrawlingObject.triengle)
            {
                graphics.DrawPolygon(pen, points);
                pictureBox1.Image = bitmap;

            }

        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            draw = true;
            point.X = e.X;
            point.Y = e.Y;
            //if (rectangl)
            //{
            //    point.X = e.X;
            //    point.Y = e.Y;
            //}

        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (drawlingObject == DrawlingObject.text)
            {
                textBox = new TextBox();
                textBox.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 300);
                pictureBox1.Controls.Add(textBox);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

    }
}
