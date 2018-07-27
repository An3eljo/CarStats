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
using CarStats.Droid.Specific;
using CarStats.Interfaces;
using Xamarin.Forms;

[assembly:Dependency(typeof(LocationHandler))]
namespace CarStats.Droid.Specific
{
    class LocationHandler : ILocationHandler
    {
        public static LocationManager LocationManager;
        public Location GetLastLocationFromDevice()
        {
            var criteria = new Criteria { PowerRequirement = Power.Medium };

            var bestProvider = LocationManager.GetBestProvider(criteria, true);
            var androidLocation = LocationManager.GetLastKnownLocation(bestProvider);
            
            return androidLocation != null ? CreateLocation(androidLocation) : null;
        }

        private Location CreateLocation(Android.Locations.Location androidLocation)
        {
            if (androidLocation.HasSpeed)
            {
                return new Location(androidLocation.Latitude, androidLocation.Longitude, androidLocation.Altitude, androidLocation.Speed);
            }

            return new Location(androidLocation.Latitude, androidLocation.Longitude, androidLocation.Altitude);
        }
    }
}