using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.Properties;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.Analytics;
using GMap.NET.WindowsForms.Markers;
using RSSReader.Objects.MapView;
using RSSReader.Objects;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using LoadHandler;
using SaveHandler;

namespace RSSReader
{
    public partial class MapView : Form
    {
        public MapView(RSSReader menu)
        {
            InitializeComponent();

            Channels = new List<Channel>();
            myCities = new CityHT();
            StreamReader fileStream = new StreamReader("../../Objects/MapView/USCities.txt");
            myCities.FileParse(fileStream);
            refreshRate = 5;
            numDisplayArticles = 10;
           
            this.menu = menu;
            updateTimer();
            fmList = new List<FeedMarker>();
          
        }


        private void MapView_Load(object sender, EventArgs e)
        {
            // When the view loads, we should also load the saved feeds
             // Initialize map:
              gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
              GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
              gmap.SetCurrentPositionByKeywords("United States");
              gmap.Zoom = 4;

              LoadXML newLoadXML = new LoadXML();
              Channels = newLoadXML.toList();
              refreshAll();
              
        }

        private void addPIN(PointLatLng point, Article art)
        {
            FeedMarker fm = new FeedMarker(point, art, gmap);
            this.fmList.Add(fm);
        }

    
        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Process.Start(item.ToolTipText); // Open up the article


            // Search the list of FeedMarkers for this article
           
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

                foreach (Article a in currentFeed.mArticles)
                {
                    City result = myCities.getCity(a.mTitle);
                    if (result != null)
                    {
                        PointLatLng point = new PointLatLng(result.mLatitude, -result.mLongitude);
                        addPIN(point, a);
                    }
                }

                mapList.Items.Clear();
                foreach (FeedMarker found in fmList)
                {

                    if (found != null) // If found, add it to the list
                    {

                        vItem = mapList.Items.Add(found.article.mTitle);
                        vItem.SubItems.Add(found.article.mDescription);
                        vItem.SubItems.Add(found.article.mPubDate.ToString());
                        vItem.SubItems.Add(found.article.mLink);
                    }
                }

                mapList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
               

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

            mapList.Items.Clear();

            foreach (Channel i in Channels)
                foreach (Feed j in i.mFeeds)
                    j.refresh(numDisplayArticles);
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


        ListViewItem vItem;
        List<FeedMarker> fmList;
        RSSReader menu;
        CityHT myCities;

        private void mapList_ItemActivate(object sender, EventArgs e)
        {
            Process.Start(mapList.SelectedItems[0].SubItems[3].Text); // Open up the article
        }

        
      
    }
}
