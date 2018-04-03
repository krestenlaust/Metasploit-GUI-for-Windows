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
                metasploitstatus.Text = "Installed";
            }
            else
            {
                metasploit = false;
                metasploitstatus.Text = "Not installed";
            }
            //metasploitstatus.Text = systemroot + "metasploit-framework";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://windows.metasploit.com/metasploitframework-latest.msi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper")){
                CreateBasicFolders();
                //Isnt installed
                //Directory.CreateDirectory(systemroot + @"metagui\Extensions");
            }
            else
            {
                //Is installed
            }
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
