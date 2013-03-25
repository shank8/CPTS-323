using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Api.Maps.Service.StaticMaps;
using Google.Api.Maps.Service.Geocoding;

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
            var map = new StaticMap();

            map.Center = "970 C st. Pullman, Wa"; // or a lat/lng coordinate
            map.Zoom = "14";
            map.Size = "680x496";
            map.Sensor = "true";

            var url = map.ToUri();

            webBrowser.Url = url;

            var request = new GeocodingRequest();
            
            request.Address = "970 C st. Pullman , Wa";
            request.Sensor = "false";

            var response = GeocodingService.GetResponse(request);

            var result = response.Results.First();

            System.Windows.Forms.MessageBox.Show(result.FormattedAddress);

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

      
    }
}
