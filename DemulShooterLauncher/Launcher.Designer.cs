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
            this.components = new System.ComponentModel.Container();
            this.BtnStart = new System.Windows.Forms.Button();
            this.checkNoResize = new System.Windows.Forms.CheckBox();
            this.checkWidescreen = new System.Windows.Forms.CheckBox();
            this.checkNoReload = new System.Windows.Forms.CheckBox();
            this.checkNoFire = new System.Windows.Forms.CheckBox();
            this.checkNoGuns = new System.Windows.Forms.CheckBox();
            this.checkNoCross = new System.Windows.Forms.CheckBox();
            this.checkDdinumber = new System.Windows.Forms.CheckBox();
            this.checkVerbs = new System.Windows.Forms.CheckBox();
            this.TipNoResize = new System.Windows.Forms.ToolTip(this.components);
            this.TipWidescreen = new System.Windows.Forms.ToolTip(this.components);
            this.TipNoReload = new System.Windows.Forms.ToolTip(this.components);
            this.TipNoGuns = new System.Windows.Forms.ToolTip(this.components);
            this.TipNoFire = new System.Windows.Forms.ToolTip(this.components);
            this.TipNoCross = new System.Windows.Forms.ToolTip(this.components);
            this.TipddNumber = new System.Windows.Forms.ToolTip(this.components);
            this.TipVerbs = new System.Windows.Forms.ToolTip(this.components);
            this.listBoxTarget = new System.Windows.Forms.ListBox();
            this.listBoxRom = new System.Windows.Forms.ListBox();
            this.linkWiki = new System.Windows.Forms.LinkLabel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkPatches = new System.Windows.Forms.LinkLabel();
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
            // checkNoResize
            // 
            this.checkNoResize.AccessibleDescription = "";
            this.checkNoResize.AutoSize = true;
            this.checkNoResize.Enabled = false;
            this.checkNoResize.Location = new System.Drawing.Point(460, 46);
            this.checkNoResize.Name = "checkNoResize";
            this.checkNoResize.Size = new System.Drawing.Size(70, 17);
            this.checkNoResize.TabIndex = 3;
            this.checkNoResize.Text = "No resize";
            this.TipNoResize.SetToolTip(this.checkNoResize, "Fix demul bug (exiting fullscreen when shooting upper left corner). This will blo" +
        "ck all mouse inputs to Demul GUI (menus, etc...)");
            this.checkNoResize.UseVisualStyleBackColor = true;
            // 
            // checkWidescreen
            // 
            this.checkWidescreen.AutoSize = true;
            this.checkWidescreen.Enabled = false;
            this.checkWidescreen.Location = new System.Drawing.Point(460, 4);
            this.checkWidescreen.Name = "checkWidescreen";
            this.checkWidescreen.Size = new System.Drawing.Size(83, 17);
            this.checkWidescreen.TabIndex = 4;
            this.checkWidescreen.Text = "Widescreen";
            this.TipWidescreen.SetToolTip(this.checkWidescreen, "Demul widescreen hack, works for some games");
            this.checkWidescreen.UseVisualStyleBackColor = true;
            // 
            // checkNoReload
            // 
            this.checkNoReload.AutoSize = true;
            this.checkNoReload.Enabled = false;
            this.checkNoReload.Location = new System.Drawing.Point(460, 92);
            this.checkNoReload.Name = "checkNoReload";
            this.checkNoReload.Size = new System.Drawing.Size(93, 17);
            this.checkNoReload.TabIndex = 5;
            this.checkNoReload.Text = "No autoreload";
            this.TipNoReload.SetToolTip(this.checkNoReload, "Disable ingame auto-reload when last bullet is fired in hod3pc");
            this.checkNoReload.UseVisualStyleBackColor = true;
            // 
            // checkNoFire
            // 
            this.checkNoFire.AutoSize = true;
            this.checkNoFire.Enabled = false;
            this.checkNoFire.Location = new System.Drawing.Point(460, 25);
            this.checkNoFire.Name = "checkNoFire";
            this.checkNoFire.Size = new System.Drawing.Size(78, 17);
            this.checkNoFire.TabIndex = 6;
            this.checkNoFire.Text = "No autofire";
            this.TipNoFire.SetToolTip(this.checkNoFire, "Disable ingame auto-fire (Sega Golden Gun only)");
            this.checkNoFire.UseVisualStyleBackColor = true;
            // 
            // checkNoGuns
            // 
            this.checkNoGuns.AutoSize = true;
            this.checkNoGuns.Enabled = false;
            this.checkNoGuns.Location = new System.Drawing.Point(460, 69);
            this.checkNoGuns.Name = "checkNoGuns";
            this.checkNoGuns.Size = new System.Drawing.Size(66, 17);
            this.checkNoGuns.TabIndex = 7;
            this.checkNoGuns.Text = "No guns";
            this.TipNoGuns.SetToolTip(this.checkNoGuns, "Hide guns display in hod3pc during gameplay (just like real arcade machine)");
            this.checkNoGuns.UseVisualStyleBackColor = true;
            // 
            // checkNoCross
            // 
            this.checkNoCross.AutoSize = true;
            this.checkNoCross.Enabled = false;
            this.checkNoCross.Location = new System.Drawing.Point(460, 115);
            this.checkNoCross.Name = "checkNoCross";
            this.checkNoCross.Size = new System.Drawing.Size(86, 17);
            this.checkNoCross.TabIndex = 8;
            this.checkNoCross.Text = "No Crosshair";
            this.TipNoCross.SetToolTip(this.checkNoCross, " Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)");
            this.checkNoCross.UseVisualStyleBackColor = true;
            // 
            // checkDdinumber
            // 
            this.checkDdinumber.AutoSize = true;
            this.checkDdinumber.Enabled = false;
            this.checkDdinumber.Location = new System.Drawing.Point(460, 138);
            this.checkDdinumber.Name = "checkDdinumber";
            this.checkDdinumber.Size = new System.Drawing.Size(83, 17);
            this.checkDdinumber.TabIndex = 9;
            this.checkDdinumber.Text = "DDI number";
            this.TipddNumber.SetToolTip(this.checkDdinumber, "Dolphin\'s DirectInput number for P2 device (optional, default = 2)");
            this.checkDdinumber.UseVisualStyleBackColor = true;
            // 
            // checkVerbs
            // 
            this.checkVerbs.AutoSize = true;
            this.checkVerbs.Enabled = false;
            this.checkVerbs.Location = new System.Drawing.Point(460, 161);
            this.checkVerbs.Name = "checkVerbs";
            this.checkVerbs.Size = new System.Drawing.Size(53, 17);
            this.checkVerbs.TabIndex = 10;
            this.checkVerbs.Text = "Verbs";
            this.TipVerbs.SetToolTip(this.checkVerbs, "Verbose ON (debug information written to a text file)");
            this.checkVerbs.UseVisualStyleBackColor = true;
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
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 212);
            this.Controls.Add(this.linkPatches);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.linkWiki);
            this.Controls.Add(this.listBoxRom);
            this.Controls.Add(this.listBoxTarget);
            this.Controls.Add(this.checkVerbs);
            this.Controls.Add(this.checkDdinumber);
            this.Controls.Add(this.checkNoCross);
            this.Controls.Add(this.checkNoGuns);
            this.Controls.Add(this.checkNoFire);
            this.Controls.Add(this.checkNoReload);
            this.Controls.Add(this.checkWidescreen);
            this.Controls.Add(this.checkNoResize);
            this.Controls.Add(this.BtnStart);
            this.Name = "Default";
            this.Text = "DemulShooterLauncher";
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.CheckBox checkNoResize;
        private System.Windows.Forms.CheckBox checkWidescreen;
        private System.Windows.Forms.CheckBox checkNoReload;
        private System.Windows.Forms.CheckBox checkNoFire;
        private System.Windows.Forms.CheckBox checkNoGuns;
        private System.Windows.Forms.CheckBox checkNoCross;
        private System.Windows.Forms.CheckBox checkDdinumber;
        private System.Windows.Forms.CheckBox checkVerbs;
        private System.Windows.Forms.ToolTip TipNoResize;
        private System.Windows.Forms.ToolTip TipWidescreen;
        private System.Windows.Forms.ToolTip TipNoReload;
        private System.Windows.Forms.ToolTip TipNoGuns;
        private System.Windows.Forms.ToolTip TipNoFire;
        private System.Windows.Forms.ToolTip TipNoCross;
        private System.Windows.Forms.ToolTip TipddNumber;
        private System.Windows.Forms.ToolTip TipVerbs;
        private System.Windows.Forms.ListBox listBoxTarget;
        private System.Windows.Forms.ListBox listBoxRom;
        private System.Windows.Forms.LinkLabel linkWiki;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkPatches;
    }
}

