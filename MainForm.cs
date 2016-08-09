using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainProject
{
    public partial class MainForm : Form
    {
        private string[] inputParameter;
        
        public MainForm(string[] args)
        { 
            inputParameter = args;
            InitializeComponent();
        }
        
        #region form events

        private void MainForm_Load(object sender, EventArgs e)
        { 
            Functions.Init();
            
            if (inputParameter.Length > 1)
            {
                textBox1.Text = inputParameter[0];
                textBox2.Text = inputParameter[1];
                
                bool recursive = false;
                if (inputParameter.Length > 2)
                    recursive = (inputParameter[2].ToLower() == "true" || inputParameter[2] == "1");
                
                checkBox1.Checked = recursive;
                
                List<string[]> diff = (List<string[]>)Functions.RunByConsole(textBox1.Text, textBox2.Text, recursive);
                
                listBox1.Items.AddRange(diff[0]);
                listBox2.Items.AddRange(diff[1]);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        { Functions.Close(); }
        
        void Button1Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
        
        void Button2Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog1.SelectedPath;            
        }
        
        void Button3Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            progressBar1.Value = 0;
                            
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a directory 1.");
                this.Enabled = true;
                return;
                
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a directory 2.");
                this.Enabled = true;
                return;
            }
            
            List<string[]> diff = (List<string[]>)Functions.RunByConsole(textBox1.Text, textBox2.Text, checkBox1.Checked);
            
            if (diff.Count == 2)
            {
                listBox1.Items.AddRange(diff[0]);
                listBox2.Items.AddRange(diff[1]);
            }
            
            this.Enabled = true;
        }

        #endregion //form events
        
        #region menu clicks

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        { Functions.ShowInfo(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Functions.Close(); }

        #endregion //menu clicks

        #region key events

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                Functions.SetKeyEvent(keyData);
                return true;
            }
            else
                return base.ProcessDialogKey(keyData);
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        { Functions.SetKeyEvent(e.KeyCode); }

        #endregion //key events
        
    }
}
