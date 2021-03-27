using DemulShooterLauncher.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemulShooterLauncher.Interface
{
    interface IArguments<T>
    {
        T[] GetArguments();

        T GetCustomArgument(string displayText, string value, bool check, bool visible, string description);
    }
}