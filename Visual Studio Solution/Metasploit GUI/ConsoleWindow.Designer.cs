namespace Metasploit_GUI
{
    partial class ConsoleWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleWindow));
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.SuspendLayout();
            // 
            // richTextBoxOutput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBoxOutput, null);
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(806, 354);
            this.richTextBoxOutput.TabIndex = 0;
            this.richTextBoxOutput.Text = "Loading...\nIf nothing happens within 1 - 2 minutes then something went wrong\n";
            this.richTextBoxOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxInput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.textBoxInput, this.autocompleteMenu1);
            this.textBoxInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxInput.Location = new System.Drawing.Point(0, 360);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(806, 22);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AllowsTabKey = true;
            this.autocompleteMenu1.AppearInterval = 200;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "public",
        "use",
        "exploit",
        "run"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // ConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 382);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.richTextBoxOutput);
            this.Name = "ConsoleWindow";
            this.Text = "Metasploit Console";
            this.Load += new System.EventHandler(this.ConsoleWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
    }
}