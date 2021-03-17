using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO3_ClassicModelsUI
{
    public class Customer
    {
        public String  CustomerName { get; set; }

        public string getCustomerName()
        {
            return CustomerName;
        }

        public string Info
        {
            get
            {
                return $"{CustomerName}";
            }
        }
    }
}
