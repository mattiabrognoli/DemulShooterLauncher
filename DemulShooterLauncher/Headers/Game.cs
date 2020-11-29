using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemulShooterLauncher.Headers
{
    class Game
    {
        public string Name { get; }
        public string Target { get; }
        public string Rom { get; }
        public string Arguments { get; }

        public Game(string name, string target, string rom, string arguments)
        {
            Name = name;
            Target = target;
            Rom = rom;
            Arguments = arguments == null ? string.Empty : arguments;
        }

    }
}
