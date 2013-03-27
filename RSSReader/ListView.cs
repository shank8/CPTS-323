using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.Objects;

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

        public List<Channel> Channels;

        private void button1_Click(object sender, EventArgs e)
        {


            Channels[0].mFeeds[0].refresh( 5);
           
       
            webBrowser.Navigate(Channels[0].mFeeds[0].mArticles[0].mLink);
        }

    }
}
