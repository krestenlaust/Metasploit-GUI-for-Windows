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
        public enum Package
        {
            NMAP, Metasploit, PythonWrapper,
        }
        public float CurrentVersionPythonWrapper, LatestVersionPythonWrapper;
        public string systemroot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        public bool metasploit;
        public bool pythonwrapper;

        public Dictionary<CheckBox, string> CheckBoxReferences = new Dictionary<CheckBox, string>();
        public Dictionary<string, bool> SelectedItems = new Dictionary<string, bool>();
        public List<CheckBox> checkBoxList = new List<CheckBox>();

        public Installer()
        {
            InitializeComponent();
        }

        private void Installer_Load(object sender, EventArgs e)
        {
            UpdateDownloads();

            CheckBoxReferences.Add(checkBoxSelectMetasploit, "Metasploit Framework");
            CheckBoxReferences.Add(checkBoxSelectPythonWrapper, "Python-Wrapper");
            CheckBoxReferences.Add(checkBoxSelectNmap, "NMAP");

            checkBoxList.Add(checkBoxSelectMetasploit);
            checkBoxList.Add(checkBoxSelectPythonWrapper);
            checkBoxList.Add(checkBoxSelectNmap);

            RegisterEventHandlers();
        }

        public void RegisterEventHandlers()
        {
            IEnumerable<CheckBox> CheckBoxes = flowLayoutPanelSoftware.Controls.OfType<CheckBox>();
            Statics.Print($"Found {CheckBoxes.Count()} checkboxes");
            foreach (CheckBox item in CheckBoxes)
            {
                item.CheckedChanged += new EventHandler(CheckBoxChanged);
            }
        }

        private void CheckBoxChanged(object sender, EventArgs e)
        {
            UpdateSelectedElements();
        }

        public void UpdateSelectedElements()
        {
            IList<CheckBox> checkboxList = checkBoxList;
            int selectedElements = checkboxList.Where(x => x.Checked.Equals(true)).Count();
            labelSelected.Text = $"{selectedElements} Elements selected";
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
                Statics.metasploit_installed = true;
                metasploitstatus.Text = "Installed";
            }
            else
            {
                metasploit = false;
                Statics.metasploit_installed = false;
                metasploitstatus.Text = "Not installed";
            }
            //metasploitstatus.Text = systemroot + "metasploit-framework";
            if (Directory.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper"))
            {
                pythonwrapper = true;
                Statics.pythonwrapper_installed = true;
                pythonwrapperstatus.Text = "Installed";
                //is installed
            }
            else
            {
                pythonwrapper = false;
                Statics.pythonwrapper_installed = false;
                pythonwrapperstatus.Text = "Not installed";
                //Isn't installed
            }
        }

        private void InstallSoftware(Package software)
        {
            switch (software)
            {
                case Package.Metasploit:
                    Process.Start("https://windows.metasploit.com/metasploitframework-latest.msi");
                    break;
                case Package.PythonWrapper:
                    if (!Directory.Exists(systemroot + @"metagui\Extensions\Python-Enwrapper"))
                    {
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
                    break;
                case Package.NMAP:

                    break;
                default:
                    break;
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

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
                checkBoxList.ForEach(x => x.Checked = true);
            else
                checkBoxList.ForEach(x => x.Checked = false);
        }

        public void UpdateSelectedValues()
        {
            checkedListBoxSelected.Items.Clear();
            foreach (CheckBox item in checkBoxList)
            {
                string checkboxName = CheckBoxReferences[item];
                if (checkboxName == null)
                    continue;

                checkedListBoxSelected.Items.Add(checkboxName, item.Checked);
            }

            /*IEnumerable<CheckBox> CheckBoxes = flowLayoutPanelSoftware.Controls.OfType<CheckBox>();
            foreach (CheckBox item in CheckBoxes)
            {
                string checkBoxName = CheckBoxReferences[item];
                if (checkBoxName == null)
                    continue;

                checkedListBoxSelected.Items.Add(checkBoxName, item.Checked);
                SelectedItems.Add(checkBoxName, item.Checked);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Main().Show();
            //this.Hide();
            this.Close();
        }
    }
}
