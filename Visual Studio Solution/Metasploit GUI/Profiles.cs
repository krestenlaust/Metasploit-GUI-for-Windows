using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metasploit_GUI
{
    public partial class Profiles : Form
    {
        public Profiles()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Loadprofile(0);
                /*
                String[] config = File.ReadAllLines(@"Profiles\Profile1.txt");
                lhost.Text = config[0];
                lport.Text = config[1];
                rhost.Text = config[2];
                rport.Text = config[3];*/
            }
            if(comboBox1.SelectedIndex == 1)
            {
                Loadprofile(1);
                /*
                String[] config = File.ReadAllLines(@"Profiles\Profile2.txt");
                lhost.Text = config[0];
                lport.Text = config[1];
                rhost.Text = config[2];
                rport.Text = config[3];*/
            }
            if(comboBox1.SelectedIndex == 2)
            {
                Loadprofile(2);
                /*
                String[] config = File.ReadAllLines(@"Profiles\Profile3.txt");
                lhost.Text = config[0];
                lport.Text = config[1];
                rhost.Text = config[2];
                rport.Text = config[3];*/
            }
            label5.Text = "Showing profile: " + comboBox1.SelectedItem;
        }

        public void Loadprofile(int profile)
        {
            profile += 1;
            String[] config = File.ReadAllLines(@"Profiles\Profile"+profile+".txt");
            lhost.Text = config[0];
            lport.Text = config[1];
            rhost.Text = config[2];
            rport.Text = config[3];
        }

        public static void LoadProfile(int profile)
        {
            new Profiles().Loadprofile(profile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Save changes
            label5.Text = "!Not implemented yet! Saved profile config to: " + comboBox1.SelectedItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Apply profile
            Options.lhost = lhost.Text;
            Options.lport = int.Parse(lport.Text);
            Options.rhost = rhost.Text;
            Options.rport = int.Parse(rport.Text);
            label5.Text = "Applied changes";
        }
    }
}
