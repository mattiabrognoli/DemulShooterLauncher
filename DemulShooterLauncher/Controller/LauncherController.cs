using DemulShooterLauncher.Objects;
using System.Linq;
using DemulShooterLauncher.Model;
using System.Diagnostics;

namespace DemulShooterLauncher.Controller
{
    class LauncherController
    {
        LauncherModel _model;
        public LauncherController()
        {
            _model = new LauncherModel();
        }

        public void LoadModel()
        {
            _model.Targets = LauncherControllerHelper.LoadingTargets().ToArray();
            _model.Roms = LauncherControllerHelper.LoadingRoms().ToArray();
        }

        public Target[] GetListTargets()
        {
            return _model.Targets;
        }

        public void StartCommand(int idRom, int idTarget, string arguments, string path = ".\\")
        {
            LauncherControllerHelper.Run(path, LauncherControllerHelper.GetRomById(_model.Roms, idRom), LauncherControllerHelper.GetTargetById(_model.Targets, idTarget).Command , arguments);
        }

        public Rom[] GetRomsWithIdTarget(int id)
        {
            return LauncherControllerHelper.GetRomByIdTarget(_model.Roms, id);
        }

        public bool CheckControl(int romID, string controlText)
        {
            return LauncherControllerHelper.GetRomById(_model.Roms, romID).Recommended.Contains(Utility.TextToArgument(controlText))? true : false;
        }

        public void StartLink(string link)
        {
            using (Process.Start(link)) { }
        }
    }
}
