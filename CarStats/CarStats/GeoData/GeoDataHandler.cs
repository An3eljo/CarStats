using System;
using System.Collections.Generic;
using System.Text;

namespace CarStats
{
    public class GeoDataHandler
    {
        public const string GeoDataFileName = "geoData.xml";

        public static List<Journey> LoadOldJourneys()
        {
            try
            {
                return XmlActions.Deserialize(GeoDataFileName, new JourneyCollection()) as List<Journey>;
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
    }
}
