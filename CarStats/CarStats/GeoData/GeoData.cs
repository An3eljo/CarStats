﻿using System;
using System.Collections.Generic;
using System.Text;
using CarStats.Interfaces;

namespace CarStats
{
    public class GeoData
    {
        public DateTime CaptureTime;
        public Location Location;

        public GeoData() { }

        public GeoData(DateTime capureTime)
        {
            CaptureTime = capureTime;
        }
    }
}
