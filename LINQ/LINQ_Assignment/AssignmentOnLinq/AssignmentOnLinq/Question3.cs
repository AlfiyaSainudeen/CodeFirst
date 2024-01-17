using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinq
{
    internal class Question3
    {
        static void Main()
        {
            //Question 3 Create an Order class that has order id, item name, order date and quantity. Create a collection of Order objects.
            //Display the data day wise from most recently ordered to least recently ordered and by quantity from highest to lowest.

            List<Order> orderList = new List<Order>()
            {
                new Order(1, "laptop",new DateTime(2020, 2, 2),4),
                new Order(2, "mouse",new DateTime(2023, 3, 3),1),
                new Order(3, "salt",new DateTime(2021, 4, 13),2),
                new Order(4, "sugar",new DateTime(2010, 1, 20),3),
                new Order(5, "teapowder",new DateTime(2024, 12, 23),1),
               
            };
            //day wise from most recently ordered to least recently ordered
            var result = orderList.OrderByDescending(o => o.OrderDate);
            Console.WriteLine("Date wise:");
            foreach (var f in result)
            {
                Console.WriteLine($"Id:{f.OrderId} Name:{f.ItemName} Date:{f.OrderDate} Quantity:{f.Quantity}");
            }
            Console.WriteLine();
            //By quantity from highest to lowest
            result = orderList.OrderByDescending(f => f.Quantity);
            Console.WriteLine("Quantity wise:");
            foreach (var f in result)
            {
                Console.WriteLine($"Id:{f.OrderId} Name:{f.ItemName} Date:{f.OrderDate} Quantity:{f.Quantity}");
            }
            Console.WriteLine();

            //Question 4 
            //. For the previous exercise, write a LINQ query that displays the details grouped by the month in the descending order of the order date.
            //month in desending order?
            var result3 = orderList.OrderByDescending(f => f.OrderDate).GroupBy(f => f.OrderDate.Month);

            Console.WriteLine();
            foreach (var r in result3)
            {
                Console.WriteLine("Month: " + r.Key);
                foreach (var o in r)
                {
                    Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.OrderDate} Quantity:{o.Quantity}");
                }
            }

            Console.WriteLine();
        }
    }
}
