using DemulShooterLauncher.Controller;
using DemulShooterLauncher.Objects;
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
        List<CheckBox> _checkBoxes;
        LauncherController launcherController = new LauncherController();

        public List<CheckBox> CheckBoxes
        {
            get
            {
                if (_checkBoxes == null)
                    _checkBoxes = Controls.OfType<CheckBox>().ToList();
                return _checkBoxes;
            }
        }

        public Launcher()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            bool exit;
            string error = string.Empty;
            if (exit = !launcherController.CheckPaths())
                error += "Insert launcher in DemulShooter Folder\n";

            if (exit = !launcherController.CheckAdmin())
                error += "Start with administrator\n";

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
            launcherController.LoadModel();
            listBoxTarget.DataSource = launcherController.GetListTargets().Select(t => new DisplayMember { Id = t.Id, Description = t.ToString() }).ToList();
            listBoxRom.DisplayMember = listBoxTarget.DisplayMember = "Description";
            listBoxRom.ValueMember = listBoxTarget.ValueMember = "Id";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            launcherController.StartCommand((listBoxRom.SelectedItem as DisplayMember).Id, (listBoxTarget.SelectedItem as DisplayMember).Id, getArguments(), pathRoot);
        }

        private string getArguments()
        {
            string args = string.Empty;
            CheckBoxes.Where(c => c.Checked).ToList().ForEach(cn => args += " -" + launcherController.FromTextToArgument(cn.Text));
            return args;
        }

        private void disableAllCheckBox()
        {
            CheckBoxes
                .ForEach(control => { control.Checked = false; control.Enabled = false; });
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnScript.Enabled = (listBoxTarget.SelectedItem as DisplayMember).Id == launcherController.Dolphin ? false : true;
            listBoxRom.DataSource = launcherController.GetRomsWithIdTarget((listBoxTarget.SelectedItem as DisplayMember).Id).Select(t => new DisplayMember { Id = t.Id, Description = t.ToString() }).ToList();
        }

        private void listBoxRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBoxTarget.SelectedItem as DisplayMember).Id == launcherController.Dolphin || (listBoxTarget.SelectedItem as DisplayMember).Id == launcherController.GetIdEs3())
                disableAllCheckBox();
            else
            {
                CheckBoxes
                    .ForEach(control =>
                    {
                        if (launcherController.CheckControl((listBoxRom.SelectedItem as DisplayMember).Id, control.Text))
                            control.Enabled = control.Checked = true;
                        else
                        {
                            control.Enabled = launcherController.CanDisableArgument(control.Text) ? false : true;
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
            if((listBoxTarget.SelectedItem as DisplayMember).Id != launcherController.Es3)
            launcherController.StartLink(launcherController.GetLink((listBoxTarget.SelectedItem as DisplayMember).Id));
        }

        private void linkPatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            launcherController.StartLink("http://forum.arcadecontrols.com/index.php/topic,149714.0.html");
        }

        private void linkHelp_LinkClicked(object sender, EventArgs e)
        {
            launcherController.StartLink(launcherController.GetLink((listBoxTarget.SelectedItem as DisplayMember).Id));
        }

        private void BtnScript_Click(object sender, EventArgs e)
        {
            launcherController.StartCreateScript((listBoxRom.SelectedItem as DisplayMember).Id, (listBoxTarget.SelectedItem as DisplayMember).Id, getArguments(), pathRoot);
            MessageBox.Show(launcherController.TextMessageBox(pathRoot, (listBoxRom.SelectedItem as DisplayMember).Id));
        }
    }
}
