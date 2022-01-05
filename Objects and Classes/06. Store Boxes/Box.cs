using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }

        public string Serialnumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }
    }
}
