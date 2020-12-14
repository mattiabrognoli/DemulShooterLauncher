namespace DemulShooterLauncher.Headers
{
    public class Game
    {
        public string Name { get; }
        public string Rom { get; }
        public string Recommended { get; }
        public string Starter { get; }

        public Game(string name, string rom, string recommended, bool starter)
        {
            this.Name = name;
            this.Rom = rom;
            this.Recommended = recommended == null ? string.Empty : recommended;
            this.Starter = starter == true ? "DemulShooterX64.exe" : "DemulShooter.exe";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
