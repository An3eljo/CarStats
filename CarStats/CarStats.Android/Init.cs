using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CarStats.Droid.Specific;

namespace CarStats.Droid
{
    public class Init : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static void Initialize()
        {
            new Init().InitializeSystemService();
        }

        public void InitializeSystemService()
        {
            LocationHandler.LocationManager = GetSystemService(LocationService) as LocationManager;
        }
    }
}