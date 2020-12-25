using DemulShooterLauncher.Controller;
using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace DemulShooterLauncher
{
    public partial class Launcher : Form
    {
        string pathRoot;
        List<CheckBox> checkBoxes;
        LauncherController launcherController;
        public Launcher()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
                Environment.Exit(-1);
            }
            InitializeComponent();
        }
        private void Default_Load(object sender, EventArgs e)
        {
            pathRoot = Directory.GetCurrentDirectory();
            launcherController = new LauncherController();
            launcherController.LoadModel();
            checkBoxes = LoadCheckBox();
            listBoxTarget.BeginUpdate();
            launcherController.GetListMachines().ToList().ForEach(m => listBoxTarget.Items.Add(m.ToString()));
            listBoxTarget.EndUpdate();
        }
        private List<CheckBox> LoadCheckBox()
        {
            List<CheckBox> list = new List<CheckBox>();
            list.Add(checkWidescreen);
            list.Add(checkNoFire);
            list.Add(checkNoResize);
            list.Add(checkNoGuns);
            list.Add(checkNoReload);
            list.Add(checkNoCross);
            list.Add(checkDdinumber);
            list.Add(checkVerbs);
            return list;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (listBoxRom.SelectedIndex == -1)
                MessageBox.Show("Unexpected Error");
            else
                launcherController.StartCommand(listBoxTarget.SelectedItem.ToString(), listBoxRom.SelectedItem.ToString(), getArguments(), pathRoot);
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
            checkBoxes
                .ForEach(control => { control.Checked = false; control.Enabled = false; });
        }
        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRom.BeginUpdate();
            listBoxRom.Items.Clear();
            string d = listBoxTarget.SelectedIndex.ToString();
            launcherController.GetListGamesFromMachineName(listBoxTarget.SelectedItem.ToString()).ToList().ForEach(g => listBoxRom.Items.Add(g.ToString()));
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
                checkBoxes
                    .ForEach(control =>
                    {
                        if (launcherController.CheckControl(listBoxTarget.SelectedItem.ToString(), listBoxRom.SelectedItem.ToString(), control.Text))
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
                    });
            }
        }
        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launcherController.StartLink("https://github.com/argonlefou/DemulShooter/wiki");
        }
        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launcherController.StartLink(Utility.GetLink(launcherController.GetTargetInListMachines(listBoxTarget.SelectedItem.ToString())));
        }
        private void linkPatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launcherController.StartLink("http://forum.arcadecontrols.com/index.php/topic,149714.0.html");
        }
    }
}
