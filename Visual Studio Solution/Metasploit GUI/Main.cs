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
    public partial class Main : Form
    {
        public Main(string[] args = null)
        {
            InitializeComponent();

            args = Environment.GetCommandLineArgs();

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--script-editor":
                        if (args.Length >= i + 1 && args[i+1].Substring(0,2) != "--")
                        {
                            new ScriptEditor(true, args[i+1]);
                        }
                        else
                        {
                            new ScriptEditor(true);
                        }
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //DebugWindow.logwrite("Loaded Main");
            //Profiles.LoadProfile(0);
            Statics.LoadProfiles();
            Statics.RefreshDictionary();
        }

        private void Open_CreatePayload() => new CreatePayload().Show();
        private void Open_RemoteAttack() => new RemoteAttack().Show();
        private void Open_Installer() => new Installer().Show();
        private void Open_ResourceScriptEditor() => new ScriptEditor().Show();
        private void Open_Console() => new ConsoleWindow().Show();
        private void Open_ProfileWindow() => new Profiles().Show();
        private void Open_Options() => new Options().Show();
        private void Open_NMAPWindow()
        {

        }
        
        private void button2_Click(object sender, EventArgs e) => Open_CreatePayload();
        private void button1_Click(object sender, EventArgs e) => Open_RemoteAttack();
        private void button3_Click(object sender, EventArgs e) => Open_Installer();
        private void button4_Click(object sender, EventArgs e) => Open_ResourceScriptEditor();
        private void button5_Click(object sender, EventArgs e) => Open_Console();
        private void button6_Click(object sender, EventArgs e) => Open_ProfileWindow();
        private void buttonOptions_Click(object sender, EventArgs e) => Open_Options();

        private void Main_KeyPress(object sender, KeyPressEventArgs e) => HandleKeypress(e);

        public void HandleKeypress(KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                switch (e.KeyChar)
                {
                    case 'i': // Installer
                        Open_Installer();
                        break;
                    case ' ':
                        break;
                }

            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                switch (e.KeyChar)
                {
                    case 'i': // Installer
                        Open_Installer();
                        break;
                    case 'n': // NMAP
                        Open_NMAPWindow();
                        break;
                }

            switch (e.KeyChar)
            {
                default:
                    break;
            }

        }

        private void buttonCreatePayload_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
