using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemulShooterLauncher
{
    static class main
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Default());
            /*
            // Create a new file in C:\\ dir  
            XmlTextWriter textWriter = new XmlTextWriter("myXmFile.xml", null);
            // Opens the document  
            textWriter.WriteStartDocument();
            // Write comments  
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element  
            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "RECORD", "urn:record");
            // Write next element  
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Student");
            textWriter.WriteEndElement();
            // Write one more element  
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("Colony");
            textWriter.WriteEndElement();
            // WriteChars  
            char[] ch = new char[3];
            ch[0] = 'a';
            ch[1] = 'r';
            ch[2] = 'c';
            textWriter.WriteStartElement("Char");
            textWriter.WriteChars(ch, 0, ch.Length);
            textWriter.WriteEndElement();
            // Ends the document.  
            textWriter.WriteEndDocument();
            // close writer  
            textWriter.Close();
            */
            /*
            int ws = 0;
            int pi = 0;
            int dc = 0;
            int cc = 0;
            int ac = 0;
            int et = 0;
            int el = 0;
            int xd = 0;
            // Read a document  
            XmlTextReader textReader = new XmlTextReader("C:\\books.xml");
            // Read until end of file  
            while (textReader.Read())
            {
                XmlNodeType nType = textReader.NodeType;
                // If node type us a declaration  
                if (nType == XmlNodeType.XmlDeclaration)
                {
                    Console.WriteLine("Declaration:" + textReader.Name.ToString());
                    xd = xd + 1;
                }
                // if node type is a comment  
                if (nType == XmlNodeType.Comment)
                {
                    Console.WriteLine("Comment:" + textReader.Name.ToString());
                    cc = cc + 1;
                }
                // if node type us an attribute  
                if (nType == XmlNodeType.Attribute)
                {
                    Console.WriteLine("Attribute:" + textReader.Name.ToString());
                    ac = ac + 1;
                }
                // if node type is an element  
                if (nType == XmlNodeType.Element)
                {
                    Console.WriteLine("Element:" + textReader.Name.ToString());
                    el = el + 1;
                }
                // if node type is an entity\  
                if (nType == XmlNodeType.Entity)
                {
                    Console.WriteLine("Entity:" + textReader.Name.ToString());
                    et = et + 1;
                }
                // if node type is a Process Instruction  
                if (nType == XmlNodeType.Entity)
                {
                    Console.WriteLine("Entity:" + textReader.Name.ToString());
                    pi = pi + 1;
                }
                // if node type a document  
                if (nType == XmlNodeType.DocumentType)
                {
                    Console.WriteLine("Document:" + textReader.Name.ToString());
                    dc = dc + 1;
                }
                // if node type is white space  
                if (nType == XmlNodeType.Whitespace)
                {
                    Console.WriteLine("WhiteSpace:" + textReader.Name.ToString());
                    ws = ws + 1;
                }
            }
            // Write the summary  
            Console.WriteLine("Total Comments:" + cc.ToString());
            Console.WriteLine("Total Attributes:" + ac.ToString());
            Console.WriteLine("Total Elements:" + el.ToString());
            Console.WriteLine("Total Entity:" + et.ToString());
            Console.WriteLine("Total Process Instructions:" + pi.ToString());
            Console.WriteLine("Total Declaration:" + xd.ToString());
            Console.WriteLine("Total DocumentType:" + dc.ToString());
            Console.WriteLine("Total WhiteSpaces:" + ws.ToString());*/
        }
    }
}
