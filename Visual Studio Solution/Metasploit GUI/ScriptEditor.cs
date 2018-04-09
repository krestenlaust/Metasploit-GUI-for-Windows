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
    public partial class ScriptEditor : Form
    {
        public string[] GreenWords = new string[1];
        public string[] PurpleWords = new string[2];
        public string[] BlueWords = new string[1];
        public string[] Words;
        public ScriptEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string text = richTextBox1.Lines[i];
                richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), text.Length);
                richTextBox1.SelectionColor = colorForLine(text);
            }
            /*
            Words = richTextBox1.Text.Split(' ');
            for (int i = 0; i < Words.Length; i++)
            {

            }*/

            richTextBox1.DeselectAll();
            richTextBox1.BackColor = Color.White;
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            try
            {
                var PurpleArray = File.ReadAllLines("PurpleWords.txt");
                PurpleWords = new string[PurpleArray.Length];
                for (int i = 0;i < PurpleArray.Length; i++)
                {
                    PurpleWords[i] = PurpleArray[i];
                }
            }
            catch
            {
                Console.WriteLine("Missing File 'PurpleWords.txt'");
            }
            try
            {
                var GreenArray = File.ReadAllLines("GreenWords.txt");
                GreenWords = new string[GreenArray.Length];
                for (int i = 0;i < GreenArray.Length; i++)
                {
                    GreenWords[i] = GreenArray[i];
                }
            }
            catch
            {
                Console.WriteLine("Missing File 'GreenWords.txt'");
            }
            try
            {
                var BlueArray = File.ReadAllLines("BlueWords.txt");
                BlueWords = new string[BlueArray.Length];
                for (int i = 0;i < BlueArray.Length; i++)
                {
                    BlueWords[i] = BlueArray[i];
                }
            }
            catch
            {
                Console.WriteLine("Missing File 'BlueWords.txt'");
            }
            //PurpleWords[0] = "exploit";
            //PurpleWords[1] = "run";
            //BlueWords[0] = "use";
        }

        private Color colorForLine(string line)
        {
            //if (line.Contains("[INFO]")) return Color.Green; //if (line.Contains("[INFO]", StringComparison.InvariantCultureIgnoreCase)) return Color.Green;
            //if (line.Contains("[ERROR]")) return Color.Red;
            for(int i = 0; i < PurpleWords.Length; i++)
            {
                if (line.Contains(PurpleWords[i])) return Color.Magenta;
            }
            for(int i = 0; i < BlueWords.Length; i++)
            {
                if (line.Contains(BlueWords[i])) return Color.Blue;
            }
            for(int i = 0; i < GreenWords.Length; i++)
            {
                if (line.Contains(GreenWords[i])) return Color.Green;
            }
            return Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
