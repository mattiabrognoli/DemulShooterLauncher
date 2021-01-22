using DemulShooterLauncher.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static DemulShooterLauncher.Utility;

namespace DemulShooterLauncher.Controller
{
    public static class LauncherControllerHelper
    {
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

        static public void Run(string rootPath, Rom current, string Rom, string arguments)
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
                    if (Rom == "dolphin5")
                        inputText = rootPath + "\\" + current.Starter + " -target=" + Rom + " -ddinumber=" + current.Command;
                    else
                        inputText = rootPath + "\\" + current.Starter + " -target=" + Rom + " -rom=" + current.Command + arguments;
                    sw.WriteLine(inputText);
                    sw.Close();
                }
                p.WaitForExit();
            }
        }
        static public List<Target> LoadingTargets()
        {
            return new List<Target>()
            {
                new Target((int)IdMachines.demul07a, "Demul 0.7a 180428", "demul07a"),
                new Target((int)IdMachines.chihiro, "Cxbx-Reloaded", "chihiro"),
                new Target((int)IdMachines.globalvr, "Global VR Roms", "globalvr"),
                new Target((int)IdMachines.lindbergh, "TeknoParrot Loader (Lindberh)", "lindbergh"),
                new Target((int)IdMachines.windows, "Window", "windows"),
                new Target((int)IdMachines.model2, "Model2 Emulator v1.1a", "model2"),
                new Target((int)IdMachines.ringwide, "TeknoParrot Loader (Ringwide)", "ringwide"),
                new Target((int)IdMachines.ttx, "Taito Type X", "ttx"),
                new Target((int)IdMachines.seganu, "TeknoParrot Loader (Sega Nu)", "seganu"),
                new Target((int)IdMachines.dolphin5, "Dolphin x64 v5.0", "dolphin5")
            };
        }

        static public List<Rom> LoadingRoms()
        {
            int id = 1;
            return new List<Rom>()
            {
                //demul07a
                new Rom(id++, (int)IdMachines.demul07a, "Brave Fire fighters", "braveff", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Confidential Mission", "confmiss", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Death Crimson OX", "deathcox", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II (US)", "hotd2", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II", "hotd2o", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "House of The Dead II (Prototype)", "hotd2p", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Lupin The Third", "lupinsho", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Manic Panic Ghosts", "manicpnc", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "The Maze of the kings", "mok", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (World)", "ninjaslt", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (Asia)", "ninjaslta", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (Japan)", "ninjasltj", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Ninja Assault (US)", "ninjasltu", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Pokasuka Ghosts", "pokasuka", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Ranger Mission", "rangrmsn", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Sports Shoting USA", "sprtshot", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Extreme Hunting", "xtrmhunt", "noresize"),
                new Rom(id++, (int)IdMachines.demul07a, "Extreme Hunting 2", "xtrmhnt2", "noresize"),

                //chihiro
                new Rom(id++, (int)IdMachines.chihiro, "Virtual Cop 3", "vcop3"),

                //globalvr
                new Rom(id++, (int)IdMachines.globalvr, "Aliens Extermination", "aliens"),
                new Rom(id++, (int)IdMachines.globalvr, "Fright Fear Land", "fearland"),

                //lindbergh
                new Rom(id++, (int)IdMachines.lindbergh, "Too Spicy", "2spicy"),
                new Rom(id++, (int)IdMachines.lindbergh, "House of the dead 4", "hotd4"),
                new Rom(id++, (int)IdMachines.lindbergh, "Let's Go Jungle", "lgj"),
                new Rom(id++, (int)IdMachines.lindbergh, "Let's Go Jungle (1 player)", "lgjsp"),
                new Rom(id++, (int)IdMachines.lindbergh, "Rambo", "rambo", " nocrosshair"),

                //windows
                new Rom(id++, (int)IdMachines.windows, "Art Is Dead", "artdead"),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Afghanistan", "hfa"),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Afghanistan (Dual Player)", "hfa2p"),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Shattered Spear", "hfss"),
                new Rom(id++, (int)IdMachines.windows, "Heavy Fire Shattered Spear (Dual Player)", "hfss2p"),
                new Rom(id++, (int)IdMachines.windows, "Reload", "reload", "nocrosshair"),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead II (PC)", "hod2pc"),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead III", "hod3pc", "noautoreload noguns"),
                new Rom(id++, (int)IdMachines.windows, "House of The Dead : Overkill", "hodo"),

                //model2
                new Rom(id++, (int)IdMachines.model2, "Behind Enemy Lines", "bel"),
                new Rom(id++, (int)IdMachines.model2, "Gunblade NY", "gunblade"),
                new Rom(id++, (int)IdMachines.model2, "House of the Dead", "hotd"),
                new Rom(id++, (int)IdMachines.model2, "Railchase 2", "rchase2"),
                new Rom(id++, (int)IdMachines.model2, "Virtua Cop", "vcop"),
                new Rom(id++, (int)IdMachines.model2, "Virtua Cop 2", "vcop2"),

                //ringwide
                new Rom(id++, (int)IdMachines.ringwide, "Let's Go Island: Lost on the Island of Tropics", "lgi"),
                new Rom(id++, (int)IdMachines.ringwide, "Let's Go Island: Lost on the Island of Tropics 3D", "lgi3D"),
                new Rom(id++, (int)IdMachines.ringwide, "Operation G.H.O.S.T.", "og"),
                new Rom(id++, (int)IdMachines.ringwide, "Sega Dream Riders", "sdr"),
                new Rom(id++, (int)IdMachines.ringwide, "Sega Golden Gun", "sgg"),
                new Rom(id++, (int)IdMachines.ringwide, "Transformers: Human Alliance", "tha"),

                //ttx
                new Rom(id++, (int)IdMachines.ttx, "Elevator Action Death Parade", "eapd"),
                new Rom(id++, (int)IdMachines.ttx, "Silent Hill: The Arcade", "sha"),
                new Rom(id++, (int)IdMachines.ttx, "Gaia Attack 4", "gattack4"),
                new Rom(id++, (int)IdMachines.ttx, "Gundam: Spirit of Zeon", "gsoz"),
                new Rom(id++, (int)IdMachines.ttx, "Gundam: Spirit of Zeon (DualScreen)", "gsoz2p"),
                new Rom(id++, (int)IdMachines.ttx, "Haunted Museum", "hmuseum"),
                new Rom(id++, (int)IdMachines.ttx, "Haunted Museum 2", "hmuseum2"),
                new Rom(id++, (int)IdMachines.ttx, "Music Gun Gun! 2", "mgungun2"),

                //seganu
                new Rom(id++, (int)IdMachines.seganu, "Luigi Mansion Arcade", "lma", null, true),

                //dolphin5
                new Rom(id++, (int)IdMachines.dolphin5, "1 -> KeyboardMouse", "1"),
                new Rom(id++, (int)IdMachines.dolphin5, "2 -> Aimtrak #1", "2"),
                new Rom(id++, (int)IdMachines.dolphin5, "3 -> Aimtrak #2", "3"),
                new Rom(id++, (int)IdMachines.dolphin5, "4 -> Other", "4")
            };
        }
    }
}
