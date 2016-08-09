namespace MainProject
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.checkBox1 = new System.Windows.Forms.CheckBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.listBox2 = new System.Windows.Forms.ListBox();
        	this.button3 = new System.Windows.Forms.Button();
        	this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        	this.progressBar1 = new System.Windows.Forms.ProgressBar();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
        	this.menuStrip1.Size = new System.Drawing.Size(944, 35);
        	this.menuStrip1.TabIndex = 0;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.infoToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// infoToolStripMenuItem
        	// 
        	this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
        	this.infoToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
        	this.infoToolStripMenuItem.Text = "&Info";
        	this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(18, 62);
        	this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(112, 35);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "Directory 1";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(500, 62);
        	this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(112, 35);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Directory 2";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(18, 106);
        	this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(426, 26);
        	this.textBox1.TabIndex = 3;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(500, 106);
        	this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(426, 26);
        	this.textBox2.TabIndex = 4;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(18, 260);
        	this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(150, 35);
        	this.label1.TabIndex = 5;
        	this.label1.Text = "Only left:";
        	// 
        	// listBox1
        	// 
        	this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left)));
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.HorizontalScrollbar = true;
        	this.listBox1.ItemHeight = 20;
        	this.listBox1.Location = new System.Drawing.Point(18, 289);
        	this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
        	this.listBox1.Size = new System.Drawing.Size(426, 124);
        	this.listBox1.TabIndex = 6;
        	// 
        	// checkBox1
        	// 
        	this.checkBox1.Location = new System.Drawing.Point(18, 160);
        	this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.checkBox1.Name = "checkBox1";
        	this.checkBox1.Size = new System.Drawing.Size(300, 37);
        	this.checkBox1.TabIndex = 8;
        	this.checkBox1.Text = "Check subdirectories";
        	this.checkBox1.UseVisualStyleBackColor = true;
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(500, 260);
        	this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(150, 35);
        	this.label2.TabIndex = 9;
        	this.label2.Text = "Only right:";
        	// 
        	// listBox2
        	// 
        	this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left)));
        	this.listBox2.FormattingEnabled = true;
        	this.listBox2.HorizontalScrollbar = true;
        	this.listBox2.ItemHeight = 20;
        	this.listBox2.Location = new System.Drawing.Point(500, 289);
        	this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.listBox2.Name = "listBox2";
        	this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
        	this.listBox2.Size = new System.Drawing.Size(426, 124);
        	this.listBox2.TabIndex = 10;
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(18, 212);
        	this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(909, 35);
        	this.button3.TabIndex = 11;
        	this.button3.Text = "Compare";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// progressBar1
        	// 
        	this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        	this.progressBar1.Location = new System.Drawing.Point(18, 434);
        	this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.progressBar1.Name = "progressBar1";
        	this.progressBar1.Size = new System.Drawing.Size(909, 35);
        	this.progressBar1.TabIndex = 12;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(944, 488);
        	this.Controls.Add(this.progressBar1);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.listBox2);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.checkBox1);
        	this.Controls.Add(this.listBox1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.menuStrip1);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.KeyPreview = true;
        	this.MainMenuStrip = this.menuStrip1;
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        internal System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

