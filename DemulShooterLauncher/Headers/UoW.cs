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

            return null;
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

        //NON SERVE PIU'
        static public string GetMachine(string machine)
        {
            if (machine == "Demul")
                return "demul07a";

            return string.Empty;
        }


    }
}
