using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CarStats.Interfaces;

namespace CarStats.Droid
{
    class Location : ILocation
    {
        public void GetLastLocationFromDevice()
        {
            var locationManager = GetSystemService(LocationService) as LocationManager;
            //getLastLocationButton.SetText(Resource.String.getting_last_location);

            var criteria = new Criteria { PowerRequirement = Power.Medium };

            var bestProvider = locationManager.GetBestProvider(criteria, true);
            var location = locationManager.GetLastKnownLocation(bestProvider);

            if (location != null)
            {
                latitude.Text = Resources.GetString(Resource.String.latitude_string, location.Latitude);
                longitude.Text = Resources.GetString(Resource.String.longitude_string, location.Longitude);
                provider.Text = Resources.GetString(Resource.String.provider_string, location.Provider);
                getLastLocationButton.SetText(Resource.String.get_last_location_button_text);
            }
            else
            {
                latitude.SetText(Resource.String.location_unavailable);
                longitude.SetText(Resource.String.location_unavailable);
                provider.Text = Resources.GetString(Resource.String.provider_string, bestProvider);
                getLastLocationButton.SetText(Resource.String.get_last_location_button_text);
            }
        }
    }
}