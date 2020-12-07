namespace DemulShooterLauncher
{
    partial class Default
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
            this.CbBListGames = new System.Windows.Forms.ComboBox();
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
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkWiki = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CbBListGames
            // 
            this.CbBListGames.DropDownHeight = 150;
            this.CbBListGames.FormattingEnabled = true;
            this.CbBListGames.IntegralHeight = false;
            this.CbBListGames.Location = new System.Drawing.Point(73, 12);
            this.CbBListGames.Name = "CbBListGames";
            this.CbBListGames.Size = new System.Drawing.Size(254, 21);
            this.CbBListGames.TabIndex = 0;
            this.CbBListGames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(152, 211);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(98, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // checkNoResize
            // 
            this.checkNoResize.AccessibleDescription = "";
            this.checkNoResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoResize.AutoSize = true;
            this.checkNoResize.Location = new System.Drawing.Point(29, 80);
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
            this.checkWidescreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkWidescreen.AutoSize = true;
            this.checkWidescreen.Location = new System.Drawing.Point(166, 80);
            this.checkWidescreen.Name = "checkWidescreen";
            this.checkWidescreen.Size = new System.Drawing.Size(83, 17);
            this.checkWidescreen.TabIndex = 4;
            this.checkWidescreen.Text = "Widescreen";
            this.TipWidescreen.SetToolTip(this.checkWidescreen, "Demul widescreen hack, works for some games");
            this.checkWidescreen.UseVisualStyleBackColor = true;
            // 
            // checkNoReload
            // 
            this.checkNoReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoReload.AutoSize = true;
            this.checkNoReload.Location = new System.Drawing.Point(269, 80);
            this.checkNoReload.Name = "checkNoReload";
            this.checkNoReload.Size = new System.Drawing.Size(93, 17);
            this.checkNoReload.TabIndex = 5;
            this.checkNoReload.Text = "No autoreload";
            this.TipNoReload.SetToolTip(this.checkNoReload, "Disable ingame auto-reload when last bullet is fired in hod3pc");
            this.checkNoReload.UseVisualStyleBackColor = true;
            // 
            // checkNoFire
            // 
            this.checkNoFire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoFire.AutoSize = true;
            this.checkNoFire.Location = new System.Drawing.Point(29, 122);
            this.checkNoFire.Name = "checkNoFire";
            this.checkNoFire.Size = new System.Drawing.Size(78, 17);
            this.checkNoFire.TabIndex = 6;
            this.checkNoFire.Text = "No autofire";
            this.TipNoFire.SetToolTip(this.checkNoFire, "Disable ingame auto-fire (Sega Golden Gun only)");
            this.checkNoFire.UseVisualStyleBackColor = true;
            // 
            // checkNoGuns
            // 
            this.checkNoGuns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoGuns.AutoSize = true;
            this.checkNoGuns.Location = new System.Drawing.Point(166, 122);
            this.checkNoGuns.Name = "checkNoGuns";
            this.checkNoGuns.Size = new System.Drawing.Size(66, 17);
            this.checkNoGuns.TabIndex = 7;
            this.checkNoGuns.Text = "No guns";
            this.TipNoGuns.SetToolTip(this.checkNoGuns, "Hide guns display in hod3pc during gameplay (just like real arcade machine)");
            this.checkNoGuns.UseVisualStyleBackColor = true;
            // 
            // checkNoCross
            // 
            this.checkNoCross.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoCross.AutoSize = true;
            this.checkNoCross.Location = new System.Drawing.Point(269, 122);
            this.checkNoCross.Name = "checkNoCross";
            this.checkNoCross.Size = new System.Drawing.Size(86, 17);
            this.checkNoCross.TabIndex = 8;
            this.checkNoCross.Text = "No Crosshair";
            this.TipNoCross.SetToolTip(this.checkNoCross, " Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)");
            this.checkNoCross.UseVisualStyleBackColor = true;
            // 
            // checkDdinumber
            // 
            this.checkDdinumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkDdinumber.AutoSize = true;
            this.checkDdinumber.Enabled = false;
            this.checkDdinumber.Location = new System.Drawing.Point(29, 164);
            this.checkDdinumber.Name = "checkDdinumber";
            this.checkDdinumber.Size = new System.Drawing.Size(83, 17);
            this.checkDdinumber.TabIndex = 9;
            this.checkDdinumber.Text = "DDI number";
            this.TipddNumber.SetToolTip(this.checkDdinumber, "Dolphin\'s DirectInput number for P2 device (optional, default = 2)");
            this.checkDdinumber.UseVisualStyleBackColor = true;
            // 
            // checkVerbs
            // 
            this.checkVerbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVerbs.AutoSize = true;
            this.checkVerbs.Enabled = false;
            this.checkVerbs.Location = new System.Drawing.Point(166, 164);
            this.checkVerbs.Name = "checkVerbs";
            this.checkVerbs.Size = new System.Drawing.Size(53, 17);
            this.checkVerbs.TabIndex = 10;
            this.checkVerbs.Text = "Verbs";
            this.TipVerbs.SetToolTip(this.checkVerbs, "Verbose ON (debug information written to a text file)");
            this.checkVerbs.UseVisualStyleBackColor = true;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(73, 40);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(48, 13);
            this.lblTarget.TabIndex = 11;
            this.lblTarget.Text = "lblTarget";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(30, 39);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(41, 13);
            this.lblText1.TabIndex = 12;
            this.lblText1.Text = "Target:";
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Location = new System.Drawing.Point(253, 40);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(29, 13);
            this.linkHelp.TabIndex = 13;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // linkWiki
            // 
            this.linkWiki.AutoSize = true;
            this.linkWiki.Location = new System.Drawing.Point(30, 15);
            this.linkWiki.Name = "linkWiki";
            this.linkWiki.Size = new System.Drawing.Size(28, 13);
            this.linkWiki.TabIndex = 14;
            this.linkWiki.TabStop = true;
            this.linkWiki.Text = "Wiki";
            this.linkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWiki_LinkClicked);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 253);
            this.Controls.Add(this.linkWiki);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.checkVerbs);
            this.Controls.Add(this.checkDdinumber);
            this.Controls.Add(this.checkNoCross);
            this.Controls.Add(this.checkNoGuns);
            this.Controls.Add(this.checkNoFire);
            this.Controls.Add(this.checkNoReload);
            this.Controls.Add(this.checkWidescreen);
            this.Controls.Add(this.checkNoResize);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.CbBListGames);
            this.Name = "Default";
            this.Text = "DemulShooterLauncher";
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBListGames;
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
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkWiki;
    }
}

