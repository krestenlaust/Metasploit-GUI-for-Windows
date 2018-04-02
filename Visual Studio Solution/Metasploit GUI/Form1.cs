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

namespace Metasploit_GUI
{
    public partial class Installer : Form
    {
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

        public void UpdateDownloads()
        {
            //if (File.Exists(Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System) + "Metasploit-framework")))
            if (File.Exists(systemroot + "Metasploit-framework"))
            {
                metasploit = true;
                metasploitstatus.Text = "Installed";
            }
            else
            {
                metasploit = false;
                metasploitstatus.Text = "Not installed";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://windows.metasploit.com/metasploitframework-latest.msi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper")){
                //Isnt installed
            }
            else
            {
                //Is installed
            }
        }
    }
}
