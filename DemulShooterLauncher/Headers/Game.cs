
namespace DemulShooterLauncher.Headers
{
    public class Game
    {
        public string Name { get; }
        public string Target { get; }
        public string Rom { get; }
        public string Starter { get; }
        public string Recommended { get; }

        public Game(string name, string target, string rom, string recommended)
        {
            Name = name;
            Target = target;
            Rom = rom;
            Starter = "DemulShooter.exe";
            Recommended = recommended == null ? string.Empty : recommended;
        }

        public Game(string name, string target, string rom, string recommended, bool starter)
        {
            Name = name;
            Target = target;
            Rom = rom;
            Starter = starter == true ? "DemulShooterX64.exe" : "DemulShooter.exe";
            Recommended = recommended == null ? string.Empty : recommended;

        }
    }
}
