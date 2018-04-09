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
    public partial class Options : Form
    {
        static public string lhost, rhost;
        static public int lport, rport;
        static public bool pythonwrapper, metasploit, nmap;
        static public bool WriteableConsole;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Options_Load(object sender, EventArgs e)
        {
            DebugWindow.logwrite("Loaded Options");
            textBox1.Text = lhost;
            textBox2.Text = lport.ToString();
            textBox3.Text = rhost;
            textBox4.Text = rport.ToString();
        }

        public void UpdateLocalHost()
        {
            lhost = textBox1.Text;
            lport = Int32.Parse(textBox2.Text);
            try
            {
                CreatePayload.UpdateHostFromSpace();
            }
            catch { }
        }
        public void UpdateRemoteHost()
        {
            rhost = textBox3.Text;
            rport = Int32.Parse(textBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLocalHost();
            CreatePayload.UpdateHostFromSpace();
            DebugWindow.logwrite("Set Lhost to:\nLhost: " + lhost + "\nLport: " + lport.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRemoteHost();
            DebugWindow.logwrite("Set Rhost to:\nRhost: " + rhost + "\nRport: " + rport.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            new DebugWindow().Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            new DebugWindow().Hide();
        }

        public Options()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
