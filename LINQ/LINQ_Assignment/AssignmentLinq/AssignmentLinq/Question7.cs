using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    internal class Question7
    {
        List<Order> list = new List<Order>()
            {
                 new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,12,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
    }
}
