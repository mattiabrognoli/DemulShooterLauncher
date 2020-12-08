using System.Collections.Generic;

namespace DemulShooterLauncher.Headers
{
    class LoadList
    {
        public LoadList()
        {
        }
        public Dictionary<string, Target> Loading()
        {
            
            Dictionary<string, Target> ListTarget = new Dictionary<string, Target>();

            //Set key value
            ListTarget["Demul 0.7a 180428"] = new Target("demul07a");
            ListTarget["Cxbx-Reloaded"] = new Target("chihiro");
            ListTarget["TeknoParrot Loader (Lindberh)"] = new Target("lindbergh");
            ListTarget["Global VR Games"] = new Target("globalvr");            
            ListTarget["Windows Games"] = new Target("windows");
            ListTarget["Model2 Emulator v1.1a"] = new Target("model2");
            ListTarget["TeknoParrot Loader (Ringwide)"] = new Target("ringwide");
            ListTarget["Taito Type X Games"] = new Target("ttx");
            ListTarget["TeknoParrot Loader (Sega Nu)"] = new Target("seganu");

            //Demul
            ListTarget["Demul 0.7a 180428"].AddRom("Brave Fire fighters", new Game("braveff", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Confidential Mission", new Game("confmiss", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Death Crimson OX", new Game("deathcox", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("House of The Dead II (US)", new Game("hotd2", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("House of The Dead II", new Game("hotd2o", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("House of The Dead II (Prototype)", new Game("hotd2p", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Lupin The Third", new Game("lupinsho", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Manic Panic Ghosts", new Game("manicpnc", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("The Maze of the kings", new Game("mok", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Ninja Assault (World)", new Game("ninjaslt", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Ninja Assault (Asia)", new Game("ninjaslta", "noresize"));           
            ListTarget["Demul 0.7a 180428"].AddRom("Ninja Assault (Japan)", new Game("ninjasltj", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Ninja Assault (US)", new Game("ninjasltu", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Pokasuka Ghosts", new Game("pokasuka", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Ranger Mission", new Game("rangrmsn", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Sports Shoting USA", new Game("sprtshot", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Extreme Hunting", new Game("xtrmhunt", "noresize"));
            ListTarget["Demul 0.7a 180428"].AddRom("Extreme Hunting 2", new Game("xtrmhnt2", "noresize"));

            //Chihiro
            ListTarget["Cxbx-Reloaded"].AddRom("Virtual Cop 3", new Game("vcop3", null));

            //Global VR
            ListTarget["Global VR Games"].AddRom("Aliens Extermination", new Game("aliens", null));
            ListTarget["Global VR Games"].AddRom("Fright Fear Land", new Game("fearland", null));

            //Lidenbergh
            ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Too Spicy", new Game("2spicy", null));
            ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("House of the dead 4", new Game("hotd4", null));
            ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Let's Go Jungle", new Game("lgj", null));
            ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Let's Go Jungle (1 player)", new Game("lgjsp", null));
            ListTarget["TeknoParrot Loader (Lindberh)"].AddRom("Rambo", new Game("rambo", "nocrosshair"));

            //Windows Games
            ListTarget["Windows Games"].AddRom("Art Is Dead", new Game("artdead", null));
            ListTarget["Windows Games"].AddRom("Heavy Fire Afghanistan", new Game("hfa", null));
            ListTarget["Windows Games"].AddRom("Heavy Fire Afghanistan (Dual Player)", new Game("hfa2p", null));
            ListTarget["Windows Games"].AddRom("Heavy Fire Shattered Spear", new Game("hfss", null));
            ListTarget["Windows Games"].AddRom("Heavy Fire Shattered Spear (Dual Player)", new Game("hfss2p", null));
            ListTarget["Windows Games"].AddRom("Reload", new Game("reload", "nocrosshair"));
            ListTarget["Windows Games"].AddRom("House of The Dead II (PC)", new Game("hod2pc", null));
            ListTarget["Windows Games"].AddRom("House of The Dead III", new Game("hod3pc", "noautoreload noguns"));
            ListTarget["Windows Games"].AddRom("House of The Dead : Overkill", new Game("hodo", null));

            //Model2
            ListTarget["Model2 Emulator v1.1a"].AddRom("Behind Enemy Lines", new Game("bel", null));
            ListTarget["Model2 Emulator v1.1a"].AddRom("Gunblade NY", new Game("gunblade", null));
            ListTarget["Model2 Emulator v1.1a"].AddRom("House of the Dead", new Game("hotd", null));
            ListTarget["Model2 Emulator v1.1a"].AddRom("Railchase 2", new Game("rchase2", null));
            ListTarget["Model2 Emulator v1.1a"].AddRom("Virtua Cop", new Game("vcop", null));
            ListTarget["Model2 Emulator v1.1a"].AddRom("Virtua Cop 2", new Game("vcop2", null));

            //RingWide
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Let's Go Island : Lost on the Island of Tropics", new Game("lgi", null));
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Let's Go Island : Lost on the Island of Tropics 3D", new Game("lgi3D", null));
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Operation G.H.O.S.T.", new Game("og", null));
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Sega Dream Riders", new Game("sdr", null));
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Sega Golden Gun", new Game("sgg", null));
            ListTarget["TeknoParrot Loader (Ringwide)"].AddRom("Transformers : Human Alliance", new Game("tha", null));

            //Taito Type X
            ListTarget["Taito Type X Games"].AddRom("Elevator Action Death Parade", new Game("eapd", null));
            ListTarget["Taito Type X Games"].AddRom("Silent Hill the Arcade", new Game("sha", null));
            ListTarget["Taito Type X Games"].AddRom("Gaia Attack 4", new Game("gattack4", null));
            ListTarget["Taito Type X Games"].AddRom("Gundam : Spirit of Zeon", new Game("gsoz", null));
            ListTarget["Taito Type X Games"].AddRom("Gundam : Spirit of Zeon ( DualScreen )", new Game("gsoz2p", null));
            ListTarget["Taito Type X Games"].AddRom("Haunted Museum", new Game("hmuseum", null));
            ListTarget["Taito Type X Games"].AddRom("Haunted Museum 2", new Game("hmuseum2", null));
            ListTarget["Taito Type X Games"].AddRom("Music Gun Gun! 2", new Game("mgungun2", null));

            //Seha Nu
            ListTarget["TeknoParrot Loader (Sega Nu)"].AddRom("Luigi Mansion Arcade", new Game("lma", null, true));

            return ListTarget;

        }
    }
}
