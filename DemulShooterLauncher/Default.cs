using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemulShooterLauncher
{
    public partial class Default : Form
    {
        public Default()
        {
            if (!Headers.UoW.checkPaths())
            {
                MessageBox.Show("Error. Insert in DemulShooterFolder");
                Environment.Exit(-1);
            }

            InitializeComponent();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string nameGame = ComboBDemulList.Text;
            StartCommand start = new StartCommand(nameGame, "Demul");
            //  TODO
            //  Da inserire a caricamento pagina iniziale
            if (!start.IsRunAsAdmin())
            {
                MessageBox.Show("Error!Run to administrator");
                Environment.Exit(-2);
            }
            start.Run();

        }
    }
}
