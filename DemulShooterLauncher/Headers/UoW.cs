using System.Collections.Generic;
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

        static public string GetLink(string text)
        {
            if (text == "chihiro")
                return "https://github.com/argonlefou/DemulShooter/wiki/Chihiro";
            if (text == "demul07a")
                return "https://github.com/argonlefou/DemulShooter/wiki/Demul";
            if (text == "dolphin5")
                return "https://github.com/argonlefou/DemulShooter/wiki/Dolphin";
            if (text == "globalvr")
                return "https://github.com/argonlefou/DemulShooter/wiki/Global-VR";
            if (text == "lindbergh")
                return "https://github.com/argonlefou/DemulShooter/wiki/Lindbergh";
            if (text == "model2")
                return "https://github.com/argonlefou/DemulShooter/wiki/Model2";
            if (text == "ringwide")
                return "https://github.com/argonlefou/DemulShooter/wiki/RingWide";
            if (text == "ttx")
                return "https://github.com/argonlefou/DemulShooter/wiki/Taito-Type-X";
            if (text == "windows")
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

        //TODO aggiungere metodo per restituire query
    }
}
