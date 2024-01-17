using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    internal class Question6
    {
        static void Main()
        {
            List<Order> list = new List<Order>()
            {
                 new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,12,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
            List<Item> items = new List<Item>()
            {
                new Item("pencil",50),new Item("box",20),
                new Item("pen",100),new Item("notes",200)
            };
            var priceList = from price in items
                            join order in list
                            on price.ItemName equals order.ItemName
                            select new { orderId = order.OrderId, itemName = order.ItemName, orderDate = order.date, totalprice = order.Qty * price.Price };
            Console.WriteLine("Order Price using Anonymous Types");
            foreach (var item in priceList)
            {
                Console.WriteLine($"OrderId: {item.orderId} ItemName:{item.itemName} OrderDate:{item.orderDate.ToShortDateString()} TotalPrice:{item.totalprice}");
            }

        }
    }
}
