using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CarStats.Interfaces;
using Xamarin.Forms;
using PCLStorage;

namespace CarStats
{
    public class Init
    {
        public static void Initialize()
        {
            IsPermissionFineLocationGranted();
            //CheckFiles();
        }

        /*bool IsGooglePlayServicesInstalled()
        {
            var queryResult = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (queryResult == ConnectionResult.Success)
            {
                Log.Info("MainActivity", "Google Play Services is installed on this device.");
                return true;
            }

            if (GoogleApiAvailability.Instance.IsUserResolvableError(queryResult))
            {
                // Check if there is a way the user can resolve the issue
                var errorString = GoogleApiAvailability.Instance.GetErrorString(queryResult);
                Log.Error("MainActivity", "There is a problem with Google Play Services on this device: {0} - {1}",
                    queryResult, errorString);

                // Alternately, display the error to the user.
            }

            return false;
        }*/

        //todo: check if permission is granted
        private static bool IsPermissionFineLocationGranted()
        {
            var permission = DependencyService.Get<IManifestData>().FineLocationGranted();
            return true;
        }

        private static void CheckFiles()
        {
            var rootfolder = PCLStorage.FileSystem.Current.LocalStorage;
            var t = Task.Run(() => rootfolder.GetFileAsync(GeoDataHandler.GeoDataFileName)).Result;
            if (Task.Run(() => rootfolder.GetFileAsync(GeoDataHandler.GeoDataFileName)).Result == null)
            {
                
            }
        }
    }
}
