namespace Metasploit_GUI
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDisableDebug = new System.Windows.Forms.RadioButton();
            this.radioButtonEnableDebug = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxEditableConsole = new System.Windows.Forms.CheckBox();
            this.checkBoxAutocomplete = new System.Windows.Forms.CheckBox();
            this.groupBoxAutoCompletePrefs = new System.Windows.Forms.GroupBox();
            this.buttonRefreshDict = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonDictionary = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarMaxSuggestions = new System.Windows.Forms.TrackBar();
            this.toolTipOptions = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAutoCompletePrefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxSuggestions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(209, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payload settings";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "RPORT:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "RHOST:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "LPORT:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LHOST:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDisableDebug);
            this.groupBox2.Controls.Add(this.radioButtonEnableDebug);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug/Console log";
            // 
            // radioButtonDisableDebug
            // 
            this.radioButtonDisableDebug.AutoSize = true;
            this.radioButtonDisableDebug.Location = new System.Drawing.Point(6, 57);
            this.radioButtonDisableDebug.Name = "radioButtonDisableDebug";
            this.radioButtonDisableDebug.Size = new System.Drawing.Size(127, 21);
            this.radioButtonDisableDebug.TabIndex = 1;
            this.radioButtonDisableDebug.TabStop = true;
            this.radioButtonDisableDebug.Text = "Hide Debug log";
            this.radioButtonDisableDebug.UseVisualStyleBackColor = true;
            this.radioButtonDisableDebug.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonEnableDebug
            // 
            this.radioButtonEnableDebug.AutoSize = true;
            this.radioButtonEnableDebug.Location = new System.Drawing.Point(6, 30);
            this.radioButtonEnableDebug.Name = "radioButtonEnableDebug";
            this.radioButtonEnableDebug.Size = new System.Drawing.Size(132, 21);
            this.radioButtonEnableDebug.TabIndex = 0;
            this.radioButtonEnableDebug.TabStop = true;
            this.radioButtonEnableDebug.Text = "Show Debug log";
            this.radioButtonEnableDebug.UseVisualStyleBackColor = true;
            this.radioButtonEnableDebug.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 404);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxEditableConsole);
            this.groupBox3.Controls.Add(this.checkBoxAutocomplete);
            this.groupBox3.Controls.Add(this.groupBoxAutoCompletePrefs);
            this.groupBox3.Location = new System.Drawing.Point(443, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 302);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console Window Preferences";
            // 
            // checkBoxEditableConsole
            // 
            this.checkBoxEditableConsole.AutoSize = true;
            this.checkBoxEditableConsole.Location = new System.Drawing.Point(6, 273);
            this.checkBoxEditableConsole.Name = "checkBoxEditableConsole";
            this.checkBoxEditableConsole.Size = new System.Drawing.Size(183, 21);
            this.checkBoxEditableConsole.TabIndex = 2;
            this.checkBoxEditableConsole.Text = "Editable Console Output";
            this.checkBoxEditableConsole.UseVisualStyleBackColor = true;
            this.checkBoxEditableConsole.CheckedChanged += new System.EventHandler(this.checkBoxEditableConsole_CheckedChanged);
            this.checkBoxEditableConsole.MouseHover += new System.EventHandler(this.checkBoxEditableConsole_MouseHover);
            // 
            // checkBoxAutocomplete
            // 
            this.checkBoxAutocomplete.AutoSize = true;
            this.checkBoxAutocomplete.Checked = true;
            this.checkBoxAutocomplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutocomplete.Location = new System.Drawing.Point(6, 59);
            this.checkBoxAutocomplete.Name = "checkBoxAutocomplete";
            this.checkBoxAutocomplete.Size = new System.Drawing.Size(171, 21);
            this.checkBoxAutocomplete.TabIndex = 1;
            this.checkBoxAutocomplete.Text = "Enable Auto-Complete";
            this.checkBoxAutocomplete.UseVisualStyleBackColor = true;
            this.checkBoxAutocomplete.CheckedChanged += new System.EventHandler(this.checkBoxAutocomplete_CheckedChanged);
            // 
            // groupBoxAutoCompletePrefs
            // 
            this.groupBoxAutoCompletePrefs.Controls.Add(this.buttonRefreshDict);
            this.groupBoxAutoCompletePrefs.Controls.Add(this.labelValue);
            this.groupBoxAutoCompletePrefs.Controls.Add(this.buttonDictionary);
            this.groupBoxAutoCompletePrefs.Controls.Add(this.label5);
            this.groupBoxAutoCompletePrefs.Controls.Add(this.trackBarMaxSuggestions);
            this.groupBoxAutoCompletePrefs.Location = new System.Drawing.Point(6, 86);
            this.groupBoxAutoCompletePrefs.Name = "groupBoxAutoCompletePrefs";
            this.groupBoxAutoCompletePrefs.Size = new System.Drawing.Size(200, 179);
            this.groupBoxAutoCompletePrefs.TabIndex = 0;
            this.groupBoxAutoCompletePrefs.TabStop = false;
            this.groupBoxAutoCompletePrefs.Text = "Auto-Complete Preferences";
            // 
            // buttonRefreshDict
            // 
            this.buttonRefreshDict.Location = new System.Drawing.Point(6, 59);
            this.buttonRefreshDict.Name = "buttonRefreshDict";
            this.buttonRefreshDict.Size = new System.Drawing.Size(188, 33);
            this.buttonRefreshDict.TabIndex = 4;
            this.buttonRefreshDict.Text = "Refresh Dictionary";
            this.buttonRefreshDict.UseVisualStyleBackColor = true;
            this.buttonRefreshDict.Click += new System.EventHandler(this.buttonRefreshDict_Click);
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(114, 124);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(48, 17);
            this.labelValue.TabIndex = 3;
            this.labelValue.Text = "Value:";
            // 
            // buttonDictionary
            // 
            this.buttonDictionary.Location = new System.Drawing.Point(6, 26);
            this.buttonDictionary.Name = "buttonDictionary";
            this.buttonDictionary.Size = new System.Drawing.Size(188, 33);
            this.buttonDictionary.TabIndex = 2;
            this.buttonDictionary.Text = "Change dictionary location";
            this.buttonDictionary.UseVisualStyleBackColor = true;
            this.buttonDictionary.Click += new System.EventHandler(this.buttonDictionary_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Max Suggestions at once";
            // 
            // trackBarMaxSuggestions
            // 
            this.trackBarMaxSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarMaxSuggestions.LargeChange = 2;
            this.trackBarMaxSuggestions.Location = new System.Drawing.Point(6, 118);
            this.trackBarMaxSuggestions.Minimum = 1;
            this.trackBarMaxSuggestions.Name = "trackBarMaxSuggestions";
            this.trackBarMaxSuggestions.Size = new System.Drawing.Size(104, 56);
            this.trackBarMaxSuggestions.TabIndex = 0;
            this.trackBarMaxSuggestions.Value = 5;
            this.trackBarMaxSuggestions.Scroll += new System.EventHandler(this.trackBarMaxSuggestions_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text file(*.txt)|*txt|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select Auto-Complete Dictionary";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 404);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAutoCompletePrefs.ResumeLayout(false);
            this.groupBoxAutoCompletePrefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxSuggestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDisableDebug;
        private System.Windows.Forms.RadioButton radioButtonEnableDebug;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxAutocomplete;
        private System.Windows.Forms.GroupBox groupBoxAutoCompletePrefs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarMaxSuggestions;
        private System.Windows.Forms.ToolTip toolTipOptions;
        private System.Windows.Forms.CheckBox checkBoxEditableConsole;
        private System.Windows.Forms.Button buttonDictionary;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonRefreshDict;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}