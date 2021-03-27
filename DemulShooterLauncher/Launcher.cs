using DemulShooterLauncher.Controller;
using DemulShooterLauncher.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            bool exit = false;
            string error = string.Empty;
            if (!launcherController.CheckPaths())
            {
                error += "Insert launcher in DemulShooter Folder\n";
                exit = true;
            }

            if (!launcherController.CheckAdmin())
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
            PanelArguments.Controls.OfType<CheckBox>().Where(c => c.Checked).Select(c => c.Tag).ToList().ForEach(t => args += " -" + t);
            return args;
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnScript.Enabled = (listBoxTarget.SelectedItem as DisplayMember).Id == launcherController.Dolphin ? false : true;
            listBoxRom.DataSource = launcherController.GetRomsWithIdTarget((listBoxTarget.SelectedItem as DisplayMember).Id).Select(t => new DisplayMember { Id = t.Id, Description = t.ToString() }).ToList();
        }

        private void listBoxRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelArguments.Controls.Clear();
            int i = 0;
            Rom currentRom = launcherController.GetRom((listBoxRom.SelectedItem as DisplayMember).Id);


                currentRom.Arguments.GetArguments().ToList().ForEach(a =>
                {
                    CheckBox box = new CheckBox();
                    box.Tag = a.Value;
                    box.Text = a.DisplayText;
                    box.Checked = a.Check;
                    box.Visible = a.Visible;
                    box.Location = new Point(0, i);
                    if(!string.IsNullOrEmpty(a.Description))
                        new ToolTip().SetToolTip(box, a.Description);
                    i += 19;
                    PanelArguments.Controls.Add(box);
                });
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
