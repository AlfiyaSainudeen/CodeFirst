using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    class Item
    {
        public Item(string Name, double price)
        {
            ItemName = Name;
            Price = price;
        }
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
    internal class Question5
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
          
            var query = from order in list
                        join item in items on order.ItemName equals item.ItemName
                        group new { order.OrderId, order.ItemName, order.date, TotalPrice = item.Price * order.Qty }
                        by new { Month = order.date.Month }
                      into groupedOrders
                        orderby  groupedOrders.Key.Month descending
                        select groupedOrders;
            foreach(var group in query)
            {
                foreach(var order in group)
                {
                    Console.WriteLine($"OrderId:{order.OrderId} ItemName:{order.ItemName},OrderDate:{order.date},TotalPrice:{order.TotalPrice:C}");
                }
            }

        }

    }
}
