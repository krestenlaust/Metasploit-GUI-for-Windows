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

        private static DebugWindow form = null;

        public DebugWindow()
        {
            InitializeComponent();
            form = this;
        }

        public static void AppendLog(string log)
        {
            if (form != null)
            {
                form.richTextBoxLog.Text += log;
                int textLength = form.richTextBoxLog.TextLength;
                int logLength = log.Length;
                form.richTextBoxLog.Select(Math.Max(0, textLength - logLength), textLength);

                Color targetColor = form.richTextBoxLog.ForeColor;

                switch (log.Substring(log.IndexOf('[') + 1, log.IndexOf(']')))
                {
                    case "WARNING":
                        targetColor = Statics.Warning_Color;
                        break;
                    case "ERROR":
                        targetColor = Statics.Error_Color;
                        break;
                }

                form.richTextBoxLog.SelectionColor = targetColor;
                form.richTextBoxLog.DeselectAll();
            }
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
