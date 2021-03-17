using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO3_ClassicModelsUI
{
    public class OrderSelectedEventArgs: EventArgs
    {
        public int OrderNumber { get; set; }
    }
}
