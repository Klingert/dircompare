using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    internal static class Functions
    {
        private static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private static FormWindowState lastWindowState = FormWindowState.Normal;
        
        internal static void Init()
        {
            try
            {
                Size sizeApp = new Size();
                if (ConfigurationManager.AppSettings["windowState"] == "Maximized")
                    Program.mainForm.WindowState = FormWindowState.Maximized;
                else
                {
                    Program.mainForm.WindowState = FormWindowState.Normal;
                    sizeApp.Width = Convert.ToInt32(ConfigurationManager.AppSettings["appWidth"]);
                    sizeApp.Height = Convert.ToInt32(ConfigurationManager.AppSettings["appHeight"]);
                    Program.mainForm.Size = sizeApp;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        internal static void Close()
        {
            try
            {
                ChangeAppSetting("windowState", Program.mainForm.WindowState.ToString());
                if (Program.mainForm.WindowState != FormWindowState.Maximized)
                {
                    ChangeAppSetting("appWidth", Program.mainForm.Size.Width.ToString());
                    ChangeAppSetting("appHeight", Program.mainForm.Size.Height.ToString());
                }
                config.Save(ConfigurationSaveMode.Modified);

                Application.Exit();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        internal static void ShowInfo()
        {
            try
            {
                Info frmInfo = new Info();
                frmInfo.textBox1.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

                frmInfo.ShowDialog();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        internal static void Resize()
        {
            try
            {
                //ToDo:
                //Testen, dass nach Maximized wieder vorhergehende Größe
                //nach Schließen von Minimized nach Öffnen wieder normal
                if (lastWindowState != FormWindowState.Normal)
                {
                    ChangeAppSetting("appWidth", Program.mainForm.Size.Width.ToString());
                    ChangeAppSetting("appHeight", Program.mainForm.Size.Height.ToString());
                    config.Save(ConfigurationSaveMode.Modified);
                }

                FormWindowState windowState = Program.mainForm.WindowState;
                if (windowState == FormWindowState.Maximized || windowState == FormWindowState.Minimized)
                {
                    lastWindowState = Program.mainForm.WindowState;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private static void ChangeAppSetting(string sSetting, string sValue)
        {
            try
            {
                config.AppSettings.Settings.Remove(sSetting);
                config.AppSettings.Settings.Add(sSetting, sValue);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        internal static void SetKeyEvent(Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case Keys.Prior:
                    case Keys.OemMinus:
                    case Keys.Down:
                    case Keys.Left:
                        //ToDo: Insert function    
                        //Previous();
                        break;
                    case Keys.Next:
                    case Keys.Oemplus:
                    case Keys.Space:
                    case Keys.Up:
                    case Keys.Right:
                        //ToDo: Insert function   
                        //Next();
                        break;
                    case Keys.Home:
                        //ToDo: Insert function   
                        //First();
                        break;
                    case Keys.End:
                        //ToDo: Insert function   
                        //Last();
                        break;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        internal static IList<string[]> RunByConsole(string path1, string path2, bool recursive)
        {
            List<string[]> ret = new List<string[]>();
            
            try
            {   
                SearchOption option;
                if (recursive)
                    option = SearchOption.AllDirectories;
                else
                    option = SearchOption.TopDirectoryOnly;
                
                ProgressBar progressBar = Program.mainForm.progressBar1;
                ret.Add(CompareDirs(path1, path2, option, progressBar));
                ret.Add(CompareDirs(path2, path1, option, progressBar));
                
                progressBar.Value = progressBar.Maximum;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
            return ret;
        }
        
        public static string[] CompareDirs(string dirReference, string dirToCompare, SearchOption option, System.Windows.Forms.ProgressBar progressBar = null)
        {
            if (!Directory.Exists(dirReference))
                throw new Exception("Can not find '" + dirReference + "'.");

            if (!Directory.Exists(dirToCompare))
                throw new Exception("Can not find '" + dirToCompare + "'.");
                
            string[] dir1 = Directory.GetDirectories(dirReference, "*", option);
            string[] dir2 = Directory.GetDirectories(dirToCompare, "*", option);
            
            Dictionary<string, string> dic1 = (Dictionary<string, string>)ConvertToDic(dir1, dirReference);
            Dictionary<string, string> dic2 = (Dictionary<string, string>)ConvertToDic(dir2, dirToCompare);
            
            if (progressBar != null)
                progressBar.Maximum = dic1.Count + dic2.Count;
            string[] diff = CompareDics(dic1, dic2, progressBar);

            return diff;            
        }
        
        private static string[] CompareDics(Dictionary<string, string> dicToCompare, Dictionary<string, string> dicReference, System.Windows.Forms.ProgressBar progressBar = null)
        {
            List<string> list = new List<string>();
            bool progress = (progressBar != null);
            
            foreach (string item in dicToCompare.Values) 
            //Parallel.ForEach(dicToCompare.Values, item =>
            {
                if (progress)
                    progressBar.Value++;
                
                if (!dicReference.ContainsValue(item))
                    list.Add(item);
            }//);
            
            return list.ToArray();
        }

        private static IDictionary<string, string> ConvertToDic(string[] dir, string path)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            
            foreach (string d in dir) 
            //Parallel.ForEach(dir, d =>
            {
                dic.Add(d, d.Substring(path.Length + 1));
            }//);
            
            return dic;
        }
    }
}
