namespace DemulShooterLauncher
{
    partial class Launcher
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStart = new System.Windows.Forms.Button();
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.listBoxRom = new System.Windows.Forms.ListBox();
            this.linkWiki = new System.Windows.Forms.LinkLabel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkPatches = new System.Windows.Forms.LinkLabel();
            this.BtnScript = new System.Windows.Forms.Button();
            this.PanelArguments = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(457, 184);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(69, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // listBoxTarget
            // 
            this.listBoxTarget.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTarget.FormattingEnabled = true;
            this.listBoxTarget.Location = new System.Drawing.Point(0, 0);
            this.listBoxTarget.Name = "listBoxTarget";
            this.listBoxTarget.Size = new System.Drawing.Size(217, 212);
            this.listBoxTarget.Sorted = true;
            this.listBoxTarget.TabIndex = 15;
            this.listBoxTarget.SelectedIndexChanged += new System.EventHandler(this.listBoxTarget_SelectedIndexChanged);
            this.listBoxTarget.DoubleClick += new System.EventHandler(this.linkHelp_LinkClicked);
            // 
            // listBoxRom
            // 
            this.listBoxRom.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxRom.FormattingEnabled = true;
            this.listBoxRom.Location = new System.Drawing.Point(217, 0);
            this.listBoxRom.Name = "listBoxRom";
            this.listBoxRom.Size = new System.Drawing.Size(237, 212);
            this.listBoxRom.Sorted = true;
            this.listBoxRom.TabIndex = 16;
            this.listBoxRom.SelectedIndexChanged += new System.EventHandler(this.listBoxRom_SelectedIndexChanged);
            this.listBoxRom.DoubleClick += new System.EventHandler(this.BtnStart_Click);
            // 
            // linkWiki
            // 
            this.linkWiki.AutoSize = true;
            this.linkWiki.Location = new System.Drawing.Point(549, 5);
            this.linkWiki.Name = "linkWiki";
            this.linkWiki.Size = new System.Drawing.Size(28, 13);
            this.linkWiki.TabIndex = 17;
            this.linkWiki.TabStop = true;
            this.linkWiki.Text = "Wiki";
            this.linkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWiki_LinkClicked);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(549, 26);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(49, 13);
            this.linkHelp.TabIndex = 18;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help rom";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // linkPatches
            // 
            this.linkPatches.AutoSize = true;
            this.linkPatches.Location = new System.Drawing.Point(549, 47);
            this.linkPatches.Name = "linkPatches";
            this.linkPatches.Size = new System.Drawing.Size(73, 13);
            this.linkPatches.TabIndex = 19;
            this.linkPatches.TabStop = true;
            this.linkPatches.Text = "More Patches";
            this.linkPatches.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPatches_LinkClicked);
            // 
            // BtnScript
            // 
            this.BtnScript.Location = new System.Drawing.Point(544, 184);
            this.BtnScript.Name = "BtnScript";
            this.BtnScript.Size = new System.Drawing.Size(78, 23);
            this.BtnScript.TabIndex = 20;
            this.BtnScript.Text = "Create Script";
            this.BtnScript.UseVisualStyleBackColor = true;
            this.BtnScript.Click += new System.EventHandler(this.BtnScript_Click);
            // 
            // PanelArguments
            // 
            this.PanelArguments.Location = new System.Drawing.Point(458, 0);
            this.PanelArguments.Name = "PanelArguments";
            this.PanelArguments.Size = new System.Drawing.Size(89, 178);
            this.PanelArguments.TabIndex = 21;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 212);
            this.Controls.Add(this.PanelArguments);
            this.Controls.Add(this.BtnScript);
            this.Controls.Add(this.linkPatches);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.linkWiki);
            this.Controls.Add(this.listBoxRom);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.BtnStart);
            this.Name = "Launcher";
            this.Text = "DemulShooterLauncher";
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ListBox listBoxTarget;
        private System.Windows.Forms.ListBox listBoxRom;
        private System.Windows.Forms.LinkLabel linkWiki;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkPatches;
        private System.Windows.Forms.Button BtnScript;
        private System.Windows.Forms.Panel PanelArguments;
    }
}

