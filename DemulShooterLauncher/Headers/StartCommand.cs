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

            string rootPath = ".\\";
            // Set options for process and then start that
            /*System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c DemulShooter.exe target = " + Machine + " - rom = " + Name + " - noresize";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            
            System.Diagnostics.ProcessStartInfo myProcessInfo = new System.Diagnostics.ProcessStartInfo(); //Initializes a new ProcessStartInfo of name myProcessInfo
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe"; //Sets the FileName property of myProcessInfo to %SystemRoot%\System32\cmd.exe where %SystemRoot% is a system variable which is expanded using Environment.ExpandEnvironmentVariables
            myProcessInfo.Arguments = "cd.."; //Sets the arguments to cd..
            myProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; //Sets the WindowStyle of myProcessInfo which indicates the window state to use when the process is started to Hidden
            System.Diagnostics.Process.Start(myProcessInfo); //Starts the process based on myProcessInfo
             
             */
            //System.Diagnostics.Process.Start("DemulShooter.exe", "/c target = " + Machine + " - rom = " + Name + " - noresize");
            System.Diagnostics.ProcessStartInfo myProcessInfo = new System.Diagnostics.ProcessStartInfo();
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
            //myProcessInfo.Arguments = "-target=" + Machine + " -rom = " + Name + " -noresize";
            myProcessInfo.Verb = "runas";
            myProcessInfo.RedirectStandardInput = true;
            myProcessInfo.UseShellExecute = false;

            Process p = Process.Start(myProcessInfo);
            StreamWriter sw = p.StandardInput;
            string inputText = rootPath + "DemulShooter.exe -target=" + Machine + " -rom=" + Name + " -noresize";
            sw.WriteLine(inputText);
            sw.Close();

            p.WaitForExit();


        }

        public bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
