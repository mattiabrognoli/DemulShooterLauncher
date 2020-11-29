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
        public string Name { get; }
        public string Machine { get; }
        public StartCommand(string name, string machine)
        {
            Name = UoW.GetCode(name);
            Machine = UoW.GetMachine(machine);
        }

        public void Run()
        {

            string rootPath = Directory.GetCurrentDirectory();
            System.Diagnostics.ProcessStartInfo myProcessInfo = new System.Diagnostics.ProcessStartInfo();
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
            //myProcessInfo.Arguments = "-target=" + Machine + " -rom = " + Name + " -noresize";
            myProcessInfo.Verb = "runas";
            myProcessInfo.RedirectStandardInput = true;
            myProcessInfo.UseShellExecute = false;

            Process p = Process.Start(myProcessInfo);
            StreamWriter sw = p.StandardInput;
            string inputText = rootPath + "\\DemulShooter.exe -target=" + Machine + " -rom=" + Name + " -noresize";
            sw.WriteLine(inputText);
            sw.Close();

            p.WaitForExit();

        }

    }
}
