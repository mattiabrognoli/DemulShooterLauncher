using DemulShooterLauncher.Headers;
using System.Linq;
using DemulShooterLauncher.Model;
using System.Diagnostics;

namespace DemulShooterLauncher.Controller
{
    class LauncherController
    {
        MachineSummary _machineSummary;
        public LauncherController()
        {
            _machineSummary = new MachineSummary();
        }

        public void LoadModel()
        {
            _machineSummary.Machines = LauncherControllerHelper.LoadingMachines().ToArray();
        }

        public Machine[] GetListMachines()
        {
            return _machineSummary.Machines;
        }

        public void StartCommand(string machineName, string gameName, string arguments, string path = ".\\")
        {
            LauncherControllerHelper.Run(path, LauncherControllerHelper.FindGameInGamesbyName(LauncherControllerHelper.FindGamesbyName(_machineSummary.Machines, machineName), gameName), LauncherControllerHelper.FindTargetbyName(_machineSummary.Machines, machineName), arguments);
        }

        public Game[] GetListGamesFromMachineName(string machineName)
        {
            return LauncherControllerHelper.FindGamesbyName(_machineSummary.Machines, machineName);
        }

        public Game GetGameFromGameName(string machineName, string gameName)
        {
            return LauncherControllerHelper.FindGameInGamesbyName(LauncherControllerHelper.FindGamesbyName(_machineSummary.Machines, machineName), gameName);
        }

        public string GetTargetInListMachines(string machineName)
        {
            return LauncherControllerHelper.FindTargetbyName(_machineSummary.Machines, machineName);
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
