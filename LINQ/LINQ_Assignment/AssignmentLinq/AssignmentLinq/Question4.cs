using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
  

    internal class Question4
    {
         
        static void Main()
        {
            List<Order> list = new List<Order>()
            {
                 new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
            var s = list.OrderByDescending(a => a.date.Month);
            foreach (var o in s)
            {
                Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.date.ToShortDateString()} Qty:{o.Qty}");
            }
        }
    }
}
