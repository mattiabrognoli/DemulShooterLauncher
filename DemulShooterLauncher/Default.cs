using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace DemulShooterLauncher
{
    public partial class Default : Form
    {
        string pathRoot;
        List<CheckBox> checkBoxes;
        List<Machine> ListMachines;

        public Default()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            pathRoot = Directory.GetCurrentDirectory();
            bool exit = false;
            string error = string.Empty;
            if (!Utility.checkPaths())
            {
                error += "Insert launcher in DemulShooter Folder\n";
                exit = true;
            }

            if (!Utility.checkAdmin(new WindowsPrincipal(WindowsIdentity.GetCurrent())))
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
            checkBoxes = new List<CheckBox>();

            foreach (var control in this.Controls)
                if (control is CheckBox)
                {
                    var tmp = (CheckBox)control;
                    checkBoxes.Add(tmp);
                    tmp.Enabled = false;
                }
            ListMachines = load.LoadingMachines();

            listBoxTarget.BeginUpdate();

            foreach (var t in ListMachines)
                listBoxTarget.Items.Add(t.ToString());

            listBoxTarget.EndUpdate();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string arguments = getArguments();
            StartCommand start = new StartCommand();
            if (listBoxRom.SelectedIndex == -1)
                MessageBox.Show("Unexpected Error");
            else
                start.Run(pathRoot, Utility.QueryGame(ListMachines, listBoxTarget.SelectedItem.ToString()).Find(g => g.Name == listBoxRom.SelectedItem.ToString()), ListMachines.Find(m => m.Name == listBoxTarget.SelectedItem.ToString()).Target, arguments);
        }

        private string getArguments()
        {
            string args = string.Empty;

            foreach (var control in checkBoxes)
                if (control.Checked)
                    args += " -" + Utility.TextToArgument(control.Text);

            return args;
        }

        private void disableAllCheckBox()
        {
            foreach (var control in checkBoxes)
            {
                control.Checked = false;
                control.Enabled = false;
            }
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRom.BeginUpdate();
            listBoxRom.Items.Clear();
            foreach (var q in Utility.QueryGame(ListMachines, listBoxTarget.SelectedItem.ToString()))
                listBoxRom.Items.Add(q.ToString());

            listBoxRom.EndUpdate();

            if (listBoxRom.Items.Count > 0)
                listBoxRom.SelectedIndex = 0;
            else
                disableAllCheckBox();
        }

        private void listBoxRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTarget.SelectedItem.ToString() == "Dolphin x64 v5.0")
                disableAllCheckBox();
            else
            {
                foreach (var control in checkBoxes)
                    if (Utility.QueryGame(ListMachines, listBoxTarget.SelectedItem.ToString()).Find(g => g.Name == listBoxRom.SelectedItem.ToString()).Recommended.Contains(Utility.TextToArgument(control.Text)))
                    {
                        control.Enabled = true;
                        control.Checked = true;
                    }
                    else
                    {
                        if (Utility.CanDisableArgument(control.Text))
                            control.Enabled = false;
                        else
                            control.Enabled = true;
                        control.Checked = false;
                    }
            }
        }

        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process.Start("https://github.com/argonlefou/DemulShooter/wiki")) { }
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listBoxTarget.SelectedIndex >= 0)
                using (Process.Start(Utility.GetLink(ListMachines.Find(m => m.Name == listBoxTarget.SelectedItem.ToString()).Target))) { }
        }

        private void linkPatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process.Start("http://forum.arcadecontrols.com/index.php/topic,149714.0.html")) { }
        }
    }
}
