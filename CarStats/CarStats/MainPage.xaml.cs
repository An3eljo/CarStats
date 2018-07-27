using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PCLStorage;

namespace CarStats
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Test();
		    ButtonStartStop.Text = "Start";
		}

	    private void Test()
	    {
	        GeoDataHandler.CreateJourney("testjourney1", DateTime.Now);

            var newGeoData1 = new GeoData();
            GeoDataHandler.AddLocationToGeoData(newGeoData1);
            newGeoData1.CaptureTime = DateTime.Now;
	        GeoDataHandler.AddGeoDataToJourney(newGeoData1, JourneyCollection.Instance[0]);

	        var newGeoData2 = new GeoData();
	        GeoDataHandler.AddLocationToGeoData(newGeoData2);
	        newGeoData2.CaptureTime = DateTime.Now;
	        GeoDataHandler.AddGeoDataToJourney(newGeoData2, JourneyCollection.Instance[0]);

            var newGeoData3 = new GeoData();
	        GeoDataHandler.AddLocationToGeoData(newGeoData3);
	        newGeoData3.CaptureTime = DateTime.Now;
	        GeoDataHandler.AddGeoDataToJourney(newGeoData3, JourneyCollection.Instance[0]);

	        var t = JourneyCollection.Instance;
	    }

	    private void ButtonStartStop_OnClicked(object sender, EventArgs e)
	    {
	        ButtonStartStop.Text = ButtonStartStop.Text == "Start" ? "Stop" : "Start";
	    }
	}
}
