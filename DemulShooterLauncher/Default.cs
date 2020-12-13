using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

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
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
            checkBoxes = new List<CheckBox>();
            //ListTargets = new Dictionary<string, Target>();

            foreach (var control in this.Controls)
                if (control is CheckBox)
                {
                    var tmp = (CheckBox)control;
                    checkBoxes.Add(tmp);
                    tmp.Enabled = false;
                }
            ListMachines = load.LoadingMachines();
            //ListGames = load.LoadingGames();
            //ListTargets = load.Loading();

            listBoxTarget.BeginUpdate();

            foreach (var t in ListMachines)
            {
                listBoxTarget.Items.Add(t.ToString());
            }

            listBoxTarget.EndUpdate();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string arguments = getArguments();
            StartCommand start = new StartCommand();
            if (listBoxRom.SelectedIndex == -1)
                MessageBox.Show("Unexpected Error");
            else
                start.Run(pathRoot, ListMachines.Where(t => t.Name == listBoxTarget.SelectedItem.ToString()).Select(m => m.Games).Single().Find(g => g.Name == listBoxRom.SelectedItem.ToString()), ListMachines.Find(m => m.Name == listBoxTarget.SelectedItem.ToString()).Target, arguments);
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
            {
                control.Checked = false;
                control.Enabled = false;
            }
        }

        private void listBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxRom.BeginUpdate();
            listBoxRom.Items.Clear();
            //foreach (var g in ListTargets[listBoxTarget.SelectedItem.ToString()].ListRom)
            //foreach (var g in ListMachines.Where(t => t.Name == listBoxTarget.SelectedItem.ToString()).Select(m => m.Games).ToList())// == listBoxTarget.SelectedItem.ToString()).ToList())
            //{
                foreach (var q in ListMachines.Where(t => t.Name == listBoxTarget.SelectedItem.ToString()).Select(m => m.Games).Single())
                    listBoxRom.Items.Add(q.ToString());
            //}
            listBoxRom.EndUpdate();

            if (listBoxRom.Items.Count > 0)
                listBoxRom.SelectedIndex = 0;
            else
                disableAllCheckBox();
        }

        private void listBoxRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var control in checkBoxes)
                //if (ListTargets[listBoxTarget.SelectedItem.ToString()].ListRom[listBoxRom.SelectedItem.ToString()].Recommended.Contains(UoW.TextToArgument(control.Text)))
                if (ListMachines.Where(t => t.Name == listBoxTarget.SelectedItem.ToString()).Select(m => m.Games).Single().Find(g => g.Name == listBoxRom.SelectedItem.ToString()).Recommended.Contains(UoW.TextToArgument(control.Text)))
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

        private void linkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process.Start("https://github.com/argonlefou/DemulShooter/wiki")) { }
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if (listBoxTarget.SelectedIndex >= 0)
            using (Process.Start(UoW.GetLink(ListMachines.Find(m => m.Name == listBoxTarget.SelectedItem.ToString()).Target))) { }
        }

        private void linkPatches_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process.Start("http://forum.arcadecontrols.com/index.php/topic,149714.0.html")) { }
        }
    }
}
