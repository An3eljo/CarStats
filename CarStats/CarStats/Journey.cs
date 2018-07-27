using System;
using System.Collections.Generic;
using System.Text;

namespace CarStats
{
    public class Journey : List<GeoData>
    {
        public DateTime StartDate;
        public string Name;
        public TimeSpan Duration;

        public Journey() { }

        public Journey(string name, DateTime startDate)
        {
            this.Name = name;
            this.StartDate = startDate;
        }
    }
}
