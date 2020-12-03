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

            //TODO Aggiungere tutti giochi

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

            /*
            Esempio xml create

            if (File.Exists(PathXML))
            {
                var uri = new System.Uri(PathXML);
                XmlReaderSettings settings = new XmlReaderSettings { IgnoreComments = true, IgnoreWhitespace = true };
                //XmlTextReader xmlReader = new XmlTextReader(PathXML);
                XmlReader xmlReader = XmlReader.Create(uri.AbsoluteUri, settings);
                string name = null, target = null, rom = null, arguments = null;
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element)
                        switch (xmlReader.Name)
                        {
                            case "name":
                                name = xmlReader.Name;
                                break;
                            case "target":
                                target = xmlReader.Name;
                                break;
                            case "rom":
                                rom = xmlReader.Name;
                                break;
                            case "arguments":
                                arguments = xmlReader.Name;
                                break;
                        }
                    if (xmlReader.NodeType == XmlNodeType.EndElement && xmlReader.Name == "/game")
                        GameList.Add(new Game(name, target, rom, arguments));
                }



            }*/

            GameList.Sort((p, q) => p.Name.CompareTo(q.Name));

            return GameList;

        }
    }
}
