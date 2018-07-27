using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CarStats.Droid.Specific;
using CarStats.Interfaces;
using Xamarin.Forms;

[assembly:Dependency(typeof(ManifestData))]
namespace CarStats.Droid.Specific
{
    class ManifestData : IManifestData
    {
        public string FineLocationGranted()
        {
            //try
            //{
            //    PackageInfo info = Context.getPackageManager().getPackageInfo(
            //        context.getPackageName(), 0);
            //    targetSdkVersion = info.applicationInfo.targetSdkVersion;
            //}
            //catch (PackageManager.NameNotFoundException e)
            //{
            //    e.printStackTrace();
            //}
            //if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
            //{
            //    if ()
            //    {

            //    }
            //}
            return Manifest.Permission.AccessFineLocation;
        }
    }
}