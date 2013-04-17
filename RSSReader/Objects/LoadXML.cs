using System;
using System.Xml;
using System.IO;
using System.Text;
using RSSReader.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace LoadHandler
{
    class LoadXML
    {
        [STAThread]
        public void load()
        {
            try
            {
                // Create an XML document instance.
                // The same instance of DOM is used through out this code; this 
                // may or may not be the actual case.
                XmlDocument doc = new XmlDocument();

                // Load the XML data from a file.
                // This code assumes that the XML file is in the same folder.
                doc.Load("../../XMLFeed.xml");

                // Load the XML data from a file stream.
                // You can also use other I/O streams in the same way with the 
                // Load method.
                FileStream fileStrm = new FileStream("../../XMLFeed.xml", FileMode.Open);
                // New content replaces older content because the same DOM is 
                // used.
                doc.Load(fileStrm);
                // Use DOM to manipulate the XML data here.
                // Close any Streams once they are used.
                fileStrm.Close();

                // Load the XML data from a URL.
                // Make sure that the URL points to a correct XML resource.
                //doc.Load("http://localhost/RSS Reader/CPTS-323/RSSReader/Objects/XMLFeed.xml");

                // Load the XML data from a reader object.
                // Preserve the white spaces.
                doc.PreserveWhitespace = true;
                // Read the XML by using XmlTextReader.            
                XmlTextReader rdr = new XmlTextReader("../../XMLFeed.xml");
                rdr.MoveToContent();     // Move to the content nodes.
                rdr.Read();              // Start reading.
                rdr.Skip();              // Skip the root.
                rdr.Skip();              // Skip the first content node.
                doc.Load(rdr);           // Read the second node data into DOM.

                // To load the entire data, pass in the reader object when its
                // state is ReadState.Initial.
                // To do this in the aforementioned code section, comment out 
                // the Skip and MoveToContent method calls.

                // Load the XML strings.
                doc.LoadXml("<Channel><Title><Link><Description>" +
                   "<Item><Title><Link><Description>" +
                   "</Description></Link></Title></Item>" +
                   "</Description></Link></Title></Channel>");

                // doc.LoadXml("<Collection><Book><Title>Priciple of Relativity</Title>" +
                //"<Author>Albert Einstein</Author>" +
                //"<Genre>Physics</Genre></Book></Collection>");

                // Display the content of the DOM document.
                Console.Write("\n{0}\n", doc.OuterXml);
            }
            catch (XmlException xmlEx)   // Handle the XML exceptions here.   
            {
                Console.WriteLine("{0}", xmlEx.Message);
            }
            catch (Exception ex)         // Handle the generic exceptions here.
            {
                Console.WriteLine("{0}", ex.Message);
            }
            finally
            {
                // Finalize here.
            }
        }

        public List<Channel> toList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("test.xml");
            XmlElement root = doc.DocumentElement;
            List<Channel> Channels = new List<Channel>();


            foreach (XmlNode ChannelNode in root.ChildNodes)
            {
                Channel newChannel = new Channel("", "");
                newChannel.mTitle = ChannelNode.ChildNodes[0].InnerText;
                newChannel.mDescription = ChannelNode.ChildNodes[1].InnerText;
                newChannel.mDateAdded = ChannelNode.ChildNodes[2].InnerText;

               

                foreach (XmlNode FeedNode in ChannelNode.ChildNodes)
                {
                   if( FeedNode.Name == "Feed" )
                    {
                        Feed newFeed = new Feed("", "", "");
                        newFeed.mTitle = FeedNode.ChildNodes[0].InnerText;
                        newFeed.mURL = FeedNode.ChildNodes[1].InnerText;
                        newFeed.mDescription = FeedNode.ChildNodes[2].InnerText;
                        newChannel.mFeeds.Add(newFeed);
                    }
                    
                }

                Channels.Add(newChannel);
            }

            return Channels;
        }


    }

}