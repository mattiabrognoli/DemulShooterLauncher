using System.Collections.Generic;

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
