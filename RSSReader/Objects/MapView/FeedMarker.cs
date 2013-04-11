﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RSSReader.Objects;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.Properties;
using GMap.NET.MapProviders;
using GMap.NET.ObjectModel;
using GMap.NET.Projections;
using GMap.NET.Analytics;
using GMap.NET.WindowsForms.Markers;

using System.Drawing;

namespace RSSReader.Objects.MapView
{
    public class FeedMarker
    {
        public FeedMarker(PointLatLng loc, Feed fd, GMapControl gmap)
        {
            location = loc;
            feed = fd;
            this.gmap = gmap;
            addPIN(gmap.Position);
        }

        private void addPIN(PointLatLng point)
        {
            GMapOverlay markersOverlay = new GMapOverlay(gmap, "marker");
            this.marker = new GMapMarkerGoogleRed(point);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
        }

        /*
         * This custom marker will show information
         * about the correlated feed and will also
         * have a custom image to display
         */
        private Bitmap bitmap;
        private GMapControl gmap;
        private GMapMarkerGoogleRed marker;
        public EventHandler eHandler;
        public PointLatLng location;
        
        public Feed feed;
    }
}
