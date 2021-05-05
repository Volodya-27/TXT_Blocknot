
namespace PaintDZ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Text = new System.Windows.Forms.Button();
            this.button_CLear = new System.Windows.Forms.Button();
            this.button_Color_All = new System.Windows.Forms.Button();
            this.button_Pen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_triangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_circle = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonColorPalitra = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_Text);
            this.groupBox1.Controls.Add(this.button_CLear);
            this.groupBox1.Controls.Add(this.button_Color_All);
            this.groupBox1.Controls.Add(this.button_Pen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_Text
            // 
            this.button_Text.BackColor = System.Drawing.Color.White;
            this.button_Text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Text.BackgroundImage")));
            this.button_Text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Text.Location = new System.Drawing.Point(136, 10);
            this.button_Text.Name = "button_Text";
            this.button_Text.Size = new System.Drawing.Size(37, 40);
            this.button_Text.TabIndex = 5;
            this.button_Text.UseVisualStyleBackColor = false;
            this.button_Text.Click += new System.EventHandler(this.button_Text_Click);
            // 
            // button_CLear
            // 
            this.button_CLear.BackColor = System.Drawing.Color.White;
            this.button_CLear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CLear.BackgroundImage")));
            this.button_CLear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_CLear.Location = new System.Drawing.Point(93, 10);
            this.button_CLear.Name = "button_CLear";
            this.button_CLear.Size = new System.Drawing.Size(37, 40);
            this.button_CLear.TabIndex = 3;
            this.button_CLear.UseVisualStyleBackColor = false;
            this.button_CLear.Click += new System.EventHandler(this.button_CLear_Click);
            // 
            // button_Color_All
            // 
            this.button_Color_All.BackColor = System.Drawing.Color.White;
            this.button_Color_All.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Color_All.BackgroundImage")));
            this.button_Color_All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Color_All.Location = new System.Drawing.Point(50, 10);
            this.button_Color_All.Name = "button_Color_All";
            this.button_Color_All.Size = new System.Drawing.Size(37, 40);
            this.button_Color_All.TabIndex = 2;
            this.button_Color_All.UseVisualStyleBackColor = false;
            this.button_Color_All.Click += new System.EventHandler(this.button_Color_All_Click);
            // 
            // button_Pen
            // 
            this.button_Pen.BackColor = System.Drawing.Color.White;
            this.button_Pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Pen.BackgroundImage")));
            this.button_Pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Pen.Location = new System.Drawing.Point(7, 10);
            this.button_Pen.Name = "button_Pen";
            this.button_Pen.Size = new System.Drawing.Size(37, 40);
            this.button_Pen.TabIndex = 1;
            this.button_Pen.UseVisualStyleBackColor = false;
            this.button_Pen.Click += new System.EventHandler(this.button_Pen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Інструменти";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_triangle);
            this.groupBox2.Controls.Add(this.button_line);
            this.groupBox2.Controls.Add(this.button_circle);
            this.groupBox2.Controls.Add(this.button_Rectangle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Location = new System.Drawing.Point(293, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button_triangle
            // 
            this.button_triangle.BackColor = System.Drawing.Color.White;
            this.button_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_triangle.BackgroundImage")));
            this.button_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_triangle.Location = new System.Drawing.Point(135, 11);
            this.button_triangle.Name = "button_triangle";
            this.button_triangle.Size = new System.Drawing.Size(37, 40);
            this.button_triangle.TabIndex = 10;
            this.button_triangle.UseVisualStyleBackColor = false;
            this.button_triangle.Click += new System.EventHandler(this.button_triangle_Click);
            // 
            // button_line
            // 
            this.button_line.BackColor = System.Drawing.Color.White;
            this.button_line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_line.BackgroundImage")));
            this.button_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_line.Location = new System.Drawing.Point(92, 11);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(37, 40);
            this.button_line.TabIndex = 8;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_circle
            // 
            this.button_circle.BackColor = System.Drawing.Color.White;
            this.button_circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_circle.BackgroundImage")));
            this.button_circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_circle.Location = new System.Drawing.Point(49, 11);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(37, 40);
            this.button_circle.TabIndex = 7;
            this.button_circle.UseVisualStyleBackColor = false;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.BackColor = System.Drawing.Color.White;
            this.button_Rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Rectangle.BackgroundImage")));
            this.button_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Rectangle.Location = new System.Drawing.Point(6, 11);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(37, 40);
            this.button_Rectangle.TabIndex = 6;
            this.button_Rectangle.UseVisualStyleBackColor = false;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фігури";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonColorPalitra);
            this.groupBox3.Controls.Add(this.button_color);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Location = new System.Drawing.Point(573, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 82);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // buttonColorPalitra
            // 
            this.buttonColorPalitra.BackColor = System.Drawing.Color.White;
            this.buttonColorPalitra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonColorPalitra.BackgroundImage")));
            this.buttonColorPalitra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonColorPalitra.Location = new System.Drawing.Point(53, 11);
            this.buttonColorPalitra.Name = "buttonColorPalitra";
            this.buttonColorPalitra.Size = new System.Drawing.Size(41, 40);
            this.buttonColorPalitra.TabIndex = 12;
            this.buttonColorPalitra.UseVisualStyleBackColor = false;
            this.buttonColorPalitra.Click += new System.EventHandler(this.buttonColorPalitra_Click);
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.Red;
            this.button_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_color.Location = new System.Drawing.Point(6, 10);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(37, 40);
            this.button_color.TabIndex = 11;
            this.button_color.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Колір";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(679, 49);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(186, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(13, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 597);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(877, 803);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Text;
        private System.Windows.Forms.Button button_CLear;
        private System.Windows.Forms.Button button_Color_All;
        private System.Windows.Forms.Button button_Pen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.Button button_triangle;
        private System.Windows.Forms.Button buttonColorPalitra;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

