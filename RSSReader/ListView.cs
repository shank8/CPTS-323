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
using LoadHandler;
using SaveHandler;

namespace RSSReader
{
    public partial class ListView : Form
    {
        public ListView(RSSReader menu)
        {
            InitializeComponent();

            Channels = new List<Channel>();
            refreshRate = 5;
            numDisplayArticles = 10;
            this.mainmenu = menu;
            updateTimer();

           
            LoadXML newLoadXML = new LoadXML();
            Channels = newLoadXML.toList();
            refreshAll();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            // When the view loads, we should also load the saved feeds

        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            TreeNode cur = channelTree.SelectedNode;
            if (cur.Index == 0)
            {
                var res = MessageBox.Show("Are you sure?", "Remove Channel",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    Channel result = Channels.Find(
                        delegate(Channel ch)
                        {
                            return ch.mTitle == cur.Text;
                        });
                    if (result != null)
                    {
                        Channels.Remove(result);
                        cur.Remove();
                    }
                }

            }
            else
            {
                MessageBox.Show("This is not a channel", "Ooops");
            }
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

                for (int i = 0; i < numDisplayArticles; ++i) // !!!!! use user-defined number of articles to display/refresh at a time. 10 is arbitrary number !!!!! 
                {
                   // if ((Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i] != null) || (!Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].isIncomplete()))
                   // {
                        it = articleListView.Items.Add(Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].mTitle);
                        it.SubItems.Add(Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].mDescription);
                        it.SubItems.Add(Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].mPubDate.ToString());
                        it.SubItems.Add(Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].mLink);
                  //  }
                }
                articleListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
    

    }

       

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            channelTree.Nodes.Clear();
            Channels.Sort(delegate(Channel c1, Channel c2) { return c1.mTitle.CompareTo(c2.mTitle); });

            for (int i = 0; i < Channels.Count; i++)
            {
                channelTree.Nodes.Add(Channels[i].mTitle);

                for (int j = 0; j < Channels[i].mFeeds.Count; j++)
                {
                    channelTree.Nodes[i].Nodes.Add(Channels[i].mFeeds[j].mTitle);
                }
            }
            
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            channelTree.Nodes.Clear();
            Channels.Sort(delegate(Channel c1, Channel c2) { return c1.mDateAdded.CompareTo(c2.mDateAdded); });

            for (int i = 0; i < Channels.Count; i++)
            {
                channelTree.Nodes.Add(Channels[i].mTitle);

                for (int j = 0; j < Channels[i].mFeeds.Count; j++)
                {
                    channelTree.Nodes[i].Nodes.Add(Channels[i].mFeeds[j].mTitle);
                }
            }

        }
 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML newXMLSave = new SaveXML();
            newXMLSave.toXMLDoc( Channels );
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXML newLoadXML = new LoadXML();
            Channels = newLoadXML.toList();
            refreshAll();
        }


        private void RefreshRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as ToolStripMenuItem;
            var menuText = clickedMenuItem.Text;

            switch (menuText)
            {
                case "Every 5 Minutes":
                    refreshRate = 5;
                    break;

                case "Every 10 Minutes":
                    refreshRate = 10;
                    break;

                case "Every 15 Minutes":
                    refreshRate = 15;
                    break;

                case "Every Hour":
                    refreshRate = 60;
                    break;

            }
        }

        private void DisplayArticlesNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clickedMenuItem = sender as ToolStripMenuItem;
            var menuText = clickedMenuItem.Text;

            switch (menuText)
            {
                case "5 Articles":
                    numDisplayArticles = 5;
                    MessageBox.Show("here");
                    break;

                case "10 Articles":
                    numDisplayArticles = 10;
                    break;

                case "15 Articles":
                    numDisplayArticles = 15;
                    break;

                case "20 Articles":
                    numDisplayArticles = 20;
                    break;
            }

            refreshAll();
        }

        private void updateTimer()
        {
            timer1.Interval = refreshRate * 60 * 1000; //If refresh is 5, it is every 5 minutes
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshAll();
        }

        public void refreshAll()
        {
            channelTree.Nodes.Clear();

            for (int i = 0; i < Channels.Count; i++)
            {
                channelTree.Nodes.Add(Channels[i].mTitle);
                
                for( int j = 0 ; j < Channels[i].mFeeds.Count; j++)
                {
                    channelTree.Nodes[i].Nodes.Add(Channels[i].mFeeds[j].mTitle);
                }
            }

            articleListView.Items.Clear();

            foreach (Channel i in Channels)
                foreach (Feed j in i.mFeeds)
                    j.refresh(numDisplayArticles);
        }

    

        private void articleListView_ItemActivate(object sender, EventArgs e)
        {
            var a = articleListView.SelectedItems[0].SubItems[3].Text;
            webBrowser.Navigate(a);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML newXMLSave = new SaveXML();
            newXMLSave.toXMLDoc(Channels);
            Application.Exit();
        }

        public List<Channel> Channels;
        public Feed currentFeed;
        public int refreshRate;
        public int numDisplayArticles;

        public ListViewItem it;
        public RSSReader mainmenu;

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.ActiveForm.Hide();
            mainmenu.Show();
        }

        

     




    }
}
