using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Management_System_Assignment
{
    public class BillingSystem : IBillingSystem
    {
        public void DisplayAvailableItems(List<Item> items)
        {
            Console.WriteLine("List of available items: ");

            foreach(Item item in items)
            {
                Console.WriteLine(item.Name + " --> " +item.Price);
            }
        }

        public void GenerateInvoice(Invoice invoice)
        {
            Console.WriteLine("---------------\n" +
                "Invoice Bill: \n" +
                "---------------");

            Console.WriteLine(invoice.DisplayItemsList());

            Console.WriteLine("------------------------------\n" +
                "Grand Total: " + invoice.GrandTotal);
            
        }
    }
}
