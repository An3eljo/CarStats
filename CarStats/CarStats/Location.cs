using System;
using System.Collections.Generic;
using System.Text;

namespace CarStats
{
    public class Location
    {
        public double Longtitude;
        public double Latitude;
        public double Altitude;
        public double Speed;

        public Location() { }

        public Location(double latitude, double longtitude, double altitude)
        {
            this.Longtitude = longtitude;
            this.Latitude = latitude;
            this.Altitude = altitude;
        }

        public Location(double latitude, double longtitude, double altitude, double speed)
        {
            this.Longtitude = longtitude;
            this.Latitude = latitude;
            this.Altitude = altitude;
            this.Speed = speed;
        }
    }
}
