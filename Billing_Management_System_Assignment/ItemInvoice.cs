using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Management_System_Assignment
{
    public class ItemInvoice
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get
            {
                return Item.Price * Quantity;
            }
        }
    }
}
