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
    public partial class ScriptEditor : Form
    {
        public ScriptEditor()
        {
            InitializeComponent();
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {

        }

        private void runButton1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<int> AllIndexes = new List<int>();//List for taking the indexes, where the word appears.

            string word = "my";//This will be the searched word.

            AllIndexes = WordsIndex(word);//Calling this function to find the indexes, where the word appears.

            foreach (int item in AllIndexes) //Coloring all appearance of the word.
            {
                richTextBox1.Select(item, word.Length);
                richTextBox1.SelectionColor = Color.BlueViolet;
            }
        }

        private List<int> WordsIndex(String word)
        {
            List<int> indexes = new List<int>();
            int i = 0;
            int ind = 0;
            while (i < richTextBox1.Text.Length)
            {
                ind = richTextBox1.Find(word, i, RichTextBoxFinds.WholeWord);//This function finds the index of the appearance of the word.
                if (ind != -1)
                {
                    indexes.Add(ind);
                    i = i + ind + 1;
                }
                else
                    return indexes;
            }
            return indexes;
        }
    }
}
