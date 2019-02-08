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

        private void button2_Click(object sender, EventArgs e) => new CreatePayload().Show();
        private void button1_Click(object sender, EventArgs e) => new RemoteAttack().Show();
        private void button3_Click(object sender, EventArgs e) => new Installer().Show();
        private void button4_Click(object sender, EventArgs e) => new ScriptEditor().Show();
        private void button5_Click(object sender, EventArgs e) => new ConsoleWindow().Show();
        private void button6_Click(object sender, EventArgs e) => new Profiles().Show();
        private void buttonOptions_Click(object sender, EventArgs e) => new Options().Show();
    }
}
