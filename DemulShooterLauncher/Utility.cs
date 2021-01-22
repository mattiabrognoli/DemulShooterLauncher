using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace DemulShooterLauncher
{
    public static class Utility
    {
        public enum IdMachines : int
        {
            demul07a,
            chihiro,
            globalvr,
            lindbergh,
            windows,
            model2,
            ringwide,
            ttx,
            seganu,
            dolphin5
        }

        static public bool checkPaths()
        {
            if (!File.Exists(".\\DemulShooter.exe") || !File.Exists(".\\DemulShooterX64.exe") || !File.Exists("DsCore.dll"))
                return false;
            return true;
        }

        static public bool checkAdmin(WindowsPrincipal principal)
        {
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static public string GetLink(int id)
        {
            if (id == (int)IdMachines.demul07a)
                return "https://github.com/argonlefou/DemulShooter/wiki/Chihiro";
            if (id == (int)IdMachines.chihiro)
                return "https://github.com/argonlefou/DemulShooter/wiki/Demul";
            if (id == (int)IdMachines.globalvr)
                return "https://github.com/argonlefou/DemulShooter/wiki/Dolphin";
            if (id == (int)IdMachines.lindbergh)
                return "https://github.com/argonlefou/DemulShooter/wiki/Global-VR";
            if (id == (int)IdMachines.windows)
                return "https://github.com/argonlefou/DemulShooter/wiki/Lindbergh";
            if (id == (int)IdMachines.model2)
                return "https://github.com/argonlefou/DemulShooter/wiki/Model2";
            if (id == (int)IdMachines.ttx)
                return "https://github.com/argonlefou/DemulShooter/wiki/RingWide";
            if (id == (int)IdMachines.seganu)
                return "https://github.com/argonlefou/DemulShooter/wiki/Taito-Type-X";
            if (id == (int)IdMachines.dolphin5)
                return "https://github.com/argonlefou/DemulShooter/wiki/Windows-games";
            return string.Empty;
        }

        static public string TextToArgument(string text)
        {
            if (text == "No resize")
                return "noresize";
            if (text == "Widescreen")
                return "widescreen";
            if (text == "No autoreload")
                return "noautoreload";
            if (text == "No autofire")
                return "noautofire";
            if (text == "No guns")
                return "noguns";
            if (text == "No Crosshair")
                return "nocrosshair";
            if (text == "DDI number")
                return "ddinumber";
            if (text == "Verbs")
                return "v";

            return string.Empty;
        }

        static public bool CanDisableArgument(string text)
        {
            if (text == "No resize")
                return true;
            if (text == "No autoreload")
                return true;
            if (text == "No autofire")
                return true;
            if (text == "No guns")
                return true;
            if (text == "No Crosshair")
                return true;
            if (text == "DDI number")
                return true;

            return false;
        }
    }
}
