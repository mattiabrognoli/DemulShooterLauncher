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
        string PathXML { get; }

        public LoadList(string pathxml)
        {
            PathXML = pathxml;
        }

        
        public List<Game> Loading()
        {
            
            List<Game> GameList = new List<Game>();
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



            }
            return GameList;

        }
    }
}
