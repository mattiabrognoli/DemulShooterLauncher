using DemulShooterLauncher.Objects;
using DemulShooterLauncher.Model;
using System.Diagnostics;
using System.Security.Principal;
using System.Linq;
using static DemulShooterLauncher.Controller.LauncherControllerHelper;

namespace DemulShooterLauncher.Controller
{
    class LauncherController
    {
        public int Dolphin { get => (int)IdMachines.dolphin5; }
        public int Es3 { get => (int)IdMachines.es3; }

        LauncherModel _model;

        public LauncherController()
        {
            _model = new LauncherModel();
        }

        public void LoadModel()
        {
            _model.Targets = LoadingTargets().ToArray();
            _model.Roms = LoadingRoms().ToArray();
        }

        public Target[] GetListTargets()
        {
            return _model.Targets;
        }

        public string GetLink(int idTarget)
        {
            return _model.Targets.AsQueryable().Where(t => t.Id == idTarget).SingleOrDefault().Link;
        }

        public bool CanDisableArgument(string text)
        {
            return canDisableArgument(text);
        }

        public void StartCommand(int idRom, int idTarget, string arguments, string path = ".\\")
        {
            Run(path, GetRomById(_model.Roms, idRom), GetTargetById(_model.Targets, idTarget).Command , arguments);
        }

        public void StartCreateScript(int idRom, int idTarget, string arguments, string path = ".\\")
        {
            CreateScript(path, GetRomById(_model.Roms, idRom), GetTargetById(_model.Targets, idTarget).Command, arguments);
        }

        public Rom[] GetRomsWithIdTarget(int id)
        {
            return GetRomByIdTarget(_model.Roms, id);
        }

        public bool CheckControl(int romID, string controlText)
        {
            return GetRomById(_model.Roms, romID).Recommended.Contains(TextToArgument(controlText))? true : false;
        }

        public void StartLink(string link)
        {
            using (Process.Start(link)) { }
        }

        public bool CheckPaths()
        {
            return checkPaths();
        }

        public string FromTextToArgument(string text)
        {
            return TextToArgument(text);
        }

        public bool CheckAdmin()
        {
            return checkAdmin(new WindowsPrincipal(WindowsIdentity.GetCurrent()));
        }

        public int GetIdDolphin()
        {
            return (int)IdMachines.dolphin5;
        }

        public int GetIdEs3()
        {
            return (int)IdMachines.es3;
        }

        public string TextMessageBox(string path, int idRom)
        {
            return "Script Created in" + "\n" + path + "\\" + GetRomById(_model.Roms, idRom).Command + ".bat";
        }
    }
}
