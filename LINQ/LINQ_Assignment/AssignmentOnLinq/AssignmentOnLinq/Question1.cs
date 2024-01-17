using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLinq
{
    //Given an array of numbers. Find  the cube of the numbers that are greater than 100 but less than 1000 using LINQ.
    internal class Question1
    {
        static void Main()
        {
            int[] n = { 1, 2, 3, 4, 5, 6, 78, 89, 76, 65, 54, 43, 32, 21 };
            var result = from f in n
                         let i = f * f * f
                         where i > 100 && i < 1000
                         select i;
            foreach (var k in result)
                Console.WriteLine(k);


        }
    }
}
