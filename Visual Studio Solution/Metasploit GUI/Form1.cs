using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace Metasploit_GUI
{
    public partial class Installer : Form
    {
        public float CurrentVersionPythonWrapper, LatestVersionPythonWrapper;
        public string systemroot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        public bool metasploit;
        public bool pythonwrapper;

        public Installer()
        {
            InitializeComponent();
        }

        private void Installer_Load(object sender, EventArgs e)
        {
            UpdateDownloads();
        }

        public void CreateBasicFolders()
        {
            Directory.CreateDirectory(systemroot + @"metagui\Extensions");
            //Directory.CreateDirectory(systemroot + @"metagui");
        }

        public void UpdateDownloads()
        {
            
            //if (File.Exists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System) + "Metasploit-framework")))
            if (Directory.Exists(systemroot + "metasploit-framework"))
            {
                metasploit = true;
                Options.metasploit = true;
                metasploitstatus.Text = "Installed";
            }
            else
            {
                metasploit = false;
                Options.metasploit = false;
                metasploitstatus.Text = "Not installed";
            }
            //metasploitstatus.Text = systemroot + "metasploit-framework";
            if (Directory.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper"))
            {
                pythonwrapper = true;
                Options.pythonwrapper = true;
                pythonwrapperstatus.Text = "Installed";
                //is installed
            }
            else
            {
                pythonwrapper = false;
                Options.pythonwrapper = false;
                pythonwrapperstatus.Text = "Not installed";
                //Isn't installed
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://windows.metasploit.com/metasploitframework-latest.msi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper")){
                //CreateBasicFolders();
                /*
                Directory.CreateDirectory(systemroot + @"metagui\Extensions\Python-Enwrapper");
                pythonwrapperstatus.Text = "Downloading...";
                var url = "https://github.com/kres0345/Metasploit-windows-GUI/raw/master/Extensions/Python-Enwrapper/Enwrapper.exe";
                var url2 = "https://raw.githubusercontent.com/kres0345/Metasploit-windows-GUI/master/Extensions/Python-Enwrapper/version";
                WebClient client = new WebClient();
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(url), systemroot + @"metagui\Extensions\Python-Enwrapper\Enwrapper.exe");
                Console.WriteLine(1);
                WebClient client2 = new WebClient();
                client2.DownloadFile(url2, systemroot + @"metagui\Extensions\Python-Enwrapper\version");
                */
            }
            else
            {
                pythonwrapperstatus.Text = "Checking for updates...";
                CurrentVersionPythonWrapper = float.Parse(File.ReadAllText(systemroot + @"metagui\Extensions\Python-Enwrapper\version"));
                Console.WriteLine(CurrentVersionPythonWrapper);
                WebClient wc = new WebClient();
                LatestVersionPythonWrapper = float.Parse(wc.DownloadString("https://raw.githubusercontent.com/kres0345/Metasploit-windows-GUI/master/Extensions/Python-Enwrapper/version"));
                if (CurrentVersionPythonWrapper < LatestVersionPythonWrapper)
                {
                    pythonwrapperstatus.Text = "Found update, updating";
                    DownloadPythonWrapper();
                }
            }
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pythonwrapperstatus.Text = "Installed";
        }

        public void DownloadPythonWrapper()
        {
            Directory.CreateDirectory(systemroot + @"metagui\Extensions\Python-Enwrapper");
            pythonwrapperstatus.Text = "Downloading...";
            var url = "https://github.com/kres0345/Metasploit-windows-GUI/raw/master/Extensions/Python-Enwrapper/Enwrapper.exe";
            var url2 = "https://raw.githubusercontent.com/kres0345/Metasploit-windows-GUI/master/Extensions/Python-Enwrapper/version";
            WebClient client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(url), systemroot + @"metagui\Extensions\Python-Enwrapper\Enwrapper.exe");
            WebClient client2 = new WebClient();
            client2.DownloadFile(url2, systemroot + @"metagui\Extensions\Python-Enwrapper\version");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}
