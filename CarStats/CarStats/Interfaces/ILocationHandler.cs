using System;
using System.Collections.Generic;
using System.Text;

namespace CarStats.Interfaces
{
    interface ILocationHandler
    {
        Location GetLastLocationFromDevice();
    }
}
