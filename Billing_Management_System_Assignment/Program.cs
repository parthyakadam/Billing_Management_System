using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Management_System_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------\n" +
                "Welcome to Billing Management System:\n" +
                "----------------------------------------");

            BillingSystem bs = new BillingSystem();
            List<Item> availableItems = new List<Item>
            {
                new Item { Id= 1, Name= "Apple", Price= 50},
                new Item { Id= 2, Name= "Banana", Price= 20},
            };

            bs.DisplayAvailableItems(availableItems);
            Invoice invoice = new Invoice();

            while (true) 
            {
                Console.WriteLine("Enter the item id: ");
                int userItem = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the quantity");
                int userQty = int.Parse(Console.ReadLine());

                Item selectedItem = availableItems.Find(item => item.Id == userItem);
                
                if (selectedItem != null)
                {
                        
                    invoice.AddItem(selectedItem, userQty);
                        
                }
                else
                {
                    Console.WriteLine("Invalid item. Please select a valid item available");
                }

                Console.WriteLine("Do you want to continue shupping? Press 'y' for yes and 'n' for no");
                string flag = Console.ReadLine();
                

                if (flag.ToLower() == "n")
                {
                    break;
                }
            }

            bs.GenerateInvoice(invoice);

            Console.ReadLine();
        }
    }
}
