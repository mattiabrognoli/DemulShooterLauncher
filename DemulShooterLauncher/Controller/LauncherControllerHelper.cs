using DemulShooterLauncher.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace DemulShooterLauncher.Controller
{
    public static class LauncherControllerHelper
    {
        public enum IdMachines : int
        {
            demul07a,
            chihiro,
            globalvr,
            lindbergh,
            windows,
            model2,
            ringwide,
            ttx,
            seganu,
            dolphin5,
            es3
        }

        static public bool checkPaths()
        {
            if (!File.Exists(".\\DemulShooter.exe") || !File.Exists(".\\DemulShooterX64.exe") || !File.Exists("DsCore.dll"))
                return false;
            return true;
        }

        static public bool checkAdmin(WindowsPrincipal principal)
        {
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static public string TextToArgument(string text)
        {
            if (text == "No resize")
                return "noresize";
            if (text == "Widescreen")
                return "widescreen";
            if (text == "No autoreload")
                return "noautoreload";
            if (text == "No autofire")
                return "noautofire";
            if (text == "No guns")
                return "noguns";
            if (text == "No Crosshair")
                return "nocrosshair";
            if (text == "DDI number")
                return "ddinumber";
            if (text == "Verbs")
                return "v";

            return string.Empty;
        }

        static public bool canDisableArgument(string text)
        {
            if (text == "No resize")
                return true;
            if (text == "No autoreload")
                return true;
            if (text == "No autofire")
                return true;
            if (text == "No guns")
                return true;
            if (text == "No Crosshair")
                return true;
            if (text == "DDI number")
                return true;

            return false;
        }

        static public Target GetTargetById(Target[] targets, int id)
        {
            return targets.Where(m => m.Id == id).FirstOrDefault();
        }

        static public Rom GetRomById(Rom[] roms, int id)
        {
            return roms.Where(m => m.Id == id).FirstOrDefault();
        }

        static public Rom[] GetRomByIdTarget(Rom[] Roms, int idTarget)
        {
            return Roms.Where(r => r.TargetId == idTarget).ToArray();
        }

        static public void Run(string rootPath, Rom current, string target, string arguments)
        {
            ProcessStartInfo myProcessInfo = new ProcessStartInfo();
            myProcessInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + "\\System32\\cmd.exe";
            myProcessInfo.Verb = "runas";
            myProcessInfo.RedirectStandardInput = true;
            myProcessInfo.UseShellExecute = false;
            using (Process p = Process.Start(myProcessInfo))
            {
                using (StreamWriter sw = p.StandardInput)
                {
                    string inputText;
                    if (target == "dolphin5")
                        inputText = rootPath + "\\" + current.Starter + " -target=" + target + " -ddinumber=" + current.Command;
                    else
                        inputText = rootPath + "\\" + current.Starter + " -target=" + target + " -rom=" + current.Command + arguments;
                    sw.WriteLine(inputText);
                    sw.Close();
                }
                p.WaitForExit();
            }
        }

        static public void CreateScript(string rootPath, Rom current, string target, string arguments)
        {
            string inputText;
            if (target == "dolphin5")
                inputText = current.Starter + " -target=" + target + " -ddinumber=" + current.Command;
            else
                inputText = current.Starter + " -target=" + target + " -rom=" + current.Command + arguments;
            File.WriteAllText(rootPath + "\\" + current.Command + ".bat", inputText);

        }
        static public List<Target> LoadingTargets()
        {
            return new List<Target>()
            {
                new Target((int)IdMachines.demul07a, "Demul 0.7a 180428", "demul07a", "https://github.com/argonlefou/DemulShooter/wiki/Demul"),
                new Target((int)IdMachines.chihiro, "Cxbx-Reloaded", "chihiro", "https://github.com/argonlefou/DemulShooter/wiki/Chihiro"),
                new Target((int)IdMachines.globalvr, "Global VR", "globalvr", "https://github.com/argonlefou/DemulShooter/wiki/Global-VR"),
                new Target((int)IdMachines.lindbergh, "TeknoParrot Loader (Lindberh)", "lindbergh", "https://github.com/argonlefou/DemulShooter/wiki/Lindbergh"),
                new Target((int)IdMachines.windows, "Windows", "windows", "https://github.com/argonlefou/DemulShooter/wiki/Windows-games"),
                new Target((int)IdMachines.model2, "Model2 Emulator v1.1a", "model2", "https://github.com/argonlefou/DemulShooter/wiki/Model2"),
                new Target((int)IdMachines.ringwide, "TeknoParrot Loader (Ringwide)", "ringwide", "https://github.com/argonlefou/DemulShooter/wiki/RingWide"),
                new Target((int)IdMachines.ttx, "Taito Type X", "ttx", "https://github.com/argonlefou/DemulShooter/wiki/Taito-Type-X"),
                new Target((int)IdMachines.seganu, "TeknoParrot Loader (Sega Nu)", "seganu", "https://github.com/argonlefou/DemulShooter/wiki/SEGA-Nu"),
                new Target((int)IdMachines.dolphin5, "Dolphin x64 v5.0", "dolphin5", "https://github.com/argonlefou/DemulShooter/wiki/Dolphin"),
                new Target((int)IdMachines.es3, "Namco System ES3", "es3")
            };
        }

        static public List<Rom> LoadingRoms()
        {
            int id = 1;
            return new List<Rom>()
            {
                //demul07a
                new Rom(id++, (int)IdMachines.demul07a, "Brave Fire fighters", "braveff", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Confidential Mission", "confmiss", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Death Crimson OX", "deathcox", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II (US)", "hotd2", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II", "hotd2o", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II (Prototype)", "hotd2p", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Lupin The Third", "lupinsho", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Manic Panic Ghosts", "manicpnc", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "The Maze of the kings", "mok", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (World)", "ninjaslt", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (Asia)", "ninjaslta", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (Japan)", "ninjasltj", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (US)", "ninjasltu", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Pokasuka Ghosts", "pokasuka", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Ranger Mission", "rangrmsn", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Sports Shoting USA", "sprtshot", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Extreme Hunting", "xtrmhunt", new DemulArguments()),
                new Rom(id++, (int)IdMachines.demul07a, "Extreme Hunting 2", "xtrmhnt2", new DemulArguments()),

                //chihiro
                new Rom(id++, (int)IdMachines.chihiro, "Virtual Cop 3", "vcop3", new ChihiroArguments()),

                //globalvr
                new Rom(id++, (int)IdMachines.globalvr, "Aliens Extermination", "aliens", new GlobalvrArguments()),
                new Rom(id++, (int)IdMachines.globalvr, "Fright Fear Land", "fearland", new FrightFearLandArguments()),

                //lindbergh
                new Rom(id++, (int)IdMachines.lindbergh, "Too Spicy", "2spicy", new LindberghArguments()),
                new Rom(id++, (int)IdMachines.lindbergh, "House of the dead 4", "hotd4", new LindberghArguments()),
                new Rom(id++, (int)IdMachines.lindbergh, "Let's Go Jungle", "lgj", new LindberghArguments()),
                new Rom(id++, (int)IdMachines.lindbergh, "Let's Go Jungle (1 player)", "lgjsp", new LindberghArguments()),
                new Rom(id++, (int)IdMachines.lindbergh, "Rambo", "rambo", new RamboLindberghArguments()),

                //windows
                new Rom(id++, (int)IdMachines.windows, "Art Is Dead", "artdead", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Afghanistan", "hfa", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Afghanistan (Dual Player)", "hfa2p", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Shattered Spear", "hfss", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Shattered Spear (Dual Player)", "hfss2p", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "Reload", "reload", new ReloadArguments()),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead II (PC)", "hod2pc", new WindowsArguments()),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead III", "hod3pc", new Hod3Arguments()),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead : Overkill", "hodo", new WindowsArguments()),

                //model2
                new Rom(id++, (int)IdMachines.model2, "Behind Enemy Lines", "bel", new Model2Arguments()),
                new Rom(id++, (int)IdMachines.model2, "Gunblade NY", "gunblade", new Model2Arguments()),
                new Rom(id++, (int)IdMachines.model2, "House of the Dead", "hotd", new Model2Arguments()),
                new Rom(id++, (int)IdMachines.model2, "Railchase 2", "rchase2", new Model2Arguments()),
                new Rom(id++, (int)IdMachines.model2, "Virtua Cop", "vcop", new Model2Arguments()),
                new Rom(id++, (int)IdMachines.model2, "Virtua Cop 2", "vcop2", new Model2Arguments()),

                //ringwide
                new Rom(id++, (int)IdMachines.ringwide, "Let's Go Island: Lost on the Island of Tropics", "lgi", new RingWideArguments()),
                new Rom(id++, (int)IdMachines.ringwide, "Let's Go Island: Lost on the Island of Tropics 3D", "lgi3D", new RingWideArguments()),
                new Rom(id++, (int)IdMachines.ringwide, "Operation G.H.O.S.T.", "og", new RingWideArguments()),
                new Rom(id++, (int)IdMachines.ringwide, "Sega Dream Riders", "sdr", new RingWideArguments()),
                new Rom(id++, (int)IdMachines.ringwide, "Sega Golden Gun", "sgg", new RingWideArguments()),
                new Rom(id++, (int)IdMachines.ringwide, "Transformers: Human Alliance", "tha", new RingWideArguments()),

                //ttx
                new Rom(id++, (int)IdMachines.ttx, "Elevator Action Death Parade", "eapd", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Silent Hill: The Arcade", "sha", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Gaia Attack 4", "gattack4", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Gundam: Spirit of Zeon", "gsoz", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Gundam: Spirit of Zeon (DualScreen)", "gsoz2p", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Haunted Museum", "hmuseum", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Haunted Museum 2", "hmuseum2", new TaitoTypeXArguments()),
                new Rom(id++, (int)IdMachines.ttx, "Music Gun Gun! 2", "mgungun2", new TaitoTypeXArguments()),

                //seganu
                new Rom(id++, (int)IdMachines.seganu, "Luigi Mansion Arcade", "lma", new SEGANuArguments(), true),

                //es3
                new Rom(id++, (int)IdMachines.es3, "Time Crisis 5", "tc5", new ES3Arguments(), true),

                //dolphin5
                new Rom(id++, (int)IdMachines.dolphin5, "1 -> KeyboardMouse", "1", new DolphinArguments()),
                new Rom(id++, (int)IdMachines.dolphin5, "2 -> Aimtrak #1", "2", new DolphinArguments()),
                new Rom(id++, (int)IdMachines.dolphin5, "3 -> Aimtrak #2", "3", new DolphinArguments()),
                new Rom(id++, (int)IdMachines.dolphin5, "4 -> Other", "4", new DolphinArguments())
            };
        }
    }
}
