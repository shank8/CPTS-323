using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XML_Parser
{
    [Serializable()]
    public class State
    {
        //Sample Format
        [XmlAttribute("ID")]
        public int uniqueID;

        [XmlElement("Title")]
        public string title;

        [XmlElement("Category")]
        public string category;

        [XmlElement("Transition")]
        public int transition;

        [XmlElement("Name")]
        public string name;

        [XmlElement("Connect_To")]
        public string connect;

        public State()
        {
            //Sample
            uniqueID = 0;
            title = "N/A";
            category = "N/A";
            transition = 0;
            name = "N/A";
            connect = "N/A";
        }

        public bool canMove(string nextID)
        {
            return connect.Contains(nextID);
        }



        public void print()
        {
            Console.WriteLine("ID: " + uniqueID);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Connects To: " + connect);
            Console.WriteLine("Transition: " + transition);
        }
    }
}

