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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DebugWindow.logwrite("Loaded Main");
        }

        private void button2_Click(object sender, EventArgs e) => new CreatePayload().Show();

        private void button1_Click(object sender, EventArgs e) => new RemoteAttack().Show();

        private void button3_Click(object sender, EventArgs e) => new Installer().Show();

        private void button4_Click(object sender, EventArgs e) => new ScriptEditor().Show();

        private void button5_Click(object sender, EventArgs e) => new ConsoleWindow("").Show();
    }
}
