using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.Objects;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

using XML_Handler;
using XML_Parser;

namespace RSSReader
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();

            Channels = new List<Channel>();


        }

        private void ListView_Load(object sender, EventArgs e)
        {
            // When the view loads, we should also load the saved feeds

        }

        private void remBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            addChannel newChannel = new addChannel(channelTree, Channels);
            newChannel.Show();

        }


        private void channelTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Level == 0) // This is used to create a new feed in a channel
            {
                addFeed newfeed = new addFeed(e.Node, channelTree, Channels);

                newfeed.Show();
            }
            else // This is used to initiate the RSS retrieval
            {

            }
        }

       

        private void channelTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > 0) //not a channel
            {

                int ChannelIndex = e.Node.Parent.Index;
                int FeedIndex = e.Node.Index;
                    currentFeed = Channels[ChannelIndex].mFeeds[FeedIndex];

                for (int i = 0; i < 10; ++i) // !!!!! use user-defined number of articles to display/refresh at a time. 10 is arbitrary number !!!!! 
                {
                    if ((Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i] != null) || (!Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].isIncomplete()))
                    {
                        ArticleTreeView.Nodes.Add(Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].mTitle);
                        Article currentArticle = Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i];
                        ArticleTreeView.Nodes[i].Nodes.Add("Description: " + currentArticle.mDescription );
                        ArticleTreeView.Nodes[i].Nodes.Add("Link: " + currentArticle.mLink);
                        ArticleTreeView.Nodes[i].Nodes.Add("Publish Date: " + currentArticle.mPubDate);

                    }
                }

            }
    

    }

        private void ArticleTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                webBrowser.Navigate(currentFeed.mArticles[e.Node.Index].mLink);
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            channelTree.Nodes.Clear();
          //  Channels.OrderBy( Channels[0].mTitle );
           // Channels[0].mFeeds


           
        
        }

        void sortByDate( )
        {
            List<Channel> newList = new List<Channel>();

            for( int i = 0; i < Channels.Count; i++ )
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //http://support.microsoft.com/kb/815813

        }


        public bool loadXML(string path)
        {
           
            Console.WriteLine("Loading XML file from " + @path);
            using (TextReader r = new StreamReader(@path))
            {
                XmlSerializer s = new XmlSerializer(typeof(List<State>));
                parser.stateList = (List<State>)s.Deserialize(r);
            }
            return true;
        }

        public bool saveXML(string path)
        {
            Console.WriteLine("Saving XML file to " + @path);
            using (TextWriter w = new StreamWriter(@path))
            {
                XmlSerializer s = new XmlSerializer(typeof(List<State>));
                s.Serialize(w, parser.stateList);
            }
            return true;
        }
        public List<Channel> Channels;
        public Feed currentFeed;
        public Parser parser = new Parser();

    }
}
