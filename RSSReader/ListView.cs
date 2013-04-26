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

            filterType = 1;
            Channels = new List<Channel>();
            refreshRate = 5;
            numDisplayArticles = 10;
            this.menu = menu;
            updateTimer();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            // When the view loads, we should also load the saved feeds
            LoadXML newLoadXML = new LoadXML();
            Channels = newLoadXML.toList();
            refreshAll();
        }

        private void remBtn_Click(object sender, EventArgs e)
        {
            if (channelTree.SelectedNode.Level == 0)
            {
                Channel ch;

                ch = Channels.Find(
                    delegate(Channel csh)
                    {
                        return (csh.mTitle == channelTree.SelectedNode.Text);
                    });

                if (ch != null)
                {
                    Channels.Remove(ch);
                    refreshAll();
                    SaveXML newXMLSave = new SaveXML();
                    newXMLSave.toXMLDoc(Channels);
                }

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

                articleListView.Items.Clear();
                currentFeed.Filter(filterType);

                for (int i = 0; i < numDisplayArticles; ++i) // !!!!! use user-defined number of articles to display/refresh at a time. 10 is arbitrary number !!!!! 
                {
                    //  if ((Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i] != null) || (!Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i].isIncomplete()))
                    //  {

                    Article cur = Channels[ChannelIndex].mFeeds[FeedIndex].mArticles[i];
                    ListViewItem it = articleListView.Items.Add(cur.mTitle);
                    it.SubItems.Add(cur.mDescription);
                    it.SubItems.Add(cur.mPubDate.ToString());
                    it.SubItems.Add(cur.mLink);

                    //  }
                }
                articleListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

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
            filterType = 1;
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
            filterType = 2;
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
            newXMLSave.toXMLDoc(Channels);
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

                for (int j = 0; j < Channels[i].mFeeds.Count; j++)
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

            webBrowser.Navigate(articleListView.SelectedItems[0].SubItems[3].Text);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXML newXMLSave = new SaveXML();
            newXMLSave.toXMLDoc(Channels);
            this.Hide();
            menu.Show();
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
        public RSSReader menu;
        public int filterType;

        private void channelTree_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            foreach (Channel ch in Channels)
            {
                if (ch.mTitle == e.Node.Text)
                {
                    toolTip1.Show(ch.mDescription, channelTree);

                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Channel ch;
                Channel editCh;

                ch = Channels.Find(
                    delegate(Channel csh)
                    {
                        return (csh.mTitle == channelTree.SelectedNode.Text);
                    });
                editCh = ch;
                if (ch != null)
                {
                    
                    Channels.Remove(ch);
                    refreshAll();
                    SaveXML newXMLSave = new SaveXML();
                    newXMLSave.toXMLDoc(Channels);
                }


                // Now create a new one
                if (editCh != null)
                {
                    addChannel edit = new addChannel(channelTree, Channels, editCh.mTitle, editCh.mDescription);
                    edit.Show();
                }
            }
        

    }
}
