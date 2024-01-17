using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinq
{
    internal class Bill
    {
        public Bill(int orderid, string itemName, DateTime orderdate, int totalprice)
        {
            OrderId = orderid;
            ItemName = itemName;
            OrderDate = orderdate;
            TotalPrice = totalprice;
        }
        public int OrderId { get; set; }
        public string ItemName { get; set; }

        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; }
    }
}
