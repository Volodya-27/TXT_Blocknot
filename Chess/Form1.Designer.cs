
namespace Chess
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пешкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.тураToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кіньToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.корольToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.королеваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.офіцерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пешкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.корольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.королеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кіньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.офіцерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Desk_Creat_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 559);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figureToolStripMenuItem});
            this.contextMenuStrip1.Margin = new System.Windows.Forms.Padding(50);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пешкаToolStripMenuItem1,
            this.тураToolStripMenuItem1,
            this.кіньToolStripMenuItem1,
            this.корольToolStripMenuItem1,
            this.королеваToolStripMenuItem1,
            this.офіцерToolStripMenuItem1});
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // пешкаToolStripMenuItem1
            // 
            this.пешкаToolStripMenuItem1.Name = "пешкаToolStripMenuItem1";
            this.пешкаToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.пешкаToolStripMenuItem1.Text = "Пешка";
            this.пешкаToolStripMenuItem1.Click += new System.EventHandler(this.пешкаToolStripMenuItem1_Click);
            // 
            // тураToolStripMenuItem1
            // 
            this.тураToolStripMenuItem1.Name = "тураToolStripMenuItem1";
            this.тураToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.тураToolStripMenuItem1.Text = "Тура";
            this.тураToolStripMenuItem1.Click += new System.EventHandler(this.тураToolStripMenuItem1_Click);
            // 
            // кіньToolStripMenuItem1
            // 
            this.кіньToolStripMenuItem1.Name = "кіньToolStripMenuItem1";
            this.кіньToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.кіньToolStripMenuItem1.Text = "Кінь";
            this.кіньToolStripMenuItem1.Click += new System.EventHandler(this.кіньToolStripMenuItem1_Click);
            // 
            // корольToolStripMenuItem1
            // 
            this.корольToolStripMenuItem1.Name = "корольToolStripMenuItem1";
            this.корольToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.корольToolStripMenuItem1.Text = "Король";
            this.корольToolStripMenuItem1.Click += new System.EventHandler(this.корольToolStripMenuItem1_Click);
            // 
            // королеваToolStripMenuItem1
            // 
            this.королеваToolStripMenuItem1.Name = "королеваToolStripMenuItem1";
            this.королеваToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.королеваToolStripMenuItem1.Text = "Королева";
            this.королеваToolStripMenuItem1.Click += new System.EventHandler(this.королеваToolStripMenuItem1_Click);
            // 
            // офіцерToolStripMenuItem1
            // 
            this.офіцерToolStripMenuItem1.Name = "офіцерToolStripMenuItem1";
            this.офіцерToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.офіцерToolStripMenuItem1.Text = "Офіцер";
            this.офіцерToolStripMenuItem1.Click += new System.EventHandler(this.офіцерToolStripMenuItem1_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пешкаToolStripMenuItem,
            this.корольToolStripMenuItem,
            this.тураToolStripMenuItem,
            this.королеваToolStripMenuItem,
            this.кіньToolStripMenuItem,
            this.офіцерToolStripMenuItem});
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // пешкаToolStripMenuItem
            // 
            this.пешкаToolStripMenuItem.Name = "пешкаToolStripMenuItem";
            this.пешкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пешкаToolStripMenuItem.Text = "Пешка";
            this.пешкаToolStripMenuItem.Click += new System.EventHandler(this.пешкаToolStripMenuItem_Click);
            // 
            // корольToolStripMenuItem
            // 
            this.корольToolStripMenuItem.Name = "корольToolStripMenuItem";
            this.корольToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.корольToolStripMenuItem.Text = "Король";
            this.корольToolStripMenuItem.Click += new System.EventHandler(this.BlackкорольToolStripMenuItem_Click);
            // 
            // тураToolStripMenuItem
            // 
            this.тураToolStripMenuItem.Name = "тураToolStripMenuItem";
            this.тураToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тураToolStripMenuItem.Text = "Тура";
            this.тураToolStripMenuItem.Click += new System.EventHandler(this.тураToolStripMenuItem_Click);
            // 
            // королеваToolStripMenuItem
            // 
            this.королеваToolStripMenuItem.Name = "королеваToolStripMenuItem";
            this.королеваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.королеваToolStripMenuItem.Text = "Королева";
            this.королеваToolStripMenuItem.Click += new System.EventHandler(this.королеваToolStripMenuItem_Click);
            // 
            // кіньToolStripMenuItem
            // 
            this.кіньToolStripMenuItem.Name = "кіньToolStripMenuItem";
            this.кіньToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кіньToolStripMenuItem.Text = "Кінь";
            this.кіньToolStripMenuItem.Click += new System.EventHandler(this.кіньToolStripMenuItem_Click);
            // 
            // офіцерToolStripMenuItem
            // 
            this.офіцерToolStripMenuItem.Name = "офіцерToolStripMenuItem";
            this.офіцерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.офіцерToolStripMenuItem.Text = "Офіцер";
            this.офіцерToolStripMenuItem.Click += new System.EventHandler(this.офіцерToolStripMenuItem_Click);
            // 
            // Desk_Creat_button
            // 
            this.Desk_Creat_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Desk_Creat_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Desk_Creat_button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desk_Creat_button.Location = new System.Drawing.Point(12, 577);
            this.Desk_Creat_button.Name = "Desk_Creat_button";
            this.Desk_Creat_button.Size = new System.Drawing.Size(949, 137);
            this.Desk_Creat_button.TabIndex = 2;
            this.Desk_Creat_button.Text = "Desk Create";
            this.Desk_Creat_button.UseVisualStyleBackColor = false;
            this.Desk_Creat_button.Click += new System.EventHandler(this.Desk_Creat_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 726);
            this.Controls.Add(this.Desk_Creat_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пешкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem тураToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кіньToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem корольToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem королеваToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem офіцерToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пешкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem корольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem королеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кіньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem офіцерToolStripMenuItem;
        private System.Windows.Forms.Button Desk_Creat_button;
    }
}

