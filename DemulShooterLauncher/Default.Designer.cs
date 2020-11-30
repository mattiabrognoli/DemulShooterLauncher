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
            this.LblOptions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbBListGames
            // 
            this.CbBListGames.FormattingEnabled = true;
            this.CbBListGames.Location = new System.Drawing.Point(102, 12);
            this.CbBListGames.Name = "CbBListGames";
            this.CbBListGames.Size = new System.Drawing.Size(194, 21);
            this.CbBListGames.TabIndex = 0;
            this.CbBListGames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(170, 408);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // checkNoResize
            // 
            this.checkNoResize.AutoSize = true;
            this.checkNoResize.Location = new System.Drawing.Point(33, 281);
            this.checkNoResize.Name = "checkNoResize";
            this.checkNoResize.Size = new System.Drawing.Size(65, 17);
            this.checkNoResize.TabIndex = 3;
            this.checkNoResize.Text = "noresize";
            this.checkNoResize.UseVisualStyleBackColor = true;
            // 
            // checkWidescreen
            // 
            this.checkWidescreen.AutoSize = true;
            this.checkWidescreen.Location = new System.Drawing.Point(170, 281);
            this.checkWidescreen.Name = "checkWidescreen";
            this.checkWidescreen.Size = new System.Drawing.Size(80, 17);
            this.checkWidescreen.TabIndex = 4;
            this.checkWidescreen.Text = "widescreen";
            this.checkWidescreen.UseVisualStyleBackColor = true;
            // 
            // checkNoReload
            // 
            this.checkNoReload.AutoSize = true;
            this.checkNoReload.Location = new System.Drawing.Point(298, 281);
            this.checkNoReload.Name = "checkNoReload";
            this.checkNoReload.Size = new System.Drawing.Size(88, 17);
            this.checkNoReload.TabIndex = 5;
            this.checkNoReload.Text = "noautoreload";
            this.checkNoReload.UseVisualStyleBackColor = true;
            this.checkNoReload.CheckedChanged += new System.EventHandler(this.checkNoReload_CheckedChanged);
            // 
            // checkNoFire
            // 
            this.checkNoFire.AutoSize = true;
            this.checkNoFire.Location = new System.Drawing.Point(33, 323);
            this.checkNoFire.Name = "checkNoFire";
            this.checkNoFire.Size = new System.Drawing.Size(76, 17);
            this.checkNoFire.TabIndex = 6;
            this.checkNoFire.Text = "noautofire ";
            this.checkNoFire.UseVisualStyleBackColor = true;
            // 
            // checkNoGuns
            // 
            this.checkNoGuns.AutoSize = true;
            this.checkNoGuns.Location = new System.Drawing.Point(170, 323);
            this.checkNoGuns.Name = "checkNoGuns";
            this.checkNoGuns.Size = new System.Drawing.Size(61, 17);
            this.checkNoGuns.TabIndex = 7;
            this.checkNoGuns.Text = "noguns";
            this.checkNoGuns.UseVisualStyleBackColor = true;
            // 
            // checkNoCross
            // 
            this.checkNoCross.AutoSize = true;
            this.checkNoCross.Location = new System.Drawing.Point(298, 323);
            this.checkNoCross.Name = "checkNoCross";
            this.checkNoCross.Size = new System.Drawing.Size(80, 17);
            this.checkNoCross.TabIndex = 8;
            this.checkNoCross.Text = "nocrosshair";
            this.checkNoCross.UseVisualStyleBackColor = true;
            // 
            // checkDdinumber
            // 
            this.checkDdinumber.AutoSize = true;
            this.checkDdinumber.Location = new System.Drawing.Point(33, 364);
            this.checkDdinumber.Name = "checkDdinumber";
            this.checkDdinumber.Size = new System.Drawing.Size(75, 17);
            this.checkDdinumber.TabIndex = 9;
            this.checkDdinumber.Text = "ddinumber";
            this.checkDdinumber.UseVisualStyleBackColor = true;
            // 
            // checkVerbs
            // 
            this.checkVerbs.AutoSize = true;
            this.checkVerbs.Location = new System.Drawing.Point(170, 364);
            this.checkVerbs.Name = "checkVerbs";
            this.checkVerbs.Size = new System.Drawing.Size(32, 17);
            this.checkVerbs.TabIndex = 10;
            this.checkVerbs.Text = "v";
            this.checkVerbs.UseVisualStyleBackColor = true;
            this.checkVerbs.Visible = false;
            // 
            // LblOptions
            // 
            this.LblOptions.AutoSize = true;
            this.LblOptions.Location = new System.Drawing.Point(170, 220);
            this.LblOptions.Name = "LblOptions";
            this.LblOptions.Size = new System.Drawing.Size(46, 13);
            this.LblOptions.TabIndex = 11;
            this.LblOptions.Text = "Options:";
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 455);
            this.Controls.Add(this.LblOptions);
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
        private System.Windows.Forms.Label LblOptions;
    }
}

