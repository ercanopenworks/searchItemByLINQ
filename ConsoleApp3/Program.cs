using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = new int[] { 1, 2, 3, 4, 5, 3, 3, 2, 5 };

            //var query = (from item in numList
            //             group item by item into g
            //             orderby g.Count() descending
            //             select new { Item = g.Key, Count = g.Count() });

            

            int searchKey = 2;



            var query = (from item in numList
                         group item by item into g
                         orderby g.Count() descending
                         select new { Key = g.Key, Value = g.Count() }).ToDictionary(pair => pair.Key, pair => pair.Value); ;

          
            int num = query[searchKey];

            Console.Write(num);
            Console.Read();
        }
    }
}
