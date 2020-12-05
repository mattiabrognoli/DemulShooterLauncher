using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DemulShooterLauncher.Headers
{
    class LoadList
    {
        //string PathXML { get; }

        public LoadList()
        {
        }


        public List<Game> Loading()
        {
            List<Game> GameList = new List<Game>();

            //Demul
            GameList.Add(new Game("Brave Fire fighters", "demul07a", "braveff", "noresize"));
            GameList.Add(new Game("Confidential Mission", "demul07a", "confmiss", "noresize"));
            GameList.Add(new Game("Death Crimson OX", "demul07a", "deathcox", "noresize"));
            GameList.Add(new Game("House of The Dead II (US)", "demul07a", "hotd2", "noresize"));
            GameList.Add(new Game("House of The Dead II", "demul07a", "hotd2o", "noresize"));
            GameList.Add(new Game("House of The Dead II (Prototype)", "demul07a", "hotd2p", "noresize"));
            GameList.Add(new Game("Lupin The Third", "demul07a", "lupinsho", "noresize"));        
            GameList.Add(new Game("Manic Panic Ghosts", "demul07a", "manicpnc", "noresize"));
            GameList.Add(new Game("The Maze of the kings", "demul07a", "mok", "noresize"));
            GameList.Add(new Game("Ninja Assault (World)", "demul07a", "ninjaslt", "noresize"));
            GameList.Add(new Game("Ninja Assault (Asia)", "demul07a", "ninjaslta", "noresize"));
            GameList.Add(new Game("Ninja Assault (Japan)", "demul07a", "ninjasltj", "noresize"));
            GameList.Add(new Game("Ninja Assault (US)", "demul07a", "ninjasltu", "noresize"));
            GameList.Add(new Game("Pokasuka Ghosts", "demul07a", "pokasuka", "noresize"));
            GameList.Add(new Game("Ranger Mission", "demul07a", "rangrmsn", "noresize"));
            GameList.Add(new Game("Sports Shoting USA", "demul07a", "sprtshot", "noresize"));
            GameList.Add(new Game("Extreme Hunting", "demul07a", "xtrmhunt", "noresize"));
            GameList.Add(new Game("Extreme Hunting 2", "demul07a", "xtrmhnt2", "noresize"));

            //Chihiro
            GameList.Add(new Game("Virtual Cop 3", "chihiro", "vcop3", null));

            //GlobalVR
            GameList.Add(new Game("Aliens Extermination", "globalvr", "aliens", null));
            GameList.Add(new Game("Fright Fear Land", "globalvr", "fearland", null));

            //Lidenbergh
            GameList.Add(new Game("Too Spicy", "lindbergh", "2spicy", null));
            GameList.Add(new Game("House of the dead 4", "lindbergh", "hotd4", null));
            GameList.Add(new Game("Let's Go Jungle", "lindbergh", "lgj", null));
            GameList.Add(new Game("Let's Go Jungle (1 player)", "lindbergh", "lgjsp", null));
            GameList.Add(new Game("Rambo", "lindbergh", "rambo", "nocrosshair"));

            //Windows Games
            GameList.Add(new Game("Art Is Dead", "windows", "artdead", null));
            GameList.Add(new Game("Heavy Fire Afghanistan", "windows", "hfa", null));
            GameList.Add(new Game("Heavy Fire Afghanistan (Dual Player)", "windows", "hfa2p", null));
            GameList.Add(new Game("Heavy Fire Shattered Spear", "windows", "hfss", null));
            GameList.Add(new Game("Heavy Fire Shattered Spear (Dual Player)", "windows", "hfss2p", null));
            GameList.Add(new Game("Reload", "windows", "reload", "nocrosshair"));
            GameList.Add(new Game("House of The Dead II (PC)", "windows", "hod2pc", null));
            GameList.Add(new Game("House of The Dead III", "windows", "hod3pc", "noautoreload noguns"));
            GameList.Add(new Game("House of The Dead : Overkill", "windows", "hodo", "noautoreload noguns"));

            //Model2
            GameList.Add(new Game("Behind Enemy Lines", "model2", "bel", null));
            GameList.Add(new Game("Gunblade NY", "model2", "gunblade", null));
            GameList.Add(new Game("House of the Dead", "model2", "hotd", null));
            GameList.Add(new Game("Railchase 2", "model2", "rchase2", null));
            GameList.Add(new Game("Virtua Cop", "model2", "vcop", null));
            GameList.Add(new Game("Virtua Cop 2", "model2", "vcop2", null));

            //RingWide
            GameList.Add(new Game("Let's Go Island : Lost on the Island of Tropics", "ringwide", "lgi", null));
            GameList.Add(new Game("Let's Go Island : Lost on the Island of Tropics 3D", "ringwide", "lgi3D", null));
            GameList.Add(new Game("Operation G.H.O.S.T.", "ringwide", "og", null));
            GameList.Add(new Game("Sega Dream Riders", "ringwide", "sdr", null));
            GameList.Add(new Game("Sega Golden Gun", "ringwide", "sgg", null));
            GameList.Add(new Game("Transformers : Human Alliance", "ringwide", "tha", null));

            //Taito Type X
            GameList.Add(new Game("Elevator Action Death Parade", "ttx", "eapd", null));
            GameList.Add(new Game("Silent Hill the Arcade", "ttx", "sha", null));
            GameList.Add(new Game("Gaia Attack 4", "ttx", "gattack4", null));
            GameList.Add(new Game("Gundam : Spirit of Zeon", "ttx", "gsoz", null));
            GameList.Add(new Game("Gundam : Spirit of Zeon ( DualScreen )", "ttx", "gsoz2p", null));
            GameList.Add(new Game("Haunted Museum", "ttx", "hmuseum", null));
            GameList.Add(new Game("Haunted Museum 2", "ttx", "hmuseum2", null));
            GameList.Add(new Game("Music Gun Gun! 2", "ttx", "mgungun2", null));

            //Seha Nu
            GameList.Add(new Game("Luigi Mansion Arcade", "seganu", "lma", null, true));

            GameList.Sort((p, q) => p.Name.CompareTo(q.Name));

            return GameList;

        }
    }
}
