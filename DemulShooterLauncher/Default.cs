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
        public Default()
        {
            pathRoot = Directory.GetCurrentDirectory();
            if (!Headers.UoW.checkPaths())
            {
                MessageBox.Show("Error. Insert in DemulShooterFolder");
                System.Environment.Exit(-1);               
            }

            if (!Headers.UoW.checkAdmin(new WindowsPrincipal(WindowsIdentity.GetCurrent())))
            {
                MessageBox.Show("Error. Start with administrator");
                System.Environment.Exit(-2);
            }

            InitializeComponent();

            LoadList load = new LoadList(pathRoot + "\\list.xml");
            List<Game> games = load.Loading();
            foreach (Game g in games)
                CbBListGames.Items.Add(g.Name);
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string nameGame = CbBListGames.Text;
            StartCommand start = new StartCommand(nameGame, "Demul");

            start.Run();

        }
    }
}
