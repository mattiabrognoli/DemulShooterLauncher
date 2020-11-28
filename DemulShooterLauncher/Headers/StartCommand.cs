using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Set options for process and then start that
            /*System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c DemulShooter.exe target = " + Machine + " - rom = " + Name + " - noresize";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();*/
            System.Diagnostics.Process.Start("DemulShooter.exe", "/c target = " + Machine + " - rom = " + Name + " - noresize");
            //process.WaitForExit();
        }
    }
}
