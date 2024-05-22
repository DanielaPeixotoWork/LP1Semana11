using System;
using System.Collections.Generic;
using System.Linq;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T comparisonItem) where T : struct, IComparable<T>
        {
            return items.Where(item => item.CompareTo(comparisonItem) < 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var intItems = new List<int> { 1, 2, 3, 4, 5, 6 };
            int intComparisonItem = 4;
            var intResult = BeforeUtils.GetTheOnesBefore(intItems, intComparisonItem);

            Console.WriteLine("Integers before 4:");
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }

            var dateItems = new List<DateTime>
            {
                new DateTime(2023, 1, 1),
                new DateTime(2023, 6, 15),
                new DateTime(2024, 1, 1),
                new DateTime(2022, 12, 31)
            };
            DateTime dateComparisonItem = new DateTime(2023, 1, 1);
            var dateResult = BeforeUtils.GetTheOnesBefore(dateItems, dateComparisonItem);

            Console.WriteLine("\nDates before January 1, 2023:");
            foreach (var date in dateResult)
            {
                Console.WriteLine(date.ToShortDateString());
            }
        }
    }
}