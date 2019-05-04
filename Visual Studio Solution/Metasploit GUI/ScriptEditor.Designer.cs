namespace Metasploit_GUI
{
    partial class ScriptEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditor));
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.toolStripWindow = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFiles = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonRun = new System.Windows.Forms.ToolStripDropDownButton();
            this.runAsResourceScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.infobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infobarOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lineNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocompleteMenuText = new AutocompleteMenuNS.AutocompleteMenu();
            this.LineNumberTextBox = new System.Windows.Forms.TextBox();
            this.statusStripInfobar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHistoryIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripWindow.SuspendLayout();
            this.statusStripInfobar.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenuText.SetAutocompleteMenu(this.richTextBoxCode, this.autocompleteMenuText);
            this.richTextBoxCode.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCode.Location = new System.Drawing.Point(46, 30);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.Size = new System.Drawing.Size(888, 434);
            this.richTextBoxCode.TabIndex = 0;
            this.richTextBoxCode.Text = "";
            this.richTextBoxCode.SelectionChanged += new System.EventHandler(this.richTextBoxCode_SelectionChanged);
            this.richTextBoxCode.VScroll += new System.EventHandler(this.richTextBoxCode_VScroll);
            this.richTextBoxCode.FontChanged += new System.EventHandler(this.richTextBoxCode_FontChanged);
            this.richTextBoxCode.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBoxCode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBoxCode_PreviewKeyDown);
            // 
            // toolStripWindow
            // 
            this.toolStripWindow.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFiles,
            this.toolStripDropDownButtonEdit,
            this.toolStripDropDownButtonRun,
            this.toolStripButtonView});
            this.toolStripWindow.Location = new System.Drawing.Point(0, 0);
            this.toolStripWindow.Name = "toolStripWindow";
            this.toolStripWindow.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripWindow.Size = new System.Drawing.Size(934, 27);
            this.toolStripWindow.TabIndex = 2;
            this.toolStripWindow.Tag = "";
            this.toolStripWindow.Text = "toolStripWindow";
            // 
            // toolStripDropDownButtonFiles
            // 
            this.toolStripDropDownButtonFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButtonFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFiles.Image")));
            this.toolStripDropDownButtonFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFiles.Name = "toolStripDropDownButtonFiles";
            this.toolStripDropDownButtonFiles.Size = new System.Drawing.Size(52, 24);
            this.toolStripDropDownButtonFiles.Text = "Files";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonEdit
            // 
            this.toolStripDropDownButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem1});
            this.toolStripDropDownButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEdit.Image")));
            this.toolStripDropDownButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEdit.Name = "toolStripDropDownButtonEdit";
            this.toolStripDropDownButtonEdit.Size = new System.Drawing.Size(49, 24);
            this.toolStripDropDownButtonEdit.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem1
            // 
            this.redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            this.redoToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+Y";
            this.redoToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.redoToolStripMenuItem1.Text = "Redo";
            this.redoToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButtonRun
            // 
            this.toolStripDropDownButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAsResourceScriptToolStripMenuItem});
            this.toolStripDropDownButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonRun.Image")));
            this.toolStripDropDownButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRun.Name = "toolStripDropDownButtonRun";
            this.toolStripDropDownButtonRun.Size = new System.Drawing.Size(48, 24);
            this.toolStripDropDownButtonRun.Text = "Run";
            // 
            // runAsResourceScriptToolStripMenuItem
            // 
            this.runAsResourceScriptToolStripMenuItem.Name = "runAsResourceScriptToolStripMenuItem";
            this.runAsResourceScriptToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.runAsResourceScriptToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.runAsResourceScriptToolStripMenuItem.Text = "Run as Resource Script";
            this.runAsResourceScriptToolStripMenuItem.Click += new System.EventHandler(this.runAsResourceScriptToolStripMenuItem_Click);
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infobarToolStripMenuItem,
            this.infobarOptionsToolStripMenuItem,
            this.toolStripSeparator2,
            this.lineNumbersToolStripMenuItem});
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(55, 24);
            this.toolStripButtonView.Text = "View";
            // 
            // infobarToolStripMenuItem
            // 
            this.infobarToolStripMenuItem.Checked = true;
            this.infobarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.infobarToolStripMenuItem.Name = "infobarToolStripMenuItem";
            this.infobarToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.infobarToolStripMenuItem.Text = "Infobar";
            this.infobarToolStripMenuItem.Click += new System.EventHandler(this.infobarToolStripMenuItem_Click);
            // 
            // infobarOptionsToolStripMenuItem
            // 
            this.infobarOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistoryIndexToolStripMenuItem});
            this.infobarOptionsToolStripMenuItem.Name = "infobarOptionsToolStripMenuItem";
            this.infobarOptionsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.infobarOptionsToolStripMenuItem.Text = "Infobar Options";
            // 
            // showHistoryIndexToolStripMenuItem
            // 
            this.showHistoryIndexToolStripMenuItem.Checked = true;
            this.showHistoryIndexToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHistoryIndexToolStripMenuItem.Name = "showHistoryIndexToolStripMenuItem";
            this.showHistoryIndexToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.showHistoryIndexToolStripMenuItem.Text = "Show History Index";
            this.showHistoryIndexToolStripMenuItem.Click += new System.EventHandler(this.showHistoryIndexToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // lineNumbersToolStripMenuItem
            // 
            this.lineNumbersToolStripMenuItem.Checked = true;
            this.lineNumbersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lineNumbersToolStripMenuItem.Name = "lineNumbersToolStripMenuItem";
            this.lineNumbersToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.lineNumbersToolStripMenuItem.Text = "Line numbers";
            this.lineNumbersToolStripMenuItem.Click += new System.EventHandler(this.lineNumbersToolStripMenuItem_Click);
            // 
            // autocompleteMenuText
            // 
            this.autocompleteMenuText.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenuText.Colors")));
            this.autocompleteMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenuText.ImageList = null;
            this.autocompleteMenuText.Items = new string[0];
            this.autocompleteMenuText.TargetControlWrapper = null;
            // 
            // LineNumberTextBox
            // 
            this.autocompleteMenuText.SetAutocompleteMenu(this.LineNumberTextBox, null);
            this.LineNumberTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumberTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LineNumberTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumberTextBox.Location = new System.Drawing.Point(0, 27);
            this.LineNumberTextBox.Multiline = true;
            this.LineNumberTextBox.Name = "LineNumberTextBox";
            this.LineNumberTextBox.ReadOnly = true;
            this.LineNumberTextBox.Size = new System.Drawing.Size(46, 440);
            this.LineNumberTextBox.TabIndex = 4;
            this.LineNumberTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LineNumberTextBox_MouseDown);
            // 
            // statusStripInfobar
            // 
            this.statusStripInfobar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInfobar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLine,
            this.toolStripStatusLabelHistoryIndex,
            this.toolStripStatusLabelLastAction});
            this.statusStripInfobar.Location = new System.Drawing.Point(0, 467);
            this.statusStripInfobar.Name = "statusStripInfobar";
            this.statusStripInfobar.Size = new System.Drawing.Size(934, 25);
            this.statusStripInfobar.TabIndex = 3;
            this.statusStripInfobar.Text = "statusStripInfobar";
            // 
            // toolStripStatusLabelLine
            // 
            this.toolStripStatusLabelLine.Name = "toolStripStatusLabelLine";
            this.toolStripStatusLabelLine.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabelLine.Text = "1 : 1";
            // 
            // toolStripStatusLabelHistoryIndex
            // 
            this.toolStripStatusLabelHistoryIndex.Name = "toolStripStatusLabelHistoryIndex";
            this.toolStripStatusLabelHistoryIndex.Size = new System.Drawing.Size(93, 20);
            this.toolStripStatusLabelHistoryIndex.Text = "History(0 : 0)";
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(142, 20);
            this.toolStripStatusLabelLastAction.Text = "Last action: Initiated";
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.richTextBoxCode);
            this.Controls.Add(this.LineNumberTextBox);
            this.Controls.Add(this.statusStripInfobar);
            this.Controls.Add(this.toolStripWindow);
            this.Name = "ScriptEditor";
            this.Text = "Resource Script Editor (RSE) - Metasploit GUI";
            this.Load += new System.EventHandler(this.ScriptEditor_Load);
            this.ResizeEnd += new System.EventHandler(this.ScriptEditor_ResizeEnd);
            this.toolStripWindow.ResumeLayout(false);
            this.toolStripWindow.PerformLayout();
            this.statusStripInfobar.ResumeLayout(false);
            this.statusStripInfobar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.ToolStrip toolStripWindow;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFiles;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEdit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenuText;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRun;
        private System.Windows.Forms.ToolStripMenuItem runAsResourceScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonView;
        private System.Windows.Forms.ToolStripMenuItem infobarToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripInfobar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLine;
        private System.Windows.Forms.TextBox LineNumberTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHistoryIndex;
        private System.Windows.Forms.ToolStripMenuItem infobarOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHistoryIndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem lineNumbersToolStripMenuItem;
    }
}