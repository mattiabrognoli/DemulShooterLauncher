namespace DemulShooterLauncher.Objects
{
    public class Rom
    {
        public int Id { get; }
        public int TargetId { get; }
        public string Description { get; }
        public string Command { get; }
        public Arguments Arguments { get; }
        public string Starter { get; }

        public Rom(int id, int targetid, string description, string command, Arguments arguments, bool starter = false)
        {
            this.Id = id;
            this.TargetId = targetid;
            this.Description = description;
            this.Command = command;
            this.Arguments = arguments;
            this.Starter = starter == true ? "DemulShooterX64.exe" : "DemulShooter.exe";
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
