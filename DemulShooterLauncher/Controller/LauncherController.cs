using DemulShooterLauncher.Headers;
using System.Linq;
using DemulShooterLauncher.Model;

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
            LauncherControllerHelper.Run(path, (LauncherControllerHelper.FindGamesbyName(machineSummary.Machines, machineName)).Where(g => g.Name == gameName).SingleOrDefault(), LauncherControllerHelper.FindTargetbyName(machineSummary.Machines, machineName), arguments);
        }

        public Game[] GetListGamesFromMachineName(string machineName)
        {
            return LauncherControllerHelper.FindGamesbyName(machineSummary.Machines, machineName);
        }
    }


}
