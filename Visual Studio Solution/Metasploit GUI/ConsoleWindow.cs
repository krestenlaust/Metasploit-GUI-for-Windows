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
    public partial class ConsoleWindow : Form
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        public int processid;
        public bool handler = false;
        public ConsoleWindow(string Param1)
        {
            InitializeComponent();
            if (Param1 == "handler") handler = true;
        }

        private void ConsoleWindow_Load(object sender, EventArgs e)
        {
            //string strCmdText;
            //strCmdText = "/C msfconsole";
            if (Options.WriteableConsole)
            {
                richTextBox1.ReadOnly = false;
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
            pr.StartInfo.Arguments = "/C msfconsole || echo 'msfconsole' command is not a command, is Metasploit Framework installed.";
            if (handler)
            {
                pr.StartInfo.Arguments = "/C msfconsole -x 'use multi/handler;set lhost " + Options.lhost + ";set lport " + Options.lport + ";set payload " + CreatePayload.Payload + ";exploit' || echo 'msfconsole' command is not a command, is Metasploit Framework installed.";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Send command
                //SendKeys.Send();
                //Process[] processes = Process.GetProcessesByName("notepad");
                Process processes = Process.GetProcessById(processid);
                //Process game1 = processes[0];
                Process game1 = processes;

                IntPtr p = game1.MainWindowHandle;
                SetForegroundWindow(p);
                //SendKeys.SendWait(textBox1.Text);
                SendKeys.Send(textBox1.Text);
                SendKeys.Send("{ENTER}");
                textBox1.Text = "";
                //WindowState = FormWindowState.Minimized;
                Show();
                //WindowState = FormWindowState.Normal;
                textBox1.Focus();
            }
        }
        public void Consolelog(string data)
        {
            BeginInvoke(new Action(() =>
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + data;
            }));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Select(richTextBox1.Text.Length - 1, 0);
            richTextBox1.ScrollToCaret();
        }
    }
}
