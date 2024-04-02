using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceChecker
{
    internal class TrackerItem
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Selector { get; set; }
        public string LastChecked { get; set; }
        public string LastChanged { get; set; }
        public string PrevVal { get; set; }
        public string CurrVal { get; set; }
        public bool FlagForChange { get; set; }

    }
}
