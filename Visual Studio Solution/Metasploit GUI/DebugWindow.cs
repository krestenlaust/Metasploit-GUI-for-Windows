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
    public partial class DebugWindow : Form
    {
        public DebugWindow()
        {
            InitializeComponent();
        }
        public void LogWriteFunc(string log)
        {
            richTextBox1.Text = richTextBox1.Text + "\n" + log;
        }
        static public void logwrite(string log)
        {
            DebugWindow rtb = new DebugWindow();
            rtb.LogWriteFunc(log);
            //LogWriteFunc(log);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
