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
            bool result = true;
            if (!File.Exists(".\\DemulShooter.exe"))
                result = false;
            if (!File.Exists(".\\DemulShooterX64.exe"))
                result = false;
            return result;
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

        //NON SERVE PIU
        static public string GetCode(string name)
        {
            if (name == "Confidential Mission")
                return "confmiss";
            if (name == "House of the Dead 2")
                return "hotd2";
            if (name == "Lupin the Third")
                return "lupinsho";
            if (name == "The Maze of the kings")
                return "mok";
            if (name == "Ninja Assault")
                return "Ninja Assault";

            return string.Empty;
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
