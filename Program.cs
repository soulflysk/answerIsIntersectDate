using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace DATA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a;
            a = IsOverlapped("20191101", "20191130", "20191201", "20191231");
            Console.WriteLine($"{a}");
        }
        static bool IsOverlapped(string start1, string end1, string start2, string end2)
        {
            bool result = true;
            DateTime _start1 = DateTime.ParseExact(start1, 
                                  "yyyyMMdd", 
                                   CultureInfo.InvariantCulture);
            DateTime _end1 = DateTime.ParseExact(end1, 
                                  "yyyyMMdd", 
                                   CultureInfo.InvariantCulture);
            DateTime _start2 = DateTime.ParseExact(start2, 
                                  "yyyyMMdd", 
                                   CultureInfo.InvariantCulture);
            DateTime _end2 = DateTime.ParseExact(end2, 
                                  "yyyyMMdd", 
                                   CultureInfo.InvariantCulture);


            List<DateTime> dates1 = new List<DateTime>();
            dates1.Add(_start1);
            while ((_start1 = _start1.AddDays(1)) <= _end1)
            {
                dates1.Add(_start1);
            }
            List<DateTime> dates2 = new List<DateTime>();
            dates2.Add(_start2);
            while ((_start2 = _start2.AddDays(1)) <= _end2)
            {
                dates2.Add(_start2);
            }


            var newIntersect = dates1.Intersect(dates2);
            if (newIntersect.Any())
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;

        }

    }
}