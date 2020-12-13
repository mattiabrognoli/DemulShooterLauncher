using System.Collections.Generic;

namespace DemulShooterLauncher.Headers
{
    class LoadList
    {
        public LoadList()
        {
        }
        public List<Machine> LoadingMachines()
        {

            List<Machine> ListMachine = new List<Machine>()
            {
                //Demul
                new Machine("Demul 0.7a 180428", "demul07a", new List<Game>()
                {
                    new Game("Brave Fire fighters", "braveff", "demul07a", "noresize", false),
                    new Game("Confidential Mission", "confmiss", "demul07a", "noresize", false),
                    new Game("Death Crimson OX", "deathcox", "demul07a", "noresize", false),
                    new Game("House of The Dead II (US)", "hotd2", "demul07a", "noresize", false),
                    new Game("House of The Dead II", "hotd2o", "demul07a", "noresize", false),
                    new Game("House of The Dead II (Prototype)", "hotd2p", "demul07a", "noresize", false),
                    new Game("Lupin The Third", "lupinsho", "demul07a", "noresize", false),
                    new Game("Manic Panic Ghosts", "manicpnc", "demul07a", "noresize", false),
                    new Game("The Maze of the kings", "mok", "demul07a", "noresize", false),
                    new Game("Ninja Assault (World)", "ninjaslt", "demul07a", "noresize", false),
                    new Game("Ninja Assault (Asia)", "ninjaslta", "demul07a", "noresize", false),
                    new Game("Ninja Assault (Japan)", "ninjasltj", "demul07a", "noresize", false),
                    new Game("Ninja Assault (US)", "ninjasltu", "demul07a", "noresize", false),
                    new Game("Pokasuka Ghosts", "pokasuka", "demul07a", "noresize", false),
                    new Game("Ranger Mission", "rangrmsn", "demul07a", "noresize", false),
                    new Game("Sports Shoting USA", "sprtshot", "demul07a", "noresize", false),
                    new Game("Extreme Hunting", "xtrmhunt", "demul07a", "noresize", false),
                    new Game("Extreme Hunting 2", "xtrmhnt2", "demul07a", "noresize", false)
                }),
                //Chihiro
                new Machine("Cxbx-Reloaded", "chihiro", new List<Game>()
                {
                    new Game("Virtual Cop 3", "vcop3", "chihiro", null, false)
                }),
                new Machine("Global VR Games", "globalvr", new List<Game>()
                {
                    new Game("Aliens Extermination", "aliens", "globalvr", null, false),
                    new Game("Fright Fear Land", "fearland", "globalvr", null, false)
                })
                //new Machine("TeknoParrot Loader (Lindberh)", "lindbergh"),
                //new Machine("Windows Games", "windows"),
                //new Machine("Model2 Emulator v1.1a", "model2"),
                //new Machine("TeknoParrot Loader (Ringwide)", "ringwide"),
                //new Machine("Taito Type X Games", "ttx"),
                //new Machine("TeknoParrot Loader (Sega Nu)", "seganu"),
            };
            return ListMachine;
        }




           // var res = ListGame.Join(ListMachine, g => g.GTarget, m => m.MTarget, (g, m) => new { Games = g.GName, Machines = m.MName }).ToList();


            ////Lidenbergh
            //ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Too Spicy", new Game("2spicy", null));
            //ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("House of the dead 4", new Game("hotd4", null));
            //ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Let's Go Jungle", new Game("lgj", null));
            //ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Let's Go Jungle (1 player)", new Game("lgjsp", null));
            //ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Rambo", new Game("rambo", "nocrosshair"));

            ////Windows Games
            //ListTarget["Windows Games"].AddRom("Art Is Dead", new Game("artdead", null));
            //ListTarget["Windows Games"].AddRom("Heavy Fire Afghanistan", new Game("hfa", null));
            //ListTarget["Windows Games"].AddRom("Heavy Fire Afghanistan (Dual Player)", new Game("hfa2p", null));
            //ListTarget["Windows Games"].AddRom("Heavy Fire Shattered Spear", new Game("hfss", null));
            //ListTarget["Windows Games"].AddRom("Heavy Fire Shattered Spear (Dual Player)", new Game("hfss2p", null));
            //ListTarget["Windows Games"].AddRom("Reload", new Game("reload", "nocrosshair"));
            //ListTarget["Windows Games"].AddRom("House of The Dead II (PC)", new Game("hod2pc", null));
            //ListTarget["Windows Games"].AddRom("House of The Dead III", new Game("hod3pc", "noautoreload noguns"));
            //ListTarget["Windows Games"].AddRom("House of The Dead : Overkill", new Game("hodo", null));

            ////Model2
            //ListTarget["Model2 Emulator v1.1a"].AddRom("Behind Enemy Lines", new Game("bel", null));
            //ListTarget["Model2 Emulator v1.1a"].AddRom("Gunblade NY", new Game("gunblade", null));
            //ListTarget["Model2 Emulator v1.1a"].AddRom("House of the Dead", new Game("hotd", null));
            //ListTarget["Model2 Emulator v1.1a"].AddRom("Railchase 2", new Game("rchase2", null));
            //ListTarget["Model2 Emulator v1.1a"].AddRom("Virtua Cop", new Game("vcop", null));
            //ListTarget["Model2 Emulator v1.1a"].AddRom("Virtua Cop 2", new Game("vcop2", null));

            ////RingWide
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Let's Go Island : Lost on the Island of Tropics", new Game("lgi", null));
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Let's Go Island : Lost on the Island of Tropics 3D", new Game("lgi3D", null));
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Operation G.H.O.S.T.", new Game("og", null));
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Sega Dream Riders", new Game("sdr", null));
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Sega Golden Gun", new Game("sgg", null));
            //ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Transformers : Human Alliance", new Game("tha", null));

            ////Taito Type X
            //ListTarget["Taito Type X Games"].AddRom("Elevator Action Death Parade", new Game("eapd", null));
            //ListTarget["Taito Type X Games"].AddRom("Silent Hill the Arcade", new Game("sha", null));
            //ListTarget["Taito Type X Games"].AddRom("Gaia Attack 4", new Game("gattack4", null));
            //ListTarget["Taito Type X Games"].AddRom("Gundam : Spirit of Zeon", new Game("gsoz", null));
            //ListTarget["Taito Type X Games"].AddRom("Gundam : Spirit of Zeon ( DualScreen )", new Game("gsoz2p", null));
            //ListTarget["Taito Type X Games"].AddRom("Haunted Museum", new Game("hmuseum", null));
            //ListTarget["Taito Type X Games"].AddRom("Haunted Museum 2", new Game("hmuseum2", null));
            //ListTarget["Taito Type X Games"].AddRom("Music Gun Gun! 2", new Game("mgungun2", null));

            ////Seha Nu
            //ListTarget["TeknoParrot Loader (Sega Nu)"].AddRom("Luigi Mansion Arcade", new Game("lma", null, true));



        
    }
}
