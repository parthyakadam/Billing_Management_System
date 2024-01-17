using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Management_System_Assignment
{
    public interface IBillingSystem
    {
        void DisplayAvailableItems(List<Item> items);
        void GenerateInvoice(Invoice invoice);
    }
}
