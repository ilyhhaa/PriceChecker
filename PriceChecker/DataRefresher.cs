using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChecker
{
    internal class DataRefresher
    {
        public static Form1 form1;
        public static List<TrackerItem> trackers;
        public static bool keepRunning;
        internal static int frequency;
        internal static Thread threadHandle;

        public static void RefreshData()
        {

        }
    }
}
