namespace Metasploit_GUI
{
    partial class Main
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
            this.buttonRemoteAttack = new System.Windows.Forms.Button();
            this.buttonCreatePayload = new System.Windows.Forms.Button();
            this.buttonInstaller = new System.Windows.Forms.Button();
            this.buttonRSE = new System.Windows.Forms.Button();
            this.buttonConsole = new System.Windows.Forms.Button();
            this.buttonProfiles = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonNmap = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemoteAttack
            // 
            this.buttonRemoteAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRemoteAttack.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoteAttack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRemoteAttack.Location = new System.Drawing.Point(12, 224);
            this.buttonRemoteAttack.Name = "buttonRemoteAttack";
            this.buttonRemoteAttack.Size = new System.Drawing.Size(161, 103);
            this.buttonRemoteAttack.TabIndex = 0;
            this.buttonRemoteAttack.Text = "Setup remote attack";
            this.buttonRemoteAttack.UseVisualStyleBackColor = false;
            this.buttonRemoteAttack.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreatePayload
            // 
            this.buttonCreatePayload.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatePayload.Location = new System.Drawing.Point(12, 12);
            this.buttonCreatePayload.Name = "buttonCreatePayload";
            this.buttonCreatePayload.Size = new System.Drawing.Size(244, 206);
            this.buttonCreatePayload.TabIndex = 1;
            this.buttonCreatePayload.Text = "Create Payload";
            this.buttonCreatePayload.UseVisualStyleBackColor = true;
            this.buttonCreatePayload.Click += new System.EventHandler(this.button2_Click);
            this.buttonCreatePayload.MouseEnter += new System.EventHandler(this.buttonCreatePayload_MouseEnter);
            // 
            // buttonInstaller
            // 
            this.buttonInstaller.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstaller.Location = new System.Drawing.Point(315, 224);
            this.buttonInstaller.Name = "buttonInstaller";
            this.buttonInstaller.Size = new System.Drawing.Size(173, 103);
            this.buttonInstaller.TabIndex = 2;
            this.buttonInstaller.Text = "Open installer";
            this.buttonInstaller.UseVisualStyleBackColor = true;
            this.buttonInstaller.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRSE
            // 
            this.buttonRSE.BackColor = System.Drawing.Color.Silver;
            this.buttonRSE.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRSE.Location = new System.Drawing.Point(494, 224);
            this.buttonRSE.Name = "buttonRSE";
            this.buttonRSE.Size = new System.Drawing.Size(166, 103);
            this.buttonRSE.TabIndex = 3;
            this.buttonRSE.Text = "Resource Script Editor";
            this.buttonRSE.UseVisualStyleBackColor = false;
            this.buttonRSE.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonConsole
            // 
            this.buttonConsole.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsole.Location = new System.Drawing.Point(262, 12);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(226, 206);
            this.buttonConsole.TabIndex = 4;
            this.buttonConsole.Text = "Open Console";
            this.buttonConsole.UseVisualStyleBackColor = true;
            this.buttonConsole.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonProfiles
            // 
            this.buttonProfiles.BackColor = System.Drawing.Color.Silver;
            this.buttonProfiles.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfiles.Location = new System.Drawing.Point(494, 115);
            this.buttonProfiles.Name = "buttonProfiles";
            this.buttonProfiles.Size = new System.Drawing.Size(166, 103);
            this.buttonProfiles.TabIndex = 5;
            this.buttonProfiles.Text = "Change profile";
            this.buttonProfiles.UseVisualStyleBackColor = false;
            this.buttonProfiles.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.Silver;
            this.buttonOptions.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOptions.Location = new System.Drawing.Point(494, 12);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(166, 97);
            this.buttonOptions.TabIndex = 6;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonNmap
            // 
            this.buttonNmap.Font = new System.Drawing.Font("Source Code Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNmap.Location = new System.Drawing.Point(179, 224);
            this.buttonNmap.Name = "buttonNmap";
            this.buttonNmap.Size = new System.Drawing.Size(130, 103);
            this.buttonNmap.TabIndex = 7;
            this.buttonNmap.Text = "NMAP Window";
            this.buttonNmap.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 330);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(672, 25);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 20);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 355);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonNmap);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonProfiles);
            this.Controls.Add(this.buttonConsole);
            this.Controls.Add(this.buttonRSE);
            this.Controls.Add(this.buttonInstaller);
            this.Controls.Add(this.buttonCreatePayload);
            this.Controls.Add(this.buttonRemoteAttack);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoteAttack;
        private System.Windows.Forms.Button buttonCreatePayload;
        private System.Windows.Forms.Button buttonInstaller;
        private System.Windows.Forms.Button buttonRSE;
        private System.Windows.Forms.Button buttonConsole;
        private System.Windows.Forms.Button buttonProfiles;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonNmap;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}