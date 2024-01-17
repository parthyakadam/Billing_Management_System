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
                new Item { Name= "Apple", Price= 50},
                new Item { Name= "Banana", Price= 20},
            };

            bs.DisplayAvailableItems(availableItems);
            Invoice invoice = new Invoice();

            while (true) 
            {
                Console.WriteLine("Enter the items and quantity or enter 'done' to exit");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() == "done")
                {
                    break;
                }

                string[] inputParts = userInput.Split(' ');

                if (inputParts.Length == 2 && int.TryParse(inputParts[1], out int quantity))
                {
                    Item selectedItem = availableItems.Find(item => item.Name == inputParts[0]);

                    if (selectedItem != null)
                    {
                        
                        invoice.AddItem(selectedItem, quantity);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid item. Please select a valid item available");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter correct format");
                }
            }

            bs.GenerateInvoice(invoice);

            Console.ReadLine();
        }
    }
}
