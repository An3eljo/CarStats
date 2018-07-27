using System;
using System.Collections.Generic;
using System.Text;

namespace CarStats
{
    public sealed class JourneyCollection : List<Journey>
    {
        private static volatile JourneyCollection _instance;
        private static object locker = new object();

        private JourneyCollection()
        {
        }

        public static JourneyCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (locker)
                    {
                        if (_instance == null)
                            _instance = new JourneyCollection();
                    }
                }

                return _instance;
            }
        }
    }
}
