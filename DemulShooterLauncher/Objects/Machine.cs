using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemulShooterLauncher.Headers
{
    public class Machine
    {
        public string Name { get; }
        public string Target { get; }
        public List<Game> Games { get; }

        public Machine(string name, string target, List<Game> games)
        {
            this.Name = name;
            this.Target = target;
            this.Games = games;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
