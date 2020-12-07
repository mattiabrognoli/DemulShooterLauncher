using System;
using System.IO;
using System.Diagnostics;

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

            ProcessStartInfo myProcessInfo = new ProcessStartInfo();
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
            myProcessInfo.Verb = "runas";
            myProcessInfo.RedirectStandardInput = true;
            myProcessInfo.UseShellExecute = false;

            using (Process p = Process.Start(myProcessInfo))
            {
                using (StreamWriter sw = p.StandardInput)
                {
                    string inputText = rootPath + "\\" + current.Starter + " -target=" + current.Target + " -rom=" + current.Rom + arguments;
                    sw.WriteLine(inputText);
                    sw.Close();
                }
                p.WaitForExit();
            }
            return true;
        }

    }
}
