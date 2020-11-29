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
            this.SuspendLayout();
            // 
            // CbBListGames
            // 
            this.CbBListGames.FormattingEnabled = true;
            this.CbBListGames.Location = new System.Drawing.Point(47, 22);
            this.CbBListGames.Name = "CbBListGames";
            this.CbBListGames.Size = new System.Drawing.Size(159, 21);
            this.CbBListGames.TabIndex = 0;
            this.CbBListGames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(81, 196);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 250);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.CbBListGames);
            this.Name = "Default";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbBListGames;
        private System.Windows.Forms.Button BtnStart;
    }
}

