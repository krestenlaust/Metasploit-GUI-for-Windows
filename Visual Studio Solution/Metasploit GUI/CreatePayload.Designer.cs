namespace Metasploit_GUI
{
    partial class CreatePayload
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
            this.buttonRefreshInfo = new System.Windows.Forms.Button();
            this.buttonChangeInfo = new System.Windows.Forms.Button();
            this.textBoxLport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLhost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTargetfiletype = new System.Windows.Forms.Label();
            this.comboBoxTargetType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxEncoders = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSelectTargetFilepath = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonCreateListener = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxPythonWrapper = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRefreshInfo);
            this.groupBox1.Controls.Add(this.buttonChangeInfo);
            this.groupBox1.Controls.Add(this.textBoxLport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxLhost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Local Info*";
            // 
            // buttonRefreshInfo
            // 
            this.buttonRefreshInfo.Location = new System.Drawing.Point(67, 116);
            this.buttonRefreshInfo.Name = "buttonRefreshInfo";
            this.buttonRefreshInfo.Size = new System.Drawing.Size(74, 29);
            this.buttonRefreshInfo.TabIndex = 5;
            this.buttonRefreshInfo.Text = "Refresh";
            this.buttonRefreshInfo.UseVisualStyleBackColor = true;
            this.buttonRefreshInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonChangeInfo
            // 
            this.buttonChangeInfo.Location = new System.Drawing.Point(2, 116);
            this.buttonChangeInfo.Name = "buttonChangeInfo";
            this.buttonChangeInfo.Size = new System.Drawing.Size(74, 29);
            this.buttonChangeInfo.TabIndex = 4;
            this.buttonChangeInfo.Text = "Change";
            this.buttonChangeInfo.UseVisualStyleBackColor = true;
            this.buttonChangeInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLport
            // 
            this.textBoxLport.Location = new System.Drawing.Point(10, 87);
            this.textBoxLport.MaxLength = 20;
            this.textBoxLport.Name = "textBoxLport";
            this.textBoxLport.ReadOnly = true;
            this.textBoxLport.Size = new System.Drawing.Size(125, 22);
            this.textBoxLport.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local - port(lport):";
            // 
            // textBoxLhost
            // 
            this.textBoxLhost.Location = new System.Drawing.Point(10, 42);
            this.textBoxLhost.MaxLength = 20;
            this.textBoxLhost.Name = "textBoxLhost";
            this.textBoxLhost.ReadOnly = true;
            this.textBoxLhost.Size = new System.Drawing.Size(125, 22);
            this.textBoxLhost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local - host(lhost):";
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(619, 391);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(115, 47);
            this.buttonBuild.TabIndex = 1;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelTargetfiletype);
            this.groupBox2.Controls.Add(this.comboBoxTargetType);
            this.groupBox2.Location = new System.Drawing.Point(160, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exploit*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Target filetype:";
            // 
            // labelTargetfiletype
            // 
            this.labelTargetfiletype.AutoSize = true;
            this.labelTargetfiletype.Location = new System.Drawing.Point(6, 76);
            this.labelTargetfiletype.Name = "labelTargetfiletype";
            this.labelTargetfiletype.Size = new System.Drawing.Size(16, 17);
            this.labelTargetfiletype.TabIndex = 1;
            this.labelTargetfiletype.Text = "..";
            // 
            // comboBoxTargetType
            // 
            this.comboBoxTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetType.FormattingEnabled = true;
            this.comboBoxTargetType.Items.AddRange(new object[] {
            "windows/meterpreter/reverse_tcp",
            "windows/meterpreter/reverse_http",
            "php/meterpreter_reverse_tcp",
            "osx/x64/meterpreter/reverse_tcp",
            "linux/x86/meterpreter/reverse_tcp",
            "cmd/windows/reverse_powershell"});
            this.comboBoxTargetType.Location = new System.Drawing.Point(6, 22);
            this.comboBoxTargetType.Name = "comboBoxTargetType";
            this.comboBoxTargetType.Size = new System.Drawing.Size(285, 24);
            this.comboBoxTargetType.TabIndex = 0;
            this.comboBoxTargetType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxEncoders);
            this.groupBox3.Location = new System.Drawing.Point(463, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encoders";
            // 
            // comboBoxEncoders
            // 
            this.comboBoxEncoders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncoders.FormattingEnabled = true;
            this.comboBoxEncoders.Items.AddRange(new object[] {
            "none",
            "cmd/echo",
            "generic/none",
            "x86/shikata_ga_nai",
            "php/base64",
            "cmd/powershell_base64",
            "generic/eicar"});
            this.comboBoxEncoders.Location = new System.Drawing.Point(6, 22);
            this.comboBoxEncoders.Name = "comboBoxEncoders";
            this.comboBoxEncoders.Size = new System.Drawing.Size(259, 24);
            this.comboBoxEncoders.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSelectTargetFilepath);
            this.groupBox4.Controls.Add(this.saveLocation);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(160, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 118);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Location";
            // 
            // buttonSelectTargetFilepath
            // 
            this.buttonSelectTargetFilepath.Location = new System.Drawing.Point(6, 71);
            this.buttonSelectTargetFilepath.Name = "buttonSelectTargetFilepath";
            this.buttonSelectTargetFilepath.Size = new System.Drawing.Size(134, 41);
            this.buttonSelectTargetFilepath.TabIndex = 2;
            this.buttonSelectTargetFilepath.Text = "Select Filepath";
            this.buttonSelectTargetFilepath.UseVisualStyleBackColor = true;
            this.buttonSelectTargetFilepath.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(6, 43);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.ReadOnly = true;
            this.saveLocation.Size = new System.Drawing.Size(285, 22);
            this.saveLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current:";
            // 
            // buttonCreateListener
            // 
            this.buttonCreateListener.Location = new System.Drawing.Point(497, 391);
            this.buttonCreateListener.Name = "buttonCreateListener";
            this.buttonCreateListener.Size = new System.Drawing.Size(116, 47);
            this.buttonCreateListener.TabIndex = 5;
            this.buttonCreateListener.Text = "Create listener";
            this.buttonCreateListener.UseVisualStyleBackColor = true;
            this.buttonCreateListener.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.checkBoxPythonWrapper);
            this.groupBox5.Location = new System.Drawing.Point(12, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 93);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Python-Wrapper";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "windows executables";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Only works with";
            // 
            // checkBoxPythonWrapper
            // 
            this.checkBoxPythonWrapper.AutoSize = true;
            this.checkBoxPythonWrapper.Location = new System.Drawing.Point(11, 25);
            this.checkBoxPythonWrapper.Name = "checkBoxPythonWrapper";
            this.checkBoxPythonWrapper.Size = new System.Drawing.Size(74, 21);
            this.checkBoxPythonWrapper.TabIndex = 0;
            this.checkBoxPythonWrapper.Text = "Enable";
            this.checkBoxPythonWrapper.UseVisualStyleBackColor = true;
            // 
            // CreatePayload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonCreateListener);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePayload";
            this.Text = "Create Payload";
            this.Load += new System.EventHandler(this.CreatePayload_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLhost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangeInfo;
        private System.Windows.Forms.TextBox textBoxLport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTargetType;
        private System.Windows.Forms.Label labelTargetfiletype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxEncoders;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSelectTargetFilepath;
        private System.Windows.Forms.Button buttonRefreshInfo;
        private System.Windows.Forms.Button buttonCreateListener;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxPythonWrapper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}