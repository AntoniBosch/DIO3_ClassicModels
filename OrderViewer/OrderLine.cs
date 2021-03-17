using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderViewer
{
    class OrderLine
    {
        public string ProductName { get; set; }
        public int QuantityOrdered { get; set; }
        public double PriceEach { get; set; }
        public byte[] Image { get; set; }
    }
}
