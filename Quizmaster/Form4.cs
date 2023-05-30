using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Quizmaster
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnmap_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;

            string json = FetchCurrentIpLocation();

            try
            {
                JObject jsonObject = JObject.Parse(json);
                double latitude = jsonObject.Value<double>("latitude");
                double longitude = jsonObject.Value<double>("longitude");

                PointLatLng point = new PointLatLng(latitude, longitude);
                map.Position = point;
                map.MinZoom = 1;
                map.MaxZoom = 100;
                map.Zoom = 10;

                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
                GMapOverlay markers = new GMapOverlay("markers");
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
            }
            catch (JsonReaderException ex)
            {
                // Handle JSON parsing errors
                Console.WriteLine("Error parsing JSON: " + ex.Message);
            }
        }

        private string FetchCurrentIpLocation()
        {
            string strIpLocation = string.Empty;

            var client = new RestClient("https://ipapi.co/json/");
            var request = new RestRequest()
            {
                Method = Method.Get
            };

            var response = client.Execute(request);
            strIpLocation = response.Content;

            return strIpLocation;
        }
    }
}