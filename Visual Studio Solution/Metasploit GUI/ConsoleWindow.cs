using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Metasploit_GUI
{

    public enum ConsoleStartOptions{
        handler,
        interactive,
    }

    public partial class ConsoleWindow : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public int processid;
        public bool handler;

        public ConsoleWindow(ConsoleStartOptions Options = ConsoleStartOptions.interactive)
        {
            InitializeComponent();
            switch (Options)
            {
                case ConsoleStartOptions.handler:
                    handler = true;
                    break;
                case ConsoleStartOptions.interactive:
                    handler = false;
                    break;
                default:
                    break;
            }

            Statics.Print($"Console Window mode: {Options.ToString()}");
        }

        private void ConsoleWindow_Load(object sender, EventArgs e)
        {
            //string strCmdText;
            //strCmdText = "/C msfconsole";
            if (Statics.editableConsoleOutput)
            {
                richTextBoxOutput.ReadOnly = false;
            }
            /*
            if(handler)
            {
                strCmdText = "/C msfconsole -x 'use multi/handler;set lhost " + Options.lhost + ";set lport " + Options.lport + ";set payload " + CreatePayload.Payload + ";exploit'";
            }*/
            //var p = System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            //processid = p.Id;
            ///
            Process pr = new Process();
            pr.StartInfo.RedirectStandardError = true;
            pr.StartInfo.RedirectStandardOutput = true;
            pr.StartInfo.UseShellExecute = false;
            //pr.StartInfo.CreateNoWindow = true;
            pr.StartInfo.CreateNoWindow = false;
            pr.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
            pr.StartInfo.Arguments = "/C msfconsole -a || echo 'msfconsole' command is not a command, is Metasploit Framework installed.";
            if (handler)
            {
                pr.StartInfo.Arguments = "/C msfconsole -a -x 'use multi/handler;setg lhost " + Statics.lhost + ";setg lport " + Statics.lport + ";set payload " + CreatePayload.Payload + ";exploit' || echo 'msfconsole' is not a command, is Metasploit Framework installed?";
            }
            pr.OutputDataReceived += new DataReceivedEventHandler(
                (s, u) =>
                {
                    Console.WriteLine(u.Data);
                    Consolelog(u.Data);
                    /*
                    BeginInvoke(new Action(() =>
                    {
                        richTextBox1.Text = u.Data;
                    }));*/
                    //richTextBox1.Text += u.Data;
                }
            );
            pr.ErrorDataReceived += new DataReceivedEventHandler((s, u) => { Console.WriteLine(u.Data); });
            //pr.ErrorDataReceived += new DataReceivedEventHandler((s, u) => { richTextBox1.Text += u.Data; });
            pr.Start();
            processid = pr.Id;
            pr.BeginOutputReadLine();
            ///

            //Autocomplete menu control https://www.codeproject.com/Articles/365974/Autocomplete-Menu
            autocompleteMenu1.Items = Statics.DictionaryItems;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static void RunResourceScript(string filepath)
        {
            Process pr = new Process();
            //pr.StartInfo.RedirectStandardError = true;
            //pr.StartInfo.RedirectStandardOutput = true;
            //pr.StartInfo.UseShellExecute = false;
            //pr.StartInfo.CreateNoWindow = false;
            pr.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
            //pr.StartInfo.Arguments = "/C msfconsole || echo 'msfconsole' command is not a command, is Metasploit Framework installed.";
            pr.StartInfo.Arguments = String.Format("/C msfconsole -r '{0}' || echo 'msfconsole' command is not a command, is Metasploit Framework installed. & pause", filepath);
            /*
            pr.OutputDataReceived += new DataReceivedEventHandler(
                (s, u) =>
                {
                    Console.WriteLine(u.Data);
                    Consolelog(u.Data);
                    //richTextBox1.Text += u.Data;
                }
            );*/
            //pr.ErrorDataReceived += new DataReceivedEventHandler((s, u) => { Console.WriteLine(u.Data); });
            //pr.ErrorDataReceived += new DataReceivedEventHandler((s, u) => { richTextBox1.Text += u.Data; });
            pr.Start();
            //processid = pr.Id;
            //pr.BeginOutputReadLine();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Send command
                //SendKeys.Send();
                //Process[] processes = Process.GetProcessesByName("notepad");
                Process processes;
                try
                {
                    processes = Process.GetProcessById(processid);
                }
                catch
                {
                    Statics.Print("Process not found, Metasploit Framework not found");
                    return;
                }
                //Process game1 = processes[0];
                Process game1 = processes;

                IntPtr p = game1.MainWindowHandle;
                SetForegroundWindow(p);
                //SendKeys.SendWait(textBox1.Text);
                SendKeys.Send(textBoxInput.Text);
                SendKeys.Send("{ENTER}");
                textBoxInput.Text = "";
                //WindowState = FormWindowState.Minimized;
                Show();
                //WindowState = FormWindowState.Normal;
                textBoxInput.Focus();
            }
        }
        public void Consolelog(string data)
        {
            BeginInvoke(new Action(() =>
            {
                richTextBoxOutput.Text = richTextBoxOutput.Text + "\n" + data;
            }));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBoxOutput.Select(richTextBoxOutput.Text.Length - 1, 0);
            richTextBoxOutput.ScrollToCaret();
        }

        public List<string> GetSuggestions(string keyword)
        {
            List<string> list = new List<string>();

            list.Add("Hello");

            return list;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            Statics.Print($"Getting suggestions for {textBoxInput.Text}");

            /*
            menuStripAutoComplete.Items.Clear();

            foreach (string item in GetSuggestions(textBoxInput.Text))
            {
                menuStripAutoComplete.Items.Add(item);
            }

            menuStripAutoComplete.Show();*/
        }
    }
}
