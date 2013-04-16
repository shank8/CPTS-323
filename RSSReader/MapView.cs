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

namespace RSSReader
{
    public partial class MapView : Form
    {
        public MapView()
        {
            InitializeComponent();
        }

        private void MapView_Load(object sender, EventArgs e)
        {
            // When the view loads, we should also load the saved feeds
             // Initialize map:
              gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
              GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
              gmap.SetCurrentPositionByKeywords("United States");
              gmap.Zoom = 4;
              
              addPIN(gmap.Position);
        }

        private void addPIN(PointLatLng point)
        {
            FeedMarker fm = new FeedMarker(point, new Feed("Cherry Blossom Testing Facility", "There is a lot of cool stuff here to do", "http://rss.cnn.com/rss/cnn_topstories.rss"), gmap);
            this.fmList.Add(fm);
        }

        private void remBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
          //  addChannel newChannel = new addChannel();
           // newChannel.Show();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Process.Start(item.ToolTipText); // Open up the article

            // Search the list of FeedMarkers for this article

            FeedMarker found = fmList.Find(
                delegate(FeedMarker fm)
                {
                    return fm.feed.mURL == item.ToolTipText;
                });

            if (found != null) // If found, add it to the list
            {
                mapList.Items.Clear();
                vItem = mapList.Items.Add(found.feed.mTitle);
                vItem.SubItems.Add(found.feed.mDescription);
            }
        }

        ListViewItem vItem;
        List<FeedMarker> fmList;
      
    }
}
