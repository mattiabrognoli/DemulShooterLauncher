using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Principal;

namespace DemulShooterLauncher.Headers
{
    class StartCommand
    {
        public StartCommand()
        {
        }

        public bool Run(string rootPath, Game current, string arguments)
        {

            if (current == null)
                return false;

            System.Diagnostics.ProcessStartInfo myProcessInfo = new System.Diagnostics.ProcessStartInfo();
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
            //myProcessInfo.Arguments = "-target=" + Machine + " -rom = " + Name + " -noresize";
            myProcessInfo.Verb = "runas";
            myProcessInfo.RedirectStandardInput = true;
            myProcessInfo.UseShellExecute = false;

            Process p = Process.Start(myProcessInfo);
            StreamWriter sw = p.StandardInput;
            string inputText = rootPath + "\\" + current.Starter + " -target=" + current.Target + " -rom=" + current.Rom + arguments;
            sw.WriteLine(inputText);
            sw.Close();

            p.WaitForExit();

            return true;

        }

    }
}
