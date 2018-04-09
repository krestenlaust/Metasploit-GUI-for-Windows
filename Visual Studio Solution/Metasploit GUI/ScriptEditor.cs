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
                var PurpleArrayLength = File.ReadLines("PurpleWords.txt").Count();
                PurpleWords = new string[PurpleArrayLength];
            }
            catch
            {
                Console.WriteLine("Missing File 'PurpleWords.txt'");
            }
            try
            {
                var GreenArrayLength = File.ReadLines("GreenWords.txt").Count();
                GreenWords = new string[GreenArrayLength];
            }
            catch
            {
                Console.WriteLine("Missing File 'GreenWords.txt'");
            }
            try
            {
                var BlueArrayLength = File.ReadLines("BlueWords.txt").Count();
                BlueWords = new string[BlueArrayLength];
            }
            catch
            {
                Console.WriteLine("Missing File 'BlueWords.txt'");
            }
            //for(int i = 0; i < File.ReadLines("Purple"))
            PurpleWords[0] = "exploit";
            PurpleWords[1] = "run";
            BlueWords[0] = "use";
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
                if (line.Contains(BlueWords[i])) return Color.SkyBlue;
            }
            return Color.Black;
        }


}
}
