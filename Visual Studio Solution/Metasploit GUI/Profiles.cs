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
            Loadprofile(comboBoxProfiles.SelectedItem.ToString());
            label5.Text = "Showing profile: " + comboBoxProfiles.SelectedItem;
        }

        public void Loadprofile(string profile)
        {
            lhost.Text = Statics.Profiles[profile]["lhost"];
            lport.Text = Statics.Profiles[profile]["lport"];
            rhost.Text = Statics.Profiles[profile]["rhost"];
            rport.Text = Statics.Profiles[profile]["rport"];

            /*
            profile += 1;
            String[] config = File.ReadAllLines(@"Profiles\Profile"+profile+".txt");
            lhost.Text = config[0];
            lport.Text = config[1];
            rhost.Text = config[2];
            rport.Text = config[3];*/
        }

        public void ApplyProfile(int profile)
        {
            Statics.lhost = lhost.Text;
            Statics.lport = lport.Text;
            Statics.rhost = rhost.Text;
            Statics.rport = rport.Text;

            label5.Text = "Applied the options specified";
        }

        /*
        public static void LoadProfile(int profile)
        {
            new Profiles().Loadprofile(profile);
        }*/

        private void button1_Click(object sender, EventArgs e) //Save profile
        {
            Statics.Profiles[textBoxName.Text]["lhost"] = lhost.Text;
            Statics.Profiles[textBoxName.Text]["lport"] = lport.Text;
            Statics.Profiles[textBoxName.Text]["rhost"] = rhost.Text;
            Statics.Profiles[textBoxName.Text]["rport"] = rport.Text;
            label5.Text = $"Saved the config to profile {textBoxName.Text}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Apply profile
            Statics.lhost = lhost.Text;
            Statics.lport = lport.Text;
            Statics.rhost = rhost.Text;
            Statics.rport = rport.Text;
            label5.Text = "Applied changes";
        }

        private void Profiles_Load(object sender, EventArgs e)
        {

            comboBoxProfiles.Items.Clear();
            foreach(KeyValuePair<string, Dictionary<string, string>> profile_dict in Statics.Profiles)
            {
                comboBoxProfiles.Items.Add(profile_dict.Key);
            }
        }
    }
}
