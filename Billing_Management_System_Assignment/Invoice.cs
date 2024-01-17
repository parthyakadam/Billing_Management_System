using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Management_System_Assignment
{
    public class Invoice
    {
        //private List<ItemInvoice> ItemsList = new List<ItemInvoice>();

        //public List<ItemInvoice> GetItems() { return ItemsList; }

        public List<ItemInvoice> ItemsList { get; } = new List<ItemInvoice>();

        public float GrandTotal
        {
            get
            {
                float total = 0;

                foreach (ItemInvoice item in ItemsList)
                {
                    total += item.TotalPrice;
                }

                return total;
            }
        }

        public void AddItem(Item i1, int quantiy)
        {
            ItemsList.Add(new ItemInvoice { Item = i1, Quantity = quantiy });
        }

        public string DisplayItemsList()
        {
            StringBuilder sb = new StringBuilder();

            foreach (ItemInvoice item in ItemsList)
            {
                sb.AppendLine(item.Item.Name + " --> " + item.Quantity + " --> " + item.TotalPrice);
            }

            return sb.ToString();
        }
    }
}
