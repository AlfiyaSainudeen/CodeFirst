using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    class Order
    {
        public Order(int orderId, string itemName, DateTime date, int qty)
        {
            OrderId = orderId;
            ItemName = itemName;
            this.date = date;
            Qty = qty;
        }

        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime date { get; set; }
        public int Qty { get; set; }
    }
    internal class Question3
    {
        static void Main()
        {
            /*   3.Create an Order class that has order id, item name, order date and quantity.Create a collection of Order objects.
                Display the data day wise from most recently ordered to least recently ordered and by quantity from highest to lowest.*/
            List<Order> list = new List<Order>()
            {
                 new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };

            var s = list.OrderByDescending(o => o.date);
            foreach (Order o in s)
            {
                Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.date.ToShortDateString()} Qty:{o.Qty}");
            }
            var s1 = list.OrderByDescending(o => o.Qty);
            Console.WriteLine();
            foreach (Order o in s1)
            {
                Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.date.ToShortDateString()} Qty:{o.Qty}");
            }
        }
    }
}

