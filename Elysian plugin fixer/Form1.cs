using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Elysian_plugin_fixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.Description = "Select the path to Steam's programfiles";
            browser.ShowNewFolderButton = false;
            browser.RootFolder = System.Environment.SpecialFolder.Desktop;
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = browser.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        Process.Start("https://github.com/miniboi/Elysian-plugin-fixer/blob/master/README.MD");
                    }
                }
            }
            catch
            {
                StreamWriter help = new StreamWriter(@"C:\README.TXT");
                help.WriteLine("---Made by miniboi---");
                help.WriteLine("");
                help.WriteLine("Made for ElysianGaming's Garry's mod server, when the plugins let you down, just use this tool to repair them!");
                help.WriteLine("");
                help.WriteLine("Usage:");
                help.WriteLine(@"1. Type in Steam's path in the program files (for example: C:\Program Files (x86)\Steam or C:\Program Files\Steam). You can use the Browse-button to browse to the path.");
                help.WriteLine(@"2. Press ""Fix"" and wait for the progressbar to finnish. When the progresslabel say's ""Done!"" you are ready to go!");
                help.WriteLine("");
                help.WriteLine("Note: Make sure that Garry's mod and Steam (yes, even in the task manager) is closed before you are trying to fix the files!");
                help.WriteLine("");
                help.WriteLine("---README.TXT was created because no internet connection was found---");
                help.WriteLine(@"README.TXT was created in ""C:\""");
                help.Close();
                Process.Start(@"C:\README.TXT");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            progressBar1.Maximum = 100;
            label2.Text = "1%";
            progressBar1.Value = 1;
            if (Directory.Exists(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\" + "resource"))
            {
            }
            else
            {
                Directory.CreateDirectory(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\" + "resource");
            }
            label2.Text = "2%";
            progressBar1.Value = 2;
            if (Directory.Exists(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\" + "resource" + "\fonts"))
            {
            }
            else
            {
                Directory.CreateDirectory(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\" + @"resource\" + "fonts");
            }
            label2.Text = "3%";
            progressBar1.Value = 3;
            byte[] cache1 = Properties.Resources._920118814680151843;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\920118814680151843.cache", cache1);
            label2.Text = "15%";
            progressBar1.Value = 15;
            byte[] cache2 = Properties.Resources._89351987395614163;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\89351987395614163.cache", cache2);
            label2.Text = "28%";
            progressBar1.Value = 28;
            byte[] cache3 = Properties.Resources._579003433420153955;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\579003433420153955.cache", cache3);
            label2.Text = "40%";
            progressBar1.Value = 40;
            byte[] cache4 = Properties.Resources._311117166547254615;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\311117166547254615.cache", cache4);
            label2.Text = "52%";
            progressBar1.Value = 52;
            byte[] cache5 = Properties.Resources._272849249405403879;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\272849249405403879.cache", cache5);
            label2.Text = "65%";
            progressBar1.Value = 65;
            byte[] cache6 = Properties.Resources._170410764609146232;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\170410764609146232.cache", cache6);
            label2.Text = "77%";
            progressBar1.Value = 77;
            byte[] font1 = Properties.Resources.typenoksidi;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\resource\fonts\typenoksidi.ttf", font1);
            label2.Text = "89%";
            progressBar1.Value = 89;
            byte[] font2 = Properties.Resources._170410764609146232;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\resource\fonts\hidden.ttf", font2);
            progressBar1.Value = 100;
            label2.Text = "Done!";
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            MessageBox.Show("Plugins should be repaired now! Extraction rate: " + ts, "Done!");
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
