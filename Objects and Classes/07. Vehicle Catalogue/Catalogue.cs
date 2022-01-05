using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Vehicle_Catalogue
{
    class Catalogue
    {
        public List<Cars> Car { get; set; }
        public List<Trucks> Truck { get; set; }

        public Catalogue()
        {
            Car = new List<Cars>();
            Truck = new List<Trucks>();
        }
        
    }
}
