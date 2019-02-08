namespace Metasploit_GUI
{
    partial class Installer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metasploitstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pythonwrapperstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmapstatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxSelected = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelectMetasploit = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectPythonWrapper = new System.Windows.Forms.CheckBox();
            this.checkBoxSelectNmap = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelSoftware = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.labelSelected = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanelSoftware.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSelectMetasploit);
            this.groupBox1.Controls.Add(this.metasploitstatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metasploit";
            // 
            // metasploitstatus
            // 
            this.metasploitstatus.AutoSize = true;
            this.metasploitstatus.Location = new System.Drawing.Point(6, 62);
            this.metasploitstatus.Name = "metasploitstatus";
            this.metasploitstatus.Size = new System.Drawing.Size(86, 17);
            this.metasploitstatus.TabIndex = 2;
            this.metasploitstatus.Text = "Not installed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSelectPythonWrapper);
            this.groupBox3.Controls.Add(this.pythonwrapperstatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(207, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Python-Wrapper";
            // 
            // pythonwrapperstatus
            // 
            this.pythonwrapperstatus.AutoSize = true;
            this.pythonwrapperstatus.Location = new System.Drawing.Point(6, 62);
            this.pythonwrapperstatus.Name = "pythonwrapperstatus";
            this.pythonwrapperstatus.Size = new System.Drawing.Size(86, 17);
            this.pythonwrapperstatus.TabIndex = 2;
            this.pythonwrapperstatus.Text = "Not installed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSelectNmap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nmapstatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(411, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 148);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NMAP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "NMAP currently isn\'t supported";
            // 
            // nmapstatus
            // 
            this.nmapstatus.AutoSize = true;
            this.nmapstatus.Location = new System.Drawing.Point(6, 62);
            this.nmapstatus.Name = "nmapstatus";
            this.nmapstatus.Size = new System.Drawing.Size(86, 17);
            this.nmapstatus.TabIndex = 2;
            this.nmapstatus.Text = "Not installed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOTE: you need to install the programs in their default directory";
            // 
            // checkedListBoxSelected
            // 
            this.checkedListBoxSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBoxSelected.FormattingEnabled = true;
            this.checkedListBoxSelected.Location = new System.Drawing.Point(12, 282);
            this.checkedListBoxSelected.Name = "checkedListBoxSelected";
            this.checkedListBoxSelected.Size = new System.Drawing.Size(161, 157);
            this.checkedListBoxSelected.TabIndex = 6;
            // 
            // checkBoxSelectMetasploit
            // 
            this.checkBoxSelectMetasploit.AutoSize = true;
            this.checkBoxSelectMetasploit.Location = new System.Drawing.Point(178, 10);
            this.checkBoxSelectMetasploit.Name = "checkBoxSelectMetasploit";
            this.checkBoxSelectMetasploit.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSelectMetasploit.TabIndex = 3;
            this.checkBoxSelectMetasploit.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectPythonWrapper
            // 
            this.checkBoxSelectPythonWrapper.AutoSize = true;
            this.checkBoxSelectPythonWrapper.Location = new System.Drawing.Point(178, 10);
            this.checkBoxSelectPythonWrapper.Name = "checkBoxSelectPythonWrapper";
            this.checkBoxSelectPythonWrapper.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSelectPythonWrapper.TabIndex = 4;
            this.checkBoxSelectPythonWrapper.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectNmap
            // 
            this.checkBoxSelectNmap.AutoSize = true;
            this.checkBoxSelectNmap.Location = new System.Drawing.Point(178, 10);
            this.checkBoxSelectNmap.Name = "checkBoxSelectNmap";
            this.checkBoxSelectNmap.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSelectNmap.TabIndex = 5;
            this.checkBoxSelectNmap.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSoftware
            // 
            this.flowLayoutPanelSoftware.AutoScroll = true;
            this.flowLayoutPanelSoftware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelSoftware.Controls.Add(this.groupBox1);
            this.flowLayoutPanelSoftware.Controls.Add(this.groupBox3);
            this.flowLayoutPanelSoftware.Controls.Add(this.groupBox2);
            this.flowLayoutPanelSoftware.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelSoftware.Name = "flowLayoutPanelSoftware";
            this.flowLayoutPanelSoftware.Size = new System.Drawing.Size(776, 235);
            this.flowLayoutPanelSoftware.TabIndex = 7;
            this.flowLayoutPanelSoftware.WrapContents = false;
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxActions.Controls.Add(this.buttonUpdate);
            this.groupBoxActions.Location = new System.Drawing.Point(193, 285);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(322, 154);
            this.groupBoxActions.TabIndex = 8;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 21);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 26);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update Selected";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(199, 250);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(87, 21);
            this.checkBoxSelectAll.TabIndex = 9;
            this.checkBoxSelectAll.Text = "Select all";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelected.Location = new System.Drawing.Point(11, 250);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(154, 17);
            this.labelSelected.TabIndex = 10;
            this.labelSelected.Text = "0 Elements selected";
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.flowLayoutPanelSoftware);
            this.Controls.Add(this.checkedListBoxSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Name = "Installer";
            this.Text = "Metasploit GUI - Installer";
            this.Load += new System.EventHandler(this.Installer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanelSoftware.ResumeLayout(false);
            this.groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label metasploitstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label pythonwrapperstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nmapstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSelectMetasploit;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelected;
        private System.Windows.Forms.CheckBox checkBoxSelectPythonWrapper;
        private System.Windows.Forms.CheckBox checkBoxSelectNmap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSoftware;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Label labelSelected;
    }
}

