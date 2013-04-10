using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

using XML_Parser;
namespace XML_Handler
{
    public class Parser
    {
        public List<State> stateList;

        public Parser()
        {
            stateList = new List<State>();
        }

        public bool loadXML(string path)
        {
            Console.WriteLine("Loading XML file from " + @path);
            using (TextReader r = new StreamReader(@path))
            {
                XmlSerializer s = new XmlSerializer(typeof(List<State>));
                stateList = (List<State>)s.Deserialize(r);
            }
            return true;
        }

        public bool saveXML(string path)
        {
            Console.WriteLine("Saving XML file to " + @path);
            using (TextWriter w = new StreamWriter(@path))
            {
                XmlSerializer s = new XmlSerializer(typeof(List<State>));
                s.Serialize(w, stateList);
            }
            return true;
        }
    }
}
