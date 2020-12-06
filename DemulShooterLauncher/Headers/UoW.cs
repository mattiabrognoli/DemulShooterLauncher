using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Principal;

namespace DemulShooterLauncher.Headers
{
    public static class UoW
    {
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

        static public Game GetGame(List<Game> games, string name)
        {
            foreach (var curr in games)
                if (curr.Name == name)
                    return curr;
            return null;
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

        static public string TargetToText(string text)
        {
            if (text == "chihiro")
                return "Cxbx-Reloaded";
            if (text == "demul07a")
                return "Demul 0.7a 180428";
            if (text == "dolphin5")
                return "Dolphin x64 v5.0";
            if (text == "globalvr")
                return "Global VR Games";
            if (text == "lindbergh")
                return "TeknoParrot Loader";
            if (text == "model2")
                return "Model2 Emulator v1.1a";
            if (text == "ringwide")
                return "TeknoParrot Loader";
            if (text == "ttx")
                return "Taito Type X Games";
            if (text == "windows")
                return "Windows Games";
            return string.Empty;
        }

        static public bool CanDisableArgument (string text)
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
