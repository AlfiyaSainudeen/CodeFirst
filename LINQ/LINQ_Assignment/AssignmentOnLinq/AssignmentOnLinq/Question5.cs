using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentOnLinq
{
    internal class Question5
    {
        static void Main()
        {
            //Question 5
            //. You have created Order class in the previous exercise and that has order id , item name, order date and quantity .
            //Create another class called Item that has item name and  price. Write a LINQ query such that it returns
            //order id, item name, order date and the total price (price * quantity ) grouped by the month in the descending order of the order date.lis
            List<Order> orderList = new List<Order>()
            {
                new Order(1, "laptop",new DateTime(2020, 2, 2),4),
                new Order(2, "mouse",new DateTime(2023, 3, 3),1),
                new Order(3, "salt",new DateTime(2021, 4, 13),2),
                new Order(4, "sugar",new DateTime(2010, 1, 20),3),
                new Order(5, "teapowder",new DateTime(2024, 12, 23),1),

            };
            List<Item> itemPriceList = new List<Item>()
            {
                new Item("laptop",35),
                new Item("mouse",107),
                new Item("salt",10),
                new Item("sugar",45),
                new Item("teapowder",95),
                
            };

            var result4 = from order in orderList
                          join price in itemPriceList
                          on order.ItemName equals price.ItemName
                          select new Bill(order.OrderId, price.ItemName, order.OrderDate, price.Price * order.Quantity);
            Console.WriteLine("Order Price");
            foreach (var item in result4)
            {
                Console.WriteLine($"OrderId: {item.OrderId} ItemName:{item.ItemName} OrderDate:{item.OrderDate.ToShortDateString()} TotalPrice:{item.TotalPrice}");
            }

            Console.WriteLine();

            //Question 6
            //. Do the previous exercise using anonymous types.


            var result5 = from price in itemPriceList
                          join order in orderList
                          on price.ItemName equals order.ItemName
                          select new { orderId = order.OrderId, itemName = order.ItemName, orderDate = order.OrderDate, totalprice = order.Quantity * price.Price };
            Console.WriteLine("Order Price using Anonymous Types");
            foreach (var item in result5)
            {
                Console.WriteLine($"OrderId: {item.orderId} ItemName:{item.itemName} OrderDate:{item.orderDate.ToShortDateString()} TotalPrice:{item.totalprice}");
            }
            Console.WriteLine();


            //Question 7
            //. Check if all the quantities in the Order collection is >0.
           // Get the name of the item that was ordered in largest quantity in a single order. (Hint: use LINQ methods to sort)
           //Find if there are any orders placed before Jan of this year.


            var countBeforeCheckingQuantity = orderList.Count;
            var result6 = from order in orderList
                          where order.Quantity > 0
                          select order;
            var countAfterCheckingQuantity = result6.Count();
            if (countAfterCheckingQuantity == countBeforeCheckingQuantity)
            {
                Console.WriteLine("the orders does not contain a quantity less than 1");
            }
            else
            {
                Console.WriteLine("the orders does  contain  quantity less than 1");
            }

            var itemNames = from order in orderList
                            orderby order.Quantity descending
                            where order.Quantity > 0
                            select order.ItemName;

            var itemNameWithLargestQuantity = itemNames.First();
            Console.WriteLine("Name of the item that was ordered in largest quantity in a single order: " + itemNameWithLargestQuantity);
        


            DateTime currentDate = DateTime.Now;
            bool anyOrdersBeforeThisYear = orderList.Any(order => order.OrderDate.Year < currentDate.Year);

            Console.WriteLine();



            //Question 8
            //. Rewrite the last two example of that used Count using LINQ query methods entirely.


            int itemsWithQuantityGreaterThanZero = orderList.Count(order => order.Quantity > 0);

            var result8 = itemPriceList.Join(orderList,
                            price => price.ItemName,
                            order => order.ItemName,
                            (price, order) => new
                            {
                                orderId = order.OrderId,
                                itemName = order.ItemName,
                                orderDate = order.OrderDate,
                                totalprice = order.Quantity * price.Price
                            });


            foreach (var r in result8)
            {
                Console.WriteLine($"Order ID: {r.orderId}, Item Name: {r.itemName}, Order Date: {r.orderDate}, Total Price: {r.totalprice}");
            }

            Console.WriteLine();


            //Question 9
            //Given the array of numbers. Count and display even numbers.
            //Write LINQ to get the sum of quantities for each item and also find out and display the item that has overall maximum orders.
            


                        int[] arrayofNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            var evenNumbers = from n in arrayofNumbers
                              where n % 2 == 0
                              select n;
            Console.WriteLine("Even Number Count:" + evenNumbers.Count());
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();


            //get the sum of quantities for each item and also find out and display the item that has overall maximum orders
            List<Order> orderList2 = new List<Order>()
            {
                new Order(1, "laptop",new DateTime(2020, 2, 2),41),
                new Order(2, "laptop",new DateTime(2023, 3, 3),20),
                new Order(3, "salt",new DateTime(2021, 4, 13),42),
                new Order(4, "salt",new DateTime(2010, 1, 20),13),
                new Order(5, "sugar",new DateTime(2024, 12, 23),13),
                new Order(6, "mouse",new DateTime(2022, 10, 20),10),
            };

            var result10 = from order in orderList2
                           group order.Quantity by order.ItemName;

            var result11 = from r in result10
                           select (new { name = r.Key, TotalQuantity = r.Sum(r => r) });

            foreach (var r in result11)
            {
                Console.WriteLine($"{r.name} {r.TotalQuantity}");
            }

            Console.WriteLine();
        }
    }
}
