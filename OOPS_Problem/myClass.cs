using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Problem
{
    public class myClass
    {
        public List<RiceList> riceList;
        public List<PulseList> pulseList;
        public List<WheatList> wheatList;
    }
    public class RiceList
    {
        public string Name;
        public int Weight;
        public int PricePerKg;
    }
    public class PulseList
    {
        public string Name;
        public int Weight;
        public int PricePerKg;
    }

    public class WheatList
    {
        public string Name;
        public int PricePerKg;
        public int Weight;
    }


}
