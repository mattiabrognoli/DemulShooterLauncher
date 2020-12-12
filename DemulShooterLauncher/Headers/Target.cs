using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemulShooterLauncher.Headers
{
    public class Target
    {
        public Dictionary <string, Game> ListRom {get;}
        public string Name { get;}

        public Target(string name)
        {
            Name = name;
            ListRom = new Dictionary<string, Game>();
        }

        public void AddRom(string rom, Game game)
        {
            ListRom[rom] = game;
        }
    }
}
