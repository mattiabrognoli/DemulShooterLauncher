using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemulShooter
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    public class ConsoleCommand
    {
        public string Name { get; }
        public string Machine { get; }
        public ConsoleCommand(string name, string machine)
        {
            Name = "confmiss";
            Machine = "demul07a";
        }

        public void Run()
        {

            // Set options for process and then start that
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "DemulShooter.exe";
            startInfo.Arguments = "target = " + Machine + " - rom = " + Name + " - noresize";
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            //process.WaitForExit();
        }
    }
}
