using DemulShooterLauncher.Headers;
using System.Linq;
using DemulShooterLauncher.Model;
using System.Diagnostics;

namespace DemulShooterLauncher.Controller
{
    class LauncherController
    {
        MachineSummary machineSummary;
        public LauncherController()
        {
            machineSummary = new MachineSummary();
        }

        public void LoadModel()
        {
            machineSummary.Machines = LauncherControllerHelper.LoadingMachines().ToArray();
        }

        public Machine[] GetListMachines()
        {
            return machineSummary.Machines;
        }

        public void StartCommand(string machineName, string gameName, string arguments, string path = ".\\")
        {
            LauncherControllerHelper.Run(path, LauncherControllerHelper.FindGameInGamesbyName(LauncherControllerHelper.FindGamesbyName(machineSummary.Machines, machineName), gameName), LauncherControllerHelper.FindTargetbyName(machineSummary.Machines, machineName), arguments);
        }

        public Game[] GetListGamesFromMachineName(string machineName)
        {
            return LauncherControllerHelper.FindGamesbyName(machineSummary.Machines, machineName);
        }

        public Game GetGameFromGameName(string machineName, string gameName)
        {
            return LauncherControllerHelper.FindGameInGamesbyName(LauncherControllerHelper.FindGamesbyName(machineSummary.Machines, machineName), gameName);
        }

        public string GetTargetInListMachines(string machineName)
        {
            return LauncherControllerHelper.FindTargetbyName(machineSummary.Machines, machineName);
        }

        public bool CheckControl(string machineName, string gameName, string controlText)
        {
            return GetGameFromGameName(machineName, gameName).Recommended.Contains(Utility.TextToArgument(controlText))? true : false;
        }

        public void StartLink(string link)
        {
            using (Process.Start(link)) { }
        }
    }


}
