using DemulShooterLauncher.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemulShooterLauncher.Objects
{
    public class Arguments : IArguments<DisplayArgument>
    {
        protected DisplayArgument[] _argumentsList;

        public DisplayArgument[] GetArguments()
        {
            List<DisplayArgument> list = new List<DisplayArgument>();
            list.AddRange(GetDisplayArguments());
            _argumentsList = list.OrderBy(a => a.Value).ToArray();
            return _argumentsList;
        }

        public void ChangeSet(string key, bool change)
        {
            DisplayArgument arg = _argumentsList.Where(a => a.Value == key).SingleOrDefault();

            if (arg != null)
                arg.Check = change;
        }

        public void ChangeVisible(string key, bool change)
        {
            DisplayArgument arg = _argumentsList.Where(a => a.Value == key).SingleOrDefault();

            if (arg != null)
                arg.Visible = change;
        }

        public DisplayArgument GetCustomArgument(string displayText, string value, bool check, bool visible, string description)
        {
            return new DisplayArgument()
            {
                DisplayText = displayText,
                Value = value,
                Check = check,
                Visible = visible,
                Description = description
            };
        }

        protected virtual DisplayArgument[] GetDisplayArguments()
        {
            List<DisplayArgument> result = new List<DisplayArgument>()
            {
                new DisplayArgument()
                {
                    DisplayText = "DDI number",
                    Value = "ddinumber",
                    Check = false,
                    Visible = true
                },
                new DisplayArgument()
                {
                    DisplayText = "Verbs",
                    Value = "v",
                    Check = false,
                    Visible = true
                }
            };

            return result.ToArray();
        }
    }

    public class DemulArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
                GetCustomArgument("No resize", "noresize", true, true, "Fix demul bug (exiting fullscreen when shooting upper left corner). This will block all mouse inputs to Demul GUI (menus, etc...)"),
                GetCustomArgument("Widescreen", "widescreen", false, true ,"Demul widescreen hack, works for some games")
            }.ToArray();
        }
    }

    public class ChihiroArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class WindowsArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class ReloadArguments : WindowsArguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
                GetCustomArgument("No Crosshair", "nocrosshair", true, true, "Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)"),
            }.ToArray();
        }
    }

    public class Hod3Arguments : WindowsArguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
                GetCustomArgument("No Crosshair", "nocrosshair", true, true, "Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)"),
                GetCustomArgument("No Guns", "noguns", true, true, "Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)")
            }.ToArray();
        }
    }

    public class GlobalvrArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class FrightFearLandArguments : GlobalvrArguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
                GetCustomArgument("Harder", "hardffl", false, true, "With the option, you'll play by default with the rifle pistol and pressing the change weapon button will make you use the machinegun"),
            }.ToArray();
        }
    }

    public class LindberghArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class RamboLindberghArguments : LindberghArguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
                GetCustomArgument("No Crosshair", "nocrosshair", true, true, "Hide in-game crosshair (for “Reload” on windows and \"Rambo\" on Lindbergh)"),
            }.ToArray();
        }
    }

    public class Model2Arguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class RingWideArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class TaitoTypeXArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class SEGANuArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }

    public class ES3Arguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }
    public class DolphinArguments : Arguments
    {
        protected override DisplayArgument[] GetDisplayArguments()
        {
            return new List<DisplayArgument>()
            {
            }.ToArray();
        }
    }



}
