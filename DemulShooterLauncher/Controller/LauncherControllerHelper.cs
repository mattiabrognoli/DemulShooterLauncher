using DemulShooterLauncher.Headers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DemulShooterLauncher.Controller
{
    public static class LauncherControllerHelper
    {
        static public Machine FindMachineByTarget(Machine[] machines, string target)
        {
            return machines.Where(m => m.Target == target).FirstOrDefault();
        }
        static public Game[] FindGamesbyName(Machine[] machines, string name)
        {
            return machines.Where(t => t.Name == name).Select(m => m.Games).SingleOrDefault().ToArray();
        }
        static public Game[] FindGamesbyTarget(Machine[] machines, string target)
        {
            return machines.Where(t => t.Target == target).Select(m => m.Games).SingleOrDefault().ToArray();
        }
        static public string FindTargetbyName(Machine[] machines, string name)
        {
            return machines.Where(t => t.Name == name).Select(m => m.Target).SingleOrDefault();
        }
        static public Game FindGameInGamesbyName(Game[] games, string name)
        {
            return games.Where(g => g.Name == name).SingleOrDefault();
        }
        static public void Run(string rootPath, Game current, string target, string arguments)
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
                        inputText = rootPath + "\\" + current.Starter + " -target=" + target + " -ddinumber=" + current.Rom;
                    else
                        inputText = rootPath + "\\" + current.Starter + " -target=" + target + " -rom=" + current.Rom + arguments;
                    sw.WriteLine(inputText);
                    sw.Close();
                }
                p.WaitForExit();
            }
        }
        static public List<Machine> LoadingMachines()
        {
            return new List<Machine>()
            {
                //Demul
                new Machine("Demul 0.7a 180428", "demul07a", new List<Game>()
                {
                    new Game("Brave Fire fighters", "braveff", "noresize", false),
                    new Game("Confidential Mission", "confmiss", "noresize", false),
                    new Game("Death Crimson OX", "deathcox", "noresize", false),
                    new Game("House of The Dead II (US)", "hotd2", "noresize", false),
                    new Game("House of The Dead II", "hotd2o", "noresize", false),
                    new Game("House of The Dead II (Prototype)", "hotd2p", "noresize", false),
                    new Game("Lupin The Third", "lupinsho", "noresize", false),
                    new Game("Manic Panic Ghosts", "manicpnc", "noresize", false),
                    new Game("The Maze of the kings", "mok", "noresize", false),
                    new Game("Ninja Assault (World)", "ninjaslt", "noresize", false),
                    new Game("Ninja Assault (Asia)", "ninjaslta", "noresize", false),
                    new Game("Ninja Assault (Japan)", "ninjasltj", "noresize", false),
                    new Game("Ninja Assault (US)", "ninjasltu", "noresize", false),
                    new Game("Pokasuka Ghosts", "pokasuka", "noresize", false),
                    new Game("Ranger Mission", "rangrmsn", "noresize", false),
                    new Game("Sports Shoting USA", "sprtshot", "noresize", false),
                    new Game("Extreme Hunting", "xtrmhunt", "noresize", false),
                    new Game("Extreme Hunting 2", "xtrmhnt2", "noresize", false)
                }),
                //Chihiro
                new Machine("Cxbx-Reloaded", "chihiro", new List<Game>()
                {
                    new Game("Virtual Cop 3", "vcop3", null, false)
                }),
                //GlobalVR
                new Machine("Global VR Games", "globalvr", new List<Game>()
                {
                    new Game("Aliens Extermination", "aliens",  null, false),
                    new Game("Fright Fear Land", "fearland", null, false)
                }),
                //Lindbergh
                new Machine("TeknoParrot Loader (Lindberh)", "lindbergh", new List<Game>()
                {
                    new Game("Too Spicy", "2spicy",  null, false),
                    new Game("House of the dead 4", "hotd4",  null, false),
                    new Game("Let's Go Jungle", "lgj",  null, false),
                    new Game("Let's Go Jungle (1 player)", "lgjsp",  null, false),
                    new Game("Rambo", "rambo", " nocrosshair", false),

                }),
                //Windows Games
                new Machine("Windows Games", "windows", new List<Game>()
                {
                    new Game("Art Is Dead", "artdead", null, false),
                    new Game("Heavy Fire Afghanistan", "hfa", null, false),
                    new Game("Heavy Fire Afghanistan (Dual Player)", "hfa2p", null, false),
                    new Game("Heavy Fire Shattered Spear", "hfss", null, false),
                    new Game("Heavy Fire Shattered Spear (Dual Player)", "hfss2p", null, false),
                    new Game("Reload", "reload", "nocrosshair", false),
                    new Game("House of The Dead II (PC)", "hod2pc", null, false),
                    new Game("House of The Dead III", "hod3pc", "noautoreload noguns", false),
                    new Game("House of The Dead : Overkill", "hodo", null, false),
                }),
                //Model2
                new Machine("Model2 Emulator v1.1a", "model2", new List<Game>()
                {
                    new Game("Behind Enemy Lines", "bel", null, false),
                    new Game("Gunblade NY", "gunblade", null, false),
                    new Game("House of the Dead", "hotd", null, false),
                    new Game("Railchase 2", "rchase2", null, false),
                    new Game("Virtua Cop", "vcop", null, false),
                    new Game("Virtua Cop 2", "vcop2", null, false),
                }),
                //Ringwide
                new Machine("TeknoParrot Loader (Ringwide)", "ringwide", new List<Game>()
                {
                    new Game("Let's Go Island: Lost on the Island of Tropics", "lgi", null, false),
                    new Game("Let's Go Island: Lost on the Island of Tropics 3D", "lgi3D", null, false),
                    new Game("Operation G.H.O.S.T.", "og", null, false),
                    new Game("Sega Dream Riders", "sdr", null, false),
                    new Game("Sega Golden Gun", "sgg", null, false),
                    new Game("Transformers: Human Alliance", "tha", null, false),
                }),
                //Taito Type X
                new Machine("Taito Type X Games", "ttx", new List<Game>()
                {
                    new Game("Elevator Action Death Parade", "eapd", null, false),
                    new Game("Silent Hill: The Arcade", "sha", null, false),
                    new Game("Gaia Attack 4", "gattack4", null, false),
                    new Game("Gundam: Spirit of Zeon", "gsoz", null, false),
                    new Game("Gundam: Spirit of Zeon (DualScreen)", "gsoz2p", null, false),
                    new Game("Haunted Museum", "hmuseum", null, false),
                    new Game("Haunted Museum 2", "hmuseum2", null, false),
                    new Game("Music Gun Gun! 2", "mgungun2", null, false),
                }),
                //Seha Nu
                new Machine("TeknoParrot Loader (Sega Nu)", "seganu", new List<Game>()
                {
                    new Game("Luigi Mansion Arcade", "lma", null, true),
                }),
                //Dolphin
                new Machine("Dolphin x64 v5.0", "dolphin5", new List<Game>()
                {
                    new Game("1 -> KeyboardMouse", "1", null, false),
                    new Game("2 -> Aimtrak #1", "2", null, false),
                    new Game("3 -> Aimtrak #2", "3", null, false),
                    new Game("4 -> Other", "4", null, false)
                })
            };
        }
    }
}
