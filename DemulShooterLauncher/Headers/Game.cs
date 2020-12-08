namespace DemulShooterLauncher.Headers
{
    public class Game
    {
        public string Rom { get; }
        public string Starter { get; }
        public string Recommended { get; }

        public Game(string rom, string recommended)
        {
            Rom = rom;
            Starter = "DemulShooter.exe";
            Recommended = recommended == null ? string.Empty : recommended;
        }

        public Game(string rom, string recommended, bool starter)
        {
            Rom = rom;
            Starter = starter == true ? "DemulShooterX64.exe" : "DemulShooter.exe";
            Recommended = recommended == null ? string.Empty : recommended;

        }
    }
}
