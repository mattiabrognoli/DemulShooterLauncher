using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemulShooterLauncher
{
    public partial class Default : Form
    {
        string pathRoot;
        List<Game> games;

        //TODO effettuare test vari

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



            //print default
            // CbBListGames.Text = CbBListGames.Items[0].ToString();
        }

        private void Default_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LoadList load = new LoadList();
            games = load.Loading();
            foreach (Game g in games)
                CbBListGames.Items.Add(g.Name);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game curr = UoW.GetGame(games, CbBListGames.Text);
            CheckBox tmp;

            foreach (var control in this.Controls) // I guess this is your form
                if (control is CheckBox)
                {
                    tmp = (CheckBox)control;
                    if (curr.Recommended != null && curr.Recommended.Contains(tmp.Text))
                        tmp.Checked = true;
                    else
                        tmp.Checked = false;
                }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

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

            foreach (var control in this.Controls) // I guess this is your form
            {
                CheckBox tmp;
                if (control is CheckBox)
                    if (((CheckBox)control).Checked)
                    {
                        tmp = (CheckBox)control;
                        args += " -" + tmp.Text;
                    }
            }
            return args;
        }

        private void checkNoReload_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
