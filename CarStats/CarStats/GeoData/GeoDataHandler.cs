using System;
using System.Collections.Generic;
using System.Text;
using CarStats.Interfaces;
using Xamarin.Forms;

namespace CarStats
{
    public class GeoDataHandler
    {
        public const string GeoDataFileName = "geoData.xml";

        public static List<Journey> LoadOldJourneys()
        {
            try
            {
                return XmlActions.Deserialize(GeoDataFileName, JourneyCollection.Instance) as List<Journey>;
            }
            catch (Exception )
            {
                
            }

            return null;
        }

        //todo
        public static List<GeoData> LoadGeoDataFromJourney(Journey journey)
        {
            return journey;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="journeyName"></param>
        /// <param name="startDate"></param>
        /// <returns>index of journey instance in journeycollection</returns>
        public static int? CreateJourney(string journeyName, DateTime startDate)
        {
            var newjourney = new Journey(journeyName, startDate);
            JourneyCollection.Instance.Add(newjourney);
            return JourneyCollection.Instance.IndexOf(newjourney);
        }


        public static int? AddGeoDataToJourney(GeoData geoData, Journey journey)
        {
            var journeyToCompare = journey;
            if (!JourneyCollection.Instance.Exists(j => j == journeyToCompare))
            {
                return null;
            }
            if (geoData == null)
            {
                return null;
            }
            journey.Add(geoData);
            return journey.IndexOf(geoData);
        }

        public static void AddLocationToGeoData(GeoData geoData, Location location = null)
        {
            if (geoData == null)
            {
                return;
            }
            if (location == null)
            {
                location = DependencyService.Get<ILocationHandler>(DependencyFetchTarget.NewInstance)
                    .GetLastLocationFromDevice();
            }
            geoData.Location = location;
        }
    }
}
