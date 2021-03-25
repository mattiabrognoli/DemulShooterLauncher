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

        void ChangeSet(string key, bool change);

        void ChangeVisible(string key, bool change);

        T GetCustomArgument(string displayText, string value, bool check, bool visible, string description);
    }
}