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
        //public string[] GreenWords = new string[1];
        //public string[] PurpleWords = new string[2];
        //public string[] BlueWords = new string[1];
        //public string[] Words;

        public string OpenFilePath = Statics.DefaultScriptName;
        public string LastSavedContent = "";

        public List<string> HistoryText = new List<string>();
        public int HistoryIndex = 0;

        private DialogResult RecentDialogResult;

        public ScriptEditor(bool standalone = false, string file = "")
        {
            InitializeComponent();

            if (file != "" && File.Exists(file))
            {
                OpenFilePath = file;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateTitle();

            if (richTextBoxCode.Text == "")
            {
                AddLineNumbers();
            }

            /*
            for (int i = 0; i < richTextBoxCode.Lines.Length; i++)
            {
                string text = richTextBoxCode.Lines[i];
                richTextBoxCode.Select(richTextBoxCode.GetFirstCharIndexFromLine(i), text.Length);
                richTextBoxCode.SelectionColor = colorForLine(text);
            }

            richTextBoxCode.DeselectAll();
            richTextBoxCode.BackColor = Color.White;
            richTextBoxCode.SelectionStart = richTextBoxCode.Text.Length;
            */
        }

        private void ScriptEditor_Load(object sender, EventArgs e)
        {
            Statics.Print("Opened script editor");

            LineNumberTextBox.Font = richTextBoxCode.Font;
            richTextBoxCode.Select();
            AddLineNumbers();

            UpdateTitle();

            #region Comment
            /*
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
            //BlueWords[0] = "use";*/
            #endregion
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Control)
            {
                switch (keyData)
                {
                    case Keys.Control | Keys.S:
                        SaveFile();
                        break;
                    case Keys.Control | Keys.N:
                        NewFile();
                        break;
                    case Keys.Control | Keys.O:
                        OpenFile();
                        break;
                    case Keys.Control | Keys.Z:
                        History(HistoryType.Undo);
                        break;
                    case Keys.Control | Keys.Y:
                        History(HistoryType.Redo);
                        break;
                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else
            {
                switch (keyData)
                {
                    case Keys.F5:
                        ExecuteScript();
                        break;
                    default:
                        return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            return true;
        }

        public void OpenFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Resource Script(*.rs)|*.rs|Text file(*.txt)|*.txt|All files(*.*)|*.*";
            openfile.Title = "Select the file you want to edit";

            RecentDialogResult = openfile.ShowDialog();

            if (!RecentDialogResult.Equals(DialogResult.OK))
            {
                return;
            }

            if (richTextBoxCode.Text != LastSavedContent)
            {
                Statics.Print("Last edit not saved, are you sure you want to override?");
                //Insert popup here
            }

            richTextBoxCode.Text = File.ReadAllText(openfile.FileName);

            OpenFilePath = openfile.FileName;


            UpdateTitle();
        }

        public void LoadFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return;
            }

            OpenFilePath = filepath;
            richTextBoxCode.Text = File.ReadAllText(filepath);
        }

        public void SaveFile()
        {
            if (HistoryText.Count >= 1 && LastSavedContent != HistoryText[0])
            {
                AppendHistory();
            }

            if (OpenFilePath == Statics.DefaultScriptName)
            {
                SaveAsFile();
                return;
            }

            File.WriteAllText(Path.GetFullPath(OpenFilePath), richTextBoxCode.Text);
            UpdateTitle();
            SetLastAction($"Saved file: {Path.GetFullPath(OpenFilePath)}");

            UpdateHistoryIndex();
        }

        public void SaveAsFile()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Resource Script(*.rs)|*.rs|Text file(*.txt)|*.txt|All files(*.*)|*.*";
            savefile.Title = "Save your resource script";

            RecentDialogResult = savefile.ShowDialog();

            if (RecentDialogResult.Equals(DialogResult.OK))
            {
                File.WriteAllText(Path.GetFullPath(savefile.FileName), richTextBoxCode.Text);
                OpenFilePath = savefile.FileName;
            }
            UpdateTitle();
            SetLastAction($"Saved file: {Path.GetFullPath(OpenFilePath)}");
            UpdateHistoryIndex();
        }

        public void ExecuteScript()
        {
            SaveFile();

            if (RecentDialogResult.Equals(DialogResult.OK))
            {
                ConsoleWindow.RunResourceScript(Path.GetFullPath(OpenFilePath));
                SetLastAction("Started Metasploit Console with Resource Script");
            }
            UpdateTitle();
        }

        public enum HistoryType { Undo, Redo }

        public void History(HistoryType ht)
        {
            switch (ht)
            {
                case HistoryType.Undo:
                    if (HistoryIndex + 1 > HistoryText.Count)
                    {
                        SetLastAction("Can't undo further");
                        return;
                    }

                    HistoryIndex++;
                    richTextBoxCode.Text = HistoryText[HistoryIndex];
                    SetLastAction($"Undo successful (History: {HistoryIndex}/{HistoryText.Count})");
                    break;

                case HistoryType.Redo:
                    if (HistoryIndex - 1 < 0)
                    {
                        SetLastAction("Can't redo further");
                        return;
                    }

                    HistoryIndex--;
                    richTextBoxCode.Text = HistoryText[HistoryIndex];
                    SetLastAction($"Redo successful (History: {HistoryIndex}/{HistoryText.Count})");
                    break;
            }
            UpdateHistoryIndex();
        }

        public void AppendHistory()
        {
            if (HistoryText.Count >= Statics.HistoryLength)
            {
                HistoryText.RemoveAt(HistoryText.Count - 1);
            }
            HistoryText.Insert(0, richTextBoxCode.Text);
        }

        /*
        private Color colorForLine(string line)
        {
            //if (line.Contains("[INFO]")) return Color.Green; //if (line.Contains("[INFO]", StringComparison.InvariantCultureIgnoreCase)) return Color.Green;
            //if (line.Contains("[ERROR]")) return Color.Red;
            for (int i = 0; i < PurpleWords.Length; i++)
            {
                if (line.Contains(PurpleWords[i])) return Color.Magenta;
            }
            for (int i = 0; i < BlueWords.Length; i++)
            {
                if (line.Contains(BlueWords[i])) return Color.Blue;
            }
            for (int i = 0; i < GreenWords.Length; i++)
            {
                if (line.Contains(GreenWords[i])) return Color.Green;
            }
            return Color.Black;
        }*/

        private void UpdateTitle()
        {
            if (richTextBoxCode.Text != LastSavedContent)
                this.Text = $"{Path.GetFileName(OpenFilePath)}* - Script Editor";
            else this.Text = $"{Path.GetFileName(OpenFilePath)} - Script Editor";
        }

        public int getWidth()
        {
            int w = 25;
            // get total lines of richTextBoxCode    
            int line = richTextBoxCode.Lines.Length;

            if (line <= 99)
            {
                w = 20 + (int)richTextBoxCode.Font.Size;
            }
            else if (line <= 999)
            {
                w = 30 + (int)richTextBoxCode.Font.Size;
            }
            else
            {
                w = 50 + (int)richTextBoxCode.Font.Size;
            }

            return w;
        }

        public void AddLineNumbers()
        {
            // create & set Point pt to (0,0)    
            Point pt = new Point(0, 0);
            // get First Index & First Line from richTextBoxCode    
            int First_Index = richTextBoxCode.GetCharIndexFromPosition(pt);
            int First_Line = richTextBoxCode.GetLineFromCharIndex(First_Index);
            // set X & Y coordinates of Point pt to ClientRectangle Width & Height respectively    
            pt.X = ClientRectangle.Width;
            pt.Y = ClientRectangle.Height;
            // get Last Index & Last Line from richTextBoxCode    
            int Last_Index = richTextBoxCode.GetCharIndexFromPosition(pt);
            int Last_Line = richTextBoxCode.GetLineFromCharIndex(Last_Index);
            // set Center alignment to LineNumberTextBox    
            //LineNumberTextBox.SelectionAlignment = HorizontalAlignment.Center;
            LineNumberTextBox.TextAlign = HorizontalAlignment.Center;
            // set LineNumberTextBox text to null & width to getWidth() function value
            LineNumberTextBox.Text = "";
            LineNumberTextBox.Width = getWidth();
            // now add each line number to LineNumberTextBox upto last line    
            for (int i = First_Line; i <= Last_Line + 2; i++)
            {
                LineNumberTextBox.Text += (i + 1).ToString() + "\n";
            }
        }

        public void NewFile()
        {
            if (richTextBoxCode.Text != LastSavedContent)
            {
                SaveFile();
                if (!RecentDialogResult.Equals(DialogResult.OK))
                {
                    SetLastAction("File was not saved"); //Replace with prompt to ask wheater should be saved.
                    return;
                }
            }

            richTextBoxCode.Text = "";
            OpenFilePath = Statics.DefaultScriptName;
            HistoryText.Clear();
            HistoryIndex = 0;
            UpdateTitle();
            UpdateHistoryIndex();
            SetLastAction("New file");
        }

        public void SetLastAction(string s) => toolStripStatusLabelLastAction.Text = $"Last action({DateTimeOffset.UtcNow.ToUnixTimeSeconds()}): {s}";

        public void UpdateHistoryIndex() => showHistoryIndexToolStripMenuItem.Text = $"History({(HistoryIndex+1 > HistoryText.Count ? HistoryIndex : HistoryIndex + 1)} : {HistoryText.Count})";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void runAsResourceScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteScript();
        }

        private void infobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infobarToolStripMenuItem.Checked = !infobarToolStripMenuItem.Checked;

            if (infobarToolStripMenuItem.Checked)
            {
                statusStripInfobar.Visible = true;
                richTextBoxCode.Dock = DockStyle.None;
                showHistoryIndexToolStripMenuItem.Enabled = true;
            }
            else
            {
                statusStripInfobar.Visible = false;
                richTextBoxCode.Dock = DockStyle.Bottom;
                showHistoryIndexToolStripMenuItem.Enabled = false;
            }
        }

        private void ScriptEditor_ResizeEnd(object sender, EventArgs e)
        {
            AddLineNumbers();
        }

        private void richTextBoxCode_SelectionChanged(object sender, EventArgs e)
        {
            Point pt = richTextBoxCode.GetPositionFromCharIndex(richTextBoxCode.SelectionStart);
            if (pt.X == 1)
            {
                AddLineNumbers();
            }
        }

        private void richTextBoxCode_VScroll(object sender, EventArgs e)
        {
            LineNumberTextBox.Text = "";
            AddLineNumbers();
            LineNumberTextBox.Invalidate();
        }

        private void richTextBoxCode_FontChanged(object sender, EventArgs e)
        {
            LineNumberTextBox.Font = richTextBoxCode.Font;
            richTextBoxCode.Select();
            AddLineNumbers();
        }

        private void LineNumberTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBoxCode.Select();
            LineNumberTextBox.DeselectAll();
        }

        private void richTextBoxCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            AppendHistory();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History(HistoryType.Undo);
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            History(HistoryType.Redo);
        }

        /*

        private void showHistoryIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void showHistoryIndexToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showHistoryIndexToolStripMenuItem.Checked = !showHistoryIndexToolStripMenuItem.Checked;

            showHistoryIndexToolStripMenuItem.Visible = showHistoryIndexToolStripMenuItem.Checked;

            UpdateHistoryIndex();
        }

        private void lineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxCode.Text == LastSavedContent)
            {
                this.DestroyHandle();
            }
            else
            {
                SaveAsFile();
                if (RecentDialogResult.Equals(DialogResult.OK))
                {
                    this.DestroyHandle();
                }
            }
        }
    }
}
