using System;
using System.Net;
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

            //Update #2 starts here!

            byte[] cache1a = Properties.Resources._47629746175825132;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\47629746175825132.cache", cache1a);

            byte[] cache1b = Properties.Resources._89351987395614163;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\89351987395614163.cache", cache1b);

            byte[] cache2a = Properties.Resources._276219973932937725;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\276219973932937725.cache", cache2a);

            byte[] cache2b = Properties.Resources._271725976967090974;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\276219973932937725.cache", cache2b);

            byte[] cache2c = Properties.Resources._271725976967064071;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\271725976967064071.cache", cache2c);

            byte[] cache2d = Properties.Resources._271725976966910576;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\271725976966910576.cache", cache2d);

            byte[] cache2e = Properties.Resources._271725976966814083;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\271725976966814083.cache", cache2e);

            byte[] cache2f = Properties.Resources._262714246042402985;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\262714246042402985.cache", cache2f);
       
            byte[] cache3a = Properties.Resources._311117166531522361;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\311117166531522361.cache", cache3a);

            byte[] cache4a = Properties.Resources._468672091573255728;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\468672091573255728.cache", cache4a);

            byte[] cache5a = Properties.Resources._536266067073151421;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\536266067073151421.cache", cache5a);

            byte[] cache5b = Properties.Resources._576726193816506209;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\576726193816506209.cache", cache5b);

            byte[] cache5c = Properties.Resources._576726193816698382;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\576726193816698382.cache", cache5c);

            byte[] cache5d = Properties.Resources._576726193816815205;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\576726193816815205.cache", cache5d);

            byte[] cache5e = Properties.Resources._576727710540886764;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\576727710540886764.cache", cache5e);

            byte[] cache5f = Properties.Resources._577857239728512454;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\577857239728512454.cache", cache5f);

            byte[] cache5g = Properties.Resources._577857239728769282;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\577857239728769282.cache", cache5g);

            byte[] cache5h = Properties.Resources._577875246857033802;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\577875246857033802.cache", cache5h);

            byte[] cache5i = Properties.Resources._579074999583885734;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\579074999583885734.cache", cache5i);

            byte[] cache6a = Properties.Resources._597014361885335645;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\597014361885335645.cache", cache6a);

            byte[] cache6b = Properties.Resources._720869898938009789;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\720869898938009789.cache", cache6b);

            byte[] cache6c = Properties.Resources._846954458106118633;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\846954458106118633.cache", cache6c);

            byte[] cache7a = Properties.Resources._900988960351239884;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\900988960351239884.cache", cache7a);

            byte[] cache7b = Properties.Resources._900988960351397735;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\900988960351397735.cache", cache7b);

            byte[] cache7c = Properties.Resources._901003824556294679;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\901003824556294679.cache", cache7c);

            byte[] cache7d = Properties.Resources._902127097107403993;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\902127097107403993.cache", cache7d);

            byte[] cache8a = Properties.Resources._3278922818507180118;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3278922818507180118.cache", cache8a);

            byte[] cache8b = Properties.Resources._3280046820534677070;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3280046820534677070.cache", cache8b);

            byte[] cache8c = Properties.Resources._3281171992739418238;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3281171992739418238.cache", cache8c);

            byte[] cache8d = Properties.Resources._3281182222657406780;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3281182222657406780.cache", cache8d);

            byte[] cache8e = Properties.Resources._3335221527208345019;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3335221527208345019.cache", cache8e);

            byte[] cache8f = Properties.Resources._3372369252222522694;
            File.WriteAllBytes(textBox1.Text + @"\steamapps\common\GarrysMod\garrysmod\cache\workshop\3372369252222522694.cache", cache8f);
            
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