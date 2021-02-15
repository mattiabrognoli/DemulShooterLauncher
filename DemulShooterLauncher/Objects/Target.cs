namespace DemulShooterLauncher.Objects
{
    public class Target
    {
        public int Id { get; }
        public string Description { get; }
        public string Command { get; }
        public string Link { get; }

        public Target(int id, string description, string command)
        {
            this.Id = id;
            this.Description = description;
            this.Command = command;
            this.Link = string.Empty;
        }

        public Target(int id, string description, string command, string link)
        {
            this.Id = id;
            this.Description = description;
            this.Command = command;
            this.Link = link;
        }
        public override string ToString()
        {
            return this.Description;
        }
    }
}