using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using System.Diagnostics;

namespace DemulShooterLauncher
{
    public partial class Default : Form
    {
        string pathRoot;
        List<Game> games;
        List<CheckBox> checkBoxes;
        Game curr;

        public Default()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pathRoot = Directory.GetCurrentDirectory();
            bool exit = false;
            string error = string.Empty;
            if (!UoW.checkPaths())
            {
                error += "Insert launcher in DemulShooter Folder\n";
                exit = true;
            }

            if (!UoW.checkAdmin(new WindowsPrincipal(WindowsIdentity.GetCurrent())))
            {
                error += "Start with administrator\n";
                exit = true;
            }

            if (exit)
            {
                MessageBox.Show("Error!\n" + error);
                System.Environment.Exit(-1);
            }

            InitializeComponent();
        }

        private void Default_Load(object sender, EventArgs e)
        {
            LoadList load = new LoadList();
            games = load.Loading();
            foreach (Game g in games)
                CbBListGames.Items.Add(g.Name);

            checkBoxes = new List<CheckBox>();
            foreach (var control in this.Controls)
                if (control is CheckBox)
                {
                    var tmp = (CheckBox)control;
                    checkBoxes.Add(tmp);
                    tmp.Enabled = false;
                }
            lblTarget.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbBListGames.Text == string.Empty)
                disableAllCheckBox();
            else
            {
                curr = UoW.GetGame(games, CbBListGames.Text);

                if (curr != null)
                {
                    lblTarget.Text = UoW.TargetToText(curr.Target);

                    foreach (var control in checkBoxes)
                        if (curr.Recommended != null && curr.Recommended.Contains(UoW.TextToArgument(control.Text)))
                        {
                            control.Enabled = true;
                            control.Checked = true;
                        }
                        else
                        {
                            if (UoW.CanDisableArgument(control.Text))
                                control.Enabled = false;
                            else
                                control.Enabled = true;
                            control.Checked = false;
                        }
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Game curr = UoW.GetGame(games, CbBListGames.Text);
            if (curr != null)
            {
                string arguments = getArguments();
                StartCommand start = new StartCommand();

                if (!start.Run(pathRoot, UoW.GetGame(games, CbBListGames.Text), arguments))
                    MessageBox.Show("Unexpected Error");
            }
            else
                MessageBox.Show("Game not found!");
        }

        private string getArguments()
        {
            string args = string.Empty;

            foreach (var control in checkBoxes)
                if (control.Checked)
                    args += " -" + UoW.TextToArgument(control.Text);

            return args;
        }

        private void disableAllCheckBox()
        {
            foreach (var control in checkBoxes)
                control.Enabled = false;
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(curr != null)
                using (Process.Start(UoW.GetLink(curr.Target))) { }
        }

        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process.Start("https://github.com/argonlefou/DemulShooter/wiki")) { }
        }
    }
}
