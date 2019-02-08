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
        //static public string lhost, rhost;
        //static public int lport, rport;

        //public DebugWindow dbw = null;

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
            //DebugWindow.logwrite("Loaded Options");
            Statics.Print("Loading options");
            textBox1.Text = Statics.lhost;
            textBox2.Text = Statics.lport;
            textBox3.Text = Statics.rhost;
            textBox4.Text = Statics.rport;
            Statics.Print("Options loaded");

            labelValue.Text = trackBarMaxSuggestions.Value.ToString();
            if (Statics.DebugWindowEnabled)
            {
                radioButtonEnableDebug.Checked = true;
                radioButtonDisableDebug.Checked = false;
            }
            else
            {
                radioButtonEnableDebug.Checked = true;
                radioButtonDisableDebug.Checked = false;
            }
        }

        public void UpdateLocalHost()
        {
            Statics.lhost = textBox1.Text;
            Statics.lport = textBox2.Text;
            try
            {
                CreatePayload.UpdateHostFromSpace();
            }
            catch { }
        }
        public void UpdateRemoteHost()
        {
            Statics.rhost = textBox3.Text;
            Statics.rport = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLocalHost();
            CreatePayload.UpdateHostFromSpace();
            //DebugWindow.logwrite("Set Lhost to:\nLhost: " + Statics.lhost + "\nLport: " + Statics.lport);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRemoteHost();
            //DebugWindow.logwrite("Set Rhost to:\nRhost: " + Statics.rhost + "\nRport: " + Statics.rport);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEnableDebug.Checked)
            {
                if (Statics.dbw == null)
                {
                    Statics.dbw = new DebugWindow();
                }
                Statics.dbw.Show();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDisableDebug.Checked && Statics.dbw != null)
            {
                Statics.dbw.Hide();
                //new DebugWindow().Hide();
            }
        }

        public Options()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBarMaxSuggestions_Scroll(object sender, EventArgs e)
        {
            toolTipOptions.SetToolTip(trackBarMaxSuggestions, trackBarMaxSuggestions.Value.ToString());
            Statics.MaxCompletionSuggestions = trackBarMaxSuggestions.Value;
        }

        private void checkBoxAutocomplete_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAutoCompletePrefs.Enabled = checkBoxAutocomplete.Checked;
        }

        private void checkBoxEditableConsole_CheckedChanged(object sender, EventArgs e)
        {
            Statics.editableConsoleOutput = checkBoxEditableConsole.Checked;
        }

        private void checkBoxEditableConsole_MouseHover(object sender, EventArgs e)
        {
            toolTipOptions.SetToolTip(checkBoxEditableConsole, "Changes console window readonly options");
        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Statics.dictionary_path;
            DialogResult result = openFileDialog1.ShowDialog();
            Statics.Print($"File dialog returned {result.ToString()}");
            if (result == DialogResult.OK)
            {
                Statics.dictionary_path = openFileDialog1.FileName;
                Statics.RefreshDictionary();
            }
        }

        private void buttonRefreshDict_Click(object sender, EventArgs e)
        {
            Statics.RefreshDictionary();
        }
    }
}
