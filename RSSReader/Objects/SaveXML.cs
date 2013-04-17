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


namespace SaveHandler
{
   class SaveXML
   {
      [STAThread]
      public void save( List<Channel> Channels)
      {
          
         try
         {
            // Create an XML document instance and load the XML data.
            XmlDocument doc  = new XmlDocument();
            doc = toXMLDoc( Channels );
            // This code assumes that the XML file is in the same folder.
            doc.Load("../../XMLFeed.xml");                      

            // Save the XML to a file.
            doc.Save("../../XMLFeed.xml");

            // Save the XML to a memory stream.
            MemoryStream memStream = new MemoryStream();
            ASCIIEncoding AE = new ASCIIEncoding();
            string xmlStr = doc.DocumentElement.OuterXml;
            memStream.Write(AE.GetBytes(xmlStr), 0, xmlStr.Length);
            // Use the data from the stream here.
            memStream.Close();

            // Save the XML to XmlWriter with Unicode encoding.
            // Preserve the whitespace.
            doc.PreserveWhitespace = true;                   
            XmlTextWriter wrtr = new XmlTextWriter("XML_Writer.xml", Encoding.Unicode);
            wrtr.WriteRaw(xmlStr);
            wrtr.Close();
         }
         catch(XmlException xmlEx)   // Handle the XML exceptions here.         
         {
            Console.WriteLine("{0}", xmlEx.Message);
         }
         catch(Exception ex)         // Handle the generic exceptions here.
         {
            Console.WriteLine("{0}", ex.Message);
         }
         finally
         {
            // Finalize here.
         }
      }

      public XmlDocument toXMLDoc(List<Channel> Channels)
      {

          XmlDocument doc = new XmlDocument();
          XmlWriterSettings settings = new XmlWriterSettings();
          settings.Indent = true;
          settings.NewLineOnAttributes = true;
     

            

          using (XmlWriter writer = XmlWriter.Create("test.xml", settings))
          {
              writer.WriteStartDocument();

              writer.WriteStartElement("Collection");

              foreach (Channel c in Channels)
              {
                  writer.WriteStartElement("Channel");
                  writer.WriteElementString("Title", c.mTitle);
                  writer.WriteElementString("Description", c.mDescription);
                  writer.WriteElementString("DateAdded", c.mDateAdded.ToString());


                  foreach (Feed f in c.mFeeds)
                  {
                      writer.WriteStartElement("Feed");
                      writer.WriteElementString("Title", f.mTitle);
                      writer.WriteElementString("URL", f.mURL);
                      writer.WriteElementString("Description", f.mDescription);
                      writer.WriteEndElement();


                  }
                  
                  writer.WriteEndElement();
              }

              writer.WriteEndElement();
          }


          //doc.Load("../../Test.xml");
          return doc;
      }



   }

}