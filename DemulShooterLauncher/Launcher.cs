using DemulShooterLauncher.Controller;
using DemulShooterLauncher.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
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
            listBoxTarget.DataSource = launcherController.GetListTargets().Select(t => new DisplayMember { Id = t.Id, Description = t.Description }).ToList();
            listBoxRom.DisplayMember = listBoxTarget.DisplayMember = "Description";
            listBoxRom.ValueMember = listBoxTarget.ValueMember = "Id";
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
            launcherController.StartCommand((listBoxRom.SelectedItem as DisplayMember).Id, (listBoxTarget.SelectedItem as DisplayMember).Id, getArguments(), pathRoot);
        }

        private string getArguments()
        {
            string args = string.Empty;
            checkBoxes.Where(c => c.Checked).ToList().ForEach(cn => args += " -" + Utility.TextToArgument(cn.Text));
            return args;
        }

        private void disableAllCheckBox()
        {
            checkBoxes
                .ForEach(control => { control.Checked = false; control.Enabled = false; });
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRom.DataSource = launcherController.GetRomsWithIdTarget((listBoxTarget.SelectedItem as DisplayMember).Id).Select(t => new DisplayMember { Id = t.Id, Description = t.Description }).ToList();
        }

        private void listBoxRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBoxTarget.SelectedItem as DisplayMember).Id == (int)Utility.IdMachines.dolphin5)
                disableAllCheckBox();
            else
            {
                checkBoxes
                    .ForEach(control =>
                    {
                        if (launcherController.CheckControl((listBoxRom.SelectedItem as DisplayMember).Id, control.Text))
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
            launcherController.StartLink(Utility.GetLink((listBoxTarget.SelectedItem as DisplayMember).Id));
        }

        private void linkPatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launcherController.StartLink("http://forum.arcadecontrols.com/index.php/topic,149714.0.html");
        }
    }
}
